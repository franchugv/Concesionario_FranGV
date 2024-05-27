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
    public partial class FormActualizar : Form
    {
        public FormActualizar()
        {
            InitializeComponent();
        }

        private void Controlador_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true; // Inicializado a Verdadero
            
            ComboBox opcion = (ComboBox) sender;

            // Inicializar CB
            comboBoxListaModelos.Enabled = false;
            comboBoxListaAnios.Enabled = false;
            

            try
            {
                switch (opcion.Name)
                {
                    case "comboBoxListaMarcas":
                        CBMarcas();
                        break;
                    case "comboBoxListaModelos":
                        CBModelos();
                        break;
                    case "comboBoxListaAnios":
                        CBAnios();
                        break;                    
                }

            }
            catch(Exception Error)
            {
                esValido = false;
                MensajeError = Error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);
            }
        }



        private void CBMarcas()
        {
            // Recursos
            string INSTRUCCION = $"SELECT * FROM Vehiculos WHERE Marca = '{comboBoxListaMarcas.Text}'";

            comboBoxListaModelos.Enabled = true;

            // Cargar Lista
            List<Vehiculo> ListaVehiculos = new List<Vehiculo>();
            ListaVehiculos.AddRange(APIBD.ObtenerListaVehiculos(INSTRUCCION));

            comboBoxListaModelos.Items.Clear();

            // Añadir lista al comboBox
            for (int indice = 0; indice < ListaVehiculos.Count; indice++)
            {
                comboBoxListaModelos.Items.Add(ListaVehiculos[indice].Modelo);
            }
        }

        private void CBModelos()
        {
            comboBoxListaAnios.Items.Clear();
            comboBoxListaAnios.Enabled = true;

            // Recursos
            string INSTRUCCION = $"SELECT * FROM Vehiculos WHERE Marca = '{comboBoxListaMarcas.Text}' AND Modelo = '{comboBoxListaModelos.Text}'";

            List<Vehiculo> ListaVehiculos = new List<Vehiculo>();
            ListaVehiculos.AddRange(APIBD.ObtenerListaVehiculos(INSTRUCCION));

            for (int indice = 0; indice < ListaVehiculos.Count; indice++)
            {
                comboBoxListaAnios.Items.Add(ListaVehiculos[indice].Anio);
            }


            // Cargar Lista Vehiculos
        }

        private void CBAnios()
        {
            comboBoxListaMarcas.Enabled = true;
            buttonActualizar.Enabled = true;

            // Recursos
            string INSTRUCCION = $"SELECT * FROM Vehiculos WHERE Marca = '{comboBoxListaMarcas.Text}' AND Modelo = '{comboBoxListaModelos.Text}' AND Anio = '{comboBoxListaAnios.Text}'";

            List<Vehiculo> ListaVehiculos = new List<Vehiculo>();
            ListaVehiculos.AddRange(APIBD.ObtenerListaVehiculos(INSTRUCCION));

            textBoxPrecio.Text = ListaVehiculos[0].Precio.ToString() + " €";


        }






        private void FormActualizar_Load(object sender, EventArgs e)
        {
            // Recursos
            const string INSTRUCCION = "SELECT * FROM Vehiculos";

            string MensajeError = "";
            bool esValido = true; // Inicializado a Verdadero
            List<Vehiculo> ListaVehiculos = new List<Vehiculo>();

            try
            {
                ListaVehiculos.AddRange(APIBD.ObtenerListaVehiculos(INSTRUCCION));
                comboBoxListaMarcas.Items.Clear();

                // Añadir lista de marcas al iniciar el programa
                for (int indice = 0; indice < ListaVehiculos.Count; indice++)
                {

                    if (!comboBoxListaMarcas.Items.Contains(ListaVehiculos[indice].Marca))
                    {
                        comboBoxListaMarcas.Items.Add(ListaVehiculos[indice].Marca);
                    }
                }

            }
            catch (Exception Error)
            {
                esValido = false;
                MensajeError = Error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true; // Inicializado a Verdadero
             



            try
            {
                int anio = Convert.ToInt32(comboBoxListaAnios.Text);
                float precio = Convert.ToSingle(maskedTextBoxNuevoPrecio.Text);


                Vehiculo vehiculo = new Vehiculo(comboBoxListaMarcas.Text, comboBoxListaModelos.Text, anio, precio);
                string INSTRUCCION = $"UPDATE Vehiculos SET Precio = {vehiculo.Precio} WHERE Marca = '{vehiculo.Marca}' AND Modelo = '{vehiculo.Modelo}' AND Anio = '{vehiculo.Anio}'";

                if (UI.VentanaConfirmacion("¿Desea actializar el precio?") == DialogResult.Yes)
                {             
                APIBD.EjecutarInstruccion(INSTRUCCION);
                UI.MostrarMensaje($"El vehículo de marca {comboBoxListaMarcas.Text} a sido actualizado correctamente");
                }
            }
            catch (Exception Error)
            {
                esValido = false;
                MensajeError = Error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);

                textBoxPrecio.Text = "";
                comboBoxListaAnios.Items.Clear();
                comboBoxListaAnios.Text = "";

                comboBoxListaMarcas.Text = "";

                comboBoxListaModelos.Items.Clear();
                comboBoxListaModelos.Text = "";

                maskedTextBoxNuevoPrecio.Text = "";
            }
        }
    }
}
