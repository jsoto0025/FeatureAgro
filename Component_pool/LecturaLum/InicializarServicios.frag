﻿Fragment LecturaLum_InicializarServicios {
	Action: add
	Priority: Medium
	PointBracketsLan: java
	FragmentationPoints: InicializarServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]					
		var serviceLuminosidad = app.ApplicationServices.GetService<Services.ServicioLuminosidad>();
	[/ALTERCODE-FRAG]
}