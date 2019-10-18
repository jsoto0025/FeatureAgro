<!--B-ColumnasModulosIndex-->
FutureAgro\Views\Modulos\Index.cshtml

<td>
    @{
        var colorHum = item.Humedad <= superiorHum && item.Humedad >= inferiorHum ? "success" : "danger";
    }
    <div class="badge badge-@colorHum" id="divHumedad-@item.IdModulo">@item.Humedad%</div>
</td>
            