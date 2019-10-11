using System.Threading.Tasks;
using FutureAgro.DataAccess.Models;
using FutureAgro.IoT.Contratos;
using Microsoft.AspNetCore.SignalR;

namespace FutureAgro.Web.Hubs
{
    public class LuminosidadHub : Hub
    {
        private readonly ILector<Luminosidad> _lectorLuminosidad;
        
        public LuminosidadHub(ILector<Luminosidad> lectorLuminosidad)
        {
            _lectorLuminosidad = lectorLuminosidad;
            _lectorLuminosidad.Lectura += InformarLectura;
        }

        private void InformarLectura(Luminosidad dato)
        {
            Startup.LuminosidadHub.Clients.All.SendAsync("updateLuminosidad", dato);
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}
