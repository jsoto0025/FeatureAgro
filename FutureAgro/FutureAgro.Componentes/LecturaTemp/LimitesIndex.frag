Fragment LecturaTemp_LimitesIndex {
	Action: add
	Priority: Medium
	PointBracketsLan: java
	FragmentationPoints: LimitesIndex, LimitesDetalle
	Destinations: ArchivosBasicos_ModulosIndex, ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]					
		double superiorTemp = (double)ViewData["TemperaturaLimiteSuperior"];
		double inferiorTemp = (double)ViewData["TemperaturaLimiteInferior"];
	[/ALTERCODE-FRAG]
}
