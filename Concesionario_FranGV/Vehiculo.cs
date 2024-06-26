﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario_FranGV
{
    public class Vehiculo
    {

        #region Constantes
        // CONSTANTES
        private const float PRECIO_DEF = 0;
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
        // Precio
        private const int PrecioMinimo = 5000;
        private const int PrecioMaximo = 300000;
        // MIEMBROS
        private string _marca;
        private string _modelo;
        private int _anio;
        private float _precio;
        #endregion

        // CONSTRUCTORES
        // Claves primarias
        public Vehiculo(string brand, string model, int year)
        {
            Marca = brand;
            Modelo = model;
            Anio = year;
            _precio = PRECIO_DEF;
        }

        // Todos
        public Vehiculo(string brand, string model, int year, float price) : this(brand, model, year)
        {
            Precio = price;
        }

        // PROPIEDADES
        public string Marca
        {
            get 
            { 
                return _marca; 
            }
            set
            {
                // El value se pasará a mayusculas
                value = ValidarMarca(value);
                _marca = value;
            }
        }

        public string Modelo
        {
            get 
            { 
                return _modelo; 
            }
            // El value se pasará a mayusculas
            set 
            { 
                _modelo = ValidarModelo(value); 
            }
        }

        public int Anio
        {
            get 
            { 
                return _anio; 
            }
            set 
            { 
                // Validar año
                ValidarAnio(value);
                _anio = value; 
            }
        }

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
        /// <returns>Devuelve la marca en Mayúsculas</returns>
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
                if (char.IsDigit(caracter)) throw new Exception("Los dígitos no están permitidos");
            }
            // Devolver a mayúsculas
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
            // Pasar a mayúsculas, siempre al principio
            model = model.Trim().ToUpper();

            // Min
            if (model.Length < LongitudMinimaModelo) throw new Exception("El rango del modelo inferior al rango de valores establecido");
            // Max
            if (model.Length > LongitudMaxinaModelo) throw new Exception("El rango del modelo es mayor al valores establecido");

            // Pasar a mayúsculas
            return model;            
        }

        /// <summary>
        /// Valida el máximo y el mínimo del año
        /// </summary>
        /// <param name="anio"></param>
        /// <exception cref="Exception"></exception>
        private static void ValidarAnio(int anio)
        {
            if (anio < AnioMinimo) throw new Exception("El año es inferior al mínimo");
            if (anio > AnioMaximo) throw new Exception("El año es superior al actual");
        }

        /// <summary>
        /// Valida el máximo y el mínimo del precio
        /// </summary>
        /// <param name="precio">Precio a evaluar</param>
        /// <exception cref="Exception"></exception>
        private static void ValidarPrecio(float precio)
        {
            if (precio < PrecioMinimo && precio != 0) throw new Exception("El precio es inferior al mínimo");
            if (precio > PrecioMaximo) throw new Exception("El precio es mayor al máximo");
        }












    }
    public class CadenaVaciaException : Exception
    {
        public CadenaVaciaException() : base("Cadena vacía") { }
        public CadenaVaciaException(string message) : base(message) { }
    }
}
