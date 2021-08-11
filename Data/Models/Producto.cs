using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_facturacion.Data.Models
{
    public class Producto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        [ForeignKey("TipoProducto")]
        public int TipoProductoID { get; set; }
        public TipoProducto TipoProducto { get; set; }

        [Required]
        public double Precio { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        [Required]
        public int Cantidad { get; set; }
    }
}
