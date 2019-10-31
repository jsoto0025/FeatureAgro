using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;

namespace FutureAgro.Web.Controllers
{
    public class PlantasController : Controller
    {
        private readonly FutureAgroIdentityDbContext _context;

        public PlantasController(FutureAgroIdentityDbContext context)
        {
            _context = context;
        }

        // GET: Plantas
        public async Task<IActionResult> Index()
        {
            var futureAgroIdentityDbContext = _context.Plantas.Include(p => p.Modulo).Include(p => p.Tipo);
            return View(await futureAgroIdentityDbContext.ToListAsync());
        }

        // GET: Plantas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planta = await _context.Plantas
                .Include(p => p.Modulo)
                .Include(p => p.Tipo)
                .FirstOrDefaultAsync(m => m.IdPlanta == id);
            if (planta == null)
            {
                return NotFound();
            }

            return View(planta);
        }

        // GET: Plantas/Create
        public IActionResult Create()
        {
            ViewData["IdModulo"] = new SelectList(_context.Modulos, "IdModulo", "IdModulo");
            ViewData["IdTipoPlanta"] = new SelectList(_context.Set<TipoPlanta>(), "IdTipoPlanta", "Nombre");
            return View();
        }

        // POST: Plantas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPlanta,IdTipoPlanta,Viva,Crecimiento,IdModulo")] Planta planta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdModulo"] = new SelectList(_context.Modulos, "IdModulo", "IdModulo", planta.IdModulo);
            ViewData["IdTipoPlanta"] = new SelectList(_context.Set<TipoPlanta>(), "IdTipoPlanta", "Nombre", planta.IdTipoPlanta);
            return View(planta);
        }

        // GET: Plantas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planta = await _context.Plantas.FindAsync(id);
            if (planta == null)
            {
                return NotFound();
            }
            ViewData["IdModulo"] = new SelectList(_context.Modulos, "IdModulo", "IdModulo", planta.IdModulo);
            ViewData["IdTipoPlanta"] = new SelectList(_context.Set<TipoPlanta>(), "IdTipoPlanta", "Nombre", planta.IdTipoPlanta);
            return View(planta);
        }

        // POST: Plantas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPlanta,IdTipoPlanta,Viva,Crecimiento,IdModulo")] Planta planta)
        {
            if (id != planta.IdPlanta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlantaExists(planta.IdPlanta))
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
            ViewData["IdModulo"] = new SelectList(_context.Modulos, "IdModulo", "IdModulo", planta.IdModulo);
            ViewData["IdTipoPlanta"] = new SelectList(_context.Set<TipoPlanta>(), "IdTipoPlanta", "Nombre", planta.IdTipoPlanta);
            return View(planta);
        }

        // GET: Plantas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planta = await _context.Plantas
                .Include(p => p.Modulo)
                .Include(p => p.Tipo)
                .FirstOrDefaultAsync(m => m.IdPlanta == id);
            if (planta == null)
            {
                return NotFound();
            }

            return View(planta);
        }

        // POST: Plantas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planta = await _context.Plantas.FindAsync(id);
            _context.Plantas.Remove(planta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlantaExists(int id)
        {
            return _context.Plantas.Any(e => e.IdPlanta == id);
        }
    }
}
