using FutureAgro.Web.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using FutureAgro.Web.Hubs;

namespace FutureAgro.Web.Tickers
{
    public class TemperaturaTicker
    {
        // Singleton instance
        private readonly static Lazy<TemperaturaTicker> _instance = new Lazy<TemperaturaTicker>(() => new TemperaturaTicker(Startup.TemperatureHub.Clients));

        private readonly ConcurrentDictionary<int, Temperatura> _Temperaturas = new ConcurrentDictionary<int, Temperatura>();

        private readonly object _updateTemperaturaPricesLock = new object();

        //Temperatura can go up or down by a percentage of this factor on each change
        private readonly double _rangePercent = .002;

        private readonly TimeSpan _updateInterval = TimeSpan.FromMilliseconds(250);
        private readonly Random _updateOrNotRandom = new Random();

        private readonly Timer _timer;
        private volatile bool _updatingTemperaturaPrices = false;

        private TemperaturaTicker(IHubClients clients)
        {
            Clients = clients;

            _Temperaturas.Clear();
            var Temperaturas = new List<Temperatura>
            {
                new Temperatura { Medida = 19, Modulo = 1 },
                new Temperatura { Medida = 20, Modulo = 2 },
                new Temperatura { Medida = 21, Modulo = 3 }
            };
            Temperaturas.ForEach(Temperatura => _Temperaturas.TryAdd(Temperatura.Modulo, Temperatura));

            _timer = new Timer(UpdateTemperaturaValues, null, _updateInterval, _updateInterval);

        }

        public static TemperaturaTicker Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private IHubClients Clients
        {
            get;
            set;
        }

        public IEnumerable<Temperatura> GetAllTemperatures()
        {
            return _Temperaturas.Values;
        }

        private void UpdateTemperaturaValues(object state)
        {
            lock (_updateTemperaturaPricesLock)
            {
                if (!_updatingTemperaturaPrices)
                {
                    _updatingTemperaturaPrices = true;

                    foreach (var Temperatura in _Temperaturas.Values)
                    {
                        if (TryUpdateTemperaturaPrice(Temperatura))
                        {
                            BroadcastTemperaturaPrice(Temperatura);
                        }
                    }

                    _updatingTemperaturaPrices = false;
                }
            }
        }

        private bool TryUpdateTemperaturaPrice(Temperatura Temperatura)
        {
            // Randomly choose whether to update this Temperatura or not
            var r = _updateOrNotRandom.NextDouble();
            if (r > .1)
            {
                return false;
            }

            // Update the Temperature measure by a random factor of the range percent
            var random = new Random((int)Math.Floor(Temperatura.Medida));
            var percentChange = random.NextDouble() * _rangePercent;
            var pos = random.NextDouble() > .51;
            var change = Math.Round(Temperatura.Medida * percentChange, 2);
            change = pos ? change : -change;

            Temperatura.Medida += change;
            return true;
        }

        private void BroadcastTemperaturaPrice(Temperatura Temperatura)
        {
            Clients.All.SendAsync("updateTemperatura", Temperatura);
        }
    }
}
