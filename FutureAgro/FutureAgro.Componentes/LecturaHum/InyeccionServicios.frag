Fragment LecturaHum_InyeccionServicios {
	Action: add
	Priority: Medium
	PointBracketsLan: java
	FragmentationPoints: InyeccionServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]					
		services.AddSingleton<ILector, LectorHumedad>();
		services.AddTransient<HumedadRepository>();
		services.AddSingleton<Services.ServicioHumedad>();
	[/ALTERCODE-FRAG]
}