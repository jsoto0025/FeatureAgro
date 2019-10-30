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
    public class ServicioHumedadTests
    {
        [Fact]
        public void LectorHumedad_Lectura_GuardarHumedad()
        {
            var humRepository = new Mock<HumedadRepository>(null);
            humRepository.Setup(r => r.Get()).Returns(new List<Humedad>());
            var mockLector = new Mock<LectorHumedad>(humRepository.Object);
            var humedad = new Mock<ServicioHumedad>(mockLector.Object, null)
            {
                CallBase = true
            };
            humedad.Setup(r => r.LectorHumedad_Lectura(It.IsAny<string>(), It.IsAny<Humedad>()));
            var mockObj = humedad.Object;

            mockLector.Object.LanzarLectura(new Humedad(), 10);
            humedad.Verify(r => r.LectorHumedad_Lectura(It.IsAny<string>(), It.IsAny<Humedad>()), Times.Once);
        }
    }
}
