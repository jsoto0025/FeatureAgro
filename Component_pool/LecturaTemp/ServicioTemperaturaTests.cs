using FutureAgro.DataAccess.Data;
using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Repositories;
using FutureAgro.IoT.Contratos;
using FutureAgro.IoT.Emuladores;
using FutureAgro.Web.Services;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace FutureAgro.UnitTests
{
    public class ServicioTemperaturaTests
    {
        [Fact]
        public void LectorTemperatura_Lectura_GuardarTemperatura()
        {
            var humRepository = new Mock<TemperaturaRepository>(null);
            humRepository.Setup(r => r.Get()).Returns(new List<Temperatura>());
            var mockLector = new Mock<LectorTemperatura>(humRepository.Object);
            var Temperatura = new Mock<ServicioTemperatura>(mockLector.Object, null)
            {
                CallBase = true
            };
            Temperatura.Setup(r => r.LectorTemperatura_Lectura(It.IsAny<string>(), It.IsAny<Temperatura>()));
            var mockObj = Temperatura.Object;

            mockLector.Object.LanzarLectura(new Temperatura(), 10);
            Temperatura.Verify(r => r.LectorTemperatura_Lectura(It.IsAny<string>(), It.IsAny<Temperatura>()), Times.Once);
        }
    }
}
