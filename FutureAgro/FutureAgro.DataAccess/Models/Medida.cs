using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FutureAgro.DataAccess.Models
{
    [Table("Measure")]
    public class Medida
    {
        [Key]
        [Column("MeasureId")]
        public int IdMedida { get; set; }
        [Column("TrayId")]
        public int IdModulo { get; set; }
        [Column("MeasureTypeId")]
        public TipoMedida TipoMedida { get; set; }
        [Column("Value")]
        public double Valor { get; set; }
        [Column("Date")]
        public DateTime Fecha { get; set; }
    }
}
