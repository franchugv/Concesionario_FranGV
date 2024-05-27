namespace Concesionario_FranGV
{
    partial class FormInsertar
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
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelAnio = new System.Windows.Forms.Label();
            this.textBoxAnio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelAviso = new System.Windows.Forms.Label();
            this.ButtonInsertar = new System.Windows.Forms.Button();
            this.labelInfoPrecio = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(112, 56);
            this.textBoxMarca.MaxLength = 15;
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(163, 20);
            this.textBoxMarca.TabIndex = 0;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(48, 59);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 1;
            this.labelMarca.Text = "Marca:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(48, 97);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 3;
            this.labelModelo.Text = "Modelo:";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(112, 94);
            this.textBoxModelo.MaxLength = 30;
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(163, 20);
            this.textBoxModelo.TabIndex = 2;
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Location = new System.Drawing.Point(48, 136);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(29, 13);
            this.labelAnio.TabIndex = 5;
            this.labelAnio.Text = "Año:";
            // 
            // textBoxAnio
            // 
            this.textBoxAnio.Location = new System.Drawing.Point(112, 133);
            this.textBoxAnio.MaxLength = 4;
            this.textBoxAnio.Name = "textBoxAnio";
            this.textBoxAnio.Size = new System.Drawing.Size(163, 20);
            this.textBoxAnio.TabIndex = 4;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(48, 178);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 7;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Location = new System.Drawing.Point(281, 166);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(121, 13);
            this.labelAviso.TabIndex = 8;
            this.labelAviso.Text = "El precio puede ser nulo";
            // 
            // ButtonInsertar
            // 
            this.ButtonInsertar.Location = new System.Drawing.Point(51, 215);
            this.ButtonInsertar.Name = "ButtonInsertar";
            this.ButtonInsertar.Size = new System.Drawing.Size(224, 23);
            this.ButtonInsertar.TabIndex = 9;
            this.ButtonInsertar.Text = "Insertar Vehículo";
            this.ButtonInsertar.UseVisualStyleBackColor = true;
            this.ButtonInsertar.Click += new System.EventHandler(this.ButtonInsertar_Click);
            // 
            // labelInfoPrecio
            // 
            this.labelInfoPrecio.AutoSize = true;
            this.labelInfoPrecio.Location = new System.Drawing.Point(281, 185);
            this.labelInfoPrecio.Name = "labelInfoPrecio";
            this.labelInfoPrecio.Size = new System.Drawing.Size(82, 13);
            this.labelInfoPrecio.TabIndex = 30;
            this.labelInfoPrecio.Text = "(5000 - 300000)\r\n";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(112, 178);
            this.textBoxPrecio.MaxLength = 6;
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(163, 20);
            this.textBoxPrecio.TabIndex = 31;
            // 
            // FormInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 321);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelInfoPrecio);
            this.Controls.Add(this.ButtonInsertar);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelAnio);
            this.Controls.Add(this.textBoxAnio);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBoxMarca);
            this.Name = "FormInsertar";
            this.Text = "FormInsertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.TextBox textBoxAnio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.Button ButtonInsertar;
        private System.Windows.Forms.Label labelInfoPrecio;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}