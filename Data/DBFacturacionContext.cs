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
        public virtual DbSet<TipoProducto> TipoProductos { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TipoProducto>().HasData(
                new() { Id = 1, Nombre = "Carnes" },
                new() { Id = 2, Nombre = "Frutas" },
                new() { Id = 3, Nombre = "Vegetales" }
            );

            builder.Entity<Servicio>().HasData(
                new() { Id = 1, Nombre = "Instalación" },
                new() { Id = 2, Nombre = "Reparación" },
                new() { Id = 3, Nombre = "Ensamblado" });
        }
    }
}
