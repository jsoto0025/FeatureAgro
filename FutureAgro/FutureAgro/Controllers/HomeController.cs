using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FutureAgro.Web.Models;
using FutureAgro.DataAccess.Services;
using Microsoft.AspNetCore.Authorization;
using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Data;

namespace FutureAgro.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly FutureAgroIdentityDbContext _dbContext;
        private readonly IUserService _userService;

        public HomeController(IUserService userService, FutureAgroIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var temperatures = _dbContext.Medidas.Where(x => x.TipoMedida == TipoMedida.Temperatura);
            var humidity = _dbContext.Medidas.Where(x => x.TipoMedida == TipoMedida.Humedad);
            var brightness = _dbContext.Medidas.Where(x => x.TipoMedida == TipoMedida.Luminosidad);

            ChartData datosTemperatura = ObtenerDatosMedida(temperatures, TipoMedida.Temperatura, "IndianRed", "AntiqueWhite");
            ViewData["DatosTemperatura"] = datosTemperatura;

            ChartData datosHumedad = ObtenerDatosMedida(humidity, TipoMedida.Humedad, "#007bff", "LightBlue");
            ViewData["DatosHumedad"] = datosHumedad;

            ChartData datosLuminosidad = ObtenerDatosMedida(brightness, TipoMedida.Luminosidad, "Yellow", "LightYellow");
            ViewData["DatosLuminosidad"] = datosLuminosidad;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private static ChartData ObtenerDatosMedida(IQueryable<Medida> medidasModulo, TipoMedida tipoMedida, string color, string backgroundColor)
        {
            var temperaturas = medidasModulo
                                            .Where(r => r.TipoMedida == tipoMedida)
                                            .OrderByDescending(r => r.Fecha)
                                            .Take(10);

            var datosTemperatura = new ChartData()
            {
                Labels = temperaturas.Select(r => r.Fecha.ToLongTimeString()).ToArray(),
                Datasets = new ChartDataSet[] {
                    new ChartDataSet()
                    {
                        Label = tipoMedida.ToString(),
                        BackgroundColor = backgroundColor,
                        BorderColor = color,
                        BorderWidth = 1,
                        PointBackgroundColor = color,
                        Data = temperaturas.Select(r => r.Valor).ToArray()
                    }
                }
            };
            return datosTemperatura;
        }
    }
}
