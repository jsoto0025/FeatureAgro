Fragment LecturaHum_ChartsAmbiente {
	Action: add
	Priority: Medium
	PointBracketsLan: html
	FragmentationPoints: ChartsAmbiente
	Destinations: ControlAmbienteBase_Ambiente
	SourceCode: [ALTERCODE-FRAG]				
		<div class="col-6">
			<h5 class="col-6"><i class="fas fa-tint"></i> Humedad</h5>
			<canvas id="ChartHumedad" height="150"></canvas>
		</div>
	[/ALTERCODE-FRAG]
}