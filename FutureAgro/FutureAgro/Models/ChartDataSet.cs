using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web.Models
{
    public class ChartDataSet
    {
        public string Label { get; set; } // "Medida",
        public double[] Data { get; set; } // [19.5, 23, 19, 19.5, 19.5, 20, 23],
        public string BackgroundColor { get; set; } // "antiquewhite",
        public string BorderColor { get; set; } // "INDIANRED",
        public int BorderWidth { get; set; } // 1,
        public string PointBackgroundColor { get; set; } // 
    }
}
