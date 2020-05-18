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
    public class ListaPregledanihController : Controller
    {
        private readonly CDContext _context;

        public ListaPregledanihController(CDContext context)
        {
            _context = context;
        }

        // GET: ListaPregledanih
        public async Task<IActionResult> Index()
        {
            return View(await _context.ListaPregledanih.ToListAsync());
        }

        // GET: ListaPregledanih/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaPregledanih = await _context.ListaPregledanih
                .FirstOrDefaultAsync(m => m.ListaPregledanihID == id);
            if (listaPregledanih == null)
            {
                return NotFound();
            }

            return View(listaPregledanih);
        }

        // GET: ListaPregledanih/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ListaPregledanih/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ListaPregledanihID")] ListaPregledanih listaPregledanih)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listaPregledanih);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listaPregledanih);
        }

        // GET: ListaPregledanih/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaPregledanih = await _context.ListaPregledanih.FindAsync(id);
            if (listaPregledanih == null)
            {
                return NotFound();
            }
            return View(listaPregledanih);
        }

        // POST: ListaPregledanih/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ListaPregledanihID")] ListaPregledanih listaPregledanih)
        {
            if (id != listaPregledanih.ListaPregledanihID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listaPregledanih);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListaPregledanihExists(listaPregledanih.ListaPregledanihID))
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
            return View(listaPregledanih);
        }

        // GET: ListaPregledanih/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaPregledanih = await _context.ListaPregledanih
                .FirstOrDefaultAsync(m => m.ListaPregledanihID == id);
            if (listaPregledanih == null)
            {
                return NotFound();
            }

            return View(listaPregledanih);
        }

        // POST: ListaPregledanih/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listaPregledanih = await _context.ListaPregledanih.FindAsync(id);
            _context.ListaPregledanih.Remove(listaPregledanih);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListaPregledanihExists(int id)
        {
            return _context.ListaPregledanih.Any(e => e.ListaPregledanihID == id);
        }
    }
}
