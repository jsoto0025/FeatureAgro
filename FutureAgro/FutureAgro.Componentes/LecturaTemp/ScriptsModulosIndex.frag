Fragment LecturaTemp_ScriptsModulosIndex {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: ScriptsModulosDetalle, ScriptsModulosIndex
	Destinations: ArchivosBasicos_ModulosDetails, ArchivosBasicos_ModulosIndex
	SourceCode: [ALTERCODE-FRAG]
		<script>
			var superiorTemp = @superiorTemp;
			var inferiorTemp = @inferiorTemp;
		</script>
		<script src="~/js/Hubs/Temperatura.js"></script>
	[/ALTERCODE-FRAG]
}
