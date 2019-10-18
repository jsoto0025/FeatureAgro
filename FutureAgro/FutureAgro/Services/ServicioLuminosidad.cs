using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Emuladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web.Services
{
    public class ServicioLuminosidad
    {
        private readonly FutureAgroIdentityDbContext _context;
        public ServicioLuminosidad(LectorLuminosidad lectorLuminosidad, FutureAgroIdentityDbContext context)
        {
            _context = context;
            lectorLuminosidad.Lectura += LectorLuminosidad_Lectura;
        }

        private void LectorLuminosidad_Lectura(string method, object dato)
        {
            Luminosidad luminosidad = (Luminosidad)dato;
            var medida = new Measure
            {
                TrayId = luminosidad.Modulo,
                MeasureTypeId = (int)TipoMedida.Luminosidad,
                Value = luminosidad.Medida,
                Date = DateTime.Now
            };
            Tray modulo = _context.Tray.Find(luminosidad.Modulo);
            modulo.Brightness = (int)luminosidad.Medida;

            var entity = _context.Measure.Add(medida);
            _context.SaveChanges();
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
    }
}
