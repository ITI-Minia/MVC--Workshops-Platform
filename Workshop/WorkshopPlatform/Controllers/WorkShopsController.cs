using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Workshop.Models;
using WorkshopPlatform.Models;
using System.Dynamic;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WorkshopPlatform.Controllers
{
    public class WorkShopsController : Controller
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly WorkShopDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public WorkShopsController(WorkShopDbContext context,
            IHttpContextAccessor httpContextAccessor,
            UserManager<IdentityUser> userManager,
            IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _httpContext = httpContextAccessor;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: WorkShops
        public async Task<IActionResult> Index()
        {
            var workShopDbContext = _context.WorkShops;

            return View(await workShopDbContext.ToListAsync());
        }

        public async Task<IActionResult> Emergacy(string City, string Government, string Street)
        {
            var workShopDbContext = _context.WorkShops.Include(w => w.User);

            if (Street != "" && Street != null)
            {
                Street = Street.ToLower();
                var workShop = await workShopDbContext.Where(ws => ws.Address.ToLower().Contains(Street) && ws.Government.ToLower().Contains(Government) && ws.City.ToLower().Contains(City)).ToListAsync();
                if (workShop.Count != 0)
                    return View(workShop);
                else
                {
                    if (Government != "" && Government != null)
                    {
                        Government = Government.ToLower();
                        workShop = await workShopDbContext.Where(ws => ws.Government.ToLower().Contains(Government)).ToListAsync();
                        if (workShop.Count != 0)
                            return View(workShop);
                        else
                        {
                            if (City != "" && City != null)
                            {
                                City = City.ToLower();
                                workShop = await workShopDbContext.Where(ws => ws.Government.ToLower().Contains(City)).ToListAsync();
                                if (workShop.Count != 0)
                                    return View(workShop);
                                else
                                    return View(await workShopDbContext.ToListAsync());
                            }
                            else
                                return View(await workShopDbContext.ToListAsync());
                        }
                    }
                    else
                    {
                        if (City != "" && City != null)
                        {
                            City = City.ToLower();
                            workShop = await workShopDbContext.Where(ws => ws.Government.ToLower().Contains(City)).ToListAsync();
                            if (workShop.Count != 0)
                                return View(workShop);
                            else
                                return View(await workShopDbContext.ToListAsync());
                        }
                        else
                            return View(await workShopDbContext.ToListAsync());
                    }
                }
            }
            else if (Government != "" && Government != null)
            {
                Government = Government.ToLower();
                var workShop = await workShopDbContext.Where(ws => ws.Government.ToLower().Contains(Government)).ToListAsync();

                if (workShop.Count != 0)
                    return View(workShop);
                else
                {
                    if (City != "" && City != null)
                    {
                        City = City.ToLower();
                        workShop = await workShopDbContext.Where(ws => ws.Government.ToLower().Contains(City)).ToListAsync();
                        if (workShop.Count != 0)
                            return View(workShop);
                        else
                            return View(await workShopDbContext.ToListAsync());
                    }
                    else
                        return View(await workShopDbContext.ToListAsync());
                }
            }
            else if (City != "" && City != null)
            {
                City = City.ToLower();
                var workShop = await workShopDbContext.Where(ws => ws.Government.ToLower().Contains(City)).ToListAsync();
                return View(workShop);
            }
            else
                return View(await workShopDbContext.ToListAsync());
        }

        public async Task<IActionResult> Search(string search)
        {
            if (search == "" || search == null)
            {
                var workShopDbContext = _context.WorkShops;

                return View("Index", await workShopDbContext.ToListAsync());
            }
            else
            {
                var workShopDbContext = _context.WorkShops.ToList();
                search = search.ToLower();
                var workShop = await _context.WorkShops.Where(ws => ws.Name.ToLower().Contains(search) ||
                                                                           ws.Rate.ToString().Contains(search) ||
                                                                           ws.Address.ToLower().Contains(search) ||
                                                                           ws.City.ToLower().Contains(search) ||
                                                                           ws.Government.ToLower().Contains(search)).ToListAsync();
                if (workShop == null)
                {
                    return NotFound();
                }
                ViewBag.SearchData = workShop;
                ViewBag.SearchCount = workShop.Count();
                ViewBag.flag = 1;
                ViewBag.searchText = search;
                return View("Index", workShop);
            }
        }

        public async Task<IActionResult> SearchEmergacy(string search)
        {
            if (search == "" || search == null)
            {
                var workShopDbContext = _context.WorkShops.Include(w => w.User);

                return View("Emergacy", await workShopDbContext.Include(w => w.User).ToListAsync());
            }
            else
            {
                var workShopDbContext = _context.WorkShops.Include(w => w.User).ToList();
                search = search.ToLower();
                // var w = await( from w in _context.WorkShops)
                var workShop = await _context.WorkShops.Include(w => w.User).Where(ws => ws.Name.ToLower().Contains(search) ||
                                                                           ws.Rate.ToString().Contains(search) ||
                                                                           ws.Address.ToLower().Contains(search) ||
                                                                           ws.City.ToLower().Contains(search) ||
                                                                           ws.Government.ToLower().Contains(search)/*||*/
                                                                          /* ws.User.PhoneNumber.ToString().Contains(id)*/).ToListAsync();
                if (workShop == null)
                {
                    return NotFound();
                }

                ViewBag.searchText = search;

                return View("Emergacy", workShop);
            }
        }

        [Route("workshop/{id}")]
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workShop = await _context.WorkShops
                .Include(w => w.User)
                .Include(w => w.Services)
                .Include(w => w.Images)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (workShop == null)
            {
                return NotFound();
            }

            var reviews = await _context.WorkshopRates.Where(r => r.WorkShopId == id)
                                                      .Include(r => r.UserProfile)
                                                      .Include(r => r.UserProfile.User)
                                                      .OrderByDescending(r => r.Date)
                                                      .ToListAsync();

            ViewData["reviews"] = reviews;

            var userID = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            bool WorkshopOwner = false;  //for clients

            if (workShop.UserId == userID)
            {
                WorkshopOwner = true; //for workshop owner
            }

            //services that user in current session had orderd
            var userServices = await _context.UserServices.Where(s => s.UserId == userID &&
                                                          s.Service.WorkShopId == workShop.Id
                                                          && s.Finished == false)
                                                          .ToListAsync();

            ViewBag.WorkshopOwner = WorkshopOwner;
            ViewData["UserServices"] = userServices;

            return View(workShop);
        }

        [HttpGet]
        public async Task<IActionResult> AddUserService(int? id)
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

            var userID = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            await _context.UserServices.AddAsync(
              new UserServices
              {
                  UserId = userID,
                  ServiceId = service.Id,
                  Date = DateTime.Now,
                  Finished = false
              });

            _context.SaveChanges();

            var userServices = await _context.UserServices.Where(s => s.UserId == userID && s.Finished == false)
                                                         .Include(s => s.Service)
                                                         .Include(s => s.Service.WorkShop)
                                                         .OrderByDescending(s => s.Date)
                                                         .ToListAsync();

            return PartialView("_ServiceNotifiPartial", userServices);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveUserService(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userID = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var service = await _context.UserServices.Where(s => s.ServiceId == id)
                .Where(s => s.UserId == userID)
                .OrderByDescending(s => s.Date)
                .FirstOrDefaultAsync();

            if (service == null)
            {
                return NotFound();
            }

            _context.UserServices.Remove(service);

            _context.SaveChanges();

            var userServices = await _context.UserServices.Where(s => s.UserId == userID && s.Finished == false)
                                                       .Include(s => s.Service)
                                                       .Include(s => s.Service.WorkShop)
                                                       .OrderByDescending(s => s.Date)
                                                       .ToListAsync();

            return PartialView("_ServiceNotifiPartial", userServices);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveImage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workShop = await _context.WorkShops.FindAsync(id);

            if (workShop == null)
            {
                return NotFound();
            }

            if (workShop.Image != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Upload/images");
                System.IO.File.Delete(Path.Combine(uploadsFolder, workShop.Image));
            }
            workShop.Image = null;

            _context.SaveChanges();

            return Content("");
        }

        [HttpPost]
        public async Task<IActionResult> SaveImage(int? id, IFormFile image)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workShop = await _context.WorkShops.FindAsync(id);

            if (workShop == null)
            {
                return NotFound();
            }

            string uniqueFileName = null;
            string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Upload/images");

            if (image != null)
            {
                uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                image.CopyTo(fileStream);
            }
            if (workShop.Image != null)
            {
                System.IO.File.Delete(Path.Combine(uploadsFolder, workShop.Image));
            }
            workShop.Image = uniqueFileName;

            _context.SaveChanges();

            return RedirectToAction("Details", new { id = workShop.Id });
        }

        [HttpGet]
        public async Task<IActionResult> RemoveLogo(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workShop = await _context.WorkShops.FindAsync(id);

            if (workShop == null)
            {
                return NotFound();
            }

            if (workShop.Logo != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Upload/images");
                System.IO.File.Delete(Path.Combine(uploadsFolder, workShop.Logo));
            }
            workShop.Logo = null;

            _context.SaveChanges();

            return Content("");
        }

        [HttpPost]
        public async Task<IActionResult> SaveLogo(int? id, IFormFile image)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workShop = await _context.WorkShops.FindAsync(id);

            if (workShop == null)
            {
                return NotFound();
            }

            string uniqueFileName = null;
            string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Upload/images");

            if (image != null)
            {
                uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                image.CopyTo(fileStream);
            }
            if (workShop.Logo != null)
            {
                System.IO.File.Delete(Path.Combine(uploadsFolder, workShop.Logo));
            }
            workShop.Logo = uniqueFileName;

            _context.SaveChanges();

            return RedirectToAction("Details", new { id = workShop.Id });
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> UserRate(WorkshopRate WorkshopRate)
        {
            try
            {
                WorkshopRate.Date = DateTime.Now;
                var userID = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                //var user = _userManager.FindByIdAsync(userID).Result;
                int UId = int.Parse(userID);
                var userprofile = _context.UserProfiles.Where(w => w.Id == UId).FirstOrDefault();
                WorkshopRate.UserProfileId = UId;
                WorkshopRate.UserProfile = userprofile;

                _context.Add(WorkshopRate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details));
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Details));
            }
        }
        public async Task<IActionResult> WorKShopMessageReciver(string SenderName)
        {
            if (SenderName==null)
            {
                return View();   
            }
            else
            { 
            
            var GetSender = _context.Users.Where(u => u.UserName == SenderName).FirstOrDefault();
            var GetSenderId = GetSender.Id;


            var userID = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                ViewBag.WorkShopUserId = userID;
            var CurrentUser = _context.Users.Where(n => n.Id == userID).FirstOrDefault();
            var CurrentUserName = CurrentUser.UserName;
            ViewBag.UserName = SenderName;
            var Chatting = _context.Chats.Where(c => c.Receiver == userID && c.Sender == GetSenderId).FirstOrDefault();
            var ChattingId = Chatting.Id;
            ViewBag.Messages = await _context.Messages.Where(m => m.ChatId == ChattingId).ToListAsync();
                Messages messages = new Messages()
                { UserId= GetSenderId };
                return PartialView(messages);

            }
        }
        [HttpPost]
        public async Task<IActionResult> WorKShopMessageReciver(Messages messages)
        {
        
            var SenderId = messages.UserId;
            
            var WorkShopUserID = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var CurrentUser = _context.Users.Where(n => n.Id == WorkShopUserID).FirstOrDefault();
            
            var Chatting = _context.Chats.Where(c => c.Receiver == WorkShopUserID && c.Sender == SenderId).FirstOrDefault();

            messages.ChatId = Chatting.Id;
            messages.UserId = WorkShopUserID;
            messages.Id = 0;
            await _context.AddAsync(messages);
            await _context.SaveChangesAsync();
            return Ok();
        }

        public IActionResult Message(int? id)
        {

            
            
                var userID = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.ClientID = userID;
                ViewBag.SendersName = _context.Chats.Where(c => c.Receiver == userID).Include(c => c.UserSender);
            
            @ViewBag.Id = 0;

           
            if (id !=null)
            {
                var WorkShopUser = _context.WorkShops.Where(w => w.Id == id).FirstOrDefault();
                //workshopuserId
                var UserId = WorkShopUser.UserId;
                ViewBag.UserId = UserId;

                var User = _context.Users.Where(u => u.Id == UserId).FirstOrDefault();
                var WorkShopUserName = User.UserName;
                var CurrentUser = _context.Users.Where(n => n.Id == userID).FirstOrDefault();
                var CurrentUserName = CurrentUser.UserName;
                ViewBag.UserName = CurrentUser.UserName;

                var Chatting = _context.Chats.Where(c => c.Receiver == UserId && c.Sender == userID).FirstOrDefault();
                Messages messages = new Messages()
                { Id=(int)id};

                if (Chatting == null)
                {
                    Chat chat = new Chat()
                    {
                        Sender = userID,
                        Receiver = UserId
                    };
                    _context.Add(chat);
                    _context.SaveChanges();
                    return RedirectToAction("Message", new { id = id });
                }
                else
                {

                    var ChattingId = Chatting.Id;
                    var Recivers = Chatting.Receiver;
                    
                    ViewBag.Messages = _context.Messages.Where(m => m.ChatId == ChattingId).ToList();
             
                    return View();

                }
            }

            return View();
          
        }
        [HttpPost]
        public async Task<IActionResult> Message(Messages messages)
        {
            
            
                var WorkShopUser = _context.WorkShops.Where(w => w.Id == messages.Id).FirstOrDefault();
                var UserId = WorkShopUser.UserId;
               
                var userID = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var CurrentUser = _context.Users.Where(n => n.Id == userID).FirstOrDefault();
                var Chatting = _context.Chats.Where(c => c.Receiver == UserId && c.Sender == userID).FirstOrDefault();

                messages.ChatId = Chatting.Id;
                messages.UserId = userID;
                messages.Id = 0;
                await _context.AddAsync(messages);
                await _context.SaveChangesAsync();
                return Ok();
        }
           
    }
}