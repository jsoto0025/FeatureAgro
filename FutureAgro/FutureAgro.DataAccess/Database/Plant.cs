using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Database
{
    public partial class Plant
    {
        public int PlantId { get; set; }
        public int TrayXcropId { get; set; }
        public int PlantTypeId { get; set; }
        public bool? IsAlive { get; set; }
        public int Growth { get; set; }

        public PlantType PlantType { get; set; }
        public TrayXcrop TrayXcrop { get; set; }
    }
}
