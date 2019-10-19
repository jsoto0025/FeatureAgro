Fragment Produccion_DetallePlanta {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: DetallePlanta
	Destinations: ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]				
		<h6 class="mb-3">
			Tiempo para producción
			@{
				var crecimiento = item.Crecimiento;
				var color = item.Crecimiento <= 20 ? "light" : item.Crecimiento <= 40 ? "info" : item.Crecimiento <= 60 ? "success" : item.Crecimiento < 100 ? "warning" : "danger";

				var dias = (crecimiento * 0.35);
				var txtDias = "";
				if (dias >= 35)
				{
					txtDias = "Cosechar";
				}
				else
				{
					txtDias = Math.Round(35 - dias, 0).ToString() + " Días";
				}
			}
			<span id="spanTiempoProduccion-@item.IdPlanta" class="badge badge-@color @(item.Viva?"":"invisible")">@txtDias</span>
		</h6>
	[/ALTERCODE-FRAG]
}