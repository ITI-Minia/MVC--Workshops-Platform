using Microsoft.AspNetCore.Http;
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

        public NavHeader(IHttpContextAccessor httpContextAccessor, WorkShopDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var profile = _context.UserProfiles.Where(u => u.UserId == userID).Include(p => p.User).FirstOrDefault();

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