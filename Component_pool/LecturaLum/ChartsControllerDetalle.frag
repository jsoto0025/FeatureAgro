﻿Fragment LecturaLum_ChartsControllerDetalle {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: ChartsControllerDetalle
	Destinations: ArchivosBasicos_ModulosController
	SourceCode: [ALTERCODE-FRAG]				
		ChartData datosLuminosidad = ObtenerDatosMedida(medidasModulo, TipoMedida.Luminosidad, "Yellow", "LightYellow");
		ViewData["DatosLuminosidad"] = datosLuminosidad;
	[/ALTERCODE-FRAG]
}