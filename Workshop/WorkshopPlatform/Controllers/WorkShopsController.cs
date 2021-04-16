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
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly WorkShopDbContext _context;

        public WorkShopsController(WorkShopDbContext context)
        {
            _context = context;
        }

        // GET: WorkShops
        public async Task<IActionResult> Index()
        {
            var workShopDbContext = _context.WorkShops;

            return View(await workShopDbContext.ToListAsync());
        }

        public async Task<IActionResult> Emergacy(string City, string Government)
        {
            var workShopDbContext = _context.WorkShops.Include(w => w.User);

            if (Government != "" && Government != null)
            {
                Government = Government.ToLower();
                var workShop = await workShopDbContext.Where(ws => ws.Government.ToLower().Contains(Government)).ToListAsync();
                return View(workShop);
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

        // GET: WorkShops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workShop = await _context.WorkShops

                .Include(w => w.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workShop == null)
            {
                return NotFound();
            }

            return View(workShop);
        }

        // GET: WorkShops/Create
        public IActionResult Create()
        {
            ViewData["ConfirmationId"] = new SelectList(_context.Confirmations, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: WorkShops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Image,Logo,Verified,Address,City,Government,Rate,UserId,ConfirmationId")] WorkShop workShop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workShop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", workShop.UserId);
            return View(workShop);
        }

        // GET: WorkShops/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", workShop.UserId);
            return View(workShop);
        }

        // POST: WorkShops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Image,Logo,Verified,Address,City,Government,Rate,UserId,ConfirmationId")] WorkShop workShop)
        {
            if (id != workShop.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workShop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkShopExists(workShop.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", workShop.UserId);
            return View(workShop);
        }

        // GET: WorkShops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workShop = await _context.WorkShops
                .Include(w => w.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workShop == null)
            {
                return NotFound();
            }

            return View(workShop);
        }

        // POST: WorkShops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workShop = await _context.WorkShops.FindAsync(id);
            _context.WorkShops.Remove(workShop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkShopExists(int id)
        {
            return _context.WorkShops.Any(e => e.Id == id);
        }

        public IActionResult Workshopcollector(int id)
        {
            dynamic dy = new ExpandoObject();
            dy.aboutwarsha = Workshop(id);
            dy.WarshaRate = WorkshopRating(id);
            dy.warshaservices = WorkshopService(id);

            return View(dy);
        }

        public List<WorkShop> Workshop(int? id)
        {
            List<WorkShop> workShopDbContext = _context.WorkShops.Include(w => w.User).Where(w => w.Id == id).ToList();
            return workShopDbContext;
        }

        public List<Service> WorkshopService(int? id)
        {
            List<Service> workShopDbContext = _context.Services.Where(w => w.WorkShopId == id).ToList();
            ViewBag.servcount = 0;

            return workShopDbContext;
        }

        public List<WorkshopRate> WorkshopRating(int? id)
        {
            List<WorkshopRate> workShopRatingDbContext = _context.WorkshopRates.Include(w => w.UserProfile).Include(w => w.UserProfile.User).Where(w => w.WorkShopId == id).ToList();
            ViewBag.active = "active";
            ViewBag.itemcount = 0;

            return workShopRatingDbContext;
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Userrate(WorkshopRate WorkshopRate)
        {
            try
            {
                WorkshopRate.Date = DateTime.Now;
                var userID = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                //var user = _userManager.FindByIdAsync(userID).Result;
                int UId = int.Parse(userID);
                var userprofile = _context.UserProfiles.Where(w => w.Id == UId).FirstOrDefault();
                WorkshopRate.UserProfileId = UId;
                WorkshopRate.UserProfile = userprofile;

                _context.Add(WorkshopRate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Workshopcollector));
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Workshopcollector));
            }
        }
    }
}