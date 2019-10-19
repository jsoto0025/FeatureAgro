Fragment ControlBase_ScriptsModulosHubIndex {
	Action: add
	Priority: high
	PointBracketsLan: html
	FragmentationPoints: ScriptsModulosHubIndex
	Destinations: ArchivosBasicos_ModulosIndex
	SourceCode: [ALTERCODE-FRAG]				
		<script src="~/lib/signalr/signalr.js"></script>
		<script src="~/js/Hubs/BaseHub.js"></script>

		<!--B-ScriptsModulosIndex-->

		<script src="~/js/Hubs/ErrorHub.js"></script>
	[/ALTERCODE-FRAG]
}