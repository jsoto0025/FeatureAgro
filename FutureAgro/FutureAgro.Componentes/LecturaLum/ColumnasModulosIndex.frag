Fragment LecturaLum_ColumnasModulosIndex {
	Action: add
	Priority: Medium
	PointBracketsLan: html
	FragmentationPoints: ColumnasModulosIndex
	Destinations: ArchivosBasicos_ModulosIndex
	SourceCode: [ALTERCODE-FRAG]				
		<td>
			@{
				var colorLuz = item.Luminosidad <= superiorLuz && item.Luminosidad >= inferiorLuz ? "success" : "danger";
			}
			<div class="badge badge-@colorLuz" id="divLumens-@item.IdModulo">@item.Luminosidad Lumens</div>
		</td>
	[/ALTERCODE-FRAG]
}