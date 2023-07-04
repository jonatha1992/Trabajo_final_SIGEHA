using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Xml.Linq;

namespace MPP
{
    public class MPPBitacora
    {
        Conexion DALBitacora;
        string NodoPadre = "Bitacora";
        string NodoContenedor = "Evento";
        public MPPBitacora()
        {
            DALBitacora = new Conexion();
        }

        public List<BEEvento> ListarTodo()
        {
            var Consulta = DALBitacora.LeerTodosEventos(NodoContenedor);

            List<BEEvento> lista = new List<BEEvento>();

            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         select new BEEvento
                         {
                             Id = Convert.ToInt32((x.Element("Id").Value)),
                             Fecha = Convert.ToDateTime(x.Element("Fecha")?.Value),
                             Usuario = Convert.ToString(x.Element("Usuario")?.Value),
                             Mensaje = Convert.ToString(x.Element("Mensaje")?.Value),
                         }).ToList();
            }
            else
            {
                lista = null;
            }
            return lista;
        }

        public void RegistrarEvento(BEEvento bEEvento)
        {
            XElement eventoXMl = new XElement("Evento",
                    new XElement("Id", DALBitacora.ObtenerUltimoIDBitacora(NodoPadre)),
                    new XElement("Fecha", bEEvento.Fecha.ToString("dd-MM-yyyy HH:mm:ss")),
                    new XElement("Usuario", bEEvento.Usuario),
                    new XElement("Mensaje", bEEvento.Mensaje)
                );

            DALBitacora.AgregarEvento("Bitacora", eventoXMl);

        }

   


    }
}
