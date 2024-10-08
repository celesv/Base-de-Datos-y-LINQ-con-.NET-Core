﻿// <auto-generated />
using EFDemoLINQ;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFDemoLINQ.Migrations
{
    [DbContext(typeof(ClienteContext))]
    [Migration("20240722210608_init4")]
    partial class init4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EFDemoLINQ.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("Direccion")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<string>("Ocupacion")
                        .HasColumnType("text");

                    b.Property<double>("Presupuesto")
                        .HasColumnType("double precision");

                    b.Property<string>("Telefono")
                        .HasColumnType("text");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Direccion = "123 Elm St",
                            Email = "alice.johnson@example.com",
                            Nombre = "Alice Johnson",
                            Ocupacion = "Ingenieria",
                            Presupuesto = 5000.0,
                            Telefono = "555-1234"
                        },
                        new
                        {
                            ClienteId = 2,
                            Direccion = "456 Oak St",
                            Email = "bob.smith@example.com",
                            Nombre = "Bob Smith",
                            Ocupacion = "Medicina",
                            Presupuesto = 6000.0,
                            Telefono = "555-5678"
                        },
                        new
                        {
                            ClienteId = 3,
                            Direccion = "789 Pine St",
                            Email = "charlie.brown@example.com",
                            Nombre = "Charlie Brown",
                            Ocupacion = "Abogacia",
                            Presupuesto = 7000.0,
                            Telefono = "555-8765"
                        },
                        new
                        {
                            ClienteId = 4,
                            Direccion = "321 Maple St",
                            Email = "diana.prince@example.com",
                            Nombre = "Diana Prince",
                            Ocupacion = "Abogacia",
                            Presupuesto = 8000.0,
                            Telefono = "555-3456"
                        },
                        new
                        {
                            ClienteId = 5,
                            Direccion = "654 Birch St",
                            Email = "edward.cullen@example.com",
                            Nombre = "Edward Cullen",
                            Ocupacion = "Veterinaria",
                            Presupuesto = 9000.0,
                            Telefono = "555-2345"
                        },
                        new
                        {
                            ClienteId = 6,
                            Direccion = "987 Cedar St",
                            Email = "fiona.gallagher@example.com",
                            Nombre = "Fiona Gallagher",
                            Ocupacion = "Arte",
                            Presupuesto = 10000.0,
                            Telefono = "555-6789"
                        },
                        new
                        {
                            ClienteId = 7,
                            Direccion = "135 Spruce St",
                            Email = "george.bailey@example.com",
                            Nombre = "George Bailey",
                            Ocupacion = "Veterinaria",
                            Presupuesto = 11000.0,
                            Telefono = "555-7890"
                        },
                        new
                        {
                            ClienteId = 8,
                            Direccion = "246 Fir St",
                            Email = "hannah.baker@example.com",
                            Nombre = "Hannah Baker",
                            Ocupacion = "Escritura",
                            Presupuesto = 12000.0,
                            Telefono = "555-8901"
                        },
                        new
                        {
                            ClienteId = 9,
                            Direccion = "369 Redwood St",
                            Email = "isaac.newton@example.com",
                            Nombre = "Isaac Newton",
                            Ocupacion = "Arte",
                            Presupuesto = 13000.0,
                            Telefono = "555-9012"
                        },
                        new
                        {
                            ClienteId = 10,
                            Direccion = "579 Willow St",
                            Email = "jessica.jones@example.com",
                            Nombre = "Jessica Jones",
                            Ocupacion = "Escritura",
                            Presupuesto = 14000.0,
                            Telefono = "555-0123"
                        },
                        new
                        {
                            ClienteId = 11,
                            Direccion = "680 Sequoia St",
                            Email = "kurt.cobain@example.com",
                            Nombre = "Kurt Cobain",
                            Ocupacion = "Ingenieria",
                            Presupuesto = 15000.0,
                            Telefono = "555-1234"
                        },
                        new
                        {
                            ClienteId = 12,
                            Direccion = "791 Aspen St",
                            Email = "laura.croft@example.com",
                            Nombre = "Laura Croft",
                            Ocupacion = "Medicina",
                            Presupuesto = 16000.0,
                            Telefono = "555-2345"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
