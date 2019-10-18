Fragment LecturaHum_LimitesIndex {
	Action: add
	Priority: Medium
	PointBracketsLan: java
	FragmentationPoints: LimitesIndex, LimitesDetalle
	Destinations: ArchivosBasicos_ModulosIndex, ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]					
		int superiorHum = (int)ViewData["HumedadLimiteSuperior"];
		int inferiorHum = (int)ViewData["HumedadLimiteInferior"];
	[/ALTERCODE-FRAG]
}