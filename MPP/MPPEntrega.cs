using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;




namespace MPP
{
    public class MPPEntrega : IGestor<BEEntrega>
    {
        Conexion conexion = new Conexion();
        public MPPEntrega() { }

        public BEEntrega Agregar(BEEntrega entrega)
        {
            string consulta = string.Empty;

            consulta = "INSERT INTO Entrega " +
                        "([Id unidad],[Nro acta],[Anio],[Fecha entrega]) " +
                        $"VALUES({entrega.Unidad.Id}," +
                        $"'{entrega.NroActa}'," +
                        $"{entrega.Anio}," +
                        $"'{entrega.Fecha_entrega.ToString("dd/MM/yyyy HH:mm")}')";


            conexion.Escribir(consulta);
            DataTable Tabla = conexion.Leer($"Select Id From Entrega WHERE ( [Nro acta] = '{entrega.NroActa} ') ");
            entrega.Id = Convert.ToInt32(Tabla.Rows[0]["Id"]);
            return entrega;
        }


        public bool VerificarSiExisteNroEntrega(string NroEntrega)
        {
            string consulta = string.Empty;
            consulta = $" SELECT  [Nro acta] FROM Entrega where [Nro acta] = '{NroEntrega}'";
            DataTable dt;
            dt = conexion.Leer(consulta);
            if (dt.Rows.Count > 0) return true;
            else return false;

        }

        public bool Actualizar(BEEntrega entrega)
        {
            string consulta = string.Empty;
            consulta = $"UPDATE  Entrega SET  [Id unidad] = {entrega.Unidad.Id}" +
                       $", [Nro acta] = '{entrega.NroActa}' " +
                       $", [Anio] = {entrega.Anio} " +
                       $", [Fecha entrega] = '{entrega.Fecha_entrega.ToString("dd/MM/yyyy HH:mm")}'" +
                       $"  WHERE ( [Id] =  {entrega.Id})";

            return conexion.Escribir(consulta);
        }

        public bool Eliminar(BEEntrega pEntrega)
        {
            string consulta = "";

            MPPElemento mPPElemento = new MPPElemento();

            if (pEntrega.listaPersonas != null)
            {
                consulta = $"DELETE FROM Entrega_Persona WHERE( [Id entrega] =  {pEntrega.Id} )";
                return conexion.Escribir(consulta);
            }
            if (pEntrega.listaElementos != null)
            {
                foreach (var item in pEntrega.listaElementos)
                {
                    mPPElemento.Eliminar_Elemento_Entrega(item);
                }
            }

            consulta = $"DELETE FROM Entrega WHERE ( Id = {pEntrega.Id})";


            return conexion.Escribir(consulta);
        }

