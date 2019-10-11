using System.Threading.Tasks;
using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Contratos;
using Microsoft.AspNetCore.SignalR;

namespace FutureAgro.Web.Hubs
{
    public class HumedadHub : Hub
    {
        private readonly ILector<Humedad> _lectorHumedad;
        
        public HumedadHub(ILector<Humedad> lectorHumedad)
        {
            _lectorHumedad = lectorHumedad;
            _lectorHumedad.Lectura += InformarLectura;
        }

        private void InformarLectura(Humedad dato)
        {
            Startup.HumedadHub.Clients.All.SendAsync("updateHumedad", dato);
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}
