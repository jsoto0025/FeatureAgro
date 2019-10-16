using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FutureAgro.DataAccess.Models
{
    [Table("Growth")]
    public class Crecimiento
    {
        [Key]
        [Column("GrowthId")]
        public int IdCrecimiento { get; set; }
        [Column("PlantId")]
        public int IdPlanta { get; set; }
        [Column("Growth")]
        public int PorcentajeCrecimiento { get; set; }
        [Column("Date")]
        public DateTime Fecha { get; set; }
    }
}
