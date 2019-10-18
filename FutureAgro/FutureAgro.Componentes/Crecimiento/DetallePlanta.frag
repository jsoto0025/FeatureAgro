Fragment Crecimiento_DetallePlanta {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: DetallePlanta
	Destinations: ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]		
		
		Crecimiento
		<div class="progress mb-3">
			<div id="progrescrecimiento-@item.IdPlanta" class="progress-bar" role="progressbar" style="width:@(item.Viva?item.Crecimiento:0)%;"></div>
		</div>
	[/ALTERCODE-FRAG]
}