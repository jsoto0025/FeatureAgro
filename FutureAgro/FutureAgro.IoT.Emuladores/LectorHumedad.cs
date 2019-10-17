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
    public class LectorHumedad : LectorBase<Humedad>, ILector
    {
        public event LecturaEventHandler Lectura;

        public LectorHumedad(HumedadRepository repository) : base(repository.Get().ToList())
        {
        }
        
        protected override void BroadcastLectura(Humedad humedad, double nuevaMedicion)
        {
            humedad.Medida = nuevaMedicion;
            humedad.Fecha = DateTime.Now.ToLongTimeString();
            Lectura?.Invoke("updateHumedad", humedad);
        }

        protected override double ObtenerMedidaActual(Humedad humedad)
        {
            return humedad.Medida > 0 ? humedad.Medida : 50;
        }
    }
}
