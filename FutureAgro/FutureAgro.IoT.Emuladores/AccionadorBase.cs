using System;
using System.Collections.Generic;
using System.Text;

namespace FutureAgro.IoT.Emuladores
{
    public abstract class AccionadorBase
    {
        public abstract bool Accionar(TipoAccion tipoAccion);
    }
}
