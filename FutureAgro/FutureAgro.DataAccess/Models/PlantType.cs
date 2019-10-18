using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Models
{
    public partial class PlantType
    {
        public PlantType()
        {
            Boundary = new HashSet<Boundary>();
            Crop = new HashSet<Crop>();
            Plant = new HashSet<Plant>();
        }

        public int PlantTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Boundary> Boundary { get; set; }
        public ICollection<Crop> Crop { get; set; }
        public ICollection<Plant> Plant { get; set; }
    }
}
