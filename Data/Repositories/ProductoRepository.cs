using Microsoft.EntityFrameworkCore;
using Sistema_facturacion.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_facturacion.Data.Repositories
{
    public class ProductoRepository : GenericRepository<Producto>
    {
        public ProductoRepository(DBFacturacionContext context) : base(context)
        {
        }

        public override IQueryable<Producto> Table()
        {
            return Context.Productos.Include(p => p.TipoProducto);
        }
    }
}
