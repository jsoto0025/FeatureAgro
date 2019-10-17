﻿using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.DataAccess.Repositories
{
    public class PlantasRepository
    {
        private readonly DbSet<Planta> plantas;
        public PlantasRepository(FutureAgroIdentityDbContext context)
        {
            plantas = context.Set<Planta>();
        }

        public DbSet<Planta> Get()
        {
            return plantas;
        }

        public Planta Find(params object[] values)
        {
            return plantas.Find(values);
        }
    }
}
