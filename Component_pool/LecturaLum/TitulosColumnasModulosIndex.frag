﻿Fragment LecturaLum_TitulosColumnasModulosIndex {
	Action: add
	Priority: Medium
	PointBracketsLan: html
	FragmentationPoints: TitulosColumnasModulosIndex
	Destinations: ArchivosBasicos_ModulosIndex
	SourceCode: [ALTERCODE-FRAG]
		<th>
			@Html.DisplayNameFor(model => model.Luminosidad)
		</th>
	[/ALTERCODE-FRAG]
}