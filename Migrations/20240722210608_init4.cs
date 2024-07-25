using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDemoLINQ.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Ocupacion",
                value: "Ingenieria");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Ocupacion",
                value: "Medicina");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Ocupacion",
                value: "Abogacia");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Ocupacion",
                value: "Abogacia");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "Ocupacion",
                value: "Veterinaria");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "Ocupacion",
                value: "Arte");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Ocupacion",
                value: "Veterinaria");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Ocupacion",
                value: "Escritura");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9,
                column: "Ocupacion",
                value: "Arte");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10,
                column: "Ocupacion",
                value: "Escritura");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Ocupacion",
                value: "Ingenieria");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12,
                column: "Ocupacion",
                value: "Medicina");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Ocupacion",
                value: "Ingeniera");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Ocupacion",
                value: "Médico");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Ocupacion",
                value: "Maestro");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4,
                column: "Ocupacion",
                value: "Abogada");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5,
                column: "Ocupacion",
                value: "Veterinario");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6,
                column: "Ocupacion",
                value: "Artista");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Ocupacion",
                value: "Banquero");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Ocupacion",
                value: "Escritora");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9,
                column: "Ocupacion",
                value: "Científico");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10,
                column: "Ocupacion",
                value: "Detective");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Ocupacion",
                value: "Músico");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12,
                column: "Ocupacion",
                value: "Exploradora");
        }
    }
}
