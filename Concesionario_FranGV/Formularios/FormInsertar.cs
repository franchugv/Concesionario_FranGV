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
    public partial class FormInsertar : Form
    {
        public FormInsertar()
        {
            InitializeComponent();
        }

        private void ButtonInsertar_Click(object sender, EventArgs e)
        {
            // Recursos
            bool esValido = true;
            string mensajeError = "";
            string INSTRUCCION = "";

            try
            {

                if (!string.IsNullOrEmpty(textBoxPrecio.Text))
                {
                    // Instanciar clase
                    Vehiculo coche = new Vehiculo(textBoxMarca.Text, textBoxModelo.Text, Conversiones.ConvertirInt(textBoxAnio.Text), Conversiones.ConvertirFloat(textBoxPrecio.Text));
                    // Crear instricción


                    INSTRUCCION = $"INSERT INTO Vehiculos VALUES ('{coche.Marca}', '{coche.Modelo}', '{coche.Anio}', '{coche.Precio}')";

                }
                else
                {
                    // Instanciar clase
                    Vehiculo coche = new Vehiculo(textBoxMarca.Text, textBoxModelo.Text, Conversiones.ConvertirInt(textBoxAnio.Text));
                    // Crear instricción


                    INSTRUCCION = $"INSERT INTO Vehiculos VALUES ('{coche.Marca}', '{coche.Modelo}', '{coche.Anio}', '{coche.Precio}')";


                }



                // Realizar acción
                APIBD.EjecutarInstruccion(INSTRUCCION);
            
            }
            catch(Exception error)
            {
                esValido = false;
                mensajeError = error.Message;
            }
            finally
            {
                if(!esValido) UI.MostrarError(mensajeError);
                else UI.MostrarMensaje($"El vehículo ha sido añadido correctamente");
            }

            this.Close();
        }
    }
}
