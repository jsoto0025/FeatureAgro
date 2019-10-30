using System;

namespace FutureAgro.IoT.Contratos
{
    public interface ILector
    {
        event LecturaEventHandler Lectura;
    }
    public delegate void LecturaEventHandler(string method, object dato);
}
