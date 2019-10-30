Fragment ActuadorHum_ActuadoresAmbiente {
	Action: add
	Priority: low
	PointBracketsLan: html
	FragmentationPoints: ActuadoresAmbiente
	Destinations: ControlAmbienteBase_Ambiente
	SourceCode: [ALTERCODE-FRAG]
		<div class="col-4">
			<span class="mdl-switch__label" style="left:0;">Aspersores</span>
			<label class="mdl-switch mdl-js-switch mdl-js-ripple-effect w-25" for="switch-Aspersores">
				<input type="checkbox" id="switch-Aspersores" class="mdl-switch__input" checked />
			</label>
		</div>
	[/ALTERCODE-FRAG]
}