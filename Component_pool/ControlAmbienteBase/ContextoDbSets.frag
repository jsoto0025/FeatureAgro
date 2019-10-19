Fragment ControlAmbienteBase_ContextoDbSets {
	Action: add
	Priority: high
	PointBracketsLan: java
	FragmentationPoints: ContextoDbSets
	Destinations: ArchivosBasicos_FutureAgroIdentityDbContext
	SourceCode: [ALTERCODE-FRAG]		
		public DbSet<Medida> Medidas { get; set; }
	[/ALTERCODE-FRAG]
}