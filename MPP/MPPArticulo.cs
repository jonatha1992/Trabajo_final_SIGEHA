using Abstraccion;
using BE;
using DAL;
using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPPArticulo : IGestor<BEArticulo>
    {
        Conexion conexion = new Conexion();

        string NodoPadre = "Articulos";
        string NodoContenedor = "Articulo";
        public bool Actualizar(BEArticulo Object)
        {
            XElement elementoContenedor = new XElement("Articulo",
                    new XElement("Id", Object.Id),
                    new XElement("Nombre", Object.Nombre),
                    new XElement("IdCategoria", Object.Categoria.Id));

            return conexion.Actualizar(NodoPadre, Object.Id.ToString(), elementoContenedor);
        }

        public BEArticulo Agregar(BEArticulo Object)
        {
            var NuevoID = conexion.ObtenerUltimoID(NodoPadre);

            XElement elementoContenedor = new XElement("Categoria",
                new XElement("Id", NuevoID),
                new XElement("Nombre", Object.Nombre),
                new XElement("IdCategoria", Object.Categoria.Id));

            conexion.Agregar(NodoPadre, elementoContenedor);

            Object.Id = NuevoID;

            return Object;

        }

        public bool Eliminar(BEArticulo Object)
        {
            return conexion.Eliminar(NodoPadre, Object.Id.ToString());
        }


        public BEArticulo ListarObjeto(BEArticulo pArticulo)
        {
            var Consulta = conexion.LeerObjeto(NodoContenedor, pArticulo.Id.ToString());

            if (Consulta != null)
            {
                pArticulo.Id = Convert.ToInt32(Convert.ToString(Consulta.Element("Id")?.Value));
                pArticulo.Nombre = Convert.ToString(Consulta.Element("Nombre")?.Value);
                pArticulo.Categoria = new BECategoria(Convert.ToInt32(Consulta.Element("IdCategoria")?.Value));
            }
            else
            { pArticulo = null; }
            return pArticulo;
        }

        public List<BEArticulo> ListarTodo()
        {
            var Consulta = conexion.LeerTodos(NodoPadre).Descendants("Articulo");


            List<BEArticulo> lista = new List<BEArticulo>();

            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         where Convert.ToInt32(x.Element("Id")?.Value) > 0
                         select new BEArticulo
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                             Categoria = new BECategoria(Convert.ToInt32(x.Element("IdCategoria")?.Value))
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
