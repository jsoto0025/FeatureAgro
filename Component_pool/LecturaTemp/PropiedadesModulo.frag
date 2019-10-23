Fragment LecturaTemp_PropiedadesModulo {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: PropiedadesModulo
	Destinations: ArchivosBasicos_Modulo
	SourceCode: [ALTERCODE-FRAG]
		[Column("Temperature")]
		public double? Temperatura { get; set; }
	[/ALTERCODE-FRAG]
}
