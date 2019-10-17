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
        [Column(name:"TrayId")]
        public int IdModulo { get; set; }
        [Column(name: "Capacity")]
        public int Capacidad { get; set; }
        [ForeignKey("IdModulo")]
        public ICollection<Planta> Plantas { get; set; }
        [ForeignKey("IdModulo")]
        public ICollection<Medida> Medidas { get; set; }
        [NotMapped]
        public double? Temperatura { get; set; }
        [NotMapped]
        public int? Luminosidad { get; set; }
        [NotMapped]
        public int? Humedad { get; set; }
    }
}
