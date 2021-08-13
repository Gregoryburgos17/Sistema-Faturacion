using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_facturacion.Data.Models
{
    public class Servicio
    {
        [Required]
        public int Id { get; set; }

        [Required] 
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
