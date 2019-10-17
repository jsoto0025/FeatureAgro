using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorCrecimiento : LectorDiario<Planta>, ILector
    {
        public event LecturaEventHandler Lectura;

        public LectorCrecimiento(PlantasRepository repository): base(repository.Get().ToList())
        {
        }

        protected override void BroadcastLectura(Planta planta, double nuevaMedicion)
        {
            if (planta.Viva)
            {
                if (nuevaMedicion > 100)
                    nuevaMedicion = 100;
                
                planta.Crecimiento = (int)nuevaMedicion;
                var crecimiento = new Crecimiento
                {
                    IdPlanta = planta.IdPlanta,
                    PorcentajeCrecimiento = planta.Crecimiento,
                    Fecha = DateTime.Now
                };
                Lectura?.Invoke("updateCrecimiento", crecimiento);
            }
        }
        
        protected override double ObtenerMedidaActual(Planta planta)
        {
            return planta.Crecimiento;
        }
    }
}
