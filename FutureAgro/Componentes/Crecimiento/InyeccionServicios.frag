Fragment Crecimiento_InyeccionServicios {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: InyeccionServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]				
		services.AddSingleton<ILector, LectorCrecimiento>();
		services.AddSingleton<Services.ServicioCrecimiento>();
	[/ALTERCODE-FRAG]
}
