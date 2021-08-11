using Microsoft.EntityFrameworkCore;
using Sistema_facturacion.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_facturacion.Data
{
    public class DBFacturacionContext : DbContext
    {
        public DBFacturacionContext(DbContextOptions<DBFacturacionContext> options)
    : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; }
    }
}
