using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FutureAgro.DataAccess.Database;
using Microsoft.EntityFrameworkCore;

namespace FutureAgro.DataAccess.Repositories
{
    public class CropRepository : ICropRepository
    {
        private readonly DbContext _dbContext;

        public CropRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Crop> FindAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Crop>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
