using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Models
{
    public partial class Growth
    {
        public int GrowthId { get; set; }
        public int PlantId { get; set; }
        public double Growth1 { get; set; }
        public DateTime? Date { get; set; }

        public Plant Plant { get; set; }
    }
}
