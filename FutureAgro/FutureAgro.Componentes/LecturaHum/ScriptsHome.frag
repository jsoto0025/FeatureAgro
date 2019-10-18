<!--B-ScriptsHome-->
FutureAgro\Views\Home\Index.cshtml

<script>        
    var chartDataHumedad = @Html.Raw(Json.Serialize(ViewData["DatosHumedad"]));
</script>
<script src="~/js/Home/ChartHumedadHome.js"></script>