Fragment LecturaLum_InyeccionServicios {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: InyeccionServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]					
		services.AddSingleton<ILector, LectorLuminosidad>();
		services.AddTransient<LuminosidadRepository>();
		services.AddSingleton<Services.ServicioLuminosidad>();
	[/ALTERCODE-FRAG]
}