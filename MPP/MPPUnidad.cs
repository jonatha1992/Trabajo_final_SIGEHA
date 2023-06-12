using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Linq;


namespace MPP
{
    public class MPPUnidad : IGestor<BEUnidad>
    {
        Conexion conexion = new Conexion();
        string NodoPadre = "Unidades";
        string NodoContenedor = "Unidad";

        public bool Actualizar(BEUnidad Object)
        {
            throw new NotImplementedException();
        }

        public BEUnidad Agregar(BEUnidad Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEUnidad Object)
        {
            throw new NotImplementedException();
        }

        public BEUnidad ListarObjeto(BEUnidad Punidad)
        {
            var Consulta = conexion.LeerObjeto(NodoContenedor, Punidad.Id.ToString());

            if (Consulta != null)
            {
                Punidad.Id = Convert.ToInt32(Convert.ToString(Consulta.Element("Id")?.Value));
                Punidad.Nombre = Convert.ToString(Consulta.Element("Nombre")?.Value);
                Punidad.Ursa = new BEUrsa(Convert.ToInt32(Consulta.Element("IdUrsa")?.Value));
            }
            else
            { Punidad = null; }
            return Punidad;

        }

        public List<BEUnidad> ListarTodo()
        {
            //Declaro el objeto datatable para guardar los datos y luego pasarlos a lista
            var Consulta = conexion.LeerTodos(NodoPadre).Descendants("Unidad");


            List<BEUnidad> lista = new List<BEUnidad>();    
            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         select new BEUnidad
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                             Ursa = new BEUrsa(Convert.ToInt32(Convert.ToString(x.Element("IdUrsa")?.Value)))
                           }).ToList<BEUnidad>();

            }
            else
            { lista = null; }
            return lista;
        }
    }
}
