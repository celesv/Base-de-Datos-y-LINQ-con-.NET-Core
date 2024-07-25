using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoLINQ
{
    internal class ClienteContext : DbContext // Escribir en minuscula para el autocomplete
    {
        // Crea la tabla Clientes en la DB
        public DbSet<Cliente> Clientes { get; set; }

        // Conection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=Clientes;Username=postgres;Password=1234");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                     new Cliente { ClienteId = 1, Nombre = "Alice Johnson", Presupuesto = 5000, Direccion = "123 Elm St", Telefono = "555-1234", Email = "alice.johnson@example.com", Ocupacion = "Ingenieria" },
                new Cliente { ClienteId = 2, Nombre = "Bob Smith", Presupuesto = 6000, Direccion = "456 Oak St", Telefono = "555-5678", Email = "bob.smith@example.com", Ocupacion = "Medicina" },
                new Cliente { ClienteId = 3, Nombre = "Charlie Brown", Presupuesto = 8000, Direccion = "789 Pine St", Telefono = "555-8765", Email = "charlie.brown@example.com", Ocupacion = "Abogacia" },
                new Cliente { ClienteId = 4, Nombre = "Diana Prince", Presupuesto = 8000, Direccion = "321 Maple St", Telefono = "555-3456", Email = "diana.prince@example.com", Ocupacion = "Abogacia" },
                new Cliente { ClienteId = 5, Nombre = "Edward Cullen", Presupuesto = 9000, Direccion = "654 Birch St", Telefono = "555-2345", Email = "edward.cullen@example.com", Ocupacion = "Veterinaria" },
                new Cliente { ClienteId = 6, Nombre = "Fiona Gallagher", Presupuesto = 10000, Direccion = "987 Cedar St", Telefono = "555-6789", Email = "fiona.gallagher@example.com", Ocupacion = "Arte" },
                new Cliente { ClienteId = 7, Nombre = "George Bailey", Presupuesto = 9000, Direccion = "135 Spruce St", Telefono = "555-7890", Email = "george.bailey@example.com", Ocupacion = "Veterinaria" },
                new Cliente { ClienteId = 8, Nombre = "Hannah Baker", Presupuesto = 11000, Direccion = "246 Fir St", Telefono = "555-8901", Email = "hannah.baker@example.com", Ocupacion = "Escritura" },
                new Cliente { ClienteId = 9, Nombre = "Isaac Newton", Presupuesto = 13000, Direccion = "369 Redwood St", Telefono = "555-9012", Email = "isaac.newton@example.com", Ocupacion = "Arte" },
                new Cliente { ClienteId = 10, Nombre = "Jessica Jones", Presupuesto = 14000, Direccion = "579 Willow St", Telefono = "555-0123", Email = "jessica.jones@example.com", Ocupacion = "Escritura" },
                new Cliente { ClienteId = 11, Nombre = "Kurt Cobain", Presupuesto = 16000, Direccion = "680 Sequoia St", Telefono = "555-1234", Email = "kurt.cobain@example.com", Ocupacion = "Ingenieria" },
                new Cliente { ClienteId = 12, Nombre = "Laura Croft", Presupuesto = 16000, Direccion = "791 Aspen St", Telefono = "555-2345", Email = "laura.croft@example.com", Ocupacion = "Medicina" },
                new Cliente { ClienteId = 13, Nombre = "Michael Jordan", Presupuesto = 17000, Direccion = "123 Maple Ave", Telefono = "555-3456", Email = "michael.jordan@example.com", Ocupacion = "Deportes" },
                 new Cliente { ClienteId = 14, Nombre = "Nina Simone", Presupuesto = 18000, Direccion = "456 Pine Blvd", Telefono = "555-4567", Email = "nina.simone@example.com", Ocupacion = "Musica" },
                new Cliente { ClienteId = 15, Nombre = "Oscar Wilde", Presupuesto = 18000, Direccion = "789 Cedar Lane", Telefono = "555-5678", Email = "oscar.wilde@example.com", Ocupacion = "Escritura" }
            );
        }
    }
}
