Fragment LecturaHum_ScriptsModulosIndex {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: ScriptsModulosDetalle, ScriptsModulosIndex
	Destinations: ArchivosBasicos_ModulosDetails, ArchivosBasicos_ModulosIndex
	SourceCode: [ALTERCODE-FRAG]
		<script>
			var superiorHum = @superiorHum;
			var inferiorHum = @inferiorHum;
		</script>
		<script src="~/js/Hubs/Humedad.js"></script>
	[/ALTERCODE-FRAG]
}