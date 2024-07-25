using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFDemoLINQ.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Presupuesto = table.Column<double>(type: "double precision", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Ocupacion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Direccion", "Email", "Nombre", "Ocupacion", "Presupuesto", "Telefono" },
                values: new object[,]
                {
                    { 1, "123 Elm St", "alice.johnson@example.com", "Alice Johnson", "Ingeniera", 5000.0, "555-1234" },
                    { 2, "456 Oak St", "bob.smith@example.com", "Bob Smith", "Médico", 6000.0, "555-5678" },
                    { 3, "789 Pine St", "charlie.brown@example.com", "Charlie Brown", "Maestro", 7000.0, "555-8765" },
                    { 4, "321 Maple St", "diana.prince@example.com", "Diana Prince", "Abogada", 8000.0, "555-3456" },
                    { 5, "654 Birch St", "edward.cullen@example.com", "Edward Cullen", "Veterinario", 9000.0, "555-2345" },
                    { 6, "987 Cedar St", "fiona.gallagher@example.com", "Fiona Gallagher", "Artista", 10000.0, "555-6789" },
                    { 7, "135 Spruce St", "george.bailey@example.com", "George Bailey", "Banquero", 11000.0, "555-7890" },
                    { 8, "246 Fir St", "hannah.baker@example.com", "Hannah Baker", "Escritora", 12000.0, "555-8901" },
                    { 9, "369 Redwood St", "isaac.newton@example.com", "Isaac Newton", "Científico", 13000.0, "555-9012" },
                    { 10, "579 Willow St", "jessica.jones@example.com", "Jessica Jones", "Detective", 14000.0, "555-0123" },
                    { 11, "680 Sequoia St", "kurt.cobain@example.com", "Kurt Cobain", "Músico", 15000.0, "555-1234" },
                    { 12, "791 Aspen St", "laura.croft@example.com", "Laura Croft", "Exploradora", 16000.0, "555-2345" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
