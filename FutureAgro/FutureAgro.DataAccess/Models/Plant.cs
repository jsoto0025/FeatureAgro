﻿using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Models
{
    public partial class Plant
    {
        public Plant()
        {
            GrowthNavigation = new HashSet<Growth>();
        }

        public int PlantId { get; set; }
        public int? TrayXcropId { get; set; }
        public int PlantTypeId { get; set; }
        public bool? IsAlive { get; set; }
        public int Growth { get; set; }
        public int TrayId { get; set; }

        public PlantType PlantType { get; set; }
        public Tray Tray { get; set; }
        public TrayXcrop TrayXcrop { get; set; }
        public ICollection<Growth> GrowthNavigation { get; set; }
    }
}
