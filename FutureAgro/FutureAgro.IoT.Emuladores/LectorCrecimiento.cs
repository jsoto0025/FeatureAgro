using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorCrecimiento : LectorDiario<Planta>, ILector
    {
        public event LecturaEventHandler Lectura;

        public LectorCrecimiento(PlantasRepository repository): base(repository.Get())
        {
        }

        protected override void BroadcastLectura(Planta planta, double nuevaMedicion)
        {
            if (planta.Viva)
            {
                planta.Crecimiento = (int)nuevaMedicion;
                Lectura?.Invoke("updateCrecimiento", planta);
            }
        }
        
        protected override double ObtenerMedidaActual(Planta planta)
        {
            return planta.Crecimiento;
        }
    }
}
