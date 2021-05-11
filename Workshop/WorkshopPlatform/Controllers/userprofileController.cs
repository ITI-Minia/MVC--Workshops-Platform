using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Controllers
{
    public class UserprofileController : Controller
    {
        private readonly WorkShopDbContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UserprofileController(WorkShopDbContext context,
            IHttpContextAccessor httpContext,
            IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _httpContext = httpContext;
            _webHostEnvironment = webHostEnvironment;
        }

        [Route("profile/{username}")]
        public async Task<IActionResult> IndexAsync(string username)
        {
            var userprofile = _context.UserProfiles.Where(u => u.User.UserName == username)
                                                   .Include(u => u.User).FirstOrDefault();

            //services that user in current session had orderd
            var CurrentServices = await _context.UserServices.Where(s => s.UserId == userprofile.UserId && s.Finished == false)
                                                          .OrderByDescending(s => s.Date)
                                                          .Include(s => s.Service)
                                                          .Include(s => s.Service.WorkShop)
                                                          .ToListAsync();

            var PrevServices = await _context.UserServices.Where(s => s.UserId == userprofile.UserId && s.Finished == true)
                                                      .OrderByDescending(s => s.Date)
                                                          .Include(s => s.Service)
                                                          .Include(s => s.Service.WorkShop)
                                                          .ToListAsync();

            var userID = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            bool profileOwner = false;  //for visitors

            if (userprofile.UserId == userID)
            {
                profileOwner = true; //for profile owner
            }

            ViewBag.ProfileOwner = profileOwner;
            ViewBag.CurrentServices = CurrentServices;
            ViewBag.PrevServices = PrevServices;

            return View(userprofile);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveImage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.UserProfiles.FindAsync(id);

            if (profile == null)
            {
                return NotFound();
            }

            //if (profile.Image != null)
            //{
            //    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Upload/images");
            //    System.IO.File.Delete(Path.Combine(uploadsFolder, profile.Image));
            //}

            profile.Image = null;

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

            var profile = await _context.UserProfiles.Where(p => p.Id == id)
                .Include(u => u.User).FirstOrDefaultAsync();

            if (profile == null)
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
            if (profile.Image != null)
            {
                System.IO.File.Delete(Path.Combine(uploadsFolder, profile.Image));
            }
            profile.Image = uniqueFileName;

            _context.SaveChanges();

            return RedirectToAction("Index", new { username = profile.User.UserName });
        }
    }
}