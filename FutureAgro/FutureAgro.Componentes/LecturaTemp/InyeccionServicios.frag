Fragment LecturaTemp_InyeccionServicios {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: InyeccionServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]					
		services.AddSingleton<ILector, LectorTemperatura>();
		services.AddTransient<TemperaturaRepository>();
		services.AddSingleton<Services.ServicioTemperatura>();
	[/ALTERCODE-FRAG]
}
