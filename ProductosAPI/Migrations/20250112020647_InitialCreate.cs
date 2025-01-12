using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductosAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    CantidadEnStock = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaDeCreacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "CantidadEnStock", "Descripcion", "FechaDeCreacion", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, 100, "Laptop Inspirion Dell 3535", new DateTime(2025, 1, 11, 19, 6, 46, 773, DateTimeKind.Local).AddTicks(3603), "Lapatop", 25000.99m },
                    { 2, 200, "", new DateTime(2025, 1, 11, 19, 6, 46, 775, DateTimeKind.Local).AddTicks(8324), "Teclado", 300m },
                    { 3, 200, "Ergonomico color negro.", new DateTime(2025, 1, 11, 19, 6, 46, 775, DateTimeKind.Local).AddTicks(8348), "Mouse", 200.55m },
                    { 4, 200, "", new DateTime(2025, 1, 11, 19, 6, 46, 775, DateTimeKind.Local).AddTicks(8350), "Cargador", 500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
