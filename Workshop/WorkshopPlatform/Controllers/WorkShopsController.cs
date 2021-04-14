﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Workshop.Models;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Controllers
{
    public class WorkShopsController : Controller
    {
        private readonly WorkShopDbContext _context;

        public WorkShopsController(WorkShopDbContext context)
        {
            _context = context;
        }

        // GET: WorkShops
        public async Task<IActionResult> Index()
        {
            var workShopDbContext = _context.WorkShops.Include(w => w.User);         
         
            return View(await workShopDbContext.ToListAsync());
        }

        public async Task<IActionResult> Search(string id)
        {
          
            if (id == null)
            {
                return NotFound();
            }
            if (id == "")
            {
                var workShopDbContext = _context.WorkShops.Include(w => w.User);

                return View("Index", await workShopDbContext.ToListAsync());
            }
            else
            {
                var workShopDbContext = _context.WorkShops.Include(w => w.User).ToList();
                var workShop = await _context.WorkShops.Include(w => w.User).Where(ws => ws.Name.Contains(id) ||
                                                                           ws.Rate.ToString().Contains(id) ||
                                                                           ws.Address.Contains(id) ||
                                                                           ws.City.Contains(id) ||
                                                                           ws.Government.Contains(id)).ToListAsync();
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
    }
}
