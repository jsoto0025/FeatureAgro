Fragment LecturaTemp_ColumnasModulosIndex {
	Action: add
	Priority: Medium
	PointBracketsLan: html
	FragmentationPoints: ColumnasModulosIndex
	Destinations: ArchivosBasicos_ModulosIndex
	SourceCode: [ALTERCODE-FRAG]				
		<td>
			@{
				var colorTemp = item.Temperatura <= superiorTemp && item.Temperatura >= inferiorTemp ? "success" : "danger";
			}
			<div class="badge badge-@colorTemp" id="divTemp-@item.IdModulo">@item.Temperatura°C</div>
		</td>
	[/ALTERCODE-FRAG]
}