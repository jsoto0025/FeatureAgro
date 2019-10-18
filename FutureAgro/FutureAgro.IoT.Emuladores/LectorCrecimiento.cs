using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorCrecimiento : LectorDiario<Plant>, ILector
    {
        public event LecturaEventHandler Lectura;

        private readonly PlantasRepository _repository;
        public LectorCrecimiento(PlantasRepository repository): base(repository.Get())
        {
            _repository = repository;
        }

        protected override void BroadcastLectura(Plant planta, double nuevaMedicion)
        {
            Plant p = _repository.Find(planta.PlantId);

            if (p.IsAlive==true)
            {
                if (nuevaMedicion > 100)
                    nuevaMedicion = 100;

                p.Growth = (int)nuevaMedicion;
                var crecimiento = new Crecimiento
                {
                    IdPlanta = p.PlantId,
                    PorcentajeCrecimiento = p.Growth,
                    Fecha = DateTime.Now
                };
                Lectura?.Invoke("updateCrecimiento", crecimiento);
            }
        }
        
        protected override double ObtenerMedidaActual(Plant planta)
        {
            return planta.Growth;
        }
    }
}
