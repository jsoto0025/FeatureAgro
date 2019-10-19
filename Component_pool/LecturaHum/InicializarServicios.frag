Fragment LecturaHum_InicializarServicios {
	Action: add
	Priority: Medium
	PointBracketsLan: java
	FragmentationPoints: InicializarServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]					
		var serviceHumedad = app.ApplicationServices.GetService<Services.ServicioHumedad>();
	[/ALTERCODE-FRAG]
}
