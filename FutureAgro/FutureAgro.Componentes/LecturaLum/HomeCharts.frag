/*B-HomeCharts*/
Controllers/HomeController.cs

var brightness = _dbContext.Medidas.Where(x => x.TipoMedida == TipoMedida.Luminosidad);
ChartData datosLuminosidad = ObtenerDatosMedida(brightness, TipoMedida.Luminosidad, "Yellow", "LightYellow");
ViewData["DatosLuminosidad"] = datosLuminosidad;

