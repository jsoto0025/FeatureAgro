using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Repositories
{
    public class HumedadRepository
    {
        private readonly DbContext context;
        private readonly DbSet<Humedad> humedades;
        public HumedadRepository(FutureAgroIdentityDbContext context)
        {
            humedades = context.Set<Humedad>();
        }

        public IEnumerable<Humedad> Get()
        {
            return MockHumedades();

            //return humedades;
        }

        private IEnumerable<Humedad> MockHumedades()
        {
            return new List<Humedad> {
                new Humedad
                {
                    Modulo = 1,
                    Medida = 70
                },
                new Humedad
                {
                    Modulo = 2,
                    Medida = 40
                },
                new Humedad
                {
                    Modulo = 3,
                    Medida = 70
                },
                new Humedad
                {
                    Modulo = 4,
                    Medida = 50
                },
                new Humedad
                {
                    Modulo = 5,
                    Medida = 70
                }
            };
        }
    }
}
