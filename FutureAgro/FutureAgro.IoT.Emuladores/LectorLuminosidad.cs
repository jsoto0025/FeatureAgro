using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System.Linq;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorLuminosidad : LectorBase<Luminosidad>, ILector
    {
        public event LecturaEventHandler Lectura;

        public LectorLuminosidad(LuminosidadRepository repository) : base(repository.Get().ToList())
        {
        }

        protected override void BroadcastLectura(Luminosidad luminosidad, double nuevaMedicion)
        {
            luminosidad.Medida = nuevaMedicion;
            Lectura?.Invoke("updateLuminosidad", luminosidad);
        }

        protected override double ObtenerMedidaActual(Luminosidad luminosidad)
        {
            return luminosidad.Medida;
        }
    }
}
