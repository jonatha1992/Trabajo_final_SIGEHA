using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Seguridad
{
    public class Encriptacion
    {

        private static byte[] Llave = Encoding.UTF8.GetBytes("Clave_Maestra123"); // Debe ser de 16 bytes
        private static byte[] IV = new byte[16]; // 16 bytes inicializados a 0
       

        public static string Encriptar(string text)
        {
            Aes aes = Aes.Create();
            aes.Key = Llave;
            aes.IV = IV;

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);

            sw.Write(text);
            sw.Close();
            cs.Close();
            ms.Close();
            aes.Dispose();

            return Convert.ToBase64String(ms.ToArray());
        }

        public static string Desinciptar(string text)
        {
            Aes aes = Aes.Create();
            aes.Key = Llave;
            aes.IV = IV;

            MemoryStream ms = new MemoryStream(Convert.FromBase64String(text));
            CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);

            string TextDescipto = sr.ReadToEnd();

            sr.Close();
            cs.Close();
            ms.Close();
            aes.Dispose();

            return TextDescipto;
        }
    }
}