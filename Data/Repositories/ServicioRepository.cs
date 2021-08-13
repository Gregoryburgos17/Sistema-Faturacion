using Microsoft.EntityFrameworkCore;
using Sistema_facturacion.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_facturacion.Data.Repositories
{
    public class ServicioRepository : GenericRepository<Servicio>
    {
        public ServicioRepository(DBFacturacionContext context) : base(context)
        {
        }

        public override IQueryable<Servicio> Table()
        {
            return Context.Servicios.Include(s => s.Productos);
        }
    }
}
