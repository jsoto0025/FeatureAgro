<!--B-ScriptsHome-->
FutureAgro\Views\Home\Index.cshtml

<script>        
    var chartDataLuminosidad = @Html.Raw(Json.Serialize(ViewData["DatosLuminosidad"]));
</script>
<script src="~/js/Home/ChartLuminosidadHome.js"></script>