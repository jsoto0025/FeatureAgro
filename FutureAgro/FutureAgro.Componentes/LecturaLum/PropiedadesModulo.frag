Fragment LecturaLum_PropiedadesModulo {
	Action: add
	Priority: Medium
	PointBracketsLan: java
	FragmentationPoints: PropiedadesModulo
	Destinations: ArchivosBasicos_Modulo
	SourceCode: [ALTERCODE-FRAG]
		[Column("Brightness")]
		public int? Luminosidad { get; set; }
	[/ALTERCODE-FRAG]
}