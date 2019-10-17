using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System;
using System.Linq;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorPlantasMuertas : LectorDiario<Planta>, ILector
    {
        public event LecturaEventHandler Lectura;

        public LectorPlantasMuertas(PlantasRepository repository): base(repository.Get().ToList())
        {
        }

        protected override (bool exitoso, double NuevaMedicion) TryUpdateTemperatura(Planta planta)
        {
            if (planta.Viva)
            {
                var random = new Random();
                var change = random.NextDouble();

                if (change < 0.01)
                    return (true, 1);
            }
            
            return (false, 0);
        }

        protected override void BroadcastLectura(Planta planta, double nuevaMedicion)
        {
            planta.Viva = false;
            Lectura?.Invoke("updatePlantaMuerta", planta);
        }
        
        protected override double ObtenerMedidaActual(Planta planta)
        {
            return 0;
        }
    }
}
