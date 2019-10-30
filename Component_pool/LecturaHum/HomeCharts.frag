Fragment LecturaHum_HomeCharts {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: HomeCharts
	Destinations: ArchivosBasicos_HomeController
	SourceCode: [ALTERCODE-FRAG]					
		var humidity = _dbContext.Medidas.Where(x => x.TipoMedida == TipoMedida.Humedad);
		ChartData datosHumedad = ObtenerDatosMedida(humidity, TipoMedida.Humedad, "#007bff", "LightBlue");
		ViewData["DatosHumedad"] = datosHumedad;
	[/ALTERCODE-FRAG]
}