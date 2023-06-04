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
            string Nodo = "Unidades";
            var Consulta = conexion.Leer2(Nodo).Descendants("Unidad");

            if (Consulta.Count() > 0)
            {
                Punidad = (from x in Consulta
                         where Convert.ToInt32(x.Element("Id")?.Value) ==  Punidad.Id
                         select new BEUnidad
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                         }).FirstOrDefault();
                
            }
            else
            { Punidad = null; }
            return Punidad;

        }

        public List<BEUnidad> ListarTodo()
        {
            //Declaro el objeto datatable para guardar los datos y luego pasarlos a lista
            string Nodo = "Unidades";
            var Consulta = conexion.Leer2(Nodo).Descendants("Unidad");


            List<BEUnidad> lista = new List<BEUnidad>();    
            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         select new BEUnidad
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                             Ursa = new BEUrsa(Convert.ToInt32(Convert.ToString(x.Element("Idursa")?.Value)))
                           }).ToList<BEUnidad>();

            }
            else
            { lista = null; }
            return lista;
        }
    }
}
