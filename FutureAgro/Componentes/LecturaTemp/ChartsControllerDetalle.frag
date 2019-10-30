Fragment LecturaTemp_ChartsControllerDetalle {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: ChartsControllerDetalle
	Destinations: ArchivosBasicos_ModulosController
	SourceCode: [ALTERCODE-FRAG]				
		ChartData datosTemperatura = ObtenerDatosMedida(medidasModulo, TipoMedida.Temperatura, "IndianRed", "AntiqueWhite");
        ViewData["DatosTemperatura"] = datosTemperatura;
	[/ALTERCODE-FRAG]
}