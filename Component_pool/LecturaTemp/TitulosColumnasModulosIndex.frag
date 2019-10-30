Fragment LecturaTemp_TitulosColumnasModulosIndex {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: TitulosColumnasModulosIndex
	Destinations: ArchivosBasicos_ModulosIndex
	SourceCode: [ALTERCODE-FRAG]
		<th>
			@Html.DisplayNameFor(model => model.Temperatura)
		</th>
	[/ALTERCODE-FRAG]
}