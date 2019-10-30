Fragment LecturaLum_PropiedadesModulo {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: PropiedadesModulo
	Destinations: ArchivosBasicos_Modulo
	SourceCode: [ALTERCODE-FRAG]
		[Column("Brightness")]
		public int? Luminosidad { get; set; }
	[/ALTERCODE-FRAG]
}