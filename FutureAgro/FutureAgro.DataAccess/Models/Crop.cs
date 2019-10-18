using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Models
{
    public partial class Crop
    {
        public Crop()
        {
            TrayXcrop = new HashSet<TrayXcrop>();
        }

        public int CropId { get; set; }
        public string Code { get; set; }
        public int PlantTypeId { get; set; }

        public PlantType PlantType { get; set; }
        public ICollection<TrayXcrop> TrayXcrop { get; set; }
    }
}
