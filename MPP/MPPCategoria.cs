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
    public class MPPCategoria : IGestor<BECategoria>
    {
        Conexion conexion = new Conexion();
        string Nodo = "Categorias";
        public bool Actualizar(BECategoria Object)
        {
            XElement elementoCategoria = new XElement("Categoria",
              new XElement("Id", Object.Id),
              new XElement("Nombre", Object.Nombre));

            return conexion.Actualizar(Nodo, Object.Id.ToString(), elementoCategoria);
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

        public bool Eliminar(BECategoria Object)
        {
            return conexion.Eliminar(Nodo, Object.Id.ToString());
        }

        public BECategoria ListarObjeto(BECategoria bCategoria)
        {
            var Consulta = conexion.LeerTodos("Categoria");

            if (Consulta.Count() > 0)
            {
                bCategoria = (from x in Consulta
                              where Convert.ToInt32(x.Element("Id")?.Value) > 0
                              select new BECategoria
                              {
                                  Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                  Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                              }).FirstOrDefault();


            }
            else
            { bCategoria = null; }
            return bCategoria;
        }
        public List<BECategoria> ListarTodo()
        {
            var Consulta = conexion.LeerTodos(Nodo).Descendants("Categoria");
            MPPArticulo mPPArticulo = new MPPArticulo();
            var articulos = mPPArticulo.ListarTodo();

            List<BECategoria> lista = new List<BECategoria>();

            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         where Convert.ToInt32(x.Element("Id")?.Value) > 0
                         select new BECategoria
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                         }).ToList();


                foreach (var categoria in lista)
                {
                    categoria.Articulos = articulos.FindAll(x => x.Categoria.Id == categoria.Id);

                    foreach (var art in categoria.Articulos)
                    {
                        art.Categoria.Nombre = categoria.Nombre;
                    }
                }

            }
            else
            {
                lista = null;
            }

            return lista;
        }
    }

}
