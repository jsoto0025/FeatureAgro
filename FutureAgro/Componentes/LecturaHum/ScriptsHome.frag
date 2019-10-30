Fragment LecturaHum_ScriptsHome {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: ScriptsHome
	Destinations: ArchivosBasicos_Index
	SourceCode: [ALTERCODE-FRAG]
		<script>        
			var chartDataHumedad = @Html.Raw(Json.Serialize(ViewData["DatosHumedad"]));
		</script>
		<script src="~/js/Home/ChartHumedadHome.js"></script>
	[/ALTERCODE-FRAG]
}