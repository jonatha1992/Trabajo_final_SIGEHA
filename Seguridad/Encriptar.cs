using System;
using System.Security.Cryptography;
using System.Text;

namespace Seguridad
{
    public class Encriptar
    {
        public static string Encriptacion(string pass)
        {
            try
            {
                var message = Encoding.UTF8.GetBytes(pass);


                SHA256 shadow = SHA256.Create();
                StringBuilder sb = new StringBuilder();
                byte[] stream = null;
                stream = shadow.ComputeHash(message);

                foreach (byte x in stream)
                {
                    sb.AppendFormat("{0:x2}", x);
                }

                return sb.ToString();


            }
            catch (CryptographicException ex) { throw new Exception(ex.Message); }
            catch (Exception e) { throw new Exception(e.Message); }


        }
    }
}