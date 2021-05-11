using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Workshop.Models;
using WorkshopPlatform.Models;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Workshop.ViewModel;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using WorkshopPlatform.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace WorkshopPlatform.Controllers
{
    [Authorize(Roles = "Workshop")]
    [Route("workshop/dashboard/{Action}")]
    public class ServicesController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly WorkShopDbContext _context;
        private readonly IWebHostEnvironment hosting;

        public ServicesController(WorkShopDbContext context, IWebHostEnvironment hosting,
             UserManager<IdentityUser> userManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            this.hosting = hosting;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: Services
        public IActionResult Index(int? id)
        {
            //var workShopDbContext = _context.Services.Include(s => s.WorkShop).Where(w=>w.WorkShop.Id==id);
            ViewBag.services = _context.Services.Where(w => w.WorkShop.Id == id).ToList();
            return RedirectToActionPermanent("RequestedServices");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServicesViewModel servicesViewModel)
        {
            try
            {
                var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var workshop = await _context.WorkShops
                     .FirstOrDefaultAsync(w => w.User.Id == userID);

                string ImgaeFileName = null;
                if (servicesViewModel.Imagepath != null)
                {
                    string uploads = Path.Combine(hosting.WebRootPath, "Upload/images");

                    ImgaeFileName = servicesViewModel.Imagepath.FileName;
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + ImgaeFileName;

                    string ImageFullPath = Path.Combine(uploads, uniqueFileName);
                    FileInfo file = new(ImageFullPath);

                    if (file.Exists.Equals(false))
                    {
                        servicesViewModel.Imagepath.CopyTo(new FileStream(ImageFullPath, FileMode.Create));
                    }
                }

                Service service = new()
                {
                    Title = servicesViewModel.Title,
                    Price = servicesViewModel.Price,
                    Description = servicesViewModel.Description,
                    Verified = servicesViewModel.Verified,
                    Image = ImgaeFileName,
                    WorkShopId = workshop.Id
                };

                if (ModelState.IsValid)
                {
                    await _context.Services.AddAsync(service);

                    //send notification to workshop
                    _context.Notifications.Add(new Notification
                    {
                        ReceiverId = userID,
                        Type = "AddService",
                        ContentId = service.Id,
                    });

                    await _context.SaveChangesAsync();
                    TempData["Done"] = "Created sucessfully";
                }
            }
            catch (UnauthorizedAccessException)
            {
                return RedirectToAction(nameof(DisplayServices));
            }
            catch (Exception)
            {
                TempData["Done"] = "Service doesn't created Sucessfully";
            }

            return RedirectToAction(nameof(DisplayServices));
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            ServicesViewModel viewModel = new ServicesViewModel
            {
                Id = service.Id,
                Title = service.Title,
                Image = service.Image,
                Description = service.Description,
                Verified = service.Verified,
                Price = service.Price,
                WorkShopId = service.WorkShopId,
            };

            return PartialView(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ServicesViewModel servicesViewModel)
        {
            var service = _context.Services.Find(servicesViewModel.Id);

            try
            {
                if (servicesViewModel.Imagepath != null)
                {
                    string uploads = Path.Combine(hosting.WebRootPath, "Upload/images");

                    string ImgaeFileName = servicesViewModel.Imagepath.FileName;
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + ImgaeFileName;

                    string ImageFullPath = Path.Combine(uploads, uniqueFileName);

                    FileInfo file = new(ImageFullPath);
                    if (file.Exists.Equals(false))
                    {
                        servicesViewModel.Imagepath.CopyTo(new FileStream(ImageFullPath, FileMode.Create));
                    }

                    string OldImgPath = Path.Combine(uploads, service.Image);
                    System.IO.File.Delete(OldImgPath);

                    service.Image = ImgaeFileName;
                }

                service.Title = servicesViewModel.Title;
                service.Price = servicesViewModel.Price;
                service.Description = servicesViewModel.Description;

                await _context.SaveChangesAsync();
                TempData["Done"] = "Updated Sucessfully";
            }
            catch (Exception)
            {
                TempData["Done"] = "Can't update service, something went wrong";
            }

            return RedirectToAction(nameof(DisplayServices));
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.WorkShop)
                .FirstOrDefaultAsync(m => m.Id == id);

            ServicesViewModel viewModel = new ServicesViewModel
            {
                Id = service.Id,
                Title = service.Title,
                Image = service.Image,
                Description = service.Description,
                Verified = service.Verified,
                Price = service.Price,
                WorkShopId = service.WorkShopId,
            };
            if (service == null)
            {
                return NotFound();
            }

            return PartialView(viewModel);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var service = await _context.Services.FindAsync(id);
            _context.Services.Remove(service);

            await _context.SaveChangesAsync();

            TempData["Done"] = "Deleted Sucessfully";

            return RedirectToAction(nameof(DisplayServices));
        }

        public async Task<IActionResult> DisplayServices()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var workshop = await _context.WorkShops
                 .Include(w => w.User)
                 .Include(w => w.WorkshopRates)
                 .Include(w => w.Services)
                 .FirstOrDefaultAsync(w => w.User.Id == userID);

            ViewBag.services = workshop.Services;
            return View();
        }

        public async Task<IActionResult> RequestedServices()
        {
            var model = new List<UserServicesViewModel>();

            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workshop = _context.WorkShops.Where(w => w.UserId == userID).FirstOrDefault();

            var services = await _context.UserServices
                 .Where(s => s.Service.WorkShopId == workshop.Id)
                 .Include(w => w.User)
                 .Include(w => w.Service)
                 .ToListAsync();

            ViewBag.Historyservices = (from s in services
                                       where s.Finished == true
                                       join u in _context.UserProfiles on s.UserId equals u.UserId
                                       select new UserServicesViewModel
                                       {
                                           Date = s.Date,
                                           Title = s.Service.Title,
                                           UserName = s.User.UserName,
                                           Userprofile = u
                                       }).ToList();

            var requested = services.Where(w => w.Finished == false);
            ViewBag.services = requested;

            foreach (var item in requested)
            {
                var x = new UserServicesViewModel
                {
                    Id = item.Id,
                    Finished = item.Finished,
                    Date = item.Date,
                    Title = item.Service.Title,
                    UserName = item.User.UserName,
                    Userprofile = _context.UserProfiles.Where(u => u.UserId == item.UserId).FirstOrDefault()
                };
                model.Add(x);
            }

            return View(model);
        }

        public async Task<IActionResult> GetRate()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var workshop = await _context.WorkShops
                                 .FirstOrDefaultAsync(w => w.UserId == userID);

            var data = _context.WorkshopRates
                       .Include(r => r.UserProfile)
                       .Include(r => r.UserProfile.User)
                       .Include(r => r.WorkShop)
                       .Where(w => w.WorkShop.Id == workshop.Id)
                       .ToList();

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(List<UserServicesViewModel> data)
        {
            foreach (var item in data)
            {
                var US = _context.UserServices.Where(s => s.Id == item.Id)
                    .Include(s => s.Service.WorkShop.User)
                    .FirstOrDefault();

                US.Finished = item.Finished;

                if (US.Finished)
                {
                    //send notification to user
                    _context.Notifications.Add(new Notification
                    {
                        ReceiverId = US.UserId,
                        Type = "FinishService",
                        SenderID = US.Service.WorkShop.UserId,
                        ContentId = US.ServiceId,
                    });
                }
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(RequestedServices));
        }

        public async Task<IActionResult> WorkshopSetting()
        {
            try
            {
                var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                var workshop = await _context.WorkShops
                     .Include(w => w.User)
                     .Include(w => w.City)
                     .Include(w => w.City.Government)
                     .FirstOrDefaultAsync(w => w.User.Id == userID);

                ViewBag.Verified = workshop.Verified;


                var viewModel = new WorkshopViewModel
                {
                    Id = workshop.Id,
                    Name = workshop.Name,
                    ImageUrl = workshop.Image,
                    LogoeUrl = workshop.Logo,
                    Address = workshop.Address,
                    City = workshop.City.Name,
                    Government = workshop.City.Government.Name,
                    UserId = workshop.UserId,
                    User = workshop.User,
                };
                return View(viewModel);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult WorkshopSetting(WorkshopViewModel workshopViewModel)
        {
            var workshop = _context.WorkShops.Find(workshopViewModel.Id);

            string uploads = Path.Combine(hosting.WebRootPath, "Upload/Images");
            string FileName = null;
            string FullPath = null;
            string uniqueFileName = null;

            try
            {
                if (workshopViewModel.Imagepath != null)
                {
                    FileName = workshopViewModel.Imagepath.FileName;
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + FileName;

                    FullPath = Path.Combine(uploads, uniqueFileName);

                    FileInfo file = new(FullPath);

                    workshopViewModel.Imagepath.CopyTo(new FileStream(FullPath, FileMode.Create));

                    if (workshop.Image != null)
                        System.IO.File.Delete(Path.Combine(uploads, workshop.Image));

                    workshop.Image = FileName;
                }
                else
                {
                    if (workshopViewModel.RemoveImage == "true")
                    {
                        if (workshop.Image != null)
                            System.IO.File.Delete(Path.Combine(uploads, workshop.Image));

                        workshop.Image = null;
                    }
                }

                if (workshopViewModel.Logopath != null)
                {
                    FileName = workshopViewModel.Logopath.FileName;
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + FileName;

                    FullPath = Path.Combine(uploads, uniqueFileName);

                    FileInfo file = new(FullPath);

                    workshopViewModel.Logopath.CopyTo(new FileStream(FullPath, FileMode.Create));

                    if (workshop.Logo != null)
                        System.IO.File.Delete(Path.Combine(uploads, workshop.Logo));

                    workshop.Logo = FileName;
                }
                else
                {
                    if (workshopViewModel.RemoveLogo == "true")
                    {
                        if (workshop.Logo != null)
                            System.IO.File.Delete(Path.Combine(uploads, workshop.Logo));

                        workshop.Logo = null;
                    }
                }

                workshop.Name = workshopViewModel.Name;
                workshop.Address = workshopViewModel.Address;

                var government = _context.Governments.Where(g => g.Name == workshopViewModel.Government).FirstOrDefault();
                workshop.City = _context.Cities
                                 .Where(c => c.Name == workshopViewModel.City && c.GovernmentId == government.Id)
                                 .FirstOrDefault();

                _context.Update(workshop);
                _context.SaveChanges();

                TempData["Done"] = "Updated Sucessfully";
            }
            catch (Exception)
            {
                TempData["Done"] = "Can't update workshop information, something went wrong";
            }

            return RedirectToAction(nameof(WorkshopSetting));
        }

        public async Task<IActionResult> Images()
        {
            try
            {
                var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                var workshop = await _context.WorkShops
                     .Include(w => w.User)
                     .Include(w => w.Images)
                     .FirstOrDefaultAsync(w => w.User.Id == userID);

                return View(workshop);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> RemoveImage(int? id)
        {
            try
            {
                if (id == null)
                    return NotFound();

                var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                var workshop = await _context.WorkShops
                     .FirstOrDefaultAsync(w => w.User.Id == userID);

                if (workshop == null)
                    return NotFound();

                var image = _context.WorkshopImages.Find(id);

                if (image == null)
                    return NotFound();

                if (image.WorkShopId == workshop.Id)
                {
                    string uploads = Path.Combine(hosting.WebRootPath, "Upload/images");

                    string OldImgPath = Path.Combine(uploads, image.path);
                    System.IO.File.Delete(OldImgPath);

                    _context.WorkshopImages.Remove(image);
                    _context.SaveChanges();
                }
                else
                {
                    return NotFound();
                }

                return RedirectToAction("Images");
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveImage(IFormFile image)
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var workshop = await _context.WorkShops.Where(w => w.UserId == userID).FirstOrDefaultAsync();

            if (workshop == null)
            {
                return NotFound();
            }

            string uniqueFileName = null;
            string uploadsFolder = Path.Combine(hosting.WebRootPath, "Upload/images");

            if (image != null)
            {
                uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                image.CopyTo(fileStream);
            }

            _context.WorkshopImages.Add(new WorkshopImages { WorkShopId = workshop.Id, path = uniqueFileName });

            _context.SaveChanges();

            return RedirectToAction("Images");
        }
    }
}