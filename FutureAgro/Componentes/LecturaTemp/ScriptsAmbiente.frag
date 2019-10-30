Fragment LecturaTemp_ScriptsAmbiente {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: ScriptsAmbiente
	Destinations: ControlAmbienteBase_Ambiente
	SourceCode: [ALTERCODE-FRAG]
		<script>        
			var chartDataTemperatura = @Html.Raw(Json.Serialize(ViewData["DatosTemperatura"]));
		</script>
		<script src="~/js/Ambiente/ChartsTemperatura.js"></script>
		<script src="~/js/Hubs/TemperaturaChart.js?v=4"></script>
	[/ALTERCODE-FRAG]
}
