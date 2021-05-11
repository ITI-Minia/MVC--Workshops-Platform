using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly WorkShopDbContext _context;

        public HomeController(ILogger<HomeController> logger,
            IHttpContextAccessor httpContextAccessor,
            UserManager<IdentityUser> userManager,
            WorkShopDbContext context)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> UserNotificationsAsync()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            //get user notifications
            var notifications = await _context.Notifications.Where(n => n.ReceiverId == userID)
                                              .OrderByDescending(n => n.Date)
                                              .Take(3)
                                              .ToListAsync();
            ViewBag.context = _context;

            return PartialView("_NotificationsPartial", notifications);
        }

        public async Task<IActionResult> UnreadNotificationsAsync()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            //get user notifications
            var notifications = await _context.Notifications.Where(n => n.ReceiverId == userID)
                                              .Where(n => n.Unread == true).ToListAsync();
            int Count = notifications.Count;

            return Content($"{Count}");
        }

        public async Task<IActionResult> ReadNotification(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            //get user notifications
            var notification = await _context.Notifications.Where(n => n.Id == id && n.ReceiverId == userID)
                                              .FirstOrDefaultAsync();

            if (notification == null)
            {
                return NotFound();
            }
            else
            {
                if (notification.Unread)
                {
                    notification.Unread = false;
                    _context.SaveChanges();
                }
            }

            return Content("");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TopRated()
        {
            return View();
        }
    }
}