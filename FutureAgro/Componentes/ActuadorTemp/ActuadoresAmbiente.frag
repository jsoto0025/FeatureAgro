Fragment ActuadorTemp_ActuadoresAmbiente {
	Action: add
	Priority: low
	PointBracketsLan: html
	FragmentationPoints: ActuadoresAmbiente
	Destinations: ControlAmbienteBase_Ambiente
	SourceCode: [ALTERCODE-FRAG]		
		<div class="col-4">
			<span class="mdl-switch__label" style="left:0;">Calefacción</span>
			<label class="mdl-switch mdl-js-switch mdl-js-ripple-effect w-25" for="switch-Calefaccion">
				<input type="checkbox" id="switch-Calefaccion" class="mdl-switch__input">
			</label>
		</div>
	[/ALTERCODE-FRAG]
}
