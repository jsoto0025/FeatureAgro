Fragment ControlBase_PropiedadesStartup {
	Action: add
	Priority: high
	PointBracketsLan: java
	FragmentationPoints: PropiedadesStartup
	Destinations: ArchivosBasicos_Startup
	SourceCode: [ALTERCODE-FRAG]				
		public static IHubContext<FutureAgroHub> FutureAgroHub { get; set; }
	[/ALTERCODE-FRAG]
}