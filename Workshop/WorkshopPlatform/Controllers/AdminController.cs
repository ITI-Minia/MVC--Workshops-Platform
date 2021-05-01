using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        public AdminController(IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager, WorkShopDbContext context)
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
            return View(workshops);
        }

        [Route("admin/dashboard/workshops/verified")]
        public IActionResult VerifiedWorkshops()
        {
            var workshops = _context.WorkShops.Where(w => w.Verified)
                                    .Include(w => w.User)
                                    .ToList();
            return View(workshops);
        }

        [Route("admin/dashboard/workshops/need-cnonfirm")]
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

            workshop.Verified = true;
            _context.SaveChanges();

            return Content(workshop.Name);
        }

        [Route("admin/dashboard/Services/verified")]
        public IActionResult VerifiedServices()
        {
            var Services = _context.Services.Where(s => s.Verified)
                                    .Include(s => s.WorkShop)
                                    .ToList();
            return View(Services);
        }

        [Route("admin/dashboard/Services/need-cnonfirm")]
        public IActionResult NeedConfirmServices()
        {
            var Services = _context.Services.Where(w => !w.Verified)
                                     .Include(w => w.WorkShop)
                                     .ToList();
            return View(Services);
        }

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

            service.Verified = true;
            _context.SaveChanges();

            return Content(service.Title);
        }
    }
}