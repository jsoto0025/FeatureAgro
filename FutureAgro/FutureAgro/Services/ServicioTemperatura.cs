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

        public virtual void LectorTemperatura_Lectura(string method, object dato)
        {
            Temperatura temp = (Temperatura)dato;
            var medida = new Medida
            {
                IdModulo = temp.Modulo,
                TipoMedida = TipoMedida.Temperatura,
                Valor = temp.Medida,
                Fecha = DateTime.Now
            };
            Modulo modulo = _context.Modulos.Find(temp.Modulo);
            modulo.Temperatura = temp.Medida;

            var entity = _context.Medidas.Add(medida);
            _context.SaveChanges();
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
    }
}
