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
    public class MPPComponente : IGestor<BEPermiso>
    {
        Conexion conexion = new Conexion();
        string Nodo = "Categorias";
        //public bool Actualizar(BECategoria Object)
        //{
        //    XElement elementoCategoria = new XElement("Categoria",
        //      new XElement("Id", Object.Id),
        //      new XElement("Nombre", Object.Nombre));

        //    return conexion.Actualizar(Nodo, Object.Id.ToString(), elementoCategoria);
        //}

        public bool Actualizar(BEPermiso Object)
        {
            throw new NotImplementedException();
        }

        public BECategoria Agregar(BECategoria Object)
        {
            var NuevoID = conexion.ObtenerUltimoID(Nodo);
            XElement elementoCategoria = new XElement("Categoria",
                new XElement("Id", NuevoID),
                new XElement("Nombre", Object.Nombre));

            conexion.Agregar(Nodo, elementoCategoria);

            Object.Id = NuevoID;

            return Object;
        }

        public BEPermiso Agregar(BEPermiso Object)
        {
            throw new NotImplementedException();
        }

        //public bool Eliminar(BECategoria Object)
        //{
        //    return conexion.Eliminar(Nodo, Object.Id.ToString());
        //}

        public bool Eliminar(BEPermiso Object)
        {
            throw new NotImplementedException();
        }

        public BEPermiso ListarObjeto(BECategoria bCategoria)
        {
            throw new NotImplementedException();
        }

        public BEPermiso ListarObjeto(BEPermiso Object)
        {
            throw new NotImplementedException();
        }

        public List<BEPermiso> ListarTodo()
        {
            var Consulta = conexion.LeerTodos(Nodo).Descendants("Permisos");

            List<BEPermiso> lista = new List<BEPermiso>();

            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         where Convert.ToInt32(x.Element("Id")?.Value) > 0
                         select new BEPermiso
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                         }).ToList();

            }
            else
            {
                lista = null;
            }

            return lista;
        }


    }

}
