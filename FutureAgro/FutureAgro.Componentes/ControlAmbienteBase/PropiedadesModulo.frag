/*B-PropiedadesModulo*/
DataAccess/Models/Modulo.cas

[ForeignKey("IdModulo")]
public ICollection<Medida> Medidas { get; set; }