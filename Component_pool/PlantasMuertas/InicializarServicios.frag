Fragment PlantasMuertas_InicializarServicios {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: InicializarServicios
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]				
		var servicePlantasMuertas = app.ApplicationServices.GetService<Services.ServicioPlantasMuertas>();
	[/ALTERCODE-FRAG]
}