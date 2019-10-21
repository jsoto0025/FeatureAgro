Fragment Produccion_ScriptUpdatePlantaMuerta {
	Action: add
	Priority: high
	PointBracketsLan: java
	FragmentationPoints: ScriptUpdatePlantaMuerta
	Destinations: PlantasMuertas_PlantasMuertas
	SourceCode: [ALTERCODE-FRAG]				
		$("#spanTiempoProduccion-" + planta.idPlanta).addClass("invisible");
	[/ALTERCODE-FRAG]
}