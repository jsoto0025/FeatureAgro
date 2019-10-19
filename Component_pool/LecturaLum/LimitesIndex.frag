Fragment LecturaLum_LimitesIndex {
	Action: add
	Priority: Medium
	PointBracketsLan: java
	FragmentationPoints: LimitesIndex, LimitesDetalle
	Destinations: ArchivosBasicos_ModulosIndex, ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]					
		int superiorLuz = (int)ViewData["LuminosidadLimiteSuperior"];
		int inferiorLuz = (int)ViewData["LuminosidadLimiteInferior"];
	[/ALTERCODE-FRAG]
}