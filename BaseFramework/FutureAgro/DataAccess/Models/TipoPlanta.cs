using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FutureAgro.DataAccess.Models
{
    [Table(name: "PlantType")]
    public class TipoPlanta
    {
        [Key]
        [Column(name: "PlantTypeId")]
        public int IdTipoPlanta { get; set; }
        
        [Column(name: "Name")]
        public string Nombre { get; set; }
    }
}
