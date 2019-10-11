using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorHumedad : LectorBase<Humedad>, ILector<Humedad>
    {
        public event LecturaEventHandler<Humedad> Lectura;

        public LectorHumedad(HumedadRepository repository) : base(repository.Get().ToList())
        {
        }
        
        protected override void BroadcastLectura(Humedad humedad, double nuevaMedicion)
        {
            humedad.Medida = nuevaMedicion;
            Lectura?.Invoke(humedad);
        }

        protected override double ObtenerMedidaActual(Humedad humedad)
        {
            return humedad.Medida;
        }
    }
}
