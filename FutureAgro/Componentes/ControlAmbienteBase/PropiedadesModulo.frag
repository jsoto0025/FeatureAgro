Fragment ControlAmbienteBase_PropiedadesModulo {
	Action: add
	Priority: high
	PointBracketsLan: java
	FragmentationPoints: PropiedadesModulo
	Destinations: ArchivosBasicos_Modulo
	SourceCode: [ALTERCODE-FRAG]		
		[ForeignKey("IdModulo")]
		public ICollection<Medida> Medidas { get; set; }
	[/ALTERCODE-FRAG]
}