<!--B-DetallePlanta-->
FutureAgro\Views\Home\Details.cshtml

Crecimiento
<div class="progress mb-3">
    <div id="progrescrecimiento-@item.IdPlanta" class="progress-bar" role="progressbar" style="width:@(item.Viva?item.Crecimiento:0)%;"></div>
</div>