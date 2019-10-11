using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureAgro.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        Task<IQueryable<T>> GetAll();

        Task<T> FindAsync(int? id);
    }
}
