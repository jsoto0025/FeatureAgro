using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Database
{
    public partial class Boundary
    {
        public int BoundaryId { get; set; }
        public int PlantTypeId { get; set; }
        public int? MinDo { get; set; }
        public int? MaxDo { get; set; }
        public int? OptDo { get; set; }
        public string UnitDo { get; set; }
        public decimal? MinPh { get; set; }
        public decimal? MaxPh { get; set; }
        public decimal? OptPh { get; set; }
        public string UnitPh { get; set; }
        public int? MinEc { get; set; }
        public int? MaxEc { get; set; }
        public int? OptEc { get; set; }
        public string UnitEc { get; set; }
        public int? MinOrp { get; set; }
        public int? MaxOrp { get; set; }
        public int? OptOrp { get; set; }
        public string UnitOrp { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public int? OptTemp { get; set; }
        public string UnitTemp { get; set; }
        public int MinLum { get; set; }
        public int MaxLum { get; set; }

        public PlantType PlantType { get; set; }
    }
}
