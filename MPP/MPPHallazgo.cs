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

    public class MPPHallazgo : IGestor<BEHallazgo>
    {
        Conexion conexion = new Conexion();
        string NodoPadre = "Hallazgos";
        string NodoContenedor = "Hallazgo";
        public MPPHallazgo() { }


        public BEHallazgo Agregar(BEHallazgo pHallazgo)
        {

            var NuevoID = conexion.ObtenerUltimoID(NodoPadre);

            XElement Hallazgo = new XElement("Hallazgo",
                new XElement("Id", NuevoID),
                new XElement("FechaActa", pHallazgo.FechaActa?.ToString("dd/MM/yyyy HH:mm")),
                new XElement("Nroacta", pHallazgo.NroActa),
                new XElement("IdUnidad", pHallazgo.Unidad.Id),
                new XElement("LugarHallazgo", pHallazgo.LugarHallazgo),
                new XElement("Anio", pHallazgo.Anio),
                new XElement("FechaHallazgo", pHallazgo.FechaHallazgo.ToString("dd/MM/yyyy HH:mm")),
                new XElement("Observacion", pHallazgo.Observacion)
                );

            conexion.Agregar(NodoPadre, Hallazgo);

            pHallazgo.Id = NuevoID;

            return pHallazgo;
        }
        public bool Eliminar(BEHallazgo pHallazgo)
        {

            if (pHallazgo.listaPersonas != null || pHallazgo.listaPersonas?.Count > 0)
            {
                conexion.Eliminar("Hallazgo_Personas", pHallazgo.Id.ToString(), "IdHallazgo", true);
            }
            if (pHallazgo.listaElementos != null || pHallazgo.listaElementos?.Count > 0)
            {
                conexion.Eliminar("Elementos", pHallazgo.Id.ToString(), "IdHallazgo", true);
            }

            return conexion.Eliminar(NodoPadre, pHallazgo.Id.ToString());

        }


        public bool Actualizar(BEHallazgo pHallazgo)
        {
            try
            {
                XElement HallazgoExistente = conexion.LeerObjeto("Hallazgo", pHallazgo.Id.ToString());

                if (HallazgoExistente != null)
                {
                    HallazgoExistente.SetElementValue("FechaActa", pHallazgo.FechaActa?.ToString("dd/MM/yyyy HH:mm"));
                    HallazgoExistente.SetElementValue("Nroacta", pHallazgo.NroActa);
                    HallazgoExistente.SetElementValue("IdUnidad", pHallazgo.Unidad.Id);
                    HallazgoExistente.SetElementValue("LugarHallazgo", pHallazgo.LugarHallazgo);
                    HallazgoExistente.SetElementValue("Anio", pHallazgo.Anio);
                    HallazgoExistente.SetElementValue("FechaHallazgo", pHallazgo.FechaHallazgo.ToString("dd/MM/yyyy HH:mm"));
                    
                    // Verifica si el campo "Observacion" está presente en el objeto entrega
                    if (!string.IsNullOrEmpty(pHallazgo.Observacion))
                    {
                        // Si el campo "Observacion" tiene un valor, lo agrega al XElement
                        HallazgoExistente.SetElementValue("Observacion", pHallazgo.Observacion);
                    }
                    else
                    {
                        // Si el campo "Observacion" está vacío, se asegura de que no haya un elemento "Observacion" en el XElement
                        HallazgoExistente.Element("Observacion")?.Remove();
                    }

                }
                return conexion.Actualizar(NodoPadre, pHallazgo.Id.ToString(), HallazgoExistente);

            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }


        public List<BEHallazgo> ListarTodo()
        {
            List<BEHallazgo> list = new List<BEHallazgo>();

            var Consulta = conexion.LeerTodos("Hallazgo");

            if (Consulta.Count() > 0)
            {
                list = (from x in Consulta
                        select new BEHallazgo
                        {
                            Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                            Unidad = new BEUnidad(Convert.ToInt32(Convert.ToString(x.Element("IdUnidad")?.Value))),
                            NroActa = Convert.ToString(x.Element("Nroacta")?.Value),
                            FechaHallazgo = Convert.ToDateTime(x.Element("FechaHallazgo")?.Value),
                            FechaActa = Convert.ToDateTime(x.Element("FechaActa")?.Value),
                            LugarHallazgo = Convert.ToString(x.Element("LugarHallazgo")?.Value),
                            Observacion = Convert.ToString(x.Element("Observacion")?.Value),
                            Anio = Convert.ToInt32(x.Element("Anio")?.Value)
                        }).ToList();
            }

            return list;
        }



        public BEHallazgo ListarObjeto(BEHallazgo bEHallazgo)
        {
            var x = conexion.LeerObjeto(NodoContenedor, bEHallazgo.Id.ToString());

            if (x != null)
            {
                bEHallazgo.Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value));
                bEHallazgo.NroActa = Convert.ToString(x.Element("Nroacta")?.Value);
                bEHallazgo.FechaHallazgo = Convert.ToDateTime(x.Element("FechaHallazgo")?.Value);
                bEHallazgo.LugarHallazgo = Convert.ToString(x.Element("LugarHallazgo")?.Value);
                bEHallazgo.Anio = Convert.ToInt32(x.Element("Anio")?.Value);
                bEHallazgo.Observacion = Convert.ToString(x.Element("Observacion")?.Value);
                bEHallazgo.Unidad = new BEUnidad(Convert.ToInt32(x.Element("IdUnidad")?.Value));
            }
            else
            { bEHallazgo = null; }
            return bEHallazgo;


        }

        public BEHallazgo ListarHallazgoPersonas(BEHallazgo bEHallazgo)
        {


            MPPPersona mPPPersona = new MPPPersona();
            MPPInstructor mPPInstructor = new MPPInstructor();
            MPPEstado_Persona mPPEstado_Persona = new MPPEstado_Persona();
            var EstadosPersona = mPPEstado_Persona.ListarTodo();
            bEHallazgo.listaPersonas?.Clear();


            IEnumerable<XElement> hallazgoPersonasXml = conexion.LeerTodos("Hallazgo_Persona")
                                                      .Where(e => e.Element("IdHallazgo")?.Value == bEHallazgo.Id.ToString());

            if (hallazgoPersonasXml.Any())
            {
                bEHallazgo.listaPersonas = new List<BEPersona>();

                foreach (XElement e in hallazgoPersonasXml)
                {
                    int idPersona = Convert.ToInt32(e.Element("IdPersona").Value);
                    int idEstado = Convert.ToInt32(e.Element("IdEstado").Value);

                    if (idEstado == 1)
                    {
                        BEInstructor instructor = mPPInstructor.ListarObjeto(new BEInstructor(idPersona));
                        instructor.EstadoPersona = EstadosPersona.Find(ep => ep.Id == idEstado);
                        bEHallazgo.listaPersonas.Add(instructor);

                    }
                    else
                    {
                        BEPersona ePersona = mPPPersona.ListarObjeto(new BEPersona(idPersona));
                        ePersona.EstadoPersona = EstadosPersona.Find(ep => ep.Id == idEstado);
                        bEHallazgo.listaPersonas.Add(ePersona);
                    }

                }
            }

            return bEHallazgo;
        }

        public BEHallazgo ListarHallazgoElementos(BEHallazgo bEHallazgo)
        {

            bEHallazgo.listaElementos.Clear();

            MPPArticulo mPPArticulo = new MPPArticulo();
            MPPEstado_Elemento mPPEstados = new MPPEstado_Elemento();

            var articulos = mPPArticulo.ListarTodo();
            var Estados = mPPEstados.ListarTodo();

            IEnumerable<XElement> elementosXml = conexion.LeerTodos("Elemento")
                                               .Where(e => e.Element("IdHallazgo")?.Value == bEHallazgo.Id.ToString());

            // Verificamos si hay algún elemento XML después de filtrar.
            if (elementosXml.Any())
            {
                // Si hay elementos XML, inicializamos la lista de elementos en el BEHallazgo.
                bEHallazgo.listaElementos = new List<BEElemento>();

                // Recorremos cada elemento XML.
                foreach (XElement e in elementosXml)
                {
                    // Para cada elemento XML, creamos un nuevo BEElemento.
                    // El ID del BEElemento se obtiene del elemento XML.
                    BEElemento elemento = new BEElemento(Convert.ToInt32(e.Element("Id").Value));

                    // Configuramos las propiedades de BEElemento a partir de los elementos XML.
                    elemento.Cantidad = double.Parse(e.Element("Cantidad")?.Value);
                    elemento.Descripcion = e.Element("Descripcion")?.Value;
                    elemento.Estado = Estados.Find(x => x.Id == Convert.ToInt32(e.Element("IdEstadoElemento")?.Value));
                    elemento.Articulo = articulos.Find(x => x.Id == Convert.ToInt32(e.Element("IdArticulo")?.Value));
                    bEHallazgo.listaElementos.Add(elemento); // Añade el elemento a la lista
                }
            }
            return bEHallazgo;
        }
    }
}
