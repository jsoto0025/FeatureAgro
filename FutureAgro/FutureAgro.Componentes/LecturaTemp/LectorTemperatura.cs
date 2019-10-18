using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FutureAgro.IoT.Emuladores
{
    public class LectorTemperatura : LectorBase<Temperatura>, ILector
    {
        public event LecturaEventHandler Lectura;

        public LectorTemperatura(TemperaturaRepository repository) : base(repository.Get())
        {
        }

        protected override void BroadcastLectura(Temperatura temperatura, double nuevaMedicion)
        {
            temperatura.Medida = nuevaMedicion;
            temperatura.Fecha = DateTime.Now.ToLongTimeString();
            Lectura?.Invoke("updateTemperatura", temperatura);
        }

        protected override double ObtenerMedidaActual(Temperatura temperatura)
        {
            return temperatura.Medida > 0 ? temperatura.Medida : 19;
        }
    }
}
