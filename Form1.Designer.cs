namespace EFDemoLINQ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbResult = new System.Windows.Forms.Label();
            presupuestoMin = new System.Windows.Forms.Label();
            textMinPresupuesto = new System.Windows.Forms.TextBox();
            buscarMinPresupuesto = new System.Windows.Forms.Button();
            buscarOcupacion = new System.Windows.Forms.Button();
            textOcupacion = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            mostrarClientes = new System.Windows.Forms.Button();
            Columna_1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            Columna_2 = new System.Windows.Forms.TextBox();
            VarB = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new System.Drawing.Point(45, 356);
            lbResult.Name = "lbResult";
            lbResult.Size = new System.Drawing.Size(62, 20);
            lbResult.TabIndex = 0;
            lbResult.Text = "lbResult";
            lbResult.Click += label1_Click;
            // 
            // presupuestoMin
            // 
            presupuestoMin.AutoSize = true;
            presupuestoMin.Location = new System.Drawing.Point(25, 79);
            presupuestoMin.Name = "presupuestoMin";
            presupuestoMin.Size = new System.Drawing.Size(270, 20);
            presupuestoMin.TabIndex = 1;
            presupuestoMin.Text = "Filtrar Clientes por presupuesto minimo";
            presupuestoMin.Click += label1_Click_1;
            // 
            // textMinPresupuesto
            // 
            textMinPresupuesto.Location = new System.Drawing.Point(310, 76);
            textMinPresupuesto.Name = "textMinPresupuesto";
            textMinPresupuesto.Size = new System.Drawing.Size(196, 27);
            textMinPresupuesto.TabIndex = 2;
            textMinPresupuesto.TextChanged += textMinPresupuesto_TextChanged;
            // 
            // buscarMinPresupuesto
            // 
            buscarMinPresupuesto.Location = new System.Drawing.Point(525, 76);
            buscarMinPresupuesto.Name = "buscarMinPresupuesto";
            buscarMinPresupuesto.Size = new System.Drawing.Size(94, 27);
            buscarMinPresupuesto.TabIndex = 3;
            buscarMinPresupuesto.Text = "Buscar";
            buscarMinPresupuesto.UseVisualStyleBackColor = true;
            buscarMinPresupuesto.Click += button1_Click;
            // 
            // buscarOcupacion
            // 
            buscarOcupacion.Location = new System.Drawing.Point(525, 169);
            buscarOcupacion.Name = "buscarOcupacion";
            buscarOcupacion.Size = new System.Drawing.Size(94, 27);
            buscarOcupacion.TabIndex = 6;
            buscarOcupacion.Text = "Buscar";
            buscarOcupacion.UseVisualStyleBackColor = true;
            buscarOcupacion.Click += buscarOcupacion_Click;
            // 
            // textOcupacion
            // 
            textOcupacion.Location = new System.Drawing.Point(26, 169);
            textOcupacion.Name = "textOcupacion";
            textOcupacion.Size = new System.Drawing.Size(480, 27);
            textOcupacion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 134);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(668, 20);
            label1.TabIndex = 4;
            label1.Text = "Filtrar Clientes por grupos de ocupaciones (Puede ingresar varias profesiones en el cuadro de texto)";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(165, 20);
            label2.TabIndex = 7;
            label2.Text = "Listar todos los Clientes";
            label2.Click += label2_Click;
            // 
            // mostrarClientes
            // 
            mostrarClientes.Location = new System.Drawing.Point(201, 26);
            mostrarClientes.Name = "mostrarClientes";
            mostrarClientes.Size = new System.Drawing.Size(94, 27);
            mostrarClientes.TabIndex = 8;
            mostrarClientes.Text = "Ver";
            mostrarClientes.UseVisualStyleBackColor = true;
            mostrarClientes.Click += mostrarClientes_Click_1;
            // 
            // Columna_1
            // 
            Columna_1.Location = new System.Drawing.Point(25, 285);
            Columna_1.Name = "Columna_1";
            Columna_1.Size = new System.Drawing.Size(164, 27);
            Columna_1.TabIndex = 10;
            Columna_1.TextChanged += Columna_1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(25, 228);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(286, 20);
            label3.TabIndex = 9;
            label3.Text = "Filtrar Clientes por Nombre o Presupuesto";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(25, 262);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 20);
            label4.TabIndex = 12;
            label4.Text = "Filtrar por Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(211, 262);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(158, 20);
            label7.TabIndex = 16;
            label7.Text = "Filtrar por Presupuesto";
            // 
            // Columna_2
            // 
            Columna_2.Location = new System.Drawing.Point(211, 285);
            Columna_2.Name = "Columna_2";
            Columna_2.Size = new System.Drawing.Size(164, 27);
            Columna_2.TabIndex = 15;
            Columna_2.TextChanged += Columna_2_TextChanged;
            // 
            // VarB
            // 
            VarB.Location = new System.Drawing.Point(399, 285);
            VarB.Name = "VarB";
            VarB.Size = new System.Drawing.Size(94, 27);
            VarB.TabIndex = 17;
            VarB.Text = "Buscar";
            VarB.UseVisualStyleBackColor = true;
            VarB.Click += VarB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 820);
            Controls.Add(VarB);
            Controls.Add(label7);
            Controls.Add(Columna_2);
            Controls.Add(label4);
            Controls.Add(Columna_1);
            Controls.Add(label3);
            Controls.Add(mostrarClientes);
            Controls.Add(label2);
            Controls.Add(buscarOcupacion);
            Controls.Add(textOcupacion);
            Controls.Add(label1);
            Controls.Add(buscarMinPresupuesto);
            Controls.Add(textMinPresupuesto);
            Controls.Add(presupuestoMin);
            Controls.Add(lbResult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label presupuestoMin;
        private System.Windows.Forms.TextBox textMinPresupuesto;
        private System.Windows.Forms.Button buscarMinPresupuesto;
        private System.Windows.Forms.Button buscarOcupacion;
        private System.Windows.Forms.TextBox textOcupacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mostrarClientes;
        private System.Windows.Forms.TextBox Columna_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Columna_2;
        private System.Windows.Forms.Button VarB;
    }
}

