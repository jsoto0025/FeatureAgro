using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Models
{
    public partial class Tray
    {
        public Tray()
        {
            Measure = new HashSet<Measure>();
            Plant = new HashSet<Plant>();
            TrayXcrop = new HashSet<TrayXcrop>();
        }

        public int TrayId { get; set; }
        public int Capacity { get; set; }
        public double? Temperature { get; set; }
        public int? Humidity { get; set; }
        public int? Brightness { get; set; }

        public ICollection<Measure> Measure { get; set; }
        public ICollection<Plant> Plant { get; set; }
        public ICollection<TrayXcrop> TrayXcrop { get; set; }
    }
}
