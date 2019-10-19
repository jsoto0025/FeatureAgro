Fragment LecturaLum_ScriptsAmbiente {
	Action: add
	Priority: Medium
	PointBracketsLan: html
	FragmentationPoints: ScriptsAmbiente
	Destinations: ControlAmbienteBase_Ambiente
	SourceCode: [ALTERCODE-FRAG]
		<script>        
			var chartDataLuminosidad = @Html.Raw(Json.Serialize(ViewData["DatosLuminosidad"]));
		</script>
		<script src="~/js/Ambiente/ChartsLuminosidad.js?v=4"></script>
		<script src="~/js/Hubs/LuminosidadChart.js"></script>
	[/ALTERCODE-FRAG]
}