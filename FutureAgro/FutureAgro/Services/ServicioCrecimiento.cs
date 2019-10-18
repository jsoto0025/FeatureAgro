using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Emuladores;
using System;

namespace FutureAgro.Web.Services
{
    public class ServicioCrecimiento
    {
        private readonly FutureAgroIdentityDbContext _context;
        public ServicioCrecimiento(LectorCrecimiento lectorCrecimiento, FutureAgroIdentityDbContext context)
        {
            _context = context;
            lectorCrecimiento.Lectura += LectorCrecimiento_Lectura;
        }
        
        private void LectorCrecimiento_Lectura(string method, object dato)
        {
            Crecimiento crecimiento = (Crecimiento)dato;
            Plant planta = _context.Plant.Find(crecimiento.IdPlanta);
            _context.Entry(planta).Reload();
            
            planta.Growth = crecimiento.PorcentajeCrecimiento;
            var entity = _context.Add(crecimiento);
            _context.SaveChanges();
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
    }
}
