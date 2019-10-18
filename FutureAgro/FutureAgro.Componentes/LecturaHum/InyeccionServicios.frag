/*B-InyeccionServicios*/
Startup.cs

services.AddSingleton<ILector, LectorHumedad>();
services.AddTransient<HumedadRepository>();
services.AddSingleton<ServicioHumedad>();