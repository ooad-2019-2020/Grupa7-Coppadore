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
    public class FilmZanrController : Controller
    {
        private readonly CDContext _context;

        public FilmZanrController(CDContext context)
        {
            _context = context;
        }

        // GET: FilmZanr
        public async Task<IActionResult> Index()
        {
            return View(await _context.FilmZanr.ToListAsync());
        }

        // GET: FilmZanr/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmZanr = await _context.FilmZanr
                .FirstOrDefaultAsync(m => m.FilmZanrID == id);
            if (filmZanr == null)
            {
                return NotFound();
            }

            return View(filmZanr);
        }

        // GET: FilmZanr/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FilmZanr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilmZanrID")] FilmZanr filmZanr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filmZanr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filmZanr);
        }

        // GET: FilmZanr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmZanr = await _context.FilmZanr.FindAsync(id);
            if (filmZanr == null)
            {
                return NotFound();
            }
            return View(filmZanr);
        }

        // POST: FilmZanr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FilmZanrID")] FilmZanr filmZanr)
        {
            if (id != filmZanr.FilmZanrID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmZanr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmZanrExists(filmZanr.FilmZanrID))
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
            return View(filmZanr);
        }

        // GET: FilmZanr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmZanr = await _context.FilmZanr
                .FirstOrDefaultAsync(m => m.FilmZanrID == id);
            if (filmZanr == null)
            {
                return NotFound();
            }

            return View(filmZanr);
        }

        // POST: FilmZanr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var filmZanr = await _context.FilmZanr.FindAsync(id);
            _context.FilmZanr.Remove(filmZanr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmZanrExists(int id)
        {
            return _context.FilmZanr.Any(e => e.FilmZanrID == id);
        }
    }
}
