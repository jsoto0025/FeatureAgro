Fragment ControlAmbienteBase_BotonesModulosDetalle {
	Action: add
	Priority: high
	PointBracketsLan: html
	FragmentationPoints: BotonesModulosDetalle
	Destinations: ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]		
		 |
		<a asp-action="Ambiente" asp-route-id="@Model.IdModulo">Ambiente</a>
	[/ALTERCODE-FRAG]
}