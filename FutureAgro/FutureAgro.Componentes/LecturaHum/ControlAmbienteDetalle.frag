Fragment LecturaHum_ControlAmbienteDetalle {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: ControlAmbienteDetalleHum
	Destinations: ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]					
		@{
			var colorHum = Model.Humedad <= superiorHum && Model.Humedad >= inferiorHum ? "success" : "danger";
		}
		<div class="row">
			<h6 class="col-6"><i class="fas fa-tint"></i> Humedad</h6>
			<!--B-ActuadorHumedad-->
		</div>
		<table class="table">
			<tbody>
				<tr>
					<td><div class="badge badge-@colorHum" id="divHumedad-@Model.IdModulo">@Model.Humedad%</div></td>
				</tr>
			</tbody>
		</table>
	[/ALTERCODE-FRAG]
}