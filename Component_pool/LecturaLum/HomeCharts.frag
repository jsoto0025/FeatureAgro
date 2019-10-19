Fragment LecturaLum_HomeCharts {
	Action: add
	Priority: Medium
	PointBracketsLan: java
	FragmentationPoints: HomeCharts
	Destinations: ArchivosBasicos_HomeController
	SourceCode: [ALTERCODE-FRAG]					
		var brightness = _dbContext.Medidas.Where(x => x.TipoMedida == TipoMedida.Luminosidad);
		ChartData datosLuminosidad = ObtenerDatosMedida(brightness, TipoMedida.Luminosidad, "Yellow", "LightYellow");
		ViewData["DatosLuminosidad"] = datosLuminosidad;
	[/ALTERCODE-FRAG]
}