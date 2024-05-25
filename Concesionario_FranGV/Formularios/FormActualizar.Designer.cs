namespace Concesionario_FranGV.Formularios
{
    partial class FormActualizar
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
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.labelMarca = new System.Windows.Forms.Label();
            this.comboBoxListaAnios = new System.Windows.Forms.ComboBox();
            this.labelAnio = new System.Windows.Forms.Label();
            this.comboBoxListaModelos = new System.Windows.Forms.ComboBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNuevoPrecio = new System.Windows.Forms.MaskedTextBox();
            this.labelNuevoPrecio = new System.Windows.Forms.Label();
            this.labelInfoPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxListaMarcas
            // 
            this.comboBoxListaMarcas.FormattingEnabled = true;
            this.comboBoxListaMarcas.Location = new System.Drawing.Point(123, 26);
            this.comboBoxListaMarcas.Name = "comboBoxListaMarcas";
            this.comboBoxListaMarcas.Size = new System.Drawing.Size(213, 21);
            this.comboBoxListaMarcas.TabIndex = 20;
            this.comboBoxListaMarcas.SelectedIndexChanged += new System.EventHandler(this.Controlador_SelectedIndexChanged);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Enabled = false;
            this.buttonActualizar.Location = new System.Drawing.Point(45, 227);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(267, 23);
            this.buttonActualizar.TabIndex = 19;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(77, 29);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 18;
            this.labelMarca.Text = "Marca:";
            // 
            // comboBoxListaAnios
            // 
            this.comboBoxListaAnios.Enabled = false;
            this.comboBoxListaAnios.FormattingEnabled = true;
            this.comboBoxListaAnios.Location = new System.Drawing.Point(123, 103);
            this.comboBoxListaAnios.Name = "comboBoxListaAnios";
            this.comboBoxListaAnios.Size = new System.Drawing.Size(213, 21);
            this.comboBoxListaAnios.TabIndex = 22;
            this.comboBoxListaAnios.SelectedIndexChanged += new System.EventHandler(this.Controlador_SelectedIndexChanged);
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Location = new System.Drawing.Point(77, 106);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(34, 13);
            this.labelAnio.TabIndex = 21;
            this.labelAnio.Text = "Años:";
            // 
            // comboBoxListaModelos
            // 
            this.comboBoxListaModelos.Enabled = false;
            this.comboBoxListaModelos.FormattingEnabled = true;
            this.comboBoxListaModelos.Location = new System.Drawing.Point(123, 64);
            this.comboBoxListaModelos.Name = "comboBoxListaModelos";
            this.comboBoxListaModelos.Size = new System.Drawing.Size(213, 21);
            this.comboBoxListaModelos.TabIndex = 24;
            this.comboBoxListaModelos.SelectedIndexChanged += new System.EventHandler(this.Controlador_SelectedIndexChanged);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(61, 64);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(50, 13);
            this.labelModelo.TabIndex = 23;
            this.labelModelo.Text = "Modelos:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(66, 143);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(45, 13);
            this.labelPrecio.TabIndex = 25;
            this.labelPrecio.Text = "Precios:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Location = new System.Drawing.Point(123, 143);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(92, 20);
            this.textBoxPrecio.TabIndex = 26;
            // 
            // maskedTextBoxNuevoPrecio
            // 
            this.maskedTextBoxNuevoPrecio.Location = new System.Drawing.Point(123, 184);
            this.maskedTextBoxNuevoPrecio.Mask = "000000";
            this.maskedTextBoxNuevoPrecio.Name = "maskedTextBoxNuevoPrecio";
            this.maskedTextBoxNuevoPrecio.Size = new System.Drawing.Size(92, 20);
            this.maskedTextBoxNuevoPrecio.TabIndex = 27;
            this.maskedTextBoxNuevoPrecio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // labelNuevoPrecio
            // 
            this.labelNuevoPrecio.AutoSize = true;
            this.labelNuevoPrecio.Location = new System.Drawing.Point(42, 187);
            this.labelNuevoPrecio.Name = "labelNuevoPrecio";
            this.labelNuevoPrecio.Size = new System.Drawing.Size(75, 13);
            this.labelNuevoPrecio.TabIndex = 28;
            this.labelNuevoPrecio.Text = "Nuevo Precio:";
            // 
            // labelInfoPrecio
            // 
            this.labelInfoPrecio.AutoSize = true;
            this.labelInfoPrecio.Location = new System.Drawing.Point(221, 187);
            this.labelInfoPrecio.Name = "labelInfoPrecio";
            this.labelInfoPrecio.Size = new System.Drawing.Size(82, 13);
            this.labelInfoPrecio.TabIndex = 29;
            this.labelInfoPrecio.Text = "(5000 - 300000)\r\n";
            // 
            // FormActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 279);
            this.Controls.Add(this.labelInfoPrecio);
            this.Controls.Add(this.labelNuevoPrecio);
            this.Controls.Add(this.maskedTextBoxNuevoPrecio);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.comboBoxListaModelos);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.comboBoxListaAnios);
            this.Controls.Add(this.labelAnio);
            this.Controls.Add(this.comboBoxListaMarcas);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.labelMarca);
            this.Name = "FormActualizar";
            this.Text = "FormActualizar";
            this.Load += new System.EventHandler(this.FormActualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxListaMarcas;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.ComboBox comboBoxListaAnios;
        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.ComboBox comboBoxListaModelos;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNuevoPrecio;
        private System.Windows.Forms.Label labelNuevoPrecio;
        private System.Windows.Forms.Label labelInfoPrecio;
    }
}