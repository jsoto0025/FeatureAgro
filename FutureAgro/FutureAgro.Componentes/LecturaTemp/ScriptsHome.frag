<!--B-ScriptsHome-->
FutureAgro\Views\Home\Index.cshtml

<script>        
    var chartDataTemperatura = @Html.Raw(Json.Serialize(ViewData["DatosTemperatura"]));
</script>
<script src="~/js/Home/ChartTemperaturaHome.js"></script>