        public string ObtenerNroEntrega(BEUnidad unidad, int anio)
        {

            DataTable Tabla;
            string NroActa = "";
            string consulta = " SELECT  TOP 1 [Nro acta] " +
                               " FROM Entrega " +
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
        public BEEntrega ListarObjeto(BEEntrega pEntrega)

        {
            string consulta = string.Empty;
            consulta = $"SELECT * From Entrega WHERE (Id = {pEntrega.Id} )";



            DataTable dt;
            dt = conexion.Leer(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    pEntrega.Id = int.Parse(fila["Id"].ToString());
                    pEntrega.NroActa = fila["Nro acta"].ToString();
                    pEntrega.Fecha_entrega = Convert.ToDateTime(fila["Fecha Entrega"]);
                    pEntrega.Anio = int.Parse(fila["anio"].ToString());
                    pEntrega.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);


                    string Consulta2 = "SELECT Elemento.Id, Elemento.Cantidad, Elemento.Descripcion, Estado_Elemento.Id, " +
                                        "Estado_Elemento.Estado, Articulo.Id, Articulo.Articulo, Categoria.Id, " +
                                        "Categoria.Categoria FROM Estado_Elemento INNER JOIN " +
                                        "( Categoria INNER JOIN (Articulo INNER JOIN Elemento " +
                                        " ON Articulo.Id = Elemento.[Id articulo])" +
                                        " ON Categoria.Id = Articulo.[Id categoria])" +
                                        " ON Estado_Elemento.Id = Elemento.[Id estado_elemento]" +
                                        $" WHERE ( Elemento.[Id entrega] = {pEntrega.Id} );";

                    DataTable DtElemento = conexion.Leer(Consulta2);




                    // DataTable DtElemento = conexion.Leer($"Select * From Elemento where ([Id entrega] = {pEntrega.Id} )");

                    if (DtElemento.Rows.Count > 0)
                    {
                        pEntrega.listaElementos = new List<BEElemento>();
                        foreach (DataRow x in DtElemento.Rows)
                        {
                            BEElemento elemento = new BEElemento(Convert.ToInt32(x["Elemento.Id"]));
                            elemento.Cantidad = double.Parse(x["Cantidad"].ToString());
                            elemento.Descripcion = x["Descripcion"].ToString();
                            elemento.Estado = new BEEstado_Elemento(Convert.ToInt32(x["Estado_Elemento.Id"]), x["Estado"].ToString());
                            BECategoria categoria = new BECategoria(Convert.ToInt32(x["Categoria.Id"]), x["Categoria"].ToString());
                            elemento.Articulo = new BEArticulo(Convert.ToInt32(x["Articulo.Id"]), x["Articulo"].ToString(), categoria);
                            pEntrega.listaElementos.Add(elemento);
                        }
                    }
                    else
                    {
                        pEntrega.listaElementos = null;
                    }

                    string Consulta3 = "SELECT Entrega_Persona.[Id Entrega], Persona.*, Jerarquia.*, Estado_Persona.*" +
                                      "FROM Estado_Persona INNER JOIN (Jerarquia RIGHT JOIN (Persona INNER JOIN Entrega_Persona " +
                                      "ON Persona.Id = Entrega_Persona.[Id persona]) " +
                                      "ON Jerarquia.Id = Persona.[Id jerarquia]) " +
                                      "ON Estado_Persona.Id = Entrega_Persona.[Id estado] " +
                                      $"WHERE ( [Id entrega] = {pEntrega.Id});";

                    DataTable DtPersona = conexion.Leer(Consulta3);


                    if (DtPersona.Rows.Count > 0)
                    {
                        pEntrega.listaPersonas = new List<BEPersona>();

                        foreach (DataRow y in DtPersona.Rows)
                        {
                            BEPersona persona;

                            BEEstado_Persona estado = new BEEstado_Persona(Convert.ToInt32(y["Estado_Persona.Id"]), y["Estado"].ToString());

                            if (estado.Nombre == "Instructor")
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
                            pEntrega.listaPersonas.Add(persona);

                        }
                    }
                    else
                    {
                        pEntrega.listaPersonas = null;
                    }
                }
            }
            else
            { pEntrega = null; }

            return pEntrega;

        }

        public BEEntrega ListarObjetoPersonas(BEEntrega pEntrega)

        {

            string Consulta3 = "SELECT Entrega_Persona.[Id Entrega], Persona.*, Jerarquia.*, Estado_Persona.*" +
                                       "FROM Estado_Persona INNER JOIN (Jerarquia RIGHT JOIN (Persona INNER JOIN Entrega_Persona " +
                                       "ON Persona.Id = Entrega_Persona.[Id persona]) " +
                                       "ON Jerarquia.Id = Persona.[Id jerarquia]) " +
                                       "ON Estado_Persona.Id = Entrega_Persona.[Id estado] " +
                                       $"WHERE ( [Id entrega] = {pEntrega.Id});";

            DataTable DtPersona = conexion.Leer(Consulta3);

            if (DtPersona.Rows.Count > 0)
            {
                pEntrega.listaPersonas = new List<BEPersona>();

                foreach (DataRow y in DtPersona.Rows)
                {
                    BEPersona persona;

                    BEEstado_Persona estado = new BEEstado_Persona(Convert.ToInt32(y["Estado_Persona.Id"]), y["Estado"].ToString());

                    if (estado.Nombre == "Instructor")
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



                    pEntrega.listaPersonas.Add(persona);

                }
            }
            else
            {
                pEntrega.listaPersonas = null;
            }

            return pEntrega;
        }

        public BEEntrega ListarObjetoElementos(BEEntrega pEntrega)

