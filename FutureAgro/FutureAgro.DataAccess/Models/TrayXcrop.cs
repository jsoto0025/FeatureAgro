using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Models
{
    public partial class TrayXcrop
    {
        public TrayXcrop()
        {
            Plant = new HashSet<Plant>();
        }

        public int TrayXcropId { get; set; }
        public int CropId { get; set; }
        public int TrayId { get; set; }
        public DateTime CreationDate { get; set; }

        public Crop Crop { get; set; }
        public Tray Tray { get; set; }
        public ICollection<Plant> Plant { get; set; }
    }
}
