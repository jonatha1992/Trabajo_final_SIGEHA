using Abstraccion;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace DAL
{
    public class Conexion
    {

        static string ConexionsString { get; set; }
        static string XmlFilePath { get; set; }

        public bool TestConection()
        {
            using (StreamReader archivo = new StreamReader(@"ConexionString.txt"))
            {
                ConexionsString = archivo.ReadLine();
            }

            bool fileExist = File.Exists(ConexionsString);

            if (fileExist)
            {
                XmlFilePath = ConexionsString;
            }
            else
            {
                XmlFilePath = "Base de datos.xml";
            }

            return File.Exists(XmlFilePath);
        }

        public IEnumerable<XElement> Leer2(string consulta)
        {
            try
            {


                XDocument xdoc = XDocument.Load(XmlFilePath);

                IEnumerable<XElement> ElementosGenericos = xdoc.Descendants(consulta);
           
                return ElementosGenericos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }


        public bool Escribir(string consulta, List<XElement> hijos)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(XmlFilePath);
                XElement elementoPadre = xmlDoc.Element(consulta);

                if (elementoPadre == null)
                {
                    elementoPadre = new XElement(consulta);
                    xmlDoc.Add(elementoPadre);
                }

                foreach (XElement elementoHijo in hijos)
                {
                    elementoPadre.Add(elementoHijo);
                }


                xmlDoc.Save(XmlFilePath);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }


        public bool Escribir(string consulta)
        {
            try
            {
                //    XDocument xmlDoc = XDocument.Load(XmlFilePath);
                //    XElement elementoPadre = xmlDoc.Element(consulta);

                //    if (elementoPadre == null)
                //    {
                //        elementoPadre = new XElement(consulta);
                //        xmlDoc.Add(elementoPadre);
                //    }

                //    foreach (XElement elementoHijo in hijos)
                //    {
                //        elementoPadre.Add(elementoHijo);
                //    }


                //    xmlDoc.Save(XmlFilePath);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public DataTable Leer(string consulta)
        {
            try
            {
                DataTable istagenerica = new DataTable();

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFilePath);

                // Realiza el procesamiento de la consulta para obtener los datos necesarios del documento XML
                // y cargarlos en el DataTable 'dt' según sea necesario.
                // Aquí deberás implementar tu lógica personalizada para trabajar con el XML.

                // Ejemplo de cómo cargar datos desde el XML a un DataTable:
                XmlNodeList nodes = xmlDoc.SelectNodes("/Base/Instructores");
                foreach (XmlNode node in nodes)
                {
                    //devolver una lista

                }
                return istagenerica;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //static OleDbCommand cmd;


        //static OleDbConnection cn;
        //static string ConexionsString { get; set; }
        //public bool TestConection()
        //{
        //    using (StreamReader Archivo = new StreamReader(@"ConexionString.txt"))
        //    {
        //        ConexionsString = Archivo.ReadLine();
        //    }
        //    OleDbConnection conexion;

        //    bool fileExist = File.Exists(ConexionsString);

        //    if (fileExist)
        //    {
        //        conexion = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ConexionsString + "; Jet OLEDB:Database Password = scg; ");
        //    }
        //    else
        //    {
        //        conexion = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseHallazgos.accdb ; Jet OLEDB:Database Password = scg; ");
        //    }



        //    conexion.Open();


        //    if (conexion.State == ConnectionState.Open)
        //    {
        //        //cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ConexionsString + "; Jet OLEDB:Database Password = scg; ");
        //        cn = conexion;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public DataTable Leer(string consulta)
        //{
        //    //  cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ConexionsString + "; Jet OLEDB:Database Password = scg; ");

        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        OleDbDataAdapter da = new OleDbDataAdapter(consulta, cn);
        //        da.Fill(dt);
        //    }
        //    catch (OleDbException ex)
        //    { throw ex; }
        //    catch (Exception ex)
        //    { throw ex; }
        //    finally
        //    {
        //        cn.Close();
        //    }

        //    return dt;
        //}

        //public bool Escribir(string consulta)
        //{
        //    //cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ConexionsString + "; Jet OLEDB:Database Password = scg; ");

        //    cn.Open();
        //    cmd = new OleDbCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = cn;
        //    cmd.CommandText = consulta;
        //    try
        //    {
        //        int respuesta = cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (OleDbException ex)
        //    {
        //        throw new Exception($"{ex.Message}");
        //    }

        //    finally
        //    { cn.Close(); }

        //}

    }
}
