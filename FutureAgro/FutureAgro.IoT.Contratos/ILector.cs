using System;

namespace FutureAgro.IoT.Contratos
{
    public interface ILector<T>
    {
        event LecturaEventHandler<T> Lectura;
    }
    public delegate void LecturaEventHandler<T>(T dato);
}
