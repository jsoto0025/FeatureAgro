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
            return _context.Modulos
                        .Include(r => r.Medidas)
                        .Select(r => new Luminosidad {
                            Modulo = r.IdModulo,
                            Medida = r.Medidas
                                        .Where(m => m.TipoMedida == TipoMedida.Luminosidad)
                                        .OrderByDescending(m => m.Fecha)
                                        .Select(m => m.Valor)
                                        .FirstOrDefault()
                        });
        }
    }
}
