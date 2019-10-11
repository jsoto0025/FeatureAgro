using FutureAgro.Web.Models;
using FutureAgro.Web.Tickers;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web.Hubs
{
    public class TemperaturaHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        private readonly TemperaturaTicker _tempTicker;

        public TemperaturaHub() : this(TemperaturaTicker.Instance) { }

        public TemperaturaHub(TemperaturaTicker stockTicker)
        {
            _tempTicker = stockTicker;
        }

        public IEnumerable<Temperatura> GetAllStocks()
        {
            return _tempTicker.GetAllTemperatures();
        }
    }
}
