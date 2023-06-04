using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<BEInstructor> ListarTodo()
        {
            string Nodo = "Instructores";
            var Consulta = conexion.Leer2(Nodo).Descendants("Instructor");

            List<BEInstructor> lista = new List<BEInstructor>();

            if (Consulta.Count() > 0)
            {
              var  lista2 = from x in Consulta
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
