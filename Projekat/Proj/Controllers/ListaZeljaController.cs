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
    public class ListaZeljaController : Controller
    {
        private readonly CDContext _context;

        public ListaZeljaController(CDContext context)
        {
            _context = context;
        }

        // GET: ListaZelja
        public async Task<IActionResult> Index()
        {
            return View(await _context.ListaZelja.ToListAsync());
        }

        // GET: ListaZelja/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaZelja = await _context.ListaZelja
                .FirstOrDefaultAsync(m => m.ListaZeljaID == id);
            if (listaZelja == null)
            {
                return NotFound();
            }

            return View(listaZelja);
        }

        // GET: ListaZelja/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ListaZelja/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ListaZeljaID")] ListaZelja listaZelja)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listaZelja);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listaZelja);
        }

        // GET: ListaZelja/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaZelja = await _context.ListaZelja.FindAsync(id);
            if (listaZelja == null)
            {
                return NotFound();
            }
            return View(listaZelja);
        }

        // POST: ListaZelja/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ListaZeljaID")] ListaZelja listaZelja)
        {
            if (id != listaZelja.ListaZeljaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listaZelja);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListaZeljaExists(listaZelja.ListaZeljaID))
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
            return View(listaZelja);
        }

        // GET: ListaZelja/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaZelja = await _context.ListaZelja
                .FirstOrDefaultAsync(m => m.ListaZeljaID == id);
            if (listaZelja == null)
            {
                return NotFound();
            }

            return View(listaZelja);
        }

        // POST: ListaZelja/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listaZelja = await _context.ListaZelja.FindAsync(id);
            _context.ListaZelja.Remove(listaZelja);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListaZeljaExists(int id)
        {
            return _context.ListaZelja.Any(e => e.ListaZeljaID == id);
        }
    }
}
