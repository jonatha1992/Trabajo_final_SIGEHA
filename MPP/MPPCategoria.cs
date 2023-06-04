using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
            DataTable Tabla;
            Tabla = conexion.Leer($"SELECT * FROM Categoria WHERE ( Id = {bCategoria.Id}) ");

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    bCategoria.Id = Convert.ToInt32(fila["Id"]);
                    bCategoria.Nombre = fila["Categoria"].ToString();
                }
            }
            else
            { bCategoria = null; }
            return bCategoria;
        }

        //public List<BECategoria> ListarTodo()
        //{
        //    DataTable Tabla;
        //    Tabla = conexion.Leer("Select * From Categoria");
        //    List<BECategoria> ListaCategorias = new List<BECategoria>();
        //    MPPArticulo mPPArticulo = new MPPArticulo();
        //    if (Tabla.Rows.Count > 0)
        //    {
        //        foreach (DataRow fila in Tabla.Rows)
        //        {
        //            BECategoria BCategoria = new BECategoria();
        //            BCategoria.Id = Convert.ToInt32(fila["Id"]);
        //            BCategoria.Nombre = fila["Categoria"].ToString();

        //            BCategoria.Articulos = new List<BEArticulo>();

        //            var Tabla2 = conexion.Leer($"SELECT * FROM Articulo where [Id categoria]= {BCategoria.Id} ");

        //            foreach (DataRow fila2 in Tabla2.Rows)
        //            {
        //                BEArticulo bEArticulo = new BEArticulo();
        //                bEArticulo.Id = Convert.ToInt32(fila2["Id"]);
        //                bEArticulo.NombreArticulo = fila2["Articulo"].ToString();

        //                BCategoria.Articulos.Add(bEArticulo);
        //            }


        //            ListaCategorias.Add(BCategoria);
        //        }
        //    }
        //    else
        //    { ListaCategorias = null; }
        //    return ListaCategorias;
        //}


        public List<BECategoria> ListarTodo()
        {


            string Nodo = "Cateorias";
            var Consulta = conexion.Leer2(Nodo).Descendants("Categoria");

            //TODO: SEGUIR CATEGORIAS
            List<BECategoria> lista = new List<BECategoria>();

            if (Consulta.Count() > 0)
            {
                var lista2 = from x in Consulta
                             where x.Element("Id_rol")?.Value.ToString() != ""
                             select new BEInstructor
                             {
                                 Id = Convert.ToInt32(Convert.ToString(x.Element("Id_persona")?.Value)),
                                 Legajo = Convert.ToInt32(Convert.ToString(x.Element("Legajo")?.Value)),
                                 Destino = new BEDestino(Convert.ToInt32(Convert.ToString(x.Element("Id_destino")?.Value))),
                                 Password = Convert.ToString(x.Element("Password")?.Value),
                                 Rol = new BERol(Convert.ToInt32(Convert.ToString(x.Element("Id_rol")?.Value))),
                                 Mail = Convert.ToString(x.Element("Mail")?.Value),
                                 Jerarquia = new BEJerarquia(Convert.ToInt32(Convert.ToString(x.Element("Id_jerarquia")?.Value))),
                             };

                lista = lista2.ToList<BEInstructor>();
            }
            else
            {
                lista = null;
            }

            return lista;
            DataTable Tabla;
            Tabla = conexion.Leer("Select * From Categoria");
            List<BECategoria> ListaCategorias = new List<BECategoria>();
            MPPArticulo mPPArticulo = new MPPArticulo();
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BECategoria BCategoria = new BECategoria();
                    BCategoria.Id = Convert.ToInt32(fila["Id"]);
                    BCategoria.Nombre = fila["Categoria"].ToString();

                    BCategoria.Articulos = new List<BEArticulo>();

                    var Tabla2 = conexion.Leer($"SELECT * FROM Articulo where [Id categoria]= {BCategoria.Id} ");

                    foreach (DataRow fila2 in Tabla2.Rows)
                    {
                        BEArticulo bEArticulo = new BEArticulo();
                        bEArticulo.Id = Convert.ToInt32(fila2["Id"]);
                        bEArticulo.NombreArticulo = fila2["Articulo"].ToString();

                        BCategoria.Articulos.Add(bEArticulo);
                    }


                    ListaCategorias.Add(BCategoria);
                }
            }
            else
            { ListaCategorias = null; }
            return ListaCategorias;
        }
    }
}
