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
        public bool Actualizar(BEArticulo Object)
        {
            throw new NotImplementedException();
        }

        public BEArticulo Agregar(BEArticulo Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEArticulo Object)
        {
            throw new NotImplementedException();
        }

        //public BEArticulo ListarObjeto(BEArticulo pArticulo)
        //{
        //    DataTable Tabla;
        //    Tabla = conexion.Leer($"SELECT * FROM Articulo WHERE ( Id = {pArticulo.Id}) ");
        //    MPPCategoria mPPCategoria = new MPPCategoria();
        //    if (Tabla.Rows.Count > 0)
        //    {
        //        foreach (DataRow fila in Tabla.Rows)
        //        {
        //            pArticulo.Id = Convert.ToInt32(fila["Id"]);
        //            pArticulo.Nombre = fila["Articulo"].ToString();

        //            BECategoria bECategoria = new BECategoria(Convert.ToInt32(fila["Id Categoria"]));
        //            pArticulo.Categoria = mPPCategoria.ListarObjeto(bECategoria);
        //        }
        //    }
        //    else
        //    { pArticulo = null; }
        //    return pArticulo;
        //}

        //public List<BEArticulo> ListarTodo()
        //{
        //    DataTable Tabla;
        //    conexion = new Conexion();
        //    Tabla = conexion.Leer("SELECT * FROM Articulo");
        //    List<BEArticulo> ListaArticulos = new List<BEArticulo>();
        //    MPPCategoria mCategoria = new MPPCategoria();
        //    var categorias = mCategoria.ListarTodo();

        //    if (Tabla.Rows.Count > 0)
        //    {
        //        foreach (DataRow fila in Tabla.Rows)
        //        {
        //            BEArticulo bEArticulo = new BEArticulo();
        //            bEArticulo.Id = Convert.ToInt32(fila["Id"]);
        //            bEArticulo.Nombre = fila["Articulo"].ToString();

        //            bEArticulo.Categoria = new BECategoria(Convert.ToInt32(fila["Id categoria"]));

        //            //bEArticulo.Categoria = mCategoria.ListarObjeto(BeCategoria);
        //            //bEArticulo.Categoria = categorias.Find(x => x.Id == Convert.ToInt32(fila["Id categoria"]));

        //            ListaArticulos.Add(bEArticulo);
        //        }
        //    }
        //    else
        //    { ListaArticulos = null; }
        //    return ListaArticulos;
        //}


        public BEArticulo ListarObjeto(BEArticulo pArticulo)
        {
            string Nodo = "Articulos";
            var Consulta = conexion.Leer2(Nodo).Descendants("Articulo");

            if (Consulta.Count() > 0)
            {
                pArticulo = (from x in Consulta
                             where Convert.ToInt32(x.Element("Id")?.Value) > 0
                             select new BEArticulo
                             {
                                 Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                 Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                             }).FirstOrDefault();
            }
            else
            { pArticulo = null; }
            return pArticulo;
        }
        public List<BEArticulo> ListarTodo()
        {
            string Nodo = "Articulo";
            var Consulta = conexion.Leer2(Nodo).Descendants("Articulo");


            List<BEArticulo> lista = new List<BEArticulo>();

            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         where Convert.ToInt32(x.Element("Id")?.Value) > 0
                         select new BEArticulo
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                         }).ToList<BEArticulo>();
            }
            else
            {
                lista = null;
            }

            return lista;
        }
    }
}
