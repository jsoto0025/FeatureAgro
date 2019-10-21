Fragment LecturaHum_ChartsControllerDetalle {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: ChartsControllerDetalle
	Destinations: ArchivosBasicos_ModulosController
	SourceCode: [ALTERCODE-FRAG]				
		ChartData datosHumedad = ObtenerDatosMedida(medidasModulo, TipoMedida.Humedad, "#007bff", "LightBlue");
        ViewData["DatosHumedad"] = datosHumedad;
	[/ALTERCODE-FRAG]
}