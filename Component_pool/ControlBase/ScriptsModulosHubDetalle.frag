Fragment ControlBase_ScriptsModulosHubDetalle {
	Action: add
	Priority: high
	PointBracketsLan: html
	FragmentationPoints: ScriptsModulosHubDetalle
	Destinations: ArchivosBasicos_ModulosDetails
	SourceCode: [ALTERCODE-FRAG]				
		<script src="~/lib/signalr/signalr.js"></script>
		<script src="~/js/Hubs/BaseHub.js"></script>

		<!--B-ScriptsModulosDetale-->

		<script src="~/js/Hubs/ErrorHub.js"></script>
	[/ALTERCODE-FRAG]
}