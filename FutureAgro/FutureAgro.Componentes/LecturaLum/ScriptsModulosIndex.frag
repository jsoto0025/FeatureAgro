Fragment LecturaLum_ScriptsModulosIndex {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: ScriptsModulosDetalle, ScriptsModulosIndex
	Destinations: ArchivosBasicos_ModulosDetails, ArchivosBasicos_ModulosIndex
	SourceCode: [ALTERCODE-FRAG]
		<script>
			var superiorLuz = @superiorLuz;
			var inferiorLuz = @inferiorLuz;
		</script>
		<script src="~/js/Hubs/Luminosidad.js"></script>
	[/ALTERCODE-FRAG]
}