Fragment LecturaTemp_HomeCharts {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: HomeCharts
	Destinations: ArchivosBasicos_HomeController
	SourceCode: [ALTERCODE-FRAG]					
		var temperatures = _dbContext.Medidas.Where(x => x.TipoMedida == TipoMedida.Temperatura);
		ChartData datosTemperatura = ObtenerDatosMedida(temperatures, TipoMedida.Temperatura, "IndianRed", "AntiqueWhite");
		ViewData["DatosTemperatura"] = datosTemperatura;
	[/ALTERCODE-FRAG]
}
