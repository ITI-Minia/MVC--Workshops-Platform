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

namespace WorkshopPlatform.Controllers
{
    public class WorkShopsController : Controller
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly WorkShopDbContext _context;

        public WorkShopsController(WorkShopDbContext context,
            IHttpContextAccessor httpContextAccessor,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _httpContext = httpContextAccessor;
            _userManager = userManager;
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

        public async Task<IActionResult> Search(string id)
        {
            if (id == "" || id == null)
            {
                var workShopDbContext = _context.WorkShops;

                return View("Index", await workShopDbContext.ToListAsync());
            }
            else
            {
                var workShopDbContext = _context.WorkShops.ToList();
                id = id.ToLower();
                var workShop = await _context.WorkShops.Where(ws => ws.Name.ToLower().Contains(id) ||
                                                                           ws.Rate.ToString().Contains(id) ||
                                                                           ws.Address.ToLower().Contains(id) ||
                                                                           ws.City.ToLower().Contains(id) ||
                                                                           ws.Government.ToLower().Contains(id)).ToListAsync();
                if (workShop == null)
                {
                    return NotFound();
                }
                ViewBag.SearchData = workShop;
                ViewBag.SearchCount = workShop.Count();
                ViewBag.flag = 1;
                return View("Index", workShop);
            }
        }

        public async Task<IActionResult> SearchEmergacy(string id)
        {
            if (id == "" || id == null)
            {
                var workShopDbContext = _context.WorkShops.Include(w => w.User);

                return View("Emergacy", await workShopDbContext.Include(w => w.User).ToListAsync());
            }
            else
            {
                var workShopDbContext = _context.WorkShops.Include(w => w.User).ToList();
                id = id.ToLower();
                // var w = await( from w in _context.WorkShops)
                var workShop = await _context.WorkShops.Include(w => w.User).Where(ws => ws.Name.ToLower().Contains(id) ||
                                                                           ws.Rate.ToString().Contains(id) ||
                                                                           ws.Address.ToLower().Contains(id) ||
                                                                           ws.City.ToLower().Contains(id) ||
                                                                           ws.Government.ToLower().Contains(id)/*||*/
                                                                          /* ws.User.PhoneNumber.ToString().Contains(id)*/).ToListAsync();
                if (workShop == null)
                {
                    return NotFound();
                }
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
            var userServices = await _context.UserServices.Where(s => s.UserId == userID && s.Finished == false)
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

            workShop.Image = null;

            _context.SaveChanges();

            return Content("");
        }

        [HttpPost]
        public async Task<IActionResult> SaveImage(IFormFile id)
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

            workShop.Image = null;

            _context.SaveChanges();

            return Content("");
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
    }
}