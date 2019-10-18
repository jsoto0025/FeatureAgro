/*B-InyeccionServicios*/
Startup.cs

services.AddSingleton<ILector, LectorLuminosidad>();
services.AddTransient<LuminosidadRepository>();
services.AddSingleton<Services.ServicioLuminosidad>();