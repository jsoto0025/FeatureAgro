Fragment ControlAmbienteBase_ColumnasModulosIndex {
	Action: add
	Priority: high
	PointBracketsLan: html
	FragmentationPoints: ColumnasModulosIndex
	Destinations: ArchivosBasicos_ModulosIndex
	SourceCode: [ALTERCODE-FRAG]		
		<td>
			<a asp-action="Ambiente" asp-route-id="@item.IdModulo">Ver Ambiente</a>
		</td>
	[/ALTERCODE-FRAG]
}