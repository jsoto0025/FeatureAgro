/*B-HomeCharts*/
Controllers/HomeController.cs

var humidity = _dbContext.Medidas.Where(x => x.TipoMedida == TipoMedida.Humedad);
ChartData datosHumedad = ObtenerDatosMedida(humidity, TipoMedida.Humedad, "#007bff", "LightBlue");
ViewData["DatosHumedad"] = datosHumedad;
