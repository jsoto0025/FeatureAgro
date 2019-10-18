Fragment ControlAmbienteBase_ModulosControllerDetalle {
	Action: add
	Priority: high
	PointBracketsLan: java
	FragmentationPoints: ModulosControllerDetalle, ModulosControllerIndex
	Destinations: ArchivosBasicos_ModulosController, ArchivosBasicos_ModulosController
	SourceCode: [ALTERCODE-FRAG]		
		CargarLimites();
	[/ALTERCODE-FRAG]
}
