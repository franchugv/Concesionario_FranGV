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
            "Inicial Catalog=Concesionario;" +        // Nombre de la base de datos
            "Integred Security=true;";

        // Conexión a la base de datos

        private static SqlConnection ConexionBD()
        {
            SqlConnection conexion = null;

            conexion = new SqlConnection(CONEXION);

            return conexion;
        }

        private static DataSet ObtenerClientes()
        {

            const string INSTRUCCION = "SELECT * FROM Vehiculos";

            DataSet datos = null;  // Datos de la base de datos

            SqlConnection conexionBaseDatos = null;
            SqlDataAdapter Puente = null;

            // 1. Inicializar Data Set
            datos = new DataSet();

            // 2. Establecer conxión
            conexionBaseDatos = ConexionBD();

            // 3. Acción

            



        }

    }
}
