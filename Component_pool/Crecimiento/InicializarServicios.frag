Fragment Crecimiento_InicializarServicios {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: InicializarServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]				
		var serviceCrecimiento = app.ApplicationServices.GetService<Services.ServicioCrecimiento>();
	[/ALTERCODE-FRAG]
}