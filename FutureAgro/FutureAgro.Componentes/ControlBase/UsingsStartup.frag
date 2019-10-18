Fragment ControlBase_UsingsStartup {
	Action: add
	Priority: high
	PointBracketsLan: java
	FragmentationPoints: UsingsStartup
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]				
		using FutureAgro.Web.Hubs;
		using FutureAgro.IoT.Emuladores;
		using FutureAgro.DataAccess.Repositories;
	[/ALTERCODE-FRAG]
}
