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

        private void CargarMarcas()
        {
            comboBoxListaMarcas.Text = "";
            comboBoxListaMarcas.Items.Clear();

            // Recursos
            const string INSTRUCCION = "SELECT * FROM Vehiculos";

            // Inicializar Vehiculo
            List<Vehiculo> ListaVlehiculos = new List<Vehiculo>();
            ListaVlehiculos.AddRange(APIBD.ObtenerListaVehiculos(INSTRUCCION));

            // Cargar ComboBox
            for (int indice = 0; indice < ListaVlehiculos.Count; indice++)
            {
                if (!comboBoxListaMarcas.Items.Contains(ListaVlehiculos[indice].Marca))
                    comboBoxListaMarcas.Items.Add(ListaVlehiculos[indice].Marca);
            }
        }

            
        private void FormEliminar_Load(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true;

            try
            {
                CargarMarcas();
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

        // Funcionalidades SELECTED INDEX CHANGED
        private void ListaMarcas()
        {

            comboBoxListaVehiculos.Enabled = true;

            string INSTRUCCION = $"SELECT * FROM Vehiculos WHERE Marca = '{comboBoxListaMarcas.Text}'";
            // Limpiamos previamente la lista de vehículos

            comboBoxListaVehiculos.Items.Clear();

            // Cargamos la clase
            List<Vehiculo> ListaVehiculos = new List<Vehiculo>();
            ListaVehiculos.AddRange(APIBD.ObtenerListaVehiculos(INSTRUCCION));

            // Cargar ComboBox Vehiculos
            for (int indice = 0; indice < ListaVehiculos.Count; indice++)
            {
                comboBoxListaVehiculos.Items.Add(ListaVehiculos[indice].Modelo + "," + ListaVehiculos[indice].Anio + "," + ListaVehiculos[indice].Precio);
            }


        }

        // Habilita el boton de eliminar
        private void ListaVehiculos()
        {
            buttonEliminar.Enabled = true;
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {


            // Recursos
            string MensajeError = "";
            bool esValido = true;
            string INSTRUCCION;

            try
            {
                string aux;

                // Modelo, ejemplo A8500
                string modelo = comboBoxListaVehiculos.Text.Split(',')[0];

                // ANIO, ejemplo 2001
                aux = comboBoxListaVehiculos.Text.Split(',')[1];
                int anio = Convert.ToInt32(aux);
                
                // PRECIO, ejemplo 5000
                aux = comboBoxListaVehiculos.Text.Split(',')[2];
                float precio = Convert.ToSingle(aux);


                Vehiculo vehiculo = new Vehiculo(comboBoxListaMarcas.Text, modelo, anio, precio);


                
                INSTRUCCION = $"DELETE FROM Vehiculos WHERE  Marca = '{vehiculo.Marca}' AND Modelo = '{vehiculo.Modelo}' AND Anio = '{vehiculo.Anio}'";

                // Validar eliminación
                if(UI.VentanaConfirmacion($"¿Desea Eliminar el vehículo de marca {vehiculo.Marca}?") == DialogResult.Yes)
                {
                    APIBD.EjecutarInstruccion(INSTRUCCION);
                    UI.MostrarMensaje("Vehículo eliminado correctamente");
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

                // Resetear marcas
                CargarMarcas();
            }
        }




    }
}
