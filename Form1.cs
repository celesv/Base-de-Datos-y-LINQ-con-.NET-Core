using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EFDemoLINQ
{
    public partial class Form1 : Form
    {
        ClienteContext clienteData;
        List<Cliente> clienteList;

        public Form1()
        {

            InitializeComponent();

            // Vista predeterminada

            lbResult.Text = string.Empty;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clienteData = new ClienteContext();

            float min = float.Parse(textMinPresupuesto.Text);
            clienteList = clienteData.Clientes.Where(c => c.Presupuesto >= min).Select(c => c).ToList();

            lbResult.Text = string.Empty; // Limpiar el contenido de lbResult

            // Ordenar la lista por Presupuesto en orden ascendente
            var orderedClientes = clienteList.OrderBy(c => c.Presupuesto);


            foreach (Cliente cliente in orderedClientes)
            {
                // Mostrar el encabezado del presupuesto 
                lbResult.Text += $"Presupuesto Base: {cliente.Presupuesto}\n";
                lbResult.Text += cliente.ToString();
            }
        }

        private void textMinPresupuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void buscarOcupacion_Click(object sender, EventArgs e)
        {
            clienteData = new ClienteContext();

            string input = textOcupacion.Text.Trim().ToLower();

            // Obtener las ocupaciones ingresadas y dividirlas en una lista de subcadenas
            // El método Split se utiliza para dividir una cadena en un array de subcadenas basándose en los delimitadores especificados.
            // En este caso, los delimitadores son la coma (,) y el espacio ( ) y son caracteres contenidos en un array.
            // StringSplitOptions.RemoveEmptyEntries indica que debemos eliminar las cadenas vacías. Esto elimina las cadenas que están vacías después de la división.
            // [ "Ingeniero", " Médico", " Abogado", "", " Arquitecto " ] "" (vacío, porque hay dos comas consecutivas)
            // Después de aplicar StringSplitOptions.RemoveEmptyEntries
            // [ "Ingeniero", "Medico", "Abogado", "Arquitecto" ]
            var ocupaciones = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var clientesFiltrados = clienteData.Clientes
                .Where(c => ocupaciones.Contains(c.Ocupacion.Trim().ToLower()))
                .GroupBy(c => c.Ocupacion)
                .ToList();

            lbResult.Text = string.Empty;

            foreach (var grupo in clientesFiltrados)
            {
                // Mostrar el encabezado del grupo (la ocupación)
                // La propiedad Key es utilizada en el contexto de agrupaciones (GroupBy), no para objetos individuales. 
                lbResult.Text += $"Ocupación: {grupo.Key}\n";

                foreach (Cliente cliente in grupo)
                {
                    lbResult.Text += cliente.ToString();
                }

                lbResult.Text += "\n";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void mostrarClientes_Click_1(object sender, EventArgs e)
        {
            clienteData = new ClienteContext();


            clienteList = clienteData.Clientes.Select(c => c).ToList();

            lbResult.Text = string.Empty;

            foreach (Cliente cliente in clienteList)
            {

                lbResult.Text += cliente.ToString(); // Primer ejercicio/Ejemplo
            }
        }

        private void FiltrarClientesPorNombreOYPresupuesto(string nombre, float? presupuesto = null)
        {
            using (var clienteData = new ClienteContext())
            {
                // Inicializar la consulta
                var consulta = clienteData.Clientes.AsQueryable();

                // Filtrar por nombre si se proporciona
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    // Aplicar Trim y ToLower para la comparación
                    consulta = consulta.Where(c => c.Nombre.Trim().ToLower().Contains(nombre.Trim().ToLower()));
                }

                // Filtrar por presupuesto exacto si se proporciona
                if (presupuesto.HasValue)
                {
                    consulta = consulta.Where(c => c.Presupuesto == presupuesto.Value);
                }

                // Ejecutar la consulta y obtener los resultados
                var resultados = consulta.ToList();

                // Formatear los resultados para mostrarlos en el Label
                var resultadoTexto = resultados.Any()
                    ? string.Join(Environment.NewLine, resultados.Select(c => $"Nombre: {c.Nombre}, Presupuesto: {c.Presupuesto}"))
                    : "No se encontraron resultados.";

                // Asignar el texto al Label
                lbResult.Text = resultadoTexto;
            }
        }

        private void VarB_Click(object sender, EventArgs e)
        {
            string nombre = Columna_1.Text.Trim();

            // Intentar parsear el valor del presupuesto. Si no es válido, asignar null.
            float? presupuesto = null;
            if (float.TryParse(Columna_2.Text.Trim(), out float parsedPresupuesto))
            {
                presupuesto = parsedPresupuesto;
            }

            FiltrarClientesPorNombreOYPresupuesto(nombre, presupuesto);
        }


        private void Columna_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Columna_2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
