Fragment LecturaHum_ScriptsAmbiente {
	Action: add
	Priority: Medium
	PointBracketsLan: html
	FragmentationPoints: ScriptsAmbiente
	Destinations: ControlAmbienteBase_Ambiente
	SourceCode: [ALTERCODE-FRAG]
		<script>        
			var chartDataHumedad = @Html.Raw(Json.Serialize(ViewData["DatosHumedad"]));
		</script>

		<script src="~/js/Ambiente/ChartsHumedad.js?v=4"></script>
		<script src="~/js/Hubs/HumedadChart.js"></script>
	[/ALTERCODE-FRAG]
}