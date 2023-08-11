using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

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
            MPPCategoria mPPCategoria = new MPPCategoria();
            if (Consulta != null)
            {
                pArticulo.Id = Convert.ToInt32(Convert.ToString(Consulta.Element("Id")?.Value));
                pArticulo.Nombre = Convert.ToString(Consulta.Element("Nombre")?.Value);
                pArticulo.Categoria = mPPCategoria.ListarObjeto(new BECategoria(Convert.ToInt32(Consulta.Element("IdCategoria")?.Value)));
            }
            else
            { pArticulo = null; }
            return pArticulo;
        }

        public List<BEArticulo> ListarTodo()
        {
            MPPCategoria mPPCategoria = new MPPCategoria();
            var Articulos = conexion.LeerTodos(NodoContenedor);
            var categorias = conexion.LeerTodos("Categoria");

            List<BEArticulo> lista = new List<BEArticulo>();

            if (Articulos.Count() > 0)
            {
                lista = (from Articulo in Articulos
                         join categoria in categorias on Articulo.Element("IdCategoria")?.Value equals categoria.Element("Id")?.Value into articulosCategoria
                         select new BEArticulo
                         {
                             Id = Convert.ToInt32(Articulo.Element("Id")?.Value),
                             Nombre = Articulo.Element("Nombre")?.Value,
                             Categoria = new BECategoria
                             {
                                 Id = Convert.ToInt32(Articulo.Element("IdCategoria")?.Value),
                                 Nombre = articulosCategoria.FirstOrDefault()?.Element("Nombre")?.Value
                             }
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
