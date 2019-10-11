using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Repositories
{
    public class LuminosidadRepository
    {
        private readonly DbContext context;
        private readonly DbSet<Luminosidad> Luminosidads;
        public LuminosidadRepository(FutureAgroIdentityDbContext context)
        {
            Luminosidads = context.Set<Luminosidad>();
        }

        public IEnumerable<Luminosidad> Get()
        {
            return MockLuminosidad();

            //return Luminosidads;
        }

        private IEnumerable<Luminosidad> MockLuminosidad()
        {
            return new List<Luminosidad> {
                new Luminosidad
                {
                    Modulo = 1,
                    Medida = 500
                },
                new Luminosidad
                {
                    Modulo = 2,
                    Medida = 500
                },
                new Luminosidad
                {
                    Modulo = 3,
                    Medida = 500
                },
                new Luminosidad
                {
                    Modulo = 4,
                    Medida = 500
                },
                new Luminosidad
                {
                    Modulo = 5,
                    Medida = 400
                }
            };
        }
    }
}
