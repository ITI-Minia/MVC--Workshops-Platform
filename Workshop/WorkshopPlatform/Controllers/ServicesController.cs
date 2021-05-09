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

namespace WorkshopPlatform.Controllers
{
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
            return View();
        }

        // GET: Services/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.WorkShop)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            ViewData["WorkShopId"] = new SelectList(_context.WorkShops, "Id", "Address");
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServicesViewModel servicesViewModel)
        {
            try
            {
                var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                var workshop = await _context.WorkShops
                     .Include(w => w.User)
                     .Include(w => w.WorkshopRates)
                     .Include(w => w.Services)
                     .FirstOrDefaultAsync(w => w.User.Id == userID);
                string ImgaeFileName = string.Empty;
                ImgaeFileName = servicesViewModel.Imagepath.FileName;

                string uploads = Path.Combine(hosting.WebRootPath, "imgs");
                string ImageFullPath = Path.Combine(uploads, ImgaeFileName);
                servicesViewModel.Imagepath.CopyTo(new FileStream(ImageFullPath, FileMode.Create));
                Service services = new Service()
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
                    _context.Services.Add(services);
                    await _context.SaveChangesAsync();
                    TempData["Done"] = "created Sucessfully";
                    return RedirectToAction(nameof(DisplayServices));
                }
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(DisplayServices));
            }
            //ViewData["WorkShopId"] = new SelectList(_context.WorkShops, "Id", "Address", service.WorkShopId);
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

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ServicesViewModel servicesViewModel)
        {
            string ImgaeFileName = string.Empty;

            try
            {
                ImgaeFileName = servicesViewModel.Imagepath.FileName;

                string uploads = Path.Combine(hosting.WebRootPath, "imgs");
                string ImageFullPath = Path.Combine(uploads, ImgaeFileName);
                string OldImageFile = _context.Services.Find(servicesViewModel.Id).Image;
                string OldImgPath = Path.Combine(uploads, OldImageFile);

                if (ImageFullPath != OldImgPath)
                {
                    //System.IO.File.Delete(OldImgPath);
                    servicesViewModel.Imagepath.CopyTo(new FileStream(ImageFullPath, FileMode.Create));
                }
                var servicees = _context.Services.Find(servicesViewModel.Id);
                servicees.Id = servicesViewModel.Id;
                servicees.Title = servicesViewModel.Title;
                servicees.Image = ImgaeFileName;
                servicees.Verified = servicesViewModel.Verified;
                servicees.Price = servicesViewModel.Price;
                servicees.WorkShopId = servicesViewModel.WorkShopId;
                servicees.Description = servicesViewModel.Description;
                _context.Update(servicees);
                await _context.SaveChangesAsync();
                TempData["Done"] = "Updated Sucessfully";
            }
            catch (Exception)
            {
                if (ImgaeFileName == "")
                {
                    string uploads = Path.Combine(hosting.WebRootPath, "imgs");
                    string ImageFullPath = Path.Combine(uploads, ImgaeFileName);
                    string OldImageFile = _context.Services.Find(servicesViewModel.Id).Image;
                    string OldImgPath = Path.Combine(uploads, OldImageFile);

                    var servicees = _context.Services.Find(servicesViewModel.Id);
                    servicees.Id = servicesViewModel.Id;
                    servicees.Title = servicesViewModel.Title;
                    servicees.Image = OldImageFile;
                    servicees.Verified = servicesViewModel.Verified;
                    servicees.Price = servicesViewModel.Price;
                    servicees.WorkShopId = servicesViewModel.WorkShopId;
                    servicees.Description = servicesViewModel.Description;
                    _context.Update(servicees);
                    await _context.SaveChangesAsync();
                    TempData["Done"] = "Updated Sucessfully";
                }
                return RedirectToAction(nameof(DisplayServices));
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

        private bool ServiceExists(int id)
        {
            return _context.Services.Any(e => e.Id == id);
        }

        public async Task<IActionResult> DisplayServices()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var workshop = await _context.WorkShops
                 .Include(w => w.User)
                 .Include(w => w.WorkshopRates)
                 .Include(w => w.Services)
                 .FirstOrDefaultAsync(w => w.User.Id == userID);
            ViewBag.services = _context.Services.Where(w => w.WorkShop.Id == workshop.Id).ToList();
            return View();
        }

        public async Task<IActionResult> RequestedServices()
        {
            var model = new List<UserServicesViewModel>();
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var services = await _context.UserServices
                 .Include(w => w.User)
                 .Include(w => w.Service)
                 .Where(w => w.User.Id == userID).ToListAsync();

            ViewBag.Historyservices = services.Where(w => w.Finished == true);
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
                    UserName = item.User.UserName
                };
                model.Add(x);
            }

            return View(model);
        }

        public async Task<IActionResult> GetRate()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var workshop = await _context.WorkShops
                 .Include(w => w.User)
                 .Include(w => w.WorkshopRates)
                 .FirstOrDefaultAsync(w => w.User.Id == userID);
            var model = await _context.UserServices.Where(w => w.Finished == false)
                 .Where(w => w.User.Id == userID).ToListAsync();

            var data = _context.WorkshopRates.Include(w => w.UserProfile).Include(w => w.WorkShop).Where(w => w.WorkShop.Id == workshop.Id).ToList();
            ViewBag.Rates = data;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(List<UserServicesViewModel> data)
        {
            foreach (var item in data)
            {
                var US = _context.UserServices.Find(item.Id);
                US.Finished = item.Finished;
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(RequestedServices));
        }

        public async Task<IActionResult> WorkshopSetting()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var workshop = await _context.WorkShops
                 .Include(w => w.User)
                 .Include(w => w.WorkshopRates)
                 .Include(w => w.Services)
                 .FirstOrDefaultAsync(w => w.User.Id == userID);

            var viewModel = new WorkshopViewModel
            {
                Id = workshop.Id,
                Name = workshop.Name,
                ImageUrl = workshop.Image,
                LogoeUrl = workshop.Logo,
                Verified = workshop.Verified,
                Address = workshop.Address,
                City = workshop.City,
                Government = workshop.Government,
                Rate = workshop.Rate,
                UserId = workshop.UserId,
                User = workshop.User,
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult workshopSetting(WorkshopViewModel workshopViewModel)
        {
            string uploads = Path.Combine(hosting.WebRootPath, "imgs");
            string ImgaeFileName = string.Empty;
            string LogoFileName = string.Empty;
            string OldImageFile = _context.WorkShops.Find(workshopViewModel.Id).Image;
            string OldLogoFile = _context.WorkShops.Find(workshopViewModel.Id).Image;
            string ImageFullPath;
            string LogoFullPath;
            try
            {
                var workshopss = _context.WorkShops.Find(workshopViewModel.Id);

                if (workshopViewModel.Imagepath != null && workshopViewModel.Logopath != null)
                {
                    ImgaeFileName = workshopViewModel.Imagepath.FileName;
                    LogoFileName = workshopViewModel.Logopath.FileName;
                    ImageFullPath = Path.Combine(uploads, ImgaeFileName);
                    LogoFullPath = Path.Combine(uploads, LogoFileName);
                    if (ImgaeFileName == LogoFileName)
                    {
                        workshopViewModel.Imagepath.CopyTo(new FileStream(ImageFullPath, FileMode.Create));
                    }
                    else
                    {
                        workshopViewModel.Imagepath.CopyTo(new FileStream(ImageFullPath, FileMode.Create));
                        workshopViewModel.Logopath.CopyTo(new FileStream(LogoFullPath, FileMode.Create));
                    }
                    workshopss.Image = ImgaeFileName;
                    workshopss.Logo = LogoFileName;
                }
                else
                {
                    if (workshopViewModel.Imagepath == null)
                    {
                        workshopss.Image = OldImageFile;
                    }
                    else
                    {
                        ImgaeFileName = workshopViewModel.Imagepath.FileName;
                        ImageFullPath = Path.Combine(uploads, ImgaeFileName);

                        workshopViewModel.Imagepath.CopyTo(new FileStream(ImageFullPath, FileMode.Create));
                        workshopss.Image = ImgaeFileName;
                    }
                    if (workshopViewModel.Logopath == null)
                    {
                        workshopss.Logo = OldLogoFile;
                    }
                    else
                    {
                        LogoFileName = workshopViewModel.Logopath.FileName;
                        LogoFullPath = Path.Combine(uploads, LogoFileName);
                        workshopViewModel.Logopath.CopyTo(new FileStream(LogoFullPath, FileMode.Create));
                        workshopss.Logo = LogoFileName;
                    }
                }
                workshopss.Id = workshopViewModel.Id;
                workshopss.Name = workshopViewModel.Name;
                workshopss.Verified = workshopViewModel.Verified;
                workshopss.Address = workshopViewModel.Address;
                workshopss.City = workshopViewModel.City;
                workshopss.Government = workshopViewModel.Government;
                workshopss.Rate = workshopViewModel.Rate;
                workshopss.UserId = workshopViewModel.UserId;
                workshopss.User = workshopViewModel.User;
                _context.Update(workshopss);
                _context.SaveChanges();
                TempData["Done"] = "Updated Sucessfully";
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(workshopSetting));
            }
            return RedirectToAction(nameof(workshopSetting));
        }
    }
}