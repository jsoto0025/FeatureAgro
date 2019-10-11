using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FutureAgro.DataAccess.Database;
using FutureAgro.DataAccess.Repositories;

namespace FutureAgro.DataAccess.Services
{
    public class CropService : ICropService
    {
        private readonly ICropRepository _cropRepository;

        public CropService(ICropRepository cropRepository)
        {
            _cropRepository = cropRepository;
        }

        public IQueryable<Crop> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
