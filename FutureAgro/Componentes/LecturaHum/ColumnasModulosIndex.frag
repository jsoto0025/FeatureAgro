Fragment LecturaHum_ColumnasModulosIndex {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: ColumnasModulosIndex
	Destinations: ArchivosBasicos_ModulosIndex
	SourceCode: [ALTERCODE-FRAG]				
		<td>
			@{
				var colorHum = item.Humedad <= superiorHum && item.Humedad >= inferiorHum ? "success" : "danger";
			}
			<div class="badge badge-@colorHum" id="divHumedad-@item.IdModulo">@item.Humedad%</div>
		</td>
	[/ALTERCODE-FRAG]
}            