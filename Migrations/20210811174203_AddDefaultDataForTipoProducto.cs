using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_facturacion.Migrations
{
    public partial class AddDefaultDataForTipoProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_TipoProducto_TipoProductoID",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoProducto",
                table: "TipoProducto");

            migrationBuilder.RenameTable(
                name: "TipoProducto",
                newName: "TipoProductos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoProductos",
                table: "TipoProductos",
                column: "Id");

            migrationBuilder.InsertData(
                table: "TipoProductos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Carnes" });

            migrationBuilder.InsertData(
                table: "TipoProductos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Frutas" });

            migrationBuilder.InsertData(
                table: "TipoProductos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Vegetales" });

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_TipoProductos_TipoProductoID",
                table: "Productos",
                column: "TipoProductoID",
                principalTable: "TipoProductos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_TipoProductos_TipoProductoID",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoProductos",
                table: "TipoProductos");

            migrationBuilder.DeleteData(
                table: "TipoProductos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoProductos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoProductos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "TipoProductos",
                newName: "TipoProducto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoProducto",
                table: "TipoProducto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_TipoProducto_TipoProductoID",
                table: "Productos",
                column: "TipoProductoID",
                principalTable: "TipoProducto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
