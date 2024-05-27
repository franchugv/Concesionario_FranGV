using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario_FranGV
{
    public static class Conversiones
    {
        public static int ConvertirInt(string cadena)
        {
            // Recursos
            int numero = 0;

            numero = Convert.ToInt32(cadena);

            return numero;
        }

        public static float ConvertirFloat(string cadena)
        {
            // Recursos
            float numero = 0;

            numero = Convert.ToSingle(cadena);

            return numero;
        }
    }
}
