using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekat.Models;

namespace Projekat.Controllers
{
    public class GlumacController : Controller
    {
        private readonly CDContext _context;

        public GlumacController(CDContext context)
        {
            _context = context;
        }

        // GET: Glumac
        public async Task<IActionResult> Index()
        {
            return View(await _context.Glumac.ToListAsync());
        }

        // GET: Glumac/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glumac = await _context.Glumac
                .FirstOrDefaultAsync(m => m.GlumacID == id);
            if (glumac == null)
            {
                return NotFound();
            }

            return View(glumac);
        }

        // GET: Glumac/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Glumac/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GlumacID,Ime")] Glumac glumac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(glumac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(glumac);
        }

        // GET: Glumac/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glumac = await _context.Glumac.FindAsync(id);
            if (glumac == null)
            {
                return NotFound();
            }
            return View(glumac);
        }

        // POST: Glumac/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GlumacID,Ime")] Glumac glumac)
        {
            if (id != glumac.GlumacID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(glumac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GlumacExists(glumac.GlumacID))
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
            return View(glumac);
        }

        // GET: Glumac/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glumac = await _context.Glumac
                .FirstOrDefaultAsync(m => m.GlumacID == id);
            if (glumac == null)
            {
                return NotFound();
            }

            return View(glumac);
        }

        // POST: Glumac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var glumac = await _context.Glumac.FindAsync(id);
            _context.Glumac.Remove(glumac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GlumacExists(int id)
        {
            return _context.Glumac.Any(e => e.GlumacID == id);
        }
    }
}
