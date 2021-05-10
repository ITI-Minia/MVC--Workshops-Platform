using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Views.Shared.Components
{
    public class NavHeader : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly WorkShopDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public NavHeader(IHttpContextAccessor httpContextAccessor,
                         WorkShopDbContext context,
                         SignInManager<IdentityUser> signInManager,
                         UserManager<IdentityUser> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            //get user notifications
            var notifications = await _context.Notifications.Where(n => n.ReceiverId == userID)
                                              .ToListAsync();
            int notifCount = notifications.Where(n => n.Unread == true).ToList().Count;

            ViewBag.Notifications = notifications;
            ViewBag.context = _context;
            ViewBag.UnreadCount = notifCount;

            if (User.IsInRole("Workshop"))
            {
                var workshop = _context.WorkShops.Where(w => w.UserId == userID)
                               .Include(w => w.User).FirstOrDefault();

                return View("_LoginPartial", workshop);
            }

            var profile = _context.UserProfiles.Where(u => u.UserId == userID)
                         .Include(p => p.User).FirstOrDefault();

            //services that user in current session had orderd
            var userServices = await _context.UserServices.Where(s => s.UserId == userID && s.Finished == false)
                                                          .Include(s => s.Service)
                                                          .Include(s => s.Service.WorkShop)
                                                          .OrderByDescending(s => s.Date)
                                                          .ToListAsync();
            ViewData["UserServices"] = userServices;

            return View("_LoginPartial", profile);
        }
    }
}