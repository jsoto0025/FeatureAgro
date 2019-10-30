Fragment LecturaLum_ChartsAmbiente {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: ChartsAmbiente
	Destinations: ControlAmbienteBase_Ambiente
	SourceCode: [ALTERCODE-FRAG]				
		<div class="col-6">
			<h5 class="col-6"><i class="fas fa-lightbulb"></i> Luminosidad</h5>
			<canvas id="ChartLuminosidad" height="150"></canvas>
		</div>
	[/ALTERCODE-FRAG]
}
