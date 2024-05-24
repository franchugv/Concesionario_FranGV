using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionario_FranGV
{
    public partial class Concesionario : Form
    {
        public Concesionario()
        {
            InitializeComponent();
        }

        private void Concesionario_Load(object sender, EventArgs e)
        {

        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos
            Button Opcion = (Button)sender;

            switch (Opcion.Name)
            {
                case "buttonInsertar":
                    InsertarForm();
                    break;
                case "buttonActualizar":

                    break;
                case "buttonEliminar": 
                    break;
                case "buttonConsultar":
                    break;
            }
        }

        private void InsertarForm()
        {
            FormInsertar Formulario;
            
            Formulario = new FormInsertar();

            Formulario.ShowDialog();
        }
    }
}
