using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPPElemento : IGestor<BEElemento>
    {
        Conexion conexion = new Conexion();

        public BEElemento Agregar(BEElemento pElemento)
        {

            throw new NotImplementedException();
        }

        public bool Agregar_Elemento_Hallazgo(BEHallazgo hallazgo, BEElemento elemento)
        {
            string consulta = "INSERT INTO Elemento ([Id articulo], [Id estado_elemento],[Id hallazgo], [Descripcion],[Cantidad] )" +
                            $"VALUES( {elemento.Articulo.Id} ," +
                            $"{elemento.Estado.Id}," +
                            $"{hallazgo.Id}," +
                            $"'{elemento.Descripcion}'," +
                            $"'{elemento.Cantidad}')";

            return conexion.Escribir(consulta);
        }


        public bool Agregar_Elemento_Entrega(BEEntrega entrega, BEElemento elemento)
        {
            string consulta = $" UPDATE Elemento SET [Id entrega] = {entrega.Id} " +
                              $" WHERE ( Id = {elemento.Id})";
            return conexion.Escribir(consulta);
        }

        public bool Eliminar_Elemento_Entrega(BEElemento elemento)
        {
            string consulta = consulta = $" UPDATE  Elemento SET  [Id entrega] = NULL" +
                                         $" WHERE ( Id = {elemento.Id} )";
            return conexion.Escribir(consulta);
        }

        public bool Actualizar(BEElemento pElemento)
        {

            string consulta = $" UPDATE  Elemento SET  [id articulo] = {pElemento.Articulo.Id}, " +
                                $" [Id estado_elemento] = {pElemento.Estado.Id}, " +
                                $" Descripcion = '{pElemento.Descripcion}'," +
                                $" Cantidad =  '{pElemento.Cantidad}'" +
                                $" WHERE( Id = {pElemento.Id} )";

            return conexion.Escribir(consulta);
        }
        public bool Eliminar(BEElemento pElemento)
        {

            string consulta = $"DELETE FROM Elemento WHERE (Id =  {pElemento.Id}  )";

            return conexion.Escribir(consulta);

        }

        public string ObtenerNroHallazgo(BEElemento bEElemento)
        {
            string Nro = "";
            string consulta = $"Select [Nro acta] From Hallazgo inner join Elemento ON  Elemento.[Id hallazgo]  =  Hallazgo.Id  where (Elemento.Id = {bEElemento.Id} ) ";
            DataTable Tabla = conexion.Leer(consulta);
            if (Tabla.Rows.Count > 0)
            {
                Nro = Tabla.Rows[0]["Nro acta"].ToString();
            }
            return Nro;
        }
        public string ObtenerNroEntrega(BEElemento bEElemento)
        {
            string Nro = "";
            string consulta = $"Select  [Nro acta] From Entrega inner join Elemento ON  Elemento.[Id entrega]  =  Entrega.Id  where ( Elemento.[Id] = {bEElemento.Id} ) ";
            DataTable Tabla = conexion.Leer(consulta);
            if (Tabla.Rows.Count > 0)
            {
                Nro = Tabla.Rows[0]["Nro acta"].ToString();
            }
            return Nro;
        }

        public List<BEElemento> ListarTodo()
        {
            string consulta = "Select * From Elemento";

            List<BEElemento> lista = new List<BEElemento>();

            DataTable Tabla = conexion.Leer(consulta);




            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEElemento bElemento = new BEElemento();
                    bElemento.Id = Convert.ToInt32(fila["Id"]);
                    bElemento.Cantidad = double.Parse(fila["Cantidad"].ToString());
                    bElemento.Descripcion = fila["Descripcion"].ToString();

                    lista.Add(bElemento);
                }
            }

            return lista;
        }
        public BEElemento ListarObjeto(BEElemento bElemento)
        {
            string consulta = $"Select * From ELemento where (Id = {bElemento.Id} ) ";

            DataTable Tabla = conexion.Leer(consulta);
            MPPArticulo mPPArticulo = new MPPArticulo();
            MPPEstado_Elemento mPPEstado_Articulo = new MPPEstado_Elemento();


            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    bElemento.Id = Convert.ToInt32(fila["Id"]);
                    bElemento.Cantidad = double.Parse(fila["Cantidad"].ToString());
                    bElemento.Descripcion = fila["Descripcion"].ToString();

                    BEEstado_Elemento bEEstado = new BEEstado_Elemento(Convert.ToInt32(fila["Id estado_elemento"]));
                    bElemento.Estado = mPPEstado_Articulo.ListarObjeto(bEEstado);


                    BEArticulo articulo = new BEArticulo(Convert.ToInt32(fila["id articulo"]));
                    bElemento.Articulo = mPPArticulo.ListarObjeto(articulo);
                }
            }

            return bElemento;
        }


        public List<ElementoBusqueda> BusquedaElementos(BEArticulo bEArticulo, string PDescripcion, string LugarHallazgo, DateTime? pDia, int anio, BEUnidad unidad)
        {

            List<ElementoBusqueda> lista = new List<ElementoBusqueda>();

            string Lugar = LugarHallazgo == "" ? "" : $" AND (Hallazgo.[Lugar hallazgo] LIKE '%{LugarHallazgo}%')";
            string descrípcion = PDescripcion == "" ? "" : $" AND (Elemento.Descripcion LIKE '%{PDescripcion}%')";
            string Articulo = bEArticulo == null ? "" : $" AND (Elemento.[id articulo] = {bEArticulo.Id})";
            string Dia = pDia == null ? "" : $" AND ( FORMAT(Hallazgo.[Fecha hallazgo], 'dd/mm/yyyy') = '{pDia.Value.ToString("dd/MM/yyyy")}')";
            DataTable Tabla;

            string consulta = $"SELECT Elemento.Id, Elemento.Descripcion, Elemento.Cantidad, " +
                               $"Estado_Elemento.Estado, Hallazgo.[Nro acta], Hallazgo.[Lugar hallazgo], " +
                               $"Articulo.Articulo, Entrega.[Nro acta], FORMAT(Hallazgo.[Fecha hallazgo], 'dd/mm/yyyy') AS [Fecha hallazgo]  " +
                               $"FROM Entrega RIGHT JOIN (Estado_Elemento INNER JOIN (Hallazgo INNER JOIN (Articulo INNER JOIN Elemento " +
                               $"ON Articulo.Id = Elemento.[Id articulo]) " +
                               $"ON Hallazgo.Id = Elemento.[Id hallazgo]) " +
                               $"ON Estado_Elemento.Id = Elemento.[Id estado_elemento]) " +
                               $"ON Entrega.Id = Elemento.[Id entrega] " +
                               $"WHERE (  (Hallazgo.[Id unidad] = {unidad.Id}) AND (Hallazgo.Anio = {anio}) {Dia}   {Lugar} {Articulo}  {descrípcion} );";

            Tabla = conexion.Leer(consulta);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    ElementoBusqueda bElemento = new ElementoBusqueda();
                    bElemento.Id = Convert.ToInt32(fila["Id"]);
                    bElemento.Cantidad = fila["Cantidad"].ToString();
                    bElemento.Descripcion = fila["Descripcion"].ToString();
                    bElemento.Articulo = fila["Articulo"].ToString();
                    bElemento.Estado = fila["Estado"].ToString();
                    bElemento.Hallazgo = fila["Hallazgo.Nro acta"].ToString();
                    bElemento.Lugar = fila["Lugar hallazgo"].ToString();
                    bElemento.Entrega = fila["Entrega.Nro acta"].ToString();
                    bElemento.Fecha_hallazgo = fila["Fecha hallazgo"].ToString();


                    lista.Add(bElemento);
                }
            }

            return lista;

        }


        public List<ElementoBusqueda> BusquedaElementosHallazgo(string nroActa, string lugar)
        {
            List<ElementoBusqueda> lista = new List<ElementoBusqueda>();

            DataTable Tabla;


            string Consulta2 = $"SELECT Elemento.Id, Elemento.Descripcion, Elemento.Cantidad, " +
                               $"Estado_Elemento.Estado, Hallazgo.[Nro acta], Hallazgo.[Lugar hallazgo], " +
                               $"Articulo.Articulo, Entrega.[Nro acta], FORMAT(Hallazgo.[Fecha hallazgo], 'dd/mm/yyyy') AS [Fecha hallazgo] " +
                               $"FROM Entrega RIGHT JOIN (Estado_Elemento INNER JOIN (Hallazgo INNER JOIN (Articulo INNER JOIN Elemento " +
                               $"ON Articulo.Id = Elemento.[Id articulo]) " +
                               $"ON Hallazgo.Id = Elemento.[Id hallazgo]) " +
                               $"ON Estado_Elemento.Id = Elemento.[Id estado_elemento]) " +
                               $"ON Entrega.Id = Elemento.[Id entrega]" +
                               $" WHERE ( Hallazgo.[Nro acta] = '{nroActa}' );";

            Tabla = conexion.Leer(Consulta2);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    ElementoBusqueda bElemento = new ElementoBusqueda();
                    bElemento.Id = Convert.ToInt32(fila["Id"]);
                    bElemento.Cantidad = fila["Cantidad"].ToString();
                    bElemento.Descripcion = fila["Descripcion"].ToString();
                    bElemento.Articulo = fila["Articulo"].ToString();
                    bElemento.Estado = fila["Estado"].ToString();
                    bElemento.Hallazgo = fila["Hallazgo.Nro acta"].ToString();
                    bElemento.Lugar = fila["Lugar hallazgo"].ToString();
                    bElemento.Entrega = fila["Entrega.Nro acta"].ToString();
                    bElemento.Fecha_hallazgo = fila["Fecha hallazgo"].ToString();
                    bElemento.Entrega = ObtenerNroEntrega(new BEElemento(bElemento.Id));

                    lista.Add(bElemento);
                }
            }

            return lista;

        }
    }
}
