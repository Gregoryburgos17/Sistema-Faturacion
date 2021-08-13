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
        [Range(1, double.MaxValue, ErrorMessage = "The TipoProducto field is required.")]
        public int TipoProductoID { get; set; }
        public TipoProducto TipoProducto { get; set; }

        [Required]
        [Range(double.Epsilon, double.MaxValue, ErrorMessage = "Precio must be greater than 0.")]
        public double Precio { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        [Required]
        [Range(1, double.MaxValue)] 
        public int Cantidad { get; set; }

        public List<Servicio> Servicios { get; set; } = new();
    }
}
