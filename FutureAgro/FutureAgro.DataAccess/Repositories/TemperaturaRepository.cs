using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureAgro.DataAccess.Repositories
{
    public class TemperaturaRepository
    {
        private readonly DbContext context;
        private readonly DbSet<Temperatura> temperaturas;
        public TemperaturaRepository(FutureAgroIdentityDbContext context)
        {
            temperaturas = context.Set<Temperatura>();
        }

        public IEnumerable<Temperatura> Get()
        {
            return MockTemperaturas();

            //return temperaturas;
        }

        private IEnumerable<Temperatura> MockTemperaturas()
        {
            return new List<Temperatura> {
                new Temperatura
                {
                    Modulo = 1,
                    Medida = 25
                },
                new Temperatura
                {
                    Modulo = 2,
                    Medida = 20
                },
                new Temperatura
                {
                    Modulo = 3,
                    Medida = 22
                },
                new Temperatura
                {
                    Modulo = 4,
                    Medida = 20
                },
                new Temperatura
                {
                    Modulo = 5,
                    Medida = 20
                }
            };
        }
    }
}
