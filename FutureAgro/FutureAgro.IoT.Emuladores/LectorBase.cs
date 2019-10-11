using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FutureAgro.IoT.Emuladores
{
    public abstract class LectorBase<T>
    {
        protected readonly ConcurrentBag<T> _Listado = new ConcurrentBag<T>();

        protected readonly double _rangePercent = .01;

        protected readonly TimeSpan _updateInterval = TimeSpan.FromSeconds(5);

        protected readonly object _updateTemperaturaLock = new object();
        protected readonly Random _updateOrNotRandom = new Random();

        protected readonly Timer _timer;
        protected volatile bool _updatingTemperatura = false;

        public LectorBase(List<T> listado)
        {
            _Listado.Clear();
            listado.ForEach(temperatura => _Listado.Add(temperatura));

            _timer = new Timer(UpdateTemperatura, null, _updateInterval, _updateInterval);
        }


        private void UpdateTemperatura(object state)
        {
            lock (_updateTemperaturaLock)
            {
                if (!_updatingTemperatura)
                {
                    _updatingTemperatura = true;

                    foreach (var medida in _Listado)
                    {
                        var (exitoso, NuevaMedicion) = TryUpdateTemperatura(medida);
                        if (exitoso)
                        {
                            BroadcastLectura(medida, NuevaMedicion);
                        }
                    }

                    _updatingTemperatura = false;
                }
            }
        }

        private (bool exitoso, double NuevaMedicion) TryUpdateTemperatura(T medida)
        {
            // Randomly choose whether to update this Temperatura or not
            var r = _updateOrNotRandom.NextDouble();
            if (r > .51)
            {
                return (false, 0);
            }

            double nuevaMedicion = ObtenerMedidaActual(medida);
            // Update the Temperature measure by a random factor of the range percent
            var random = new Random((int)Math.Floor(nuevaMedicion));
            var percentChange = random.NextDouble() * _rangePercent;
            var pos = random.NextDouble() > .51;
            var change = Math.Round(nuevaMedicion * percentChange, 2);
            change = pos ? change : -change;

            nuevaMedicion = Math.Round(nuevaMedicion + change, 2);
            return (true, nuevaMedicion);
        }

        protected abstract void BroadcastLectura(T medida, double nuevaMedicion);

        protected abstract double ObtenerMedidaActual(T medida);

    }
}
