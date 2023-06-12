using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPEstado_Elemento : IGestor<BEEstado_Elemento>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }
        public BEEstado_Elemento Agregar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public BEEstado_Elemento ListarObjeto(BEEstado_Elemento BEntidad)
        {

            string Nodo = "Estado_Elementos";
            var Consulta = conexion.LeerTodos(Nodo).Descendants("Estado_Elemento");

            if (Consulta.Count() > 0)
            {
                BEntidad = (from x in Consulta
                            where Convert.ToInt32(x.Element("Id")?.Value) == BEntidad.Id
                            select new BEEstado_Elemento
                            {
                                Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                            }).FirstOrDefault();
            }
            else
            { BEntidad = null; }
            return BEntidad;
        }

        public List<BEEstado_Elemento> ListarTodo()
        {


            string Nodo = "Estado_Elementos";
            var Consulta = conexion.LeerTodos(Nodo).Descendants("Estado_Elemento");


            List<BEEstado_Elemento> lista = new List<BEEstado_Elemento>();

            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         where Convert.ToInt32(x.Element("Id")?.Value) > 0
                         select new BEEstado_Elemento
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                         }).ToList<BEEstado_Elemento>();

            }
            else
            { lista = null; }
            return lista;
        }
    }
}
