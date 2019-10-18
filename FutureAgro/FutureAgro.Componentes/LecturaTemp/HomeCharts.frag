/*B-HomeCharts*/
Controllers/HomeController.cs

var temperatures = _dbContext.Medidas.Where(x => x.TipoMedida == TipoMedida.Temperatura);
ChartData datosTemperatura = ObtenerDatosMedida(temperatures, TipoMedida.Temperatura, "IndianRed", "AntiqueWhite");
ViewData["DatosTemperatura"] = datosTemperatura;
