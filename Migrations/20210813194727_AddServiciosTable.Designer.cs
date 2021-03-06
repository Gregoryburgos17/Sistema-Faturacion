// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_facturacion.Data;

namespace Sistema_facturacion.Migrations
{
    [DbContext(typeof(DBFacturacionContext))]
    [Migration("20210813194727_AddServiciosTable")]
    partial class AddServiciosTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("ProductoServicio", b =>
                {
                    b.Property<int>("ProductosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServiciosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductosId", "ServiciosId");

                    b.HasIndex("ServiciosId");

                    b.ToTable("ProductoServicio");
                });

            modelBuilder.Entity("Sistema_facturacion.Data.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<int>("TipoProductoID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TipoProductoID");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Sistema_facturacion.Data.Models.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Servicios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Instalación"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Reparación"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Ensamblado"
                        });
                });

            modelBuilder.Entity("Sistema_facturacion.Data.Models.TipoProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TipoProductos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Carnes"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Frutas"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Vegetales"
                        });
                });

            modelBuilder.Entity("ProductoServicio", b =>
                {
                    b.HasOne("Sistema_facturacion.Data.Models.Producto", null)
                        .WithMany()
                        .HasForeignKey("ProductosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sistema_facturacion.Data.Models.Servicio", null)
                        .WithMany()
                        .HasForeignKey("ServiciosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema_facturacion.Data.Models.Producto", b =>
                {
                    b.HasOne("Sistema_facturacion.Data.Models.TipoProducto", "TipoProducto")
                        .WithMany("Productos")
                        .HasForeignKey("TipoProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoProducto");
                });

            modelBuilder.Entity("Sistema_facturacion.Data.Models.TipoProducto", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
