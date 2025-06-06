﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Seguridad
{
    #region "campos"
    #endregion
    #region "Propiedades"
    #endregion
    #region "Constructor"
    #endregion
    #region "Metodos"
    #endregion
    #region "Botones"
    #endregion
    #region "Finalizador"
    #endregion



    public class Validar
    {
        public static void SoloEnterossSinEspacios(KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }

            else
            {
                V.Handled = true;
                MessageBox.Show("Solo Numeros decimales, sin Espacios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public static void soloLetrasConEspacios(KeyPressEventArgs V)
        {
            if (Char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
                MessageBox.Show("Solo Letras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        public static void soloLetrasSinEspacios(KeyPressEventArgs V)
        {
            if (Char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
                MessageBox.Show("Solo letras sin espacios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        public static void soloAlfanumericoConEspacio(KeyPressEventArgs V)
        {
            if (Char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (V.KeyChar == (char)Keys.Enter)
            {
                V.Handled = true;
                MessageBox.Show("No se permiten saltos de linea", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                V.Handled = true;
                MessageBox.Show("Solo Alfanumerico", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void soloDecimales(KeyPressEventArgs V)
        {
            if (V.KeyChar.ToString().Equals(","))
            {
                V.Handled = false;
            }
            else if (Char.IsDigit(V.KeyChar))
            {

                V.Handled = false;

            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
                MessageBox.Show("Solo Decimales", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


        public static void NoSaltosDelinea(KeyPressEventArgs V)
        {
            if (V.KeyChar == (char)Keys.Enter)
            {
                V.Handled = true;
                MessageBox.Show("No se permiten saltos de linea", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                V.Handled = false;
        }

        static public string generarCodigo(string Categoria)
        {
            Random random = new Random();
            string result = "";

            string parametros = "0123456789";   // Creamos una instancia del generador de números aleatorios


            for (int i = 0; i < 4; i++)
            {
                //Obtenemos un número aleatorio que se corresponde con una
                //posición dentro del pattern.

                int mIndex = random.Next(parametros.Length);

                //Vamos formando el código
                result += parametros[mIndex];
            }

            return result + Categoria;


        }
        static public int generarId()
        {
            Random random = new Random();
            int result = 0; // Nuestro patrón de caracteres para formar el código

            string parametros = "0123456789";

            for (int i = 0; i < 12; i++)
            {
                int mIndex = random.Next(parametros.Length);

                result += parametros[mIndex];
            }

            return result;


        }

        static public bool SoloEnteros(string text)
        {
            bool respuesta = Regex.IsMatch(text, "^([0-9]+$)");


            return respuesta;
        }

        static public bool SoloContraseña(string text)
        {
            bool respuesta = Regex.IsMatch(text, "^([A-Za-z0-9]+$)");

            return respuesta;
        }

        static public bool SoloAlfabetico_Con_Espacios(string text)
        {
            bool respuesta = Regex.IsMatch(text, "^([A-Za-z ]+$)");

            return respuesta;
        }


        static public bool VerificarNroActa(string text, string CodUnidad)
        {


            // Verificar que el número de Acta tenga entre 1 y 5 dígitos, seguidos de 3 letras, "/", y luego 4 dígitos al final.
            bool respuesta = Regex.IsMatch(text, @"^\d{1,5}[A-Z]{3}/\d{4}$");

            if (respuesta)
            {
                string codigoUnidadActa = text.Substring(text.Length - 8, 3); // Extraer los 3 caracteres del código de unidad
                respuesta = codigoUnidadActa == CodUnidad;
            }

            //// Verificar que el número de Acta tenga al menos 4 dígitos al principio seguidos de cualquier cantidad de dígitos adicionales y luego siga el formato "XXXXCCC/YYYY"
            //bool respuesta = Regex.IsMatch(text, "^[0-9]{4,}[A-Z]{3}/[0-9]{4}$");

            //string codigoUnidadActa = text.Substring(text.Length - 8, 3); // Extraer los 3 caracteres del código de unidad
            //respuesta = respuesta && codigoUnidadActa == CodUnidad;

            return respuesta;
        }
        static public bool VerificarNroDocumento(string text)
        {
            // Expresión regular para verificar un número de pasaporte o DNI
            bool esPasaporte = Regex.IsMatch(text, "^[A-Z0-9]{6,9}$");
            bool esDNI = Regex.IsMatch(text, "^[0-9]{7,8}$");

            return esPasaporte || esDNI;
        }

    }
}
