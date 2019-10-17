using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Emuladores;
using System;

namespace FutureAgro.Web.Services
{
    public class ServicioPlantasMuertas
    {
        private readonly FutureAgroIdentityDbContext _context;
        public ServicioPlantasMuertas(LectorPlantasMuertas lectorPlantasMuertas, FutureAgroIdentityDbContext context)
        {
            _context = context;
            lectorPlantasMuertas.Lectura += LectorPlantasMuertas_Lectura;
        }
        
        private void LectorPlantasMuertas_Lectura(string method, object dato)
        {
            Planta objPlanta = (Planta)dato;
            Planta plantaDb = _context.Plantas.Find(objPlanta.IdPlanta);
            _context.Entry(plantaDb).Reload();

            plantaDb.Viva = objPlanta.Viva;
            _context.SaveChanges();
        }
    }
}
