using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_CRUD_ejercicioUno.Migrations
{
    /// <inheritdoc />
    public partial class AgregarProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "producto",
                columns: new[] { "IdProducto", "Cantidad", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, 20, "High Fantasy", "A Court of Thorns and Roses" },
                    { 2, 20, "High Fantasy", "A Court of Mist and Fury" },
                    { 3, 20, "High Fantasy", "A Court of Wind and Ruins" },
                    { 4, 20, "High Fantasy", "A Court of Frost and Starlight" },
                    { 5, 20, "High Fantasy", "A Court of Silver Flames" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "producto",
                keyColumn: "IdProducto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "producto",
                keyColumn: "IdProducto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "producto",
                keyColumn: "IdProducto",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "producto",
                keyColumn: "IdProducto",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "producto",
                keyColumn: "IdProducto",
                keyValue: 5);
        }
    }
}
