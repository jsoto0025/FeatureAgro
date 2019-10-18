<!--B-ScriptsAmbiente-->
FutureAgro\Views\Modulos\Ambiente.cshtml

<script>        
    var chartDataHumedad = @Html.Raw(Json.Serialize(ViewData["DatosHumedad"]));
</script>

<script src="~/js/Ambiente/ChartsHumedad.js?v=4"></script>
<script src="~/js/Hubs/HumedadChart.js"></script>