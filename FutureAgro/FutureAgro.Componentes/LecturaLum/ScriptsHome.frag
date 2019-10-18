Fragment LecturaLum_ScriptsHome {
	Action: add
	Priority: Medium
	PointBracketsLan: html
	FragmentationPoints: ScriptsHome
	Destinations: ArchivosBasicos_Index
	SourceCode: [ALTERCODE-FRAG]
		<script>        
			var chartDataLuminosidad = @Html.Raw(Json.Serialize(ViewData["DatosLuminosidad"]));
		</script>
		<script src="~/js/Home/ChartLuminosidadHome.js"></script>
	[/ALTERCODE-FRAG]
}