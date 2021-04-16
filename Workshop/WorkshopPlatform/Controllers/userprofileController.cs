﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Controllers
{
    public class userprofileController : Controller
    {
        private readonly WorkShopDbContext _context;
        public userprofileController(WorkShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string username)
        {
            var user = _context.Users.Where(u => u.UserName == username).FirstOrDefault();
            var userprofile = _context.UserProfiles.Where(u => u.UserId == user.Id).FirstOrDefault();
            userprofile.User = user;
            return View(userprofile);
        }
    }
}