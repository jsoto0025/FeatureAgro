﻿Fragment LecturaTemp_InicializarServicios {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: InicializarServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]					
		var serviceTemperatura = app.ApplicationServices.GetService<Services.ServicioTemperatura>();
	[/ALTERCODE-FRAG]
}