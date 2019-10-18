Fragment PlantasMuertas_InyeccionServicios {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: InyeccionServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]				
		services.AddSingleton<ILector, LectorPlantasMuertas>();
	[/ALTERCODE-FRAG]
}