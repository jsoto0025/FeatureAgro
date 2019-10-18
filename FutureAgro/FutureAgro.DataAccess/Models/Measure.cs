using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Models
{
    public partial class Measure
    {
        public int MeasureId { get; set; }
        public int TrayId { get; set; }
        public int MeasureTypeId { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

        public MeasureType MeasureType { get; set; }
        public Tray Tray { get; set; }
    }
}
