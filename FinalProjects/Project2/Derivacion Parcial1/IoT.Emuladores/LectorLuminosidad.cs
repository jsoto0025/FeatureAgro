using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System;
using System.Linq;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorLuminosidad : LectorBase<Luminosidad>, ILector
    {
        public event LecturaEventHandler Lectura;

        public LectorLuminosidad(LuminosidadRepository repository) : base(repository.Get())
        {
        }

        protected override void BroadcastLectura(Luminosidad luminosidad, double nuevaMedicion)
        {
            luminosidad.Medida = nuevaMedicion;
            luminosidad.Fecha = DateTime.Now.ToLongTimeString();
            Lectura?.Invoke("updateLuminosidad", luminosidad);
        }

        protected override double ObtenerMedidaActual(Luminosidad luminosidad)
        {
            return luminosidad.Medida > 0 ? luminosidad.Medida : 400;
        }
    }
}
