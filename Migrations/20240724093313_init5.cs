using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFDemoLINQ.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Direccion", "Email", "Nombre", "Ocupacion", "Presupuesto", "Telefono" },
                values: new object[,]
                {
                    { 13, "123 Maple Ave", "michael.jordan@example.com", "Michael Jordan", "Deportes", 17000.0, "555-3456" },
                    { 14, "456 Pine Blvd", "nina.simone@example.com", "Nina Simone", "Musica", 18000.0, "555-4567" },
                    { 15, "789 Cedar Lane", "oscar.wilde@example.com", "Oscar Wilde", "Escritura", 19000.0, "555-5678" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15);
        }
    }
}
