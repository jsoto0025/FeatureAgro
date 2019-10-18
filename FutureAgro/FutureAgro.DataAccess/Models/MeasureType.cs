using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Models
{
    public partial class MeasureType
    {
        public MeasureType()
        {
            Measure = new HashSet<Measure>();
        }

        public int MeasureTypeId { get; set; }
        public string MeasureName { get; set; }

        public ICollection<Measure> Measure { get; set; }
    }
}
