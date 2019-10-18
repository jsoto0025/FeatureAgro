using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System;
using System.Linq;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorPlantasMuertas : LectorDiario<Plant>, ILector
    {
        public event LecturaEventHandler Lectura;

        public LectorPlantasMuertas(PlantasRepository repository): base(repository.Get())
        {
        }

        protected override (bool exitoso, double NuevaMedicion) TryUpdateTemperatura(Plant planta)
        {
            if (planta.IsAlive==true)
            {
                var random = new Random();
                var change = random.NextDouble();

                if (change < 0.01)
                    return (true, 1);
            }
            
            return (false, 0);
        }

        protected override void BroadcastLectura(Plant planta, double nuevaMedicion)
        {
            planta.IsAlive = false;
            Lectura?.Invoke("updatePlantaMuerta", planta);
        }
        
        protected override double ObtenerMedidaActual(Plant planta)
        {
            return 0;
        }
    }
}
