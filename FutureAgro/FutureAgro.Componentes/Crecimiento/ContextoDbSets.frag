Fragment Crecimiento_ContextoDbSets {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: ContextoDbSets
	Destinations: ArchivosBasicos_FutureAgroIdentityDbContext
	SourceCode: [ALTERCODE-FRAG]		
		public DbSet<Crecimiento> Crecimientos { get; set; }
	[/ALTERCODE-FRAG]
}