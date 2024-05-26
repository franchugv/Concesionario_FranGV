namespace Concesionario_FranGV.Formularios
{
    partial class FormEliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxListaMarcas = new System.Windows.Forms.ComboBox();
            this.comboBoxListaVehiculos = new System.Windows.Forms.ComboBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelPortada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxListaMarcas
            // 
            this.comboBoxListaMarcas.FormattingEnabled = true;
            this.comboBoxListaMarcas.Location = new System.Drawing.Point(148, 71);
            this.comboBoxListaMarcas.Name = "comboBoxListaMarcas";
            this.comboBoxListaMarcas.Size = new System.Drawing.Size(181, 21);
            this.comboBoxListaMarcas.TabIndex = 0;
            this.comboBoxListaMarcas.SelectedIndexChanged += new System.EventHandler(this.Controlador_SelectedIndexChanged);
            // 
            // comboBoxListaVehiculos
            // 
            this.comboBoxListaVehiculos.Enabled = false;
            this.comboBoxListaVehiculos.FormattingEnabled = true;
            this.comboBoxListaVehiculos.Location = new System.Drawing.Point(148, 107);
            this.comboBoxListaVehiculos.Name = "comboBoxListaVehiculos";
            this.comboBoxListaVehiculos.Size = new System.Drawing.Size(181, 21);
            this.comboBoxListaVehiculos.TabIndex = 1;
            this.comboBoxListaVehiculos.SelectedIndexChanged += new System.EventHandler(this.Controlador_SelectedIndexChanged);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(44, 71);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(98, 13);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Seleccionar marca:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(27, 110);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(115, 13);
            this.labelModelo.TabIndex = 3;
            this.labelModelo.Text = "Seleccionar Vehiculos:";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Location = new System.Drawing.Point(31, 142);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(298, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar Vehiculo";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelPortada
            // 
            this.labelPortada.AutoSize = true;
            this.labelPortada.Location = new System.Drawing.Point(120, 9);
            this.labelPortada.Name = "labelPortada";
            this.labelPortada.Size = new System.Drawing.Size(111, 39);
            this.labelPortada.TabIndex = 5;
            this.labelPortada.Text = "Eliminación Vehículos\r\n************************\r\n\r\n";
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 214);
            this.Controls.Add(this.labelPortada);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.comboBoxListaVehiculos);
            this.Controls.Add(this.comboBoxListaMarcas);
            this.Name = "FormEliminar";
            this.Text = "FormEliminar";
            this.Load += new System.EventHandler(this.FormEliminar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxListaMarcas;
        private System.Windows.Forms.ComboBox comboBoxListaVehiculos;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelPortada;
    }
}