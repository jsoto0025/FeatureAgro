Fragment LecturaTemp_ScriptsHome {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: ScriptsHome
	Destinations: ArchivosBasicos_Index
	SourceCode: [ALTERCODE-FRAG]
		<script>        
			var chartDataTemperatura = @Html.Raw(Json.Serialize(ViewData["DatosTemperatura"]));
		</script>
		<script src="~/js/Home/ChartTemperaturaHome.js"></script>
	[/ALTERCODE-FRAG]
}
