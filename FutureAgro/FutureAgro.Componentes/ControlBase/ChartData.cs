using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web.Models
{
    public class ChartData
    {
        public string[] Labels { get; set; }
        public ChartDataSet[] Datasets { get; set; }
    }
}
