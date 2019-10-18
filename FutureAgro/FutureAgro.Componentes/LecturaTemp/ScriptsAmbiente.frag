<!--B-ScriptsAmbiente-->
FutureAgro\Views\Modulos\Ambiente.cshtml

<script>        
    var chartDataTemperatura = @Html.Raw(Json.Serialize(ViewData["DatosTemperatura"]));
</script>
<script src="~/js/Ambiente/ChartsTemperatura.js"></script>
<script src="~/js/Hubs/TemperaturaChart.js?v=4"></script>