using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FutureAgro.DataAccess.Repositories
{
    public class LuminosidadRepository
    {
        private readonly FutureAgroIdentityDbContext _context;
        public LuminosidadRepository(FutureAgroIdentityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Luminosidad> Get()
        {
            return _context.Tray
                        .Include(r => r.Measure)
                        .Select(r => new Luminosidad {
                            Modulo = r.TrayId,
                            Medida = r.Brightness??0
                        });
        }
    }
}
