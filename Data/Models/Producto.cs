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
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TipoProducto Tipo { get; set; }
        public double Precio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Cantidad { get; set; }
    }
}
