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
            // Obtener año
            string Anio = comboBoxListaVehiculos.Text;
            Anio = Anio.Substring(Anio.IndexOf(" ,") + 1);
            Anio = Anio.Substring(0, Anio.IndexOf(" ,") + 1);

            // Recursos
            string MensajeError = "";
            bool esValido = true;
            string INSTRUCCION = $"SELECT * FROM Vehiculos WHERE Marca = '{comboBoxListaMarcas.Text}' AND Modelo = '' AND Anio = '{}'";

            try
            {


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

    }
}
