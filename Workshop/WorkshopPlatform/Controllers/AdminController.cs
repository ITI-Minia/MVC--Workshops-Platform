using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly WorkShopDbContext _context;

        public AdminController(IHttpContextAccessor httpContextAccessor,
            UserManager<IdentityUser> userManager,
            WorkShopDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _context = context;
        }

        [Route("admin/dashboard")]
        public IActionResult Index()
        {
            var workshops = _context.WorkShops.Include(w => w.User)
                                    .ToList();
            return RedirectToActionPermanent("NeedConfirmWorkshops");
        }

        [Route("admin/dashboard/workshops/verified")]
        public IActionResult VerifiedWorkshops()
        {
            var workshops = _context.WorkShops.Where(w => w.Verified)
                                    .Include(w => w.User)
                                    .ToList();
            return View(workshops);
        }

        [Route("admin/dashboard/workshops/confirmationsRequests")]
        public IActionResult NeedConfirmWorkshops()
        {
            var workshops = _context.WorkShops.Where(w => !w.Verified)
                                    .Include(w => w.User)
                                    .ToList();
            return View(workshops);
        }

        public async Task<IActionResult> ConfirmWorkshopAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workshop = await _context.WorkShops.FindAsync(id);

            if (workshop == null)
            {
                return NotFound();
            }

            string message;

            try
            {
                workshop.Verified = true;
                await _context.SaveChangesAsync();

                message = $"Workshop \"{workshop.Name}\" confirmed successfully";
            }
            catch
            {
                message = $"Can't confirm workshop \"{workshop.Name}\", something went wrong";
            }

            return Content(message);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteWorkshopAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workshop = await _context.WorkShops.FindAsync(id);

            if (workshop == null)
            {
                return NotFound();
            }

            string message;
            try
            {
                _context.WorkShops.Remove(workshop);
                await _context.SaveChangesAsync();

                message = $"Workshop \"{workshop.Name}\" deleted successfully";
            }
            catch
            {
                message = $"Can't delete workshop \"{workshop.Name}\", something went wrong";
            }
            return Content(message);
        }

        [Route("admin/dashboard/Services/verified")]
        public IActionResult VerifiedServices()
        {
            var Services = _context.Services.Where(s => s.Verified)
                                    .Include(s => s.WorkShop)
                                    .ToList();
            return View(Services);
        }

        [Route("admin/dashboard/Services/confirmationsRequests")]
        public IActionResult NeedConfirmServices()
        {
            var Services = _context.Services.Where(w => !w.Verified)
                                     .Include(w => w.WorkShop)
                                     .ToList();
            return View(Services);
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmServiceAsync(int? id)
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

            string message;

            try
            {
                service.Verified = true;
                await _context.SaveChangesAsync();

                message = $"Service \"{service.Title}\" confirmed successfully";
            }
            catch
            {
                message = $"Can't confirm service \"{service.Title}\", something went wrong";
            }

            return Content(message);
        }

        // GET: Services/Delete/5
        [HttpGet]
        public async Task<IActionResult> DeleteServiceAsync(int? id)
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

            string message;
            try
            {
                _context.Services.Remove(service);
                await _context.SaveChangesAsync();

                message = $"Service \"{service.Title}\" deleted successfully";
            }
            catch
            {
                message = $"Can't delete service \"{service.Title}\", something went wrong";
            }
            return Content(message);
        }

        [Route("admin/dashboard/Services/Locations")]
        public IActionResult Locations()
        {
            var Governments = _context.Governments.ToList();
            var Cities = _context.Cities.Include(c => c.Government).ToList();

            ViewBag.Governments = Governments;

            return View(Cities);
        }

        [HttpGet]
        public IActionResult CreateGovernment()
        {
            return PartialView("_CreateGovernmentPartial");
        }

        [HttpPost]
        public IActionResult CreateGovernment(Government government)
        {
            if (government == null)
                return NotFound();

            try
            {
                _context.Governments.Add(government);
                _context.SaveChanges();

                TempData["Done"] = "New government created sucessfully";
            }
            catch
            {
                TempData["Done"] = "The new government doesn't created, something went wrong";
            }

            return RedirectToAction("Locations");
        }

        [HttpGet]
        public IActionResult CreateCity()
        {
            var Governments = _context.Governments.ToList();

            ViewBag.GovernmentId = new SelectList(Governments, "Id", "Name");

            return PartialView("_CreateCityPartial");
        }

        [HttpPost]
        public IActionResult CreateCity(City city)
        {
            if (city == null)
                return NotFound();

            try
            {
                _context.Cities.Add(city);
                _context.SaveChanges();

                TempData["Done"] = "New city created sucessfully";
            }
            catch
            {
                TempData["Done"] = "The new City doesn't created, something went wrong";
            }

            return RedirectToAction("Locations");
        }
    }
}