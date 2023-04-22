using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace MPP
{

    public class MPPHallazgo : IGestor<BEHallazgo>
    {
        Conexion conexion = new Conexion();
        public MPPHallazgo() { }


        public BEHallazgo Agregar(BEHallazgo pHallazgo)
        {
            string consulta = string.Empty;


            consulta = "INSERT INTO Hallazgo ( [Id unidad], [Nro acta],[Anio],[Fecha hallazgo] ,[Lugar hallazgo]) " +
                       $"VALUES({pHallazgo.Unidad.Id}," +
                       $"'{pHallazgo.NroActa}' , " +
                       $"{pHallazgo.Anio} ," +
                       $"'{pHallazgo.FechaHallazgo.ToString("dd/MM/yyyy HH:mm")}'," +
                       $"'{pHallazgo.LugarHallazgo.Trim()}')";

            conexion.Escribir(consulta);
            DataTable Tabla = conexion.Leer($"Select Id From Hallazgo WHERE ( [Nro acta] = '{pHallazgo.NroActa} ') ");
            pHallazgo.Id = Convert.ToInt32(Tabla.Rows[0]["Id"]);

            return pHallazgo;
        }
        public bool Eliminar(BEHallazgo pHallazgo)
        {
            string consulta = "";

            if (pHallazgo.listaPersonas != null)
            {
                consulta = $"DELETE FROM Hallazgo_Persona WHERE ([Id hallazgo] =  {pHallazgo.Id})";
                conexion.Escribir(consulta);
            }

            consulta = $"DELETE FROM Hallazgo WHERE ( Hallazgo.[Id] = {pHallazgo.Id})";


            return conexion.Escribir(consulta);
        }

        public bool Actualizar(BEHallazgo pHallazgo)
        {
            string consulta = string.Empty;


            consulta = $"UPDATE  Hallazgo SET  [Id unidad] = {pHallazgo.Unidad.Id}" +
                       $", [Nro acta] = '{pHallazgo.NroActa}' " +
                       $", [Anio] ={pHallazgo.Anio}  " +
                       $", [Fecha Hallazgo] = '{pHallazgo.FechaHallazgo.ToString("dd/MM/yyyy HH:mm")}'" +
                       $", [Lugar Hallazgo] ='{pHallazgo.LugarHallazgo.Trim()}'" +
                       $"  WHERE ([Id] =  {pHallazgo.Id})";



            return conexion.Escribir(consulta);
        }
        public bool VerificarSiExisteNroHallazgo(string NroHallazgo)
        {
            string consulta = string.Empty;
            consulta = $" SELECT  [Nro acta] FROM Hallazgo where [Nro acta] = '{NroHallazgo}'";
            DataTable dt;
            dt = conexion.Leer(consulta);
            if (dt.Rows.Count > 0) return true;
            else return false;

        }

        public string ObtenerNroHallazgo(BEUnidad unidad, int anio)
        {

            DataTable Tabla;
            string NroActa = "";
            string consulta = "SELECT  TOP 1 [Nro acta] " +
                               " FROM Hallazgo " +
                              $" WHERE ( [id Unidad] =  {unidad.Id}  AND   Anio = {anio} )" +
                               " ORDER BY  [Nro acta] DESC ";

            Tabla = conexion.Leer(consulta);


            if (Tabla.Rows.Count == 0)
            {
                NroActa = "";
            }
            else
            {
                NroActa = Tabla.Rows[0]["Nro acta"].ToString();
            }

            return NroActa;
        }

        public List<BEHallazgo> ListarTodo()
        {
            List<BEHallazgo> list = new List<BEHallazgo>();

            string consulta = string.Empty;
            consulta = "SELECT Hallazgo.*, Unidad.*, Ursa.* FROM (Unidad INNER JOIN Hallazgo ON Unidad.Id = Hallazgo.[Id unidad]) INNER JOIN Ursa ON Unidad.[Id ursa] = Ursa.Id;";

            DataTable dt;
            dt = conexion.Leer(consulta);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    BEHallazgo bEHallazgo = new BEHallazgo();
                    bEHallazgo.Id = Convert.ToInt32(fila["Hallazgo.Id"]);
                    bEHallazgo.NroActa = fila["Nro acta"].ToString();
                    bEHallazgo.FechaHallazgo = Convert.ToDateTime(fila["Fecha hallazgo"]);
                    bEHallazgo.LugarHallazgo = fila["Lugar hallazgo"].ToString();
                    bEHallazgo.Anio = Convert.ToInt32(fila["Anio"]);
                    bEHallazgo.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);

                    bEHallazgo.Unidad = new BEUnidad(Convert.ToInt32(fila["Id unidad"]));
                    bEHallazgo.Unidad.NombreUnidad = fila["Unidad.Nombre"].ToString();
                    bEHallazgo.Unidad.Ursa = new BEUrsa(Convert.ToInt32(fila["Id ursa"]));
                    bEHallazgo.Unidad.Ursa.NombreUrsa = fila["Ursa.Nombre"].ToString();

                    list.Add(bEHallazgo);
                }
            }

            return list;
        }

        public List<BEHallazgo> ListarTodo(BEUnidad unidad, int Anio)
        {
            List<BEHallazgo> list = new List<BEHallazgo>();

            string consulta = string.Empty;
            consulta = $" SELECT * FROM Hallazgo where ([Id unidad] = {unidad.Id} AND Anio = {Anio} ) ORDER BY  [Nro acta] DESC ";

            DataTable dt;
            dt = conexion.Leer(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    BEHallazgo bEHallazgo = new BEHallazgo();
                    bEHallazgo.Id = Convert.ToInt32(fila["Id"]);
                    bEHallazgo.NroActa = fila["Nro acta"].ToString();
                    bEHallazgo.FechaHallazgo = Convert.ToDateTime(fila["Fecha hallazgo"]);
                    bEHallazgo.LugarHallazgo = fila["Lugar hallazgo"].ToString();
                    bEHallazgo.Anio = Convert.ToInt32(fila["Anio"]);
                    bEHallazgo.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);

                    bEHallazgo.Unidad = unidad;

                    list.Add(bEHallazgo);
                }
            }
            return list;
        }

        public List<BEHallazgo> ListarTodo(BEUnidad unidad, DateTime fecha)
        {
            List<BEHallazgo> list = new List<BEHallazgo>();
            int Anio = fecha.Year;
            int Mes = fecha.Month;


            string consulta = string.Empty;
            
            consulta = $" SELECT * FROM Hallazgo " +
                       $"where ([Id unidad] = {unidad.Id} AND " +
                       $"Anio = {Anio} AND  Month([Fecha hallazgo]) ={Mes} )  ORDER BY  [Nro acta] DESC ";

            DataTable dt;
            dt = conexion.Leer(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    BEHallazgo bEHallazgo = new BEHallazgo();
                    bEHallazgo.Id = Convert.ToInt32(fila["Id"]);
                    bEHallazgo.NroActa = fila["Nro acta"].ToString();
                    bEHallazgo.FechaHallazgo = Convert.ToDateTime(fila["Fecha hallazgo"]);
                    bEHallazgo.LugarHallazgo = fila["Lugar hallazgo"].ToString();
                    bEHallazgo.Anio = Convert.ToInt32(fila["Anio"]);
                    bEHallazgo.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);

                    bEHallazgo.Unidad = unidad;

                    list.Add(bEHallazgo);
                }
            }
            return list;
        }


        public BEHallazgo ListarObjeto(BEHallazgo bEHallazgo)
        {

            string consulta = string.Empty;
            consulta = $"SELECT * FROM Hallazgo where (Id = {bEHallazgo.Id})";



            DataTable dt;
            dt = conexion.Leer(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    bEHallazgo.Id = Convert.ToInt32(fila["Id"]);
                    bEHallazgo.NroActa = fila["Nro Acta"].ToString();
                    bEHallazgo.FechaHallazgo = Convert.ToDateTime(fila["Fecha hallazgo"]);
                    bEHallazgo.LugarHallazgo = fila["Lugar hallazgo"].ToString();
                    bEHallazgo.Anio = Convert.ToInt32(fila["Anio"]);
                    bEHallazgo.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);


                    string Consulta2 = "SELECT Elemento.Id, Elemento.Cantidad, Elemento.Descripcion, Estado_Elemento.Id, " +
                                        "Estado_Elemento.Estado, Articulo.Id, Articulo.Articulo, Categoria.Id, " +
                                        "Categoria.Categoria FROM Estado_Elemento INNER JOIN " +
                                        "( Categoria INNER JOIN (Articulo INNER JOIN Elemento " +
                                        " ON Articulo.Id = Elemento.[Id articulo])" +
                                        " ON Categoria.Id = Articulo.[Id categoria])" +
                                        " ON Estado_Elemento.Id = Elemento.[Id estado_elemento]" +
                                        $" WHERE ( Elemento.[Id hallazgo] = {bEHallazgo.Id} );";

                    DataTable DtElemento = conexion.Leer(Consulta2);


                    if (DtElemento.Rows.Count > 0)
                    {
                        bEHallazgo.listaElementos = new List<BEElemento>();
                        foreach (DataRow x in DtElemento.Rows)
                        {
                            BEElemento elemento = new BEElemento(Convert.ToInt32(x["Elemento.Id"]));
                            elemento.Cantidad = double.Parse(x["Cantidad"].ToString());
                            elemento.Descripcion = x["Descripcion"].ToString();
                            elemento.Estado = new BEEstado_Elemento(Convert.ToInt32(x["Estado_Elemento.Id"]), x["Estado"].ToString());
                            BECategoria categoria = new BECategoria(Convert.ToInt32(x["Categoria.Id"]), x["Categoria"].ToString());
                            elemento.Articulo = new BEArticulo(Convert.ToInt32(x["Articulo.Id"]), x["Articulo"].ToString(), categoria);
                            bEHallazgo.listaElementos.Add(elemento);
                        }
                    }
                    else
                    {
                        bEHallazgo.listaElementos = null;
                    }

                    string Consulta3 = "SELECT Hallazgo_Persona.[Id Hallazgo], Persona.*, Jerarquia.*, Estado_Persona.*" +
                                       "FROM Estado_Persona INNER JOIN (Jerarquia RIGHT JOIN (Persona INNER JOIN Hallazgo_Persona " +
                                       "ON Persona.Id = Hallazgo_Persona.[Id persona]) " +
                                       "ON Jerarquia.Id = Persona.[Id jerarquia]) " +
                                       "ON Estado_Persona.Id = Hallazgo_Persona.[Id estado] " +
                                       $"WHERE ( [Id hallazgo] = {bEHallazgo.Id});";

                    DataTable DtPersona = conexion.Leer(Consulta3);


                    if (DtPersona.Rows.Count > 0)
                    {
                        bEHallazgo.listaPersonas = new List<BEPersona>();

                        foreach (DataRow y in DtPersona.Rows)
                        {
                            BEPersona persona;

                            BEEstado_Persona estado = new BEEstado_Persona(Convert.ToInt32(y["Estado_Persona.Id"]), y["Estado"].ToString());

                            if (estado.Estado == "Instructor")
                            {
                                BEJerarquia bEJerarquia = new BEJerarquia(Convert.ToInt32(y["Id jerarquia"]), y["Jerarquia"].ToString(), y["Abreviatura"].ToString());
                                persona = new BEInstructor(Convert.ToInt32(y["Persona.Id"]), y["Nombre completo"].ToString(), y["DNI"].ToString(), Convert.ToInt32(y["Legajo"]), bEJerarquia);
                            }
                            else
                            {
                                persona = new BEPersona(Convert.ToInt32(y["Persona.Id"]), y["Nombre completo"].ToString(), y["DNI"].ToString());
                                persona.Domicilio = y["Domicilio"].ToString();
                                persona.Ocupacion = y["Ocupacion"].ToString();
                                persona.Telefono = y["Telefono"].ToString();
                            }
                            persona.EstadoPersona = estado;



                            bEHallazgo.listaPersonas.Add(persona);

                        }
                    }
                    else
                    {
                        bEHallazgo.listaPersonas = null;
                    }
                }
            }
            return bEHallazgo;
        }

        public BEHallazgo ListarObjetoPersonas(BEHallazgo bEHallazgo)
        {

            string consulta = string.Empty;

            MPPPersona mPPPersona = new MPPPersona();
            MPPInstructor mPPInstructor = new MPPInstructor();
            MPPEstado_Persona mPPEstado_Persona = new MPPEstado_Persona();
            var EstadosPersona = mPPEstado_Persona.ListarTodo();



            string Consulta3 = "SELECT Hallazgo_Persona.[Id Hallazgo], Persona.*, Jerarquia.*, Estado_Persona.*" +
                                  "FROM Estado_Persona INNER JOIN (Jerarquia RIGHT JOIN (Persona INNER JOIN Hallazgo_Persona " +
                                  "ON Persona.Id = Hallazgo_Persona.[Id persona]) " +
                                  "ON Jerarquia.Id = Persona.[Id jerarquia]) " +
                                  "ON Estado_Persona.Id = Hallazgo_Persona.[Id estado] " +
                                  $"WHERE ( [Id hallazgo] = {bEHallazgo.Id});";

            DataTable DtPersona = conexion.Leer(Consulta3);


            if (DtPersona.Rows.Count > 0)
            {
                bEHallazgo.listaPersonas = new List<BEPersona>();

                foreach (DataRow y in DtPersona.Rows)
                {
                    BEPersona persona;

                    BEEstado_Persona estado = new BEEstado_Persona(Convert.ToInt32(y["Estado_Persona.Id"]), y["Estado"].ToString());

                    if (estado.Estado == "Instructor")
                    {
                        BEJerarquia bEJerarquia = new BEJerarquia(Convert.ToInt32(y["Id jerarquia"]), y["Jerarquia"].ToString(), y["Abreviatura"].ToString());
                        persona = new BEInstructor(Convert.ToInt32(y["Persona.Id"]), y["Nombre completo"].ToString(), y["DNI"].ToString(), Convert.ToInt32(y["Legajo"]), bEJerarquia);
                    }
                    else
                    {
                        persona = new BEPersona(Convert.ToInt32(y["Persona.Id"]), y["Nombre completo"].ToString(), y["DNI"].ToString());
                        persona.Domicilio = y["Domicilio"].ToString();
                        persona.Ocupacion = y["Ocupacion"].ToString();
                        persona.Telefono = y["Telefono"].ToString();
                    }
                    persona.EstadoPersona = estado;
                    bEHallazgo.listaPersonas.Add(persona);

                }
            }
            else
            {
                bEHallazgo.listaPersonas = null;
            }
            return bEHallazgo;
        }

        public BEHallazgo ListarObjetoElementos(BEHallazgo bEHallazgo)
        {




            string consulta = "SELECT Elemento.Id, Elemento.Cantidad, Elemento.Descripcion, Estado_Elemento.Id, " +
                                      "Estado_Elemento.Estado, Articulo.Id, Articulo.Articulo, Categoria.Id, " +
                                      "Categoria.Categoria FROM Estado_Elemento INNER JOIN " +
                                      "( Categoria INNER JOIN (Articulo INNER JOIN Elemento " +
                                      " ON Articulo.Id = Elemento.[Id articulo])" +
                                      " ON Categoria.Id = Articulo.[Id categoria])" +
                                      " ON Estado_Elemento.Id = Elemento.[Id estado_elemento]" +
                                      $" WHERE ( Elemento.[Id hallazgo] = {bEHallazgo.Id} );";

            DataTable DtElemento = conexion.Leer(consulta);



            if (DtElemento.Rows.Count > 0)
            {
                bEHallazgo.listaElementos = new List<BEElemento>();
                foreach (DataRow x in DtElemento.Rows)
                {
                    BEElemento elemento = new BEElemento(Convert.ToInt32(x["Elemento.Id"]));
                    elemento.Cantidad = double.Parse(x["Cantidad"].ToString());
                    elemento.Descripcion = x["Descripcion"].ToString();
                    elemento.Estado = new BEEstado_Elemento(Convert.ToInt32(x["Estado_Elemento.Id"]), x["Estado"].ToString());
                    BECategoria categoria = new BECategoria(Convert.ToInt32(x["Categoria.Id"]), x["Categoria"].ToString());
                    elemento.Articulo = new BEArticulo(Convert.ToInt32(x["Articulo.Id"]), x["Articulo"].ToString(), categoria);
                    bEHallazgo.listaElementos.Add(elemento);
                }
            }
            else
            {
                bEHallazgo.listaElementos = null;
            }

            return bEHallazgo;
        }
    }
}
