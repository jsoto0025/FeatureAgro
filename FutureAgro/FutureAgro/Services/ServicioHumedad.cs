using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Emuladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web.Services
{
    public class ServicioHumedad
    {
        private readonly FutureAgroIdentityDbContext _context;
        public ServicioHumedad(LectorHumedad lectorHumedad, FutureAgroIdentityDbContext context)
        {
            _context = context;
            lectorHumedad.Lectura += LectorHumedad_Lectura;
        }

        private void LectorHumedad_Lectura(string method, object dato)
        {
            Humedad humedad = (Humedad)dato;
            var medida = new Medida
            {
                IdModulo = humedad.Modulo,
                TipoMedida = TipoMedida.Humedad,
                Valor = humedad.Medida,
                Fecha = DateTime.Now
            };

            var entity = _context.Medidas.Add(medida);
            _context.SaveChanges();
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
    }
}