        {
            string consulta = string.Empty;


            string Consulta2 = "SELECT Elemento.Id, Elemento.Cantidad, Elemento.Descripcion, Estado_Elemento.Id, " +
                                         "Estado_Elemento.Estado, Articulo.Id, Articulo.Articulo, Categoria.Id, " +
                                         "Categoria.Categoria FROM Estado_Elemento INNER JOIN " +
                                         "( Categoria INNER JOIN (Articulo INNER JOIN Elemento " +
                                         " ON Articulo.Id = Elemento.[Id articulo])" +
                                         " ON Categoria.Id = Articulo.[Id categoria])" +
                                         " ON Estado_Elemento.Id = Elemento.[Id estado_elemento]" +
                                         $" WHERE ( Elemento.[Id entrega] = {pEntrega.Id} );";

            DataTable DtElemento = conexion.Leer(Consulta2);



            if (DtElemento.Rows.Count > 0)
            {
                pEntrega.listaElementos = new List<BEElemento>();
                foreach (DataRow x in DtElemento.Rows)
                {
                    BEElemento elemento = new BEElemento(Convert.ToInt32(x["Elemento.Id"]));
                    elemento.Cantidad = double.Parse(x["Cantidad"].ToString());
                    elemento.Descripcion = x["Descripcion"].ToString();
                    elemento.Estado = new BEEstado_Elemento(Convert.ToInt32(x["Estado_Elemento.Id"]), x["Estado"].ToString());
                    BECategoria categoria = new BECategoria(Convert.ToInt32(x["Categoria.Id"]), x["Categoria"].ToString());
                    elemento.Articulo = new BEArticulo(Convert.ToInt32(x["Articulo.Id"]), x["Articulo"].ToString(), categoria);
                    pEntrega.listaElementos.Add(elemento);
                }
            }
            else
            {
                pEntrega.listaElementos = null;
            }


            return pEntrega;

        }

        public List<BEEntrega> ListarTodo()
        {
            string consulta = string.Empty;

            consulta = "SELECT Entrega.*, Unidad.*, Ursa.* FROM (Unidad INNER JOIN Entrega ON Unidad.Id = Entrega.[Id unidad]) INNER JOIN Ursa ON Unidad.[Id ursa] = Ursa.Id;";


            List<BEEntrega> lista = new List<BEEntrega>();


            DataTable dt;
            dt = conexion.Leer(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    BEEntrega pEntrega = new BEEntrega();
                    pEntrega.Id = int.Parse(fila["Id"].ToString());
                    pEntrega.NroActa = fila["Nro acta"].ToString();
                    pEntrega.Fecha_entrega = Convert.ToDateTime(fila["Fecha entrega"]);
                    pEntrega.Anio = int.Parse(fila["anio"].ToString());
                    pEntrega.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);

                    pEntrega.Unidad = new BEUnidad(Convert.ToInt32(fila["Id unidad"]));
                    pEntrega.Unidad.Nombre = fila["Unidad.Nombre"].ToString();
                    pEntrega.Unidad.Ursa = new BEUrsa(Convert.ToInt32(fila["Id ursa"]));
                    pEntrega.Unidad.Ursa.Nombre = fila["Ursa.Nombre"].ToString();


                    lista.Add(pEntrega);
                }
            }
            else
            { lista = null; }

            return lista;

        }

        public List<BEEntrega> ListarTodo(BEUnidad unidad, int Anio)
        {
            List<BEEntrega> list = new List<BEEntrega>();


            string consulta = string.Empty;
            consulta = $" SELECT * FROM Entrega where ([Id unidad] = {unidad.Id} AND Anio = {Anio}) " +
                       $" ORDER BY [Nro acta] DESC ";

            DataTable dt;
            dt = conexion.Leer(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    BEEntrega Entrega = new BEEntrega();
                    Entrega.Id = Convert.ToInt32(fila["Id"]);
                    Entrega.NroActa = fila["Nro acta"].ToString();
                    Entrega.Fecha_entrega = Convert.ToDateTime(fila["Fecha entrega"]);
                    Entrega.Anio = Convert.ToInt32(fila["Anio"]);
                    Entrega.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);

                    Entrega.Unidad = unidad;

                    list.Add(Entrega);
                }
            }
            return list;
        }

        public List<BEEntrega> ListarTodo(BEUnidad unidad, DateTime fecha)
        {
            List<BEEntrega> list = new List<BEEntrega>();
         
            int Anio = fecha.Year;
            int Mes = fecha.Month;

            string consulta = string.Empty;
            consulta = $" SELECT * FROM Entrega where ([Id unidad] = {unidad.Id} AND Anio = {Anio} AND Month([Fecha entrega]) ={Mes} ) " +
                       $" ORDER BY [Nro acta] DESC ";

            DataTable dt;
            dt = conexion.Leer(consulta);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    BEEntrega Entrega = new BEEntrega();
                    Entrega.Id = Convert.ToInt32(fila["Id"]);
                    Entrega.NroActa = fila["Nro acta"].ToString();
                    Entrega.Fecha_entrega = Convert.ToDateTime(fila["Fecha entrega"]);
                    Entrega.Anio = Convert.ToInt32(fila["Anio"]);
                    Entrega.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);

                    Entrega.Unidad = unidad;

                    list.Add(Entrega);
                }
            }
            return list;
        }
    }
}
