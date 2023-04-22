using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

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
                    bCategoria.Categoria = fila["Categoria"].ToString();
                }
            }
            else
            { bCategoria = null; }
            return bCategoria;
        }

        public List<BECategoria> ListarTodo()
        {
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
                    BCategoria.Categoria = fila["Categoria"].ToString();

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
