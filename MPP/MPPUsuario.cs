using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPUsuario
    {
        Conexion conexion = new Conexion();

        public bool Agregar(BEUsuario pUsuario)
        {
            throw new NotImplementedException();

        }
        public bool Actualizar(BEUsuario pUsuario)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEUsuario Object)
        {
            throw new NotImplementedException();
        }

        public bool GuardarPermisos(BEUsuario oBEUsu)
        {
            try
            {
                // Elimina los permisos existentes del usuario
                conexion.Eliminar("UsuariosPermisos", oBEUsu.Id.ToString(), "IdUsuario");

                // Agrega los nuevos permisos
                foreach (var permiso in oBEUsu.Permisos)
                {
                    var permisoUsuarioElement = new XElement("UsuarioPermiso",
                        new XElement("IdUsuario", oBEUsu.Id),
                        new XElement("IdPermiso", permiso.Id));

                    conexion.Agregar("UsuariosPermisos", permisoUsuarioElement);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }


        public List<BEUsuario> ListarTodo()
        {
            string Nodo = "Usuarios";
            var Consulta = conexion.LeerTodos(Nodo).Descendants("Usuario");

            List<BEUsuario> lista = new List<BEUsuario>();

            if (Consulta.Count() > 0)
            {
                 lista = (from x in Consulta
                             select new BEUsuario
                             {
                                 Id =  Convert.ToInt32((x.Element("Id").Value)),
                                 NombreUsuario = Convert.ToString(x.Element("NombreUsuario")?.Value),
                                 NombreCompleto = Convert.ToString(x.Element("NombreCompleto")?.Value),
                                 Password = Convert.ToString(x.Element("Password")?.Value),
                                 DNI = Convert.ToString(x.Element("DNI")?.Value),
                                 Ursa = new BEUrsa( Convert.ToInt32(Convert.ToString(x.Element("IdUrsa")?.Value))),
                                 Unidad = new BEUnidad( Convert.ToInt32(Convert.ToString(x.Element("IdUnidad")?.Value)))
                             }).ToList();
            }
            else
            {
                lista = null;
            }
            return lista;
        }

        public BEUsuario ListarObjeto(BEUsuario Usuario)
        {
            throw new NotImplementedException();
        }

        public DataSet ObtenerElementosReporte(BEUrsa ursa, BEUnidad unidad = null)
        {
            DataSet ds = new DataSet();
            //string Regional = ursa.Id == 6 ? "" : $" Where ( Unidad.[Id ursa] = {ursa.Id} )";
            //string Unidad = unidad == null ? "" : $" AND (  Unidad.Id =  {unidad.Id}  )";
            //DataTable Tabla;
            //conexion = new Conexion();


            //string consulta = "SELECT Ursa.Nombre AS Ursa, Unidad.Nombre AS Aeropuerto , Hallazgo.[Nro acta] AS Hallazgo, Hallazgo.[Fecha hallazgo] as [Fecha Hallazgo], " +
            //                  "Categoria.Categoria, Articulo.Articulo, Elemento.Cantidad , Elemento.Descripcion, Estado_Elemento.Estado, " +
            //                  "Hallazgo.[Lugar hallazgo], Entrega.[Nro acta] AS Entrega , Entrega.[Fecha Entrega] FROM Entrega " +
            //                  "RIGHT JOIN(Estado_Elemento INNER JOIN (Categoria INNER JOIN (Articulo INNER JOIN " +
            //                  "((Unidad INNER JOIN (Hallazgo INNER JOIN Elemento " +
            //                  "ON Hallazgo.Id = Elemento.[Id hallazgo]) " +
            //                  "ON Unidad.Id = Hallazgo.[Id unidad]) INNER JOIN Ursa " +
            //                  "ON Unidad.[Id ursa] = Ursa.Id) " +
            //                  "ON Articulo.Id = Elemento.[Id articulo]) " +
            //                  "ON Categoria.Id = Articulo.[Id categoria]) " +
            //                  "ON Estado_Elemento.Id = Elemento.[Id estado_elemento]) " +
            //                  "ON Entrega.Id = Elemento.[Id entrega]" +
            //                  $"{Regional} {Unidad} ";



            //Tabla = conexion.Leer(consulta);
            //Tabla.TableName = "Elementos";

            //ds.Tables.Add(Tabla);

            //consulta = "SELECT Ursa.Nombre AS Ursa , Unidad.Nombre AS Unidad, Hallazgo.[Nro acta] AS Hallazgo, Hallazgo.[Fecha hallazgo], " +
            //           " Hallazgo.Anio AS Año, Hallazgo.[Lugar hallazgo], Estado_Persona.Estado, Persona.DNI, Persona.[Nombre completo], Persona.Legajo" +
            //           " FROM Estado_Persona INNER JOIN((Unidad INNER JOIN (Persona INNER JOIN (Hallazgo INNER JOIN Hallazgo_Persona " +
            //           " ON Hallazgo.Id = Hallazgo_Persona.[Id Hallazgo]) " +
            //           " ON Persona.Id = Hallazgo_Persona.[Id persona]) " +
            //           " ON Unidad.Id = Hallazgo.[Id unidad]) INNER JOIN Ursa " +
            //           " ON Unidad.[Id ursa] = Ursa.Id) " +
            //           " ON Estado_Persona.Id = Hallazgo_Persona.[Id estado] " +
            //           $"{Regional} {Unidad} ";


            //Tabla = conexion.Leer(consulta);
            //Tabla.TableName = "Hallazgos - Actores";
            //ds.Tables.Add(Tabla);


            //consulta = " SELECT Ursa.Nombre AS Ursa , Unidad.Nombre AS Unidad, Entrega.[Nro acta] AS Entrega, Entrega.[Fecha entrega], " +
            //           " Entrega.Anio AS Año, Estado_Persona.Estado, Persona.DNI, Persona.[Nombre completo], Persona.Legajo" +
            //           " FROM Estado_Persona INNER JOIN ((Unidad INNER JOIN (Persona INNER JOIN (Entrega INNER JOIN Entrega_Persona " +
            //           " ON Entrega.Id = Entrega_Persona.[Id entrega]) " +
            //           " ON Persona.Id = Entrega_Persona.[Id persona]) " +
            //           " ON Unidad.Id = Entrega.[Id unidad]) INNER JOIN Ursa " +
            //           " ON Unidad.[Id ursa] = Ursa.Id) " +
            //           " ON Estado_Persona.Id = Entrega_Persona.[Id estado] " +
            //           $"{Regional} {Unidad} ";


            //Tabla = conexion.Leer(consulta);
            //Tabla.TableName = "Entrega - Actores";
            //ds.Tables.Add(Tabla);

            return ds;
        }

    }
}
