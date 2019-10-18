Fragment ActuadorHum_ActuadorHumedad {
	Action: add
	Priority: low
	PointBracketsLan: html
	FragmentationPoints: ActuadorHumedad
	Destinations: ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]		
		<h6 class="col-6 text-right align-text-bottom small">
			<span class="mdl-switch__label" style="left:0;">Aspersores</span>
			<label class="mdl-switch mdl-js-switch mdl-js-ripple-effect w-25" for="switch-Aspersores">
				<input type="checkbox" id="switch-Aspersores" class="mdl-switch__input" checked />
			</label>
		</h6>
	[/ALTERCODE-FRAG]
}