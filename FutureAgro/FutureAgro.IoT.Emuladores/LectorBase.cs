using System;
using System.Collections.Generic;
using System.Text;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorBase<T>
    {
        protected readonly double _rangePercent = .01;

        protected readonly TimeSpan _updateInterval = TimeSpan.FromSeconds(5);
    }
}
