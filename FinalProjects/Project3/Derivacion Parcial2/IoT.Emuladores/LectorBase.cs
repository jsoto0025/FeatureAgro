using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FutureAgro.IoT.Emuladores
{
    public abstract class LectorBase<T>
    {

        /*BCP-CPBase*/
        private const int _defaultUpdateInterval = 4600;
        /*ECP-CPBase*/

        private TimeSpan _updateInterval;

        protected readonly ConcurrentBag<T> _Listado = new ConcurrentBag<T>();

        protected double _rangePercent = .01;

        protected readonly object _updateTemperaturaLock = new object();
        protected readonly Random _updateOrNotRandom = new Random();

        protected readonly Timer _timer;
        protected volatile bool _updatingTemperatura = false;

        private IEnumerable<T> _listado;

        public LectorBase(IEnumerable<T> listado) : this(listado, TimeSpan.FromSeconds(_defaultUpdateInterval))
        {
        }

        public LectorBase(IEnumerable<T> listado, TimeSpan updateInterval)
        {
            _updateInterval = updateInterval;
            _listado = listado;
            _timer = new Timer(UpdateTemperatura, null, _updateInterval, _updateInterval);
        }

        private void UpdateTemperatura(object state)
        {
            lock (_updateTemperaturaLock)
            {
                if (!_updatingTemperatura)
                {
                    _updatingTemperatura = true;

                    _Listado.Clear();
                    _listado.ToList().ForEach(temperatura => _Listado.Add(temperatura));

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

        protected virtual (bool exitoso, double NuevaMedicion) TryUpdateTemperatura(T medida)
        {
            // Randomly choose whether to update this Temperatura or not
            var r = _updateOrNotRandom.NextDouble();
            if (r > .51)
            {
                return (false, 0);
            }

            double nuevaMedicion = ObtenerMedidaActual(medida);
            // Update the Temperature measure by a random factor of the range percent
            var random = new Random();
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
