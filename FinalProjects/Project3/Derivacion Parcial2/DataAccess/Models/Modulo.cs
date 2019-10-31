using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace FutureAgro.DataAccess.Models
{
    [Table(name: "Tray")]
    public class Modulo
    {
        [Key]
        [Column("TrayId")]
        public int IdModulo { get; set; }
        [Column("Capacity")]
        public int Capacidad { get; set; }
        [ForeignKey("IdModulo")]
        public ICollection<Planta> Plantas { get; set; }

        /*B-PropiedadesModulo*/

/*Code injected by: LecturaTemp_PropiedadesModulo*/
[Column("Temperature")]
		public double? Temperatura { get; set; }
/*Code injected by: LecturaTemp_PropiedadesModulo*/


/*Code injected by: ControlAmbienteBase_PropiedadesModulo*/
[ForeignKey("IdModulo")]
		public ICollection<Medida> Medidas { get; set; }
/*Code injected by: ControlAmbienteBase_PropiedadesModulo*/

    }
}
