using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario_FranGV
{
    public class Vehiculo
    {


        // CONSTANTES
        // Longitudes
        // Marca
        private const int LongitudMinimaMarca = 2;
        private const int LonxitudMaximaMarca = 15;
        // Modelo
        private const int LongitudMinimaModelo = 5;
        private const int LongitudMaxinaModelo = 30;
        // Año
        private const int AnioMinimo = 2000;
        private const int AnioMaximo = 2024;

        // Precioo
        private const int PrecioMinimo = 5000;
        private const int PrecioMaximo = 300000;

        // MIEMBROS
        private string _marca;
        private string _modelo;
        private int _anio;
        private float _precio;

        // CONSTRUCTORES
        
        // Claves primarias
        public Vehiculo(string brand, string model, int year)
        {
            Marca = brand;
            Modelo = model;
            Anio = year;
        }

        // Todos
        public Vehiculo(string brand, string model, int year, float price) : this(brand, model, year)
        {
            Precio = price;
        }

        // PROPIEDADES

        public string Marca
        {
            get { return _marca; }
            set
            {
                // El value se pasará a mayusculas
                value = ValidarMarca(value);
                _marca = value;
            }
        }

        public string Modelo
        {
            get { return _modelo; }
            // El value se pasará a mayusculas
            set { _modelo = ValidarModelo(value); }
        }

        public int Anio
        {
            get { return _anio; }
            set 
            { 
                // Validar año
                ValidarAnio(value);
                _anio = value; }
        }

        // Al ser float podrá contener decimles
        public float Precio
        {
            get { return _precio; }
            set {
                // Validar Precio
                ValidarPrecio(value);
                _precio = value; }
        }


        // MÉTODOS

        // VALIDACIONES
        /// <summary>
        /// Validar Cadena vacía
        /// </summary>
        /// <param name="cadena"></param>
        /// <exception cref="CadenaVaciaException"></exception>
        private static void ValidarCadena(string cadena)
        {
            if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaException();
        }

        /// <summary>
        /// Validar marca
        /// </summary>
        /// <param name="brand">Marca</param>
        /// <returns>Devuelve la marca en Mayusculas</returns>
        /// <exception cref="Exception"></exception>
        private static string ValidarMarca(string brand)
        {
            // RECURSOS
            brand = brand.Trim().ToUpper();

            ValidarCadena(brand);

            // Longitud mínima
            if (brand.Length > LonxitudMaximaMarca) throw new Exception($"La marca {brand} tiene una longitud superior a: {LonxitudMaximaMarca}");
            if (brand.Length < LongitudMinimaMarca) throw new Exception($"La marca {brand} tiene una longitud inferior a: {LongitudMinimaMarca}");

            foreach (char caracter in brand)
            {
                if (char.IsDigit(caracter)) throw new Exception("Los digitos no están permitidos");
            }
            // Devolver a mayusculas
            return brand;
        }
        /// <summary>
        /// Validar Modelo
        /// </summary>
        /// <param name="model">Modelo</param>
        /// <returns>Deveuelve el modelo en Mayusculas</returns>
        /// <exception cref="Exception"></exception>
        private static string ValidarModelo(string model)
        {
            // Pasar a mayusculas
            model = model.Trim().ToUpper();

            // Min
            if (model.Length < LongitudMinimaModelo) throw new Exception("Es inferior al rango de valores establecido");
            // Max
            if (model.Length > LongitudMaxinaModelo) throw new Exception("Es mayor al rango de valores establecido");

            // Parsar a mayusculas
        return model;            
        }


        private static void ValidarAnio(int anio)
        {
            if (anio < AnioMinimo) throw new Exception("El año es inferior al mínimo");
            if (anio > AnioMaximo) throw new Exception("El año es superior al actual");
        }

        private static void ValidarPrecio(float precio)
        {
            if (precio < PrecioMinimo) throw new Exception("El precio es inferor al mínimo");
            if (precio > PrecioMaximo) throw new Exception("El precio es mayor al máximo");
        }












    }
    public class CadenaVaciaException : Exception
    {
        public CadenaVaciaException() : base("Cadena vacía") { }
        public CadenaVaciaException(string message) : base(message) { }
    }
}
