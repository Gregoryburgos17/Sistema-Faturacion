using Microsoft.EntityFrameworkCore;
using Sistema_facturacion.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_facturacion.Data.Repositories
{
    public class TipoProductoRepository : GenericRepository<TipoProducto>
    {
        public TipoProductoRepository(DBFacturacionContext context) : base(context)
        {
        }

        public override IQueryable<TipoProducto> Table()
        {
            return Context.TipoProductos.Include(t => t.Productos);
        }
    }
}
