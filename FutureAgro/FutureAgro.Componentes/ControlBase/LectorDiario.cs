using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FutureAgro.IoT.Emuladores
{
    public abstract class LectorDiario<T> : LectorBase<T>
    {

        /*BCP-CustomizationPoint */
        private const int _updateDailyInterval = 86400;
        /*ECP-CustomizationPoint */

        public LectorDiario(IEnumerable<T> listado) : base(listado, TimeSpan.FromSeconds(_updateDailyInterval))
        {
            _rangePercent = .05;
        }
        
        protected override (bool exitoso, double NuevaMedicion) TryUpdateTemperatura(T medida)
        {
            double medidaActual = ObtenerMedidaActual(medida);

            if (medidaActual >= 100)
                return (false, medidaActual);

            // Update the Temperature measure by a random factor of the range percent
            var random = new Random();
            var percentChange = random.NextDouble() * _rangePercent;
            var change = Math.Round(100 * percentChange, 2);
            
            double nuevaMedicion = Math.Round(medidaActual + change, 2);
            return (true, nuevaMedicion);
        }
    }
}
