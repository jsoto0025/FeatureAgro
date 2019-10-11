using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Contratos;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace FutureAgro.Web.Hubs
{
    public class TemperaturaHub : Hub
    {
        private readonly ILector<Temperatura> _lectorTemperatura;
        
        public TemperaturaHub(ILector<Temperatura> lectorTemperatura)
        {
            _lectorTemperatura = lectorTemperatura;
            _lectorTemperatura.Lectura += InformarLectura;
        }

        private void InformarLectura(Temperatura dato)
        {
            Startup.TemperatureHub.Clients.All.SendAsync("updateTemperatura", dato);
        }
    }
}
