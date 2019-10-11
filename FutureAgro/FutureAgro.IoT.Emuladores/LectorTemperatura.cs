using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorTemperatura : LectorBase<Temperatura>, ILector<Temperatura>
    {
        private readonly ConcurrentBag<Temperatura> _Temperaturas = new ConcurrentBag<Temperatura>();

        private readonly object _updateTemperaturaLock = new object();
        private readonly Random _updateOrNotRandom = new Random();
        
        private readonly Timer _timer;
        private volatile bool _updatingTemperatura = false;

        public event LecturaEventHandler<Temperatura> Lectura;
        
        public LectorTemperatura(TemperaturaRepository repository)
        {
            _Temperaturas.Clear();
            var Temperaturas = repository.Get().ToList();
            Temperaturas.ForEach(temperatura => _Temperaturas.Add(temperatura));

            _timer = new Timer(UpdateTemperatura, null, _updateInterval, _updateInterval);
        }

        private void UpdateTemperatura(object state)
        {
            lock (_updateTemperaturaLock)
            {
                if (!_updatingTemperatura)
                {
                    _updatingTemperatura = true;

                    foreach (var Temperatura in _Temperaturas)
                    {
                        if (TryUpdateTemperatura(Temperatura))
                        {
                            BroadcastTemperatura(Temperatura);
                        }
                    }

                    _updatingTemperatura = false;
                }
            }
        }

        private bool TryUpdateTemperatura(Temperatura Temperatura)
        {
            // Randomly choose whether to update this Temperatura or not
            var r = _updateOrNotRandom.NextDouble();
            if (r > .51)
            {
                return false;
            }

            // Update the Temperature measure by a random factor of the range percent
            var random = new Random((int)Math.Floor(Temperatura.Medida));
            var percentChange = random.NextDouble() * _rangePercent;
            var pos = random.NextDouble() > .51;
            var change = Math.Round(Temperatura.Medida * percentChange, 2);
            change = pos ? change : -change;

            Temperatura.Medida = Math.Round(Temperatura.Medida + change, 2);
            return true;
        }

        private void BroadcastTemperatura(Temperatura temperatura)
        {
            Lectura?.Invoke(temperatura);
        }
    }
}
