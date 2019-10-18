Fragment ControlBase_InyeccionServicios {
	Action: add
	Priority: high
	PointBracketsLan: java
	FragmentationPoints: InyeccionServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]				
		services.AddTransient<PlantasRepository>();
	[/ALTERCODE-FRAG]
}
