using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FutureAgro.DataAccess.Services
{
    public interface IService<T>
    {
        IQueryable<T> GetAll();
    }
}
