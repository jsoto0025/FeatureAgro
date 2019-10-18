<!--B-ScriptsAmbiente-->
FutureAgro\Views\Modulos\Ambiente.cshtml

<script>        
    var chartDataLuminosidad = @Html.Raw(Json.Serialize(ViewData["DatosLuminosidad"]));
</script>
<script src="~/js/Ambiente/ChartsLuminosidad.js?v=4"></script>
<script src="~/js/Hubs/LuminosidadChart.js"></script>