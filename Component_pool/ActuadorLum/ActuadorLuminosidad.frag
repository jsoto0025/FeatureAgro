Fragment ActuadorLum_ActuadorLuminosidad {
	Action: add
	Priority: low
	PointBracketsLan: html
	FragmentationPoints: ActuadorLuminosidad
	Destinations: ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]		
		<h6 class="col-6 text-right align-text-bottom small">
			<span class="mdl-switch__label" style="left:0;">Luces</span>
			<label class="mdl-switch mdl-js-switch mdl-js-ripple-effect w-25" for="switch-Luces">
				<input type="checkbox" id="switch-Luces" class="mdl-switch__input">
			</label>
		</h6>
	[/ALTERCODE-FRAG]
}