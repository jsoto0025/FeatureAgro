using System;
using System.Collections.Generic;

namespace FutureAgro.DataAccess.Database
{
    public partial class Tray
    {
        public Tray()
        {
            TrayXcrop = new HashSet<TrayXcrop>();
        }

        public int TrayId { get; set; }
        public int Capacity { get; set; }

        public ICollection<TrayXcrop> TrayXcrop { get; set; }
    }
}
