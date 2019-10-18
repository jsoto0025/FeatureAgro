/*B-InyeccionServicios*/
Startup.cs

services.AddSingleton<ILector, LectorCrecimiento>();
services.AddSingleton<Services.ServicioCrecimiento>();