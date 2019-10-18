using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.DataAccess.Repositories
{
    public class PlantasRepository
    {
        private readonly DbSet<Plant> plantas;
        private readonly FutureAgroIdentityDbContext _context;
        public PlantasRepository(FutureAgroIdentityDbContext context)
        {
            _context = context;
            plantas = _context.Set<Plant>();
        }

        public DbSet<Plant> Get()
        {
            return plantas;
        }

        public Plant Find(params object[] values)
        {
            var planta = plantas.Find(values);
            _context.Entry(planta).Reload();
            return planta;
        }
    }
}
