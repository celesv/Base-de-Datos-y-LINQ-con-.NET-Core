using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoLINQ
{
    public class Cliente
    {
        // Coding by Convention
        // EF automatically makes this a PK in the Cliente table
        // Auto incrementing
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public double Presupuesto { get; set; } = 0;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Ocupacion { get; set; }


        // Si deseas una representación más personalizada de tu objeto Cliente en el método ToString, puedes incluir cualquier detalle que consideres relevante o útil.
        public override string ToString()
        {
            return $"{Nombre} tiene una ocupación de {Ocupacion} y su presupuesto es de {Presupuesto}\n";
        }


    }
}