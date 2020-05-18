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
    public class GlumacFilmController : Controller
    {
        private readonly CDContext _context;

        public GlumacFilmController(CDContext context)
        {
            _context = context;
        }

        // GET: GlumacFilm
        public async Task<IActionResult> Index()
        {
            return View(await _context.GlumacFilm.ToListAsync());
        }

        // GET: GlumacFilm/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glumacFilm = await _context.GlumacFilm
                .FirstOrDefaultAsync(m => m.GlumacFilmID == id);
            if (glumacFilm == null)
            {
                return NotFound();
            }

            return View(glumacFilm);
        }

        // GET: GlumacFilm/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GlumacFilm/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GlumacFilmID")] GlumacFilm glumacFilm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(glumacFilm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(glumacFilm);
        }

        // GET: GlumacFilm/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glumacFilm = await _context.GlumacFilm.FindAsync(id);
            if (glumacFilm == null)
            {
                return NotFound();
            }
            return View(glumacFilm);
        }

        // POST: GlumacFilm/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GlumacFilmID")] GlumacFilm glumacFilm)
        {
            if (id != glumacFilm.GlumacFilmID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(glumacFilm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GlumacFilmExists(glumacFilm.GlumacFilmID))
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
            return View(glumacFilm);
        }

        // GET: GlumacFilm/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var glumacFilm = await _context.GlumacFilm
                .FirstOrDefaultAsync(m => m.GlumacFilmID == id);
            if (glumacFilm == null)
            {
                return NotFound();
            }

            return View(glumacFilm);
        }

        // POST: GlumacFilm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var glumacFilm = await _context.GlumacFilm.FindAsync(id);
            _context.GlumacFilm.Remove(glumacFilm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GlumacFilmExists(int id)
        {
            return _context.GlumacFilm.Any(e => e.GlumacFilmID == id);
        }
    }
}
