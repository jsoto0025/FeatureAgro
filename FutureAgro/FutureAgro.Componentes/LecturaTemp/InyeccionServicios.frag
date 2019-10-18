/*B-InyeccionServicios*/
Startup.cs

services.AddSingleton<ILector, LectorTemperatura>();
services.AddTransient<TemperaturaRepository>();
services.AddSingleton<ServicioTemperatura>();