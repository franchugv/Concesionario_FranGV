namespace Concesionario_FranGV.Formularios
{
    partial class FormConsultar
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
            this.labelMarca = new System.Windows.Forms.Label();
            this.listBoxListaVehiculos = new System.Windows.Forms.ListBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.comboBoxListaMarcas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(30, 26);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 12;
            this.labelMarca.Text = "Marca:";
            // 
            // listBoxListaVehiculos
            // 
            this.listBoxListaVehiculos.FormattingEnabled = true;
            this.listBoxListaVehiculos.Location = new System.Drawing.Point(33, 103);
            this.listBoxListaVehiculos.Name = "listBoxListaVehiculos";
            this.listBoxListaVehiculos.Size = new System.Drawing.Size(224, 147);
            this.listBoxListaVehiculos.TabIndex = 15;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(33, 60);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(224, 23);
            this.buttonConsultar.TabIndex = 16;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // comboBoxListaMarcas
            // 
            this.comboBoxListaMarcas.FormattingEnabled = true;
            this.comboBoxListaMarcas.Location = new System.Drawing.Point(77, 26);
            this.comboBoxListaMarcas.Name = "comboBoxListaMarcas";
            this.comboBoxListaMarcas.Size = new System.Drawing.Size(180, 21);
            this.comboBoxListaMarcas.TabIndex = 17;
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 262);
            this.Controls.Add(this.comboBoxListaMarcas);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.listBoxListaVehiculos);
            this.Controls.Add(this.labelMarca);
            this.Name = "FormConsultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.FormConsultar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.ListBox listBoxListaVehiculos;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.ComboBox comboBoxListaMarcas;
    }
}