﻿Fragment LecturaTemp_ControlAmbienteDetalle {
	Action: add
	Priority: Medium
	PointBracketsLan: html
	FragmentationPoints: ControlAmbienteDetalle
	Destinations: ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]					
		@{
			var colorTemp = Model.Temperatura <= superiorTemp && Model.Temperatura >= inferiorTemp ? "success" : "danger";
		}
		<div class="row">
			<h6 class="col-6"><i class="fas fa-thermometer-half"></i> Temperatura</h6>
			<!--B-ActuadorTemperatura-->
		</div>
		<table class="table">
			<tbody>
				<tr>
					<td><div class="badge badge-@colorTemp" id="divTemp-@Model.IdModulo">@Model.Temperatura°C</div></td>
				</tr>
			</tbody>
		</table>
	[/ALTERCODE-FRAG]
}