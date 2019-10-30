using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FutureAgro.DataAccess.Repositories
{
    public class TemperaturaRepository
    {
        private readonly FutureAgroIdentityDbContext _context;
        public TemperaturaRepository(FutureAgroIdentityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Temperatura> Get()
        {
            return _context.Modulos
                        .Include(r => r.Medidas)
                        .Select(r => new Temperatura
                        {
                            Modulo = r.IdModulo,
                            Medida = r.Temperatura??0
                        });
        }
    }
}
