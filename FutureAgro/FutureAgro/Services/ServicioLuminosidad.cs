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
            var medida = new Medida
            {
                IdModulo = luminosidad.Modulo,
                TipoMedida = TipoMedida.Luminosidad,
                Valor = luminosidad.Medida,
                Fecha = DateTime.Now
            };

            var entity = _context.Medidas.Add(medida);
            _context.SaveChanges();
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
    }
}
