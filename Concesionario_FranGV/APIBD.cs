using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario_FranGV
{
    public static class APIBD
    {

        // Llamada

        private const string CONEXION =
            "Data Source=(localdb)\\MSSQLLocalDB; " + // Nombre del servidor de la base de datos
            "Initial Catalog=Concesionario; " +        // Nombre de la base de datos
            "Integrated Security=true";

        // Conexión a la base de datos

        private static SqlConnection ConexionBD()
        {
            SqlConnection conexion = null;

            conexion = new SqlConnection(CONEXION);

            return conexion;
        }

        // Para cargar el DataSet necesitamos 3 recursos:
        // 1. DataSet
        // 2. SqlConnection lo inicializamos haciendo uso del método creado anteriormente
        // 3. SqlDataAdapter necesita inicializarse  la conexión y la instrucción
        // No hay que olvidar que el en puente se usa .Fill, cogiendo por parámetro el DataSet
        // y el nombre de la tabla para rellenar el DataSet
        private static DataSet ObtenerVehiculos(string INSTRUCCION)
        {


            DataSet datos = null;  // Datos de la base de datos

            SqlConnection conexionBaseDatos = null;
            SqlDataAdapter Puente = null;

            // 1. Inicializar Data Set
            datos = new DataSet();

            // 2. Establecer conxión
            conexionBaseDatos = ConexionBD();

            // 3. Hacemos el enlace
            Puente = new SqlDataAdapter(INSTRUCCION, conexionBaseDatos);

            // Cargamos el contendio de la tabla con FILL
            Puente.Fill(datos, "Vehiculos");

            conexionBaseDatos.Close();

            return datos;


        }
        // Para pasarlos a array necesitamos:
        // 1. el array del objeto
        // 2. el DataSet inicializado con el método anterior el cual tiene la tabla cargada
        // 3. num de filas
        // 4. DataRow el cual se iguala con el contenido del DataSet
        // y luego igualamos el contenido de las filas con el Array objeto
        public static Vehiculo[] ObtenerListaVehiculos(string instruccion)
        {
            // Recursos
            Vehiculo[] ListaVehiculos = null;
            DataSet datosVehiculos = null;
            int numVehiculos = 0;
            DataRow fila = null;

            // Asignamos el dataset
            // No hacemos conexion porque ya lo hicimos en este método
            datosVehiculos = ObtenerVehiculos(instruccion);

            // Obtener num filas tabla vehículos
            numVehiculos = datosVehiculos.Tables["Vehiculos"].Rows.Count;

            // Array tamaño de vehículos
            ListaVehiculos  = new Vehiculo[numVehiculos];

            // Asignar valor de la tabla a la clase
            for (int indice = 0; indice < ListaVehiculos.Length; indice++)
            {
                string aux = "";

                int anio;
                float precio;

                fila = datosVehiculos.Tables["Vehiculos"].Rows[indice];
                 
                    anio = Convert.ToInt32(fila["Anio"]);
                    precio = Convert.ToSingle(fila["Precio"]);

                    ListaVehiculos[indice] = new Vehiculo((string)fila["Marca"], (string)fila["Modelo"], anio, precio);
                


            }
            return ListaVehiculos;

            // Devolver
        }

        // 1. Necesitamos un SqlConnection igualado con el método
        // 2. Necsesitamos el SqlCommand instanciado con la conexión y la instrucción
        // Insert, Update, Delete
        public static void EjecutarInstruccion(string Instruccion)
        {
            SqlConnection conexion = null;
            SqlCommand comando = null;

            try
            {
                conexion = ConexionBD();

                comando = new SqlCommand(Instruccion, conexion);

                // Abrir conexión
                conexion.Open();

                // Ejecución de la instricción
                comando.ExecuteNonQuery();

            }
            catch(Exception error)
            {
                throw error;
            }
            finally
            {
                conexion.Close();
            }


        }

    }
}
