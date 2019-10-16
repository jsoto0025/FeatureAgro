using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FutureAgro.DataAccess.Models
{
    [Table(name: "Plant")]
    public class Planta
    {
        [Key]
        [Column(name: "PlantId")]
        public int IdPlanta { get; set; }
        [Column(name: "PlantTypeId")]
        public int IdTipoPlanta { get; set; }
        [Column(name: "IsAlive")]
        public bool Viva { get; set; }
        [Column(name: "Growth")]
        public int Crecimiento { get; set; }
        [Column(name: "TrayId")]
        public int IdModulo { get; set; }
        [ForeignKey("IdTipoPlanta")]
        public TipoPlanta Tipo { get; set; }
        [ForeignKey("IdModulo")]
        public Modulo Modulo { get; set; }
    }
}
