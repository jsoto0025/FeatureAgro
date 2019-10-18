using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Emuladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web.Services
{
    public class ServicioTemperatura
    {
        private readonly FutureAgroIdentityDbContext _context;
        public ServicioTemperatura(LectorTemperatura lectorTemperatura, FutureAgroIdentityDbContext context)
        {
            _context = context;
            lectorTemperatura.Lectura += LectorTemperatura_Lectura;
        }

        private void LectorTemperatura_Lectura(string method, object dato)
        {
            Temperatura temp = (Temperatura)dato;
            var medida = new Measure
            {
                TrayId = temp.Modulo,
                MeasureId = (int)TipoMedida.Humedad,
                Value = temp.Medida,
                Date = DateTime.Now
            };
            Tray modulo = _context.Tray.Find(temp.Modulo);
            modulo.Temperature = temp.Medida;

            var entity = _context.Measure.Add(medida);
            _context.SaveChanges();
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
    }
}
