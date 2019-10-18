using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web.Models
{
    public class ChartDataSet
    {
        public string Label { get; set; }
        public double[] Data { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public int BorderWidth { get; set; }
        public string PointBackgroundColor { get; set; }
    }
}
