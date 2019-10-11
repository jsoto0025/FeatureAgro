using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System.Linq;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorLuminosidad : LectorBase<Luminosidad>, ILector<Luminosidad>
    {
        public event LecturaEventHandler<Luminosidad> Lectura;

        public LectorLuminosidad(LuminosidadRepository repository) : base(repository.Get().ToList())
        {
        }

        protected override void BroadcastLectura(Luminosidad luminosidad, double nuevaMedicion)
        {
            luminosidad.Medida = nuevaMedicion;
            Lectura?.Invoke(luminosidad);
        }

        protected override double ObtenerMedidaActual(Luminosidad luminosidad)
        {
            return luminosidad.Medida;
        }
    }
}
