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

        private readonly PlantasRepository _repository;
        public LectorCrecimiento(PlantasRepository repository): base(repository.Get().ToList())
        {
            _repository = repository;
        }

        protected override void BroadcastLectura(Planta planta, double nuevaMedicion)
        {
            Planta p = _repository.Find(planta.IdPlanta);

            if (p.Viva)
            {
                if (nuevaMedicion > 100)
                    nuevaMedicion = 100;

                p.Crecimiento = (int)nuevaMedicion;
                var crecimiento = new Crecimiento
                {
                    IdPlanta = p.IdPlanta,
                    PorcentajeCrecimiento = p.Crecimiento,
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
