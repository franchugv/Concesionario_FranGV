using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionario_FranGV.Formularios
{
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

    

        private void Controlador_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true;

            ComboBox Opcion = (ComboBox) sender;

            try
            {
                switch (Opcion.Name)
                {
                    case "comboBoxListaMarcas":
                        ListaMarcas();
                        break;
                    case "comboBoxListaVehiculos":
                        ListaVehiculos();
                        break;
                }
            }
            catch(Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError); 
            }
        }

        private void ListaMarcas()
        {
            comboBoxListaVehiculos.Enabled = true;

            string INSTRUCCION = $"SELECT * FROM Vehiculos WHERE Marca = '{comboBoxListaMarcas.Text}'";
            // Limpiamos previamente la lista de vehículos

            comboBoxListaVehiculos.Items.Clear();

            // Cargamos la clase
            List<Vehiculo>ListaVehiculos = new List<Vehiculo>();
            ListaVehiculos.AddRange(APIBD.ObtenerListaVehiculos(INSTRUCCION));

            // Cargar ComboBox Vehiculos
            for(int indice = 0; indice < ListaVehiculos.Count; indice++)
            {
                comboBoxListaVehiculos.Items.Add(ListaVehiculos[indice].Modelo+ ", " + ListaVehiculos[indice].Anio+" ," + ListaVehiculos[indice].Precio);
            }
            
            

        }

        private void ListaVehiculos()
        {
            buttonEliminar.Enabled = true;

            
        }







        private void FormEliminar_Load(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true;
            const string INSTRUCCION = "SELECT * FROM Vehiculos";

            try
            {
                comboBoxListaMarcas.Items.Clear();
                // Inicializar Vehiculo
                List<Vehiculo> ListaVehiculos = new List<Vehiculo>();
                ListaVehiculos.AddRange(APIBD.ObtenerListaVehiculos(INSTRUCCION));

                // Cargar ComboBox
                for (int indice = 0; indice < ListaVehiculos.Count; indice++)
                {
                    if (!comboBoxListaMarcas.Items.Contains(ListaVehiculos[indice].Marca))
                    comboBoxListaMarcas.Items.Add(ListaVehiculos[indice].Marca);
                }



            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {


            // Recursos
            string MensajeError = "";
            bool esValido = true;
            string INSTRUCCION;

            try
            {
                Vehiculo vehiculo = new Vehiculo("a", "b", 2004, 222220);


                
                INSTRUCCION = $"DELETE FROM Vehiculos WHERE  Marca = '{vehiculo.Marca}' AND Modelo = '{vehiculo.Modelo}' AND Anio = '{vehiculo.Anio}'";

                if(UI.VentanaConfirmacion($"¿Desea Eliminar el véhículo de marca {vehiculo.Marca}?") == DialogResult.Yes)
                {
                    APIBD.EjecutarInstruccion(INSTRUCCION);
                    UI.MostrarMensaje("Vehiculo eliminado correctamente");
                }

            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);
                else
                {
                    // Reseteamos el contenido para que el usuario elija otro vehiculo
                    comboBoxListaMarcas.Text = "";

                    comboBoxListaVehiculos.Text = "";
                    comboBoxListaVehiculos.Items.Clear();
                    buttonEliminar.Enabled = false;
                }
            }
        }

    }
}
