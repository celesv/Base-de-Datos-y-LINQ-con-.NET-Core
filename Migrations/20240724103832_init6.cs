using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDemoLINQ.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Presupuesto",
                value: 8000.0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Presupuesto",
                value: 9000.0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Presupuesto",
                value: 11000.0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Presupuesto",
                value: 16000.0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15,
                column: "Presupuesto",
                value: 18000.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3,
                column: "Presupuesto",
                value: 7000.0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7,
                column: "Presupuesto",
                value: 11000.0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8,
                column: "Presupuesto",
                value: 12000.0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11,
                column: "Presupuesto",
                value: 15000.0);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15,
                column: "Presupuesto",
                value: 19000.0);
        }
    }
}
