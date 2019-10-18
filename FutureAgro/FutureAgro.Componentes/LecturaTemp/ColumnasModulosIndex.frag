<!--B-ColumnasModulosIndex-->
FutureAgro\Views\Modulos\Index.cshtml

<td>
    @{
        var colorTemp = item.Temperatura <= superiorTemp && item.Temperatura >= inferiorTemp ? "success" : "danger";
    }
    <div class="badge badge-@colorTemp" id="divTemp-@item.IdModulo">@item.Temperatura°C</div>
</td>