using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Emuladores;
using System;

namespace FutureAgro.Web.Services
{
    public class ServicioCrecimiento
    {
        protected readonly object _updateTemperaturaLock = new object();
        protected volatile bool _updatingTemperatura = false;
        private readonly FutureAgroIdentityDbContext _context;
        public ServicioCrecimiento(LectorCrecimiento lectorCrecimiento, FutureAgroIdentityDbContext context)
        {
            _context = context;
            lectorCrecimiento.Lectura += LectorCrecimiento_Lectura;
        }
        
        private void LectorCrecimiento_Lectura(string method, object dato)
        {
            Crecimiento crecimiento = (Crecimiento)dato;
            Planta planta = _context.Plantas.Find(crecimiento.IdPlanta);
                    
            planta.Crecimiento = crecimiento.PorcentajeCrecimiento;
            var entity = _context.Add(crecimiento);
            _context.SaveChanges();
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
    }
}
