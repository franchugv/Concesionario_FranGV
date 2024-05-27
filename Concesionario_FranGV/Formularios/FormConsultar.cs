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
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            // Recursos
            bool esValido = true;
            string MensajeError = "";
            listBoxListaVehiculos.Items.Clear();


            try
            {


                // Recursos
                string INSTRUCCION = $"SELECT * FROM Vehiculos WHERE Marca = '{comboBoxListaMarcas.Text}'";


                // Inicializar clase vehiculos
                List<Vehiculo> listaVehiculos = new List<Vehiculo>();

                listaVehiculos.AddRange(APIBD.ObtenerListaVehiculos(INSTRUCCION));

                // Agregar información marca seleccionada
                for (int indice = 0; indice < listaVehiculos.Count; indice++)
                {
                    listBoxListaVehiculos.Items.Add($"Modelo: {listaVehiculos[indice].Modelo}, Año: {listaVehiculos[indice].Anio}, Precio: {listaVehiculos[indice].Precio}");
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

        private void CargarMarcas()
        {
            listBoxListaVehiculos.Items.Clear();
            comboBoxListaMarcas.Items.Clear();

            // Recursos
            const string INSTRUCCION = "SELECT * FROM Vehiculos";


            // Inicializar clase vehiculos
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            // Cargamos la lista de vehiculos
            listaVehiculos.AddRange(APIBD.ObtenerListaVehiculos(INSTRUCCION));


            // Agregar marcas
            for (int indice = 0; indice < listaVehiculos.Count; indice++)
            {
                if (!comboBoxListaMarcas.Items.Contains(listaVehiculos[indice].Marca))
                {
                    comboBoxListaMarcas.Items.Add(listaVehiculos[indice].Marca);
                }
            }
        }

        private void FormConsultar_Load(object sender, EventArgs e)
        {
            // Recursos
            bool esValido = true;
            string MensajeError = "";


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
    }
}
