using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using FutureAgro.Web.Models;

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
            CargarLimites();
            return View(await _context.Tray.Include(modulo => modulo.Plant).ToListAsync());
        }

        // GET: Modulos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CargarLimites();

            var modulo = await _context.Tray
                .Include(mod => mod.Plant)
                .ThenInclude(planta => planta)
                .FirstOrDefaultAsync(m => m.TrayId == id);

            if (modulo == null)
            {
                return NotFound();
            }

            return View(modulo);
        }
        
        // GET: Modulos/Ambiente/5
        public async Task<IActionResult> Ambiente(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modulo = await _context.Tray
                .FirstOrDefaultAsync(m => m.TrayId == id);

            var medidasModulo = _context.Measure
                                        .Where(r => r.TrayId == id);

            ChartData datosTemperatura = ObtenerDatosMedida(medidasModulo, TipoMedida.Temperatura, "IndianRed", "AntiqueWhite");
            ViewData["DatosTemperatura"] = datosTemperatura;

            ChartData datosHumedad = ObtenerDatosMedida(medidasModulo, TipoMedida.Humedad, "#007bff", "LightBlue");
            ViewData["DatosHumedad"] = datosHumedad;

            ChartData datosLuminosidad = ObtenerDatosMedida(medidasModulo, TipoMedida.Luminosidad, "Yellow", "LightYellow");
            ViewData["DatosLuminosidad"] = datosLuminosidad;

            if (modulo == null)
            {
                return NotFound();
            }

            return View(modulo);
        }

        private static ChartData ObtenerDatosMedida(IQueryable<Measure> medidasModulo, TipoMedida tipoMedida, string color, string backgroundColor)
        {
            var temperaturas = medidasModulo
                                            .Where(r => r.MeasureTypeId == (int)tipoMedida)
                                            .OrderByDescending(r => r.Date)
                                            .Take(10);

            var datosTemperatura = new ChartData()
            {
                Labels = temperaturas.Select(r => r.Date.ToLongTimeString()).ToArray(),
                Datasets = new ChartDataSet[] {
                    new ChartDataSet()
                    {
                        Label = tipoMedida.ToString(),
                        BackgroundColor = backgroundColor,
                        BorderColor = color,
                        BorderWidth = 1,
                        PointBackgroundColor = color,
                        Data = temperaturas.Select(r => r.Value).ToArray()
                    }
                }
            };
            return datosTemperatura;
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

            var modulo = await _context.Tray.FindAsync(id);
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

            var modulo = await _context.Tray
                .Include(mod => mod.Plant)
                .FirstOrDefaultAsync(m => m.TrayId == id);
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
            var modulo = await _context.Tray.FindAsync(id);
            _context.Tray.Remove(modulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModuloExists(int id)
        {
            return _context.Tray.Any(e => e.TrayId == id);
        }

        private void CargarLimites()
        {
            /*BCP - CustomizationPoint */

            ViewData["TemperaturaLimiteSuperior"] = (double)22;
            ViewData["TemperaturaLimiteInferior"] = (double)18;
            ViewData["HumedadLimiteSuperior"] = 75;
            ViewData["HumedadLimiteInferior"] = 50;
            ViewData["LuminosidadLimiteSuperior"] = 700;
            ViewData["LuminosidadLimiteInferior"] = 450;

            /*ECP - CustomizationPoint */
        }
    }
}
