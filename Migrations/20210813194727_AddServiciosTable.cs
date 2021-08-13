using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_facturacion.Migrations
{
    public partial class AddServiciosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductoServicio",
                columns: table => new
                {
                    ProductosId = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiciosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoServicio", x => new { x.ProductosId, x.ServiciosId });
                    table.ForeignKey(
                        name: "FK_ProductoServicio_Productos_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoServicio_Servicios_ServiciosId",
                        column: x => x.ServiciosId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Servicios",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Instalación" });

            migrationBuilder.InsertData(
                table: "Servicios",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Reparación" });

            migrationBuilder.InsertData(
                table: "Servicios",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Ensamblado" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoServicio_ServiciosId",
                table: "ProductoServicio",
                column: "ServiciosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoServicio");

            migrationBuilder.DropTable(
                name: "Servicios");
        }
    }
}
