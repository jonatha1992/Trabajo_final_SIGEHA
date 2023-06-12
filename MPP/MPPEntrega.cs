using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.Linq;




namespace MPP
{
    public class MPPEntrega : IGestor<BEEntrega>
    {
        Conexion conexion = new Conexion();
        string NodoPadre = "Entregas";
        string NodoContenedor = "Entrega";


        public MPPEntrega() { }

        public BEEntrega Agregar(BEEntrega entrega)
        {
            var NuevoID = conexion.ObtenerUltimoID(NodoPadre);

            XElement Entrega = new XElement("Hallazgo",
                new XElement("Id", NuevoID),
                new XElement("Nroacta", entrega.NroActa),
                new XElement("IdUnidad", entrega.Unidad.Id),
                new XElement("Anio", entrega.Anio),
                new XElement("FechaEntrega", entrega.Fecha_entrega)
                );

            conexion.Agregar(NodoPadre, Entrega);
            entrega.Id = NuevoID;
            return entrega;
        }


        public bool Actualizar(BEEntrega entrega)
        {

            XElement EntegaActualizado = new XElement("Hallazgo",
           new XElement("Id", entrega.Id),
           new XElement("Nroacta", entrega.NroActa),
           new XElement("IdUnidad", entrega.Unidad.Id),
           new XElement("Anio", entrega.Anio),
           new XElement("FechaEntrega", entrega.Fecha_entrega));

            return conexion.Actualizar(NodoPadre, entrega.Id.ToString(), EntegaActualizado);

        }

        public bool Eliminar(BEEntrega pEntrega)
        {

            if (pEntrega.listaPersonas != null)
            {
                conexion.Eliminar("Entrega_Persona", pEntrega.Id.ToString(), "IdEntrega");
            }

            return conexion.Eliminar(NodoPadre, pEntrega.Id.ToString());

            //Todo: colocar el elemennto que no tiene en entrega es deci
            //MPPElemento mPPElemento = null;
            //if (pEntrega.listaElementos != null)
            //{
            //    foreach (var item in pEntrega.listaElementos)
            //    {
            //        mPPElemento.Eliminar_Elemento_Entrega(item);
            //    }
            //}

        }

        public BEEntrega ListarObjeto(BEEntrega pEntrega)

