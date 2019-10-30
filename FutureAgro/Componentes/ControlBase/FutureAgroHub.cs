using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Contratos;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web.Hubs
{
    public class FutureAgroHub : Hub
    {
        private readonly IEnumerable<ILector> _lectores;
        public FutureAgroHub(IEnumerable<ILector> lectores)
        {
            _lectores = lectores;
            foreach (var lector in _lectores)
            {
                lector.Lectura += InformarLectura;
            }
        }

        private void InformarLectura(string method, object dato)
        {
            Startup.FutureAgroHub.Clients.All.SendAsync(method, dato);
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}
