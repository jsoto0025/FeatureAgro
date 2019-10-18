<!--B-ColumnasModulosIndex-->
FutureAgro\Views\Modulos\Index.cshtml

<td>
    @{
        var colorLuz = item.Luminosidad <= superiorLuz && item.Luminosidad >= inferiorLuz ? "success" : "danger";
    }
    <div class="badge badge-@colorLuz" id="divLumens-@item.IdModulo">@item.Luminosidad Lumens</div>
</td>