        {

            var x = conexion.LeerObjeto(NodoContenedor, pEntrega.Id.ToString());

            if (x != null)
            {
                pEntrega.Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value));
                pEntrega.NroActa = Convert.ToString(x.Element("Nroacta")?.Value);
                pEntrega.Fecha_entrega = Convert.ToDateTime(x.Element("FechaEntrega")?.Value);
                pEntrega.Anio = Convert.ToInt32(x.Element("Anio")?.Value);
                pEntrega.Unidad = new BEUnidad(Convert.ToInt32(x.Element("Anio")?.Value));



            }
            else
            { pEntrega = null; }
            return pEntrega;

        }

        public BEEntrega ListarObjetoPersonas(BEEntrega pEntrega)
        {
            MPPPersona mPPPersona = new MPPPersona();
            MPPInstructor mPPInstructor = new MPPInstructor();
            MPPEstado_Persona mPPEstado_Persona = new MPPEstado_Persona();
            var EstadosPersona = mPPEstado_Persona.ListarTodo();
            var personas = mPPPersona.ListarTodo();
            var jerarquias = mPPEstado_Persona.ListarTodo();


            IEnumerable<XElement> EntregaPersonasXml = conexion.LeerTodos("Entrega_Persona")
                                                      .Where(e => e.Element("IdEntrega")?.Value == pEntrega.Id.ToString());

            if (EntregaPersonasXml.Any())
            {
                pEntrega.listaPersonas = new List<BEPersona>();

                foreach (XElement e in EntregaPersonasXml)
                {
                    int idPersona = Convert.ToInt32(e.Element("IdPersona").Value);
                    int idEstado = Convert.ToInt32(e.Element("IdEstado").Value);

                    BEPersona persona = personas.Find(p => p.Id == idPersona);
                    BEEstado_Persona estado = EstadosPersona.Find(ep => ep.Id == idEstado);

                    if (persona != null && estado != null)
                    {
                        persona.EstadoPersona = estado;
                        pEntrega.listaPersonas.Add(persona);
                    }
                }
            }

            return pEntrega;

        }

        public BEEntrega ListarObjetoElementos(BEEntrega pEntrega)
        {
            MPPArticulo mPPArticulo = new MPPArticulo();
            MPPEstado_Elemento mPPEstados = new MPPEstado_Elemento();
            var articulos = mPPArticulo.ListarTodo();
            var Estados = mPPEstados.ListarTodo();


            IEnumerable<XElement> elementosXml = conexion.LeerTodos("Elemento")
                                               .Where(e => e.Element("IdEntrega")?.Value == pEntrega.Id.ToString());

            // Verificamos si hay algún elemento XML después de filtrar.
            if (elementosXml.Any())
            {
                // Si hay elementos XML, inicializamos la lista de elementos en el BEHallazgo.
                pEntrega.listaElementos = new List<BEElemento>();

                // Recorremos cada elemento XML.
                foreach (XElement e in elementosXml)
                {
                    // Para cada elemento XML, creamos un nuevo BEElemento.
                    // El ID del BEElemento se obtiene del elemento XML.
                    BEElemento elemento = new BEElemento(Convert.ToInt32(e.Element("Id").Value));

                    // Configuramos las propiedades de BEElemento a partir de los elementos XML.
                    elemento.Cantidad = double.Parse(e.Element("Cantidad").Value);
                    elemento.Descripcion = e.Element("Descripcion").Value;
                    elemento.Estado = Estados.Find(x => x.Id == Convert.ToInt32(e.Element("IdEstadoElemento").Value));
                    elemento.Articulo = articulos.Find(x => x.Id == Convert.ToInt32(e.Element("IdArticulo").Value));
                    pEntrega.listaElementos.Add(elemento); // Añade el elemento a la lista
                }
            }
            return pEntrega;
        }

        public List<BEEntrega> ListarTodo()
        {

            List<BEEntrega> list = new List<BEEntrega>();

            var Consulta = conexion.LeerTodos(NodoPadre).Descendants("Hallazgo");

            if (Consulta.Count() > 0)
            {
                list = (from x in Consulta
                        select new BEEntrega
                        {
                            Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                            NroActa = Convert.ToString(x.Element("Nroacta")?.Value),
                            Fecha_entrega = Convert.ToDateTime(x.Element("FechaEntrega")?.Value),
                            Anio = Convert.ToInt32(x.Element("Anio")?.Value),
                            Unidad = new BEUnidad(Convert.ToInt32(x.Element("IdUnidad")?.Value))
                        }).ToList();
            }

            return list;
            //string consulta = string.Empty;



            //List<BEEntrega> lista = new List<BEEntrega>();

            //var Consulta = conexion.LeerTodos(NodoPadre).Descendants("Enntrega");

            //DataTable dt;
            //dt = conexion.Leer(consulta);
            //if (dt.Rows.Count > 0)
            //{
            //    foreach (DataRow fila in dt.Rows)
            //    {
            //        BEEntrega pEntrega = new BEEntrega();
            //        pEntrega.Id = int.Parse(fila["Id"].ToString());
            //        pEntrega.NroActa = fila["Nro acta"].ToString();
            //        pEntrega.Fecha_entrega = Convert.ToDateTime(fila["Fecha entrega"]);
            //        pEntrega.Anio = int.Parse(fila["anio"].ToString());
            //        pEntrega.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);

            //        pEntrega.Unidad = new BEUnidad(Convert.ToInt32(fila["Id unidad"]));
            //        pEntrega.Unidad.Nombre = fila["Unidad.Nombre"].ToString();
            //        pEntrega.Unidad.Ursa = new BEUrsa(Convert.ToInt32(fila["Id ursa"]));
            //        pEntrega.Unidad.Ursa.Nombre = fila["Ursa.Nombre"].ToString();


            //        lista.Add(pEntrega);
            //    }
            //}
            //else
            //{ lista = null; }

            //return lista;

        }

        //public List<BEEntrega> ListarTodo(BEUnidad unidad, int Anio)
        //{
        //    List<BEEntrega> list = new List<BEEntrega>();


        //    string consulta = string.Empty;
        //    consulta = $" SELECT * FROM Entrega where ([Id unidad] = {unidad.Id} AND Anio = {Anio}) " +
        //               $" ORDER BY [Nro acta] DESC ";

        //    DataTable dt;
        //    dt = conexion.Leer(consulta);
        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow fila in dt.Rows)
        //        {
        //            BEEntrega Entrega = new BEEntrega();
        //            Entrega.Id = Convert.ToInt32(fila["Id"]);
        //            Entrega.NroActa = fila["Nro acta"].ToString();
        //            Entrega.Fecha_entrega = Convert.ToDateTime(fila["Fecha entrega"]);
        //            Entrega.Anio = Convert.ToInt32(fila["Anio"]);
        //            Entrega.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);

        //            Entrega.Unidad = unidad;

        //            list.Add(Entrega);
        //        }
        //    }
        //    return list;
        //}

        //public List<BEEntrega> ListarTodo(BEUnidad unidad, DateTime fecha)
        //{
        //    List<BEEntrega> list = new List<BEEntrega>();

        //    int Anio = fecha.Year;
        //    int Mes = fecha.Month;

        //    string consulta = string.Empty;
        //    consulta = $" SELECT * FROM Entrega where ([Id unidad] = {unidad.Id} AND Anio = {Anio} AND Month([Fecha entrega]) ={Mes} ) " +
        //               $" ORDER BY [Nro acta] DESC ";

        //    DataTable dt;
        //    dt = conexion.Leer(consulta);
        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow fila in dt.Rows)
        //        {
        //            BEEntrega Entrega = new BEEntrega();
        //            Entrega.Id = Convert.ToInt32(fila["Id"]);
        //            Entrega.NroActa = fila["Nro acta"].ToString();
        //            Entrega.Fecha_entrega = Convert.ToDateTime(fila["Fecha entrega"]);
        //            Entrega.Anio = Convert.ToInt32(fila["Anio"]);
        //            Entrega.FechaActa = fila["Fecha acta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["Fecha acta"]);

        //            Entrega.Unidad = unidad;

        //            list.Add(Entrega);
        //        }
        //    }
        //    return list;
        //}
    }
}
