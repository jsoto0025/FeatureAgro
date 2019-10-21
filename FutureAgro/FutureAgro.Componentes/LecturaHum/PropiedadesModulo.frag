Fragment LecturaHum_PropiedadesModulo {
	Action: add
	Priority: medium
	PointBracketsLan: java
	FragmentationPoints: PropiedadesModulo
	Destinations: ArchivosBasicos_Modulo
	SourceCode: [ALTERCODE-FRAG]
		[Column("Humidity")]
		public int? Humedad { get; set; }
	[/ALTERCODE-FRAG]
}