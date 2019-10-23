Fragment LecturaTemp_ChartsAmbiente {
	Action: add
	Priority: medium
	PointBracketsLan: html
	FragmentationPoints: ChartsAmbiente
	Destinations: ControlAmbienteBase_Ambiente
	SourceCode: [ALTERCODE-FRAG]				
		<div class="col-6">
			<h5 class="col-6"><i class="fas fa-thermometer-half"></i> Temperatura</h5>
			<canvas id="ChartTemperatura" height="150"></canvas>
		</div>
	[/ALTERCODE-FRAG]
}