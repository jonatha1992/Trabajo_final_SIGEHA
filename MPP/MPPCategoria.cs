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
        public bool Actualizar(BECategoria Object)
        {
            throw new NotImplementedException();
        }

        public BECategoria Agregar(BECategoria Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BECategoria Object)
        {
            throw new NotImplementedException();
        }

        public BECategoria ListarObjeto(BECategoria bCategoria)
        {
            string Nodo = "Categorias";
            var Consulta = conexion.Leer2(Nodo).Descendants("Categoria");

            if (Consulta.Count() > 0)
            {
                bCategoria = (from x in Consulta
                              where Convert.ToInt32(x.Element("Id")?.Value) > 0
                              select new BECategoria
                              {
                                  Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                  Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                              }).FirstOrDefault();

                Nodo = "Articulos";
                Consulta = conexion.Leer2(Nodo).Descendants("Articulo");
                if (Consulta.Count() > 0)
                {

                    bCategoria.Articulos = new List<BEArticulo>();

                    bCategoria.Articulos = (from x in Consulta
                                            where Convert.ToInt32(x.Element("Id_categoria")?.Value) == bCategoria.Id
                                            select new BEArticulo
                                            {
                                                Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                                Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                                                Categoria = new BECategoria(bCategoria.Id)
                                            }).ToList<BEArticulo>();
                }
            }
            else
            { bCategoria = null; }
            return bCategoria;
        }
        public List<BECategoria> ListarTodo()
        {
            string Nodo = "Categorias";
            var Consulta = conexion.Leer2(Nodo).Descendants("Categoria");

            
            List<BECategoria> lista = new List<BECategoria>();

            if (Consulta.Count() > 0)
            {
                 lista = (from x in Consulta
                             where Convert.ToInt32(x.Element("Id")?.Value) > 0
                             select new BECategoria
                             {
                                 Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                 Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                             }).ToList<BECategoria>();
            }
            else
            {
                lista = null;
            }

            return lista;
        }
    }

}
