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
    }
}
