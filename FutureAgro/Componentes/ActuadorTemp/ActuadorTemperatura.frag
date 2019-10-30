Fragment ActuadorTemp_ActuadorTemperatura {
	Action: add
	Priority: low
	PointBracketsLan: html
	FragmentationPoints: ActuadorTemperatura
	Destinations: ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]		
		<h6 class="col-6 text-right align-text-bottom small">
            <span class="mdl-switch__label" style="left:0;">Calefacción</span>
            <label class="mdl-switch mdl-js-switch mdl-js-ripple-effect w-25" for="switch-Calefaccion">
                <input type="checkbox" id="switch-Calefaccion" class="mdl-switch__input">
            </label>
        </h6>
	[/ALTERCODE-FRAG]
}