using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace DAL
{
    public class Conexion
    {

        static OleDbCommand cmd;


        static OleDbConnection cn;
        static string ConexionsString { get; set; }
        public bool TestConection()
        {
            using (StreamReader Archivo = new StreamReader(@"ConexionString.txt"))
            {
                ConexionsString = Archivo.ReadLine();
            }
            OleDbConnection conexion;

            bool fileExist = File.Exists(ConexionsString);

            if (fileExist)
            {
                conexion = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ConexionsString + "; Jet OLEDB:Database Password = scg; ");
            }
            else
            {
                conexion = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BaseHallazgos.accdb ; Jet OLEDB:Database Password = scg; ");
            }



            conexion.Open();


            if (conexion.State == ConnectionState.Open)
            {
                //cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ConexionsString + "; Jet OLEDB:Database Password = scg; ");
                cn = conexion;
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable Leer(string consulta)
        {
            //  cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ConexionsString + "; Jet OLEDB:Database Password = scg; ");

            DataTable dt = new DataTable();
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(consulta, cn);
                da.Fill(dt);
            }
            catch (OleDbException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                cn.Close();
            }

            return dt;
        }

        public bool Escribir(string consulta)
        {
            //cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + ConexionsString + "; Jet OLEDB:Database Password = scg; ");

            cn.Open();
            cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            cmd.CommandText = consulta;
            try
            {
                int respuesta = cmd.ExecuteNonQuery();
                return true;
            }
            catch (OleDbException ex)
            {
                throw new Exception($"{ex.Message}");
            }

            finally
            { cn.Close(); }

        }

    }
}
