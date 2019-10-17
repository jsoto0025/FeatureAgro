using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FutureAgro.DataAccess.Repositories
{
    public class HumedadRepository
    {
        private readonly FutureAgroIdentityDbContext _context;
        public HumedadRepository(FutureAgroIdentityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Humedad> Get()
        {
            return _context.Modulos
                        .Include(r => r.Medidas)
                        .Select(r => new Humedad
                        {
                            Modulo = r.IdModulo,
                            Medida = r.Medidas
                                        .Where(m => m.TipoMedida == TipoMedida.Humedad)
                                        .OrderByDescending(m => m.Fecha)
                                        .Select(m => m.Valor)
                                        .FirstOrDefault()
                        });
        }
    }
}
