using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Controllers
{
    public class Userprofile : Controller
    {
        private readonly WorkShopDbContext _context;
        public Userprofile (WorkShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string username)
        {
            var user = _context.Users.Where(u => u.UserName == username).FirstOrDefault();
            var userprofile = _context.UserProfiles.Where(u => u.UserId == user.Id).FirstOrDefault();
            userprofile.User = user;
            //var userProfiles = _context.UserProfiles.Where(u => u.Id == id);
            // var user = _context.UserProfiles.Include(w=>w.User).Where(u => u.User.UserName == username).FirstOrDefault();
            return View(userprofile);
        }
    }
}
