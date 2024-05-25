using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionario_FranGV
{
    public static class UI
    {
        public static void MostrarError(string error)
        {
            MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MostrarMensaje(string cadena)
        {
            MessageBox.Show(cadena, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult VentanaConfirmacion(string cadena)
        {
            DialogResult dialogo;

            dialogo = MessageBox.Show(cadena, "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return dialogo;
        }
    }
}
