Fragment LecturaLum_ControlAmbienteDetalle {
	Action: add
	Priority: Medium
	PointBracketsLan: html
	FragmentationPoints: ControlAmbienteDetalleLum
	Destinations: ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]					
		@{
			var colorLuz = Model.Luminosidad <= superiorLuz && Model.Luminosidad >= inferiorLuz ? "success" : "danger";
		}
		<div class="row">
			<h6 class="col-6"><i class="fas fa-lightbulb"></i> Luminosidad</h6>
			<!--B-ActuadorLuminosidad-->
		</div>
		<table class="table">
			<tbody>
				<tr>
					<td><div class="badge badge-@colorLuz" id="divLumens-@Model.IdModulo">@Model.Luminosidad Lumens</div></td>
				</tr>
			</tbody>
		</table>
	[/ALTERCODE-FRAG]
}