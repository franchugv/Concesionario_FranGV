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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelAnio = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 0;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 2;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 20);
            this.textBox4.TabIndex = 6;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Location = new System.Drawing.Point(281, 178);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(121, 13);
            this.labelAviso.TabIndex = 8;
            this.labelAviso.Text = "El precio puede ser nulo";
            // 
            // FormInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 321);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelAnio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBox1);
            this.Name = "FormInsertar";
            this.Text = "FormInsertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelAviso;
    }
}