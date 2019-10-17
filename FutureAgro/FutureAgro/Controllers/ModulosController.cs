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
    public class ModulosController : Controller
    {
        private readonly FutureAgroIdentityDbContext _context;

        public ModulosController(FutureAgroIdentityDbContext context)
        {
            _context = context;
        }

        // GET: Modulos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Modulos.Include(modulo => modulo.Plantas).ToListAsync());
        }

        // GET: Modulos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modulo = await _context.Modulos
                .Include(mod => mod.Medidas)
                .Include(mod => mod.Plantas)
                .ThenInclude(planta => planta.Tipo)
                .FirstOrDefaultAsync(m => m.IdModulo == id);

            modulo.Temperatura = modulo.Medidas
                                        .Where(r => r.TipoMedida == TipoMedida.Temperatura)
                                        .OrderByDescending(r => r.Fecha)
                                        .Select(r => r.Valor)
                                        .FirstOrDefault();

            modulo.Humedad = (int)modulo.Medidas
                                        .Where(r => r.TipoMedida == TipoMedida.Humedad)
                                        .OrderByDescending(r => r.Fecha)
                                        .Select(r => r.Valor)
                                        .FirstOrDefault();

            modulo.Luminosidad = (int)modulo.Medidas
                                        .Where(r => r.TipoMedida == TipoMedida.Luminosidad)
                                        .OrderByDescending(r => r.Fecha)
                                        .Select(r => r.Valor)
                                        .FirstOrDefault();

            if (modulo == null)
            {
                return NotFound();
            }

            return View(modulo);
        }

        // GET: Modulos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Modulos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdModulo,Capacidad")] Modulo modulo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modulo);
        }

        // GET: Modulos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modulo = await _context.Modulos.FindAsync(id);
            if (modulo == null)
            {
                return NotFound();
            }
            return View(modulo);
        }

        // POST: Modulos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdModulo,Capacidad")] Modulo modulo)
        {
            if (id != modulo.IdModulo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModuloExists(modulo.IdModulo))
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
            return View(modulo);
        }

        // GET: Modulos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modulo = await _context.Modulos
                .Include(mod => mod.Plantas)
                .FirstOrDefaultAsync(m => m.IdModulo == id);
            if (modulo == null)
            {
                return NotFound();
            }

            return View(modulo);
        }

        // POST: Modulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modulo = await _context.Modulos.FindAsync(id);
            _context.Modulos.Remove(modulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModuloExists(int id)
        {
            return _context.Modulos.Any(e => e.IdModulo == id);
        }
    }
}
