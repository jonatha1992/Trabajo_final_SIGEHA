using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Xml.Linq;
using System.IO;
using System.Globalization;

namespace MPP
{
    public class MPPBackUp
    {
        Conexion conexion;
        public MPPBackUp()
        {
            conexion = new Conexion();
        }

        public List<BEBackUp> ListarTodo()
        {
             var archivos = conexion.ListarBackups();

            List<BEBackUp> lista = new List<BEBackUp>();
            foreach (string archivo in archivos)
            {
                string nombreArchivo = Path.GetFileName(archivo); // Obtener el nombre del archivo sin la ruta
                string formatoFecha = "dd-MM-yyyy HH-mm-ss";
                string fechaArchivo = nombreArchivo.Replace("BackUp_", "").Replace(".xml", "");
                DateTime fecha;
                bool parseExitoso = DateTime.TryParseExact(fechaArchivo, formatoFecha, CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);


                if (parseExitoso)
                {
                    BEBackUp backup = new BEBackUp()
                    {
                        Fecha = fecha,
                        NombreArchivo = nombreArchivo
                    };

                    lista.Add(backup);
                }

            }
            return lista;
        }

        public bool GenerarBackUp(BEBackUp bakup)
        {
            return conexion.GenerarBackUp(bakup);
        }

        public bool RestaurarBackUp(BEBackUp bakup)
        {
            return conexion.RestaurarBackUp(bakup);
        }


    }
}
