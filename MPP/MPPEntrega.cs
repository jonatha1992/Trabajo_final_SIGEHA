﻿using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            XElement Entrega = new XElement("Entrega",
                new XElement("Id", NuevoID),
                new XElement("Nroacta", entrega.NroActa),
                new XElement("IdUnidad", entrega.Unidad.Id),
                new XElement("Anio", entrega.Anio),
                new XElement("FechaEntrega", entrega.Fecha_entrega.ToString("dd/MM/yyyy HH:mm")),
                new XElement("Observacion", entrega.Observacion)

                );

            conexion.Agregar(NodoPadre, Entrega);
            entrega.Id = NuevoID;
            return entrega;
        }


        public bool Actualizar(BEEntrega entrega)
        {
            try
            {
                XElement EntregaExistente = conexion.LeerObjeto("Entrega", entrega.Id.ToString());

                if (EntregaExistente != null)
                {
                    EntregaExistente.SetElementValue("Nroacta", entrega.NroActa);
                    EntregaExistente.SetElementValue("IdUnidad", entrega.Unidad.Id);
                    EntregaExistente.SetElementValue("Anio", entrega.Anio);
                    EntregaExistente.SetElementValue("FechaEntrega", entrega.Fecha_entrega.ToString("dd/MM/yyyy HH:mm"));

                    // Verifica si el campo "Observacion" está presente en el objeto entrega
                    if (!string.IsNullOrEmpty(entrega.Observacion))
                    {
                        // Si el campo "Observacion" tiene un valor, lo agrega al XElement
                        EntregaExistente.SetElementValue("Observacion", entrega.Observacion);
                    }
                    else
                    {
                        // Si el campo "Observacion" está vacío, se asegura de que no haya un elemento "Observacion" en el XElement
                        EntregaExistente.Element("Observacion")?.Remove();
                    }

                    return conexion.Actualizar(NodoPadre, entrega.Id.ToString(), EntregaExistente);
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public bool Eliminar(BEEntrega pEntrega)
        {

            if (pEntrega.listaPersonas != null)
            {
                //MPPPersona mPPPersona = new MPPPersona();
                foreach (BEPersona item in pEntrega.listaPersonas)
                {
                    //mPPPersona.EliminarPersonaEntrega(pEntrega, item);

                    conexion.Eliminar("Entrega_Persona", pEntrega.Id.ToString(), "IdEntrega", true);

                }


            }

            if (pEntrega.listaElementos != null)
            {
                MPPElemento mPPElemento = new MPPElemento();
                foreach (var item in pEntrega.listaElementos)
                {
                    mPPElemento.Eliminar_Elemento_Entrega(item);

                }
            }

            return conexion.Eliminar(NodoPadre, pEntrega.Id.ToString());

        }

        public BEEntrega ListarObjeto(BEEntrega pEntrega)
        {
            var Consulta = conexion.LeerObjeto(NodoContenedor, pEntrega.Id.ToString());
            MPPUnidad mPPUnidad = new MPPUnidad();

            if (Consulta != null)
            {
                pEntrega.Id = Convert.ToInt32(Convert.ToString(Consulta.Element("Id")?.Value));
                pEntrega.NroActa = Convert.ToString(Consulta.Element("Nroacta")?.Value);
                pEntrega.Fecha_entrega = Convert.ToDateTime(Consulta.Element("FechaEntrega")?.Value);
                pEntrega.Anio = Convert.ToInt32(Consulta.Element("Anio")?.Value);
                pEntrega.Unidad = new BEUnidad(Convert.ToInt32(Consulta.Element("IdUnidad")?.Value));
                pEntrega.Observacion = Convert.ToString(Consulta.Element("Observacion")?.Value);

            }
            else
            { pEntrega = null; }
            return pEntrega;

        }

        public BEEntrega ListarEntregaPersonas(BEEntrega pEntrega)
        {
            MPPPersona mPPPersona = new MPPPersona();
            MPPInstructor mPPInstructor = new MPPInstructor();
            MPPEstado_Persona mPPEstado_Persona = new MPPEstado_Persona();
            var EstadosPersona = mPPEstado_Persona.ListarTodo();
            pEntrega.listaPersonas?.Clear();

            IEnumerable<XElement> EntregaPersonasXml = conexion.LeerTodos("Entrega_Persona")
                                                      .Where(e => e.Element("IdEntrega")?.Value == pEntrega.Id.ToString());

            if (EntregaPersonasXml.Any())
            {
                pEntrega.listaPersonas = new List<BEPersona>();

                foreach (XElement e in EntregaPersonasXml)
                {
                    int idPersona = Convert.ToInt32(e.Element("IdPersona").Value);
                    int idEstado = Convert.ToInt32(e.Element("IdEstado").Value);

                    if (idEstado == 1)
                    {
                        BEInstructor instructor = mPPInstructor.ListarObjeto(new BEInstructor(idPersona));
                        instructor.EstadoPersona = EstadosPersona.Find(ep => ep.Id == idEstado);
                        pEntrega.listaPersonas.Add(instructor);

                    }
                    else
                    {
                        BEPersona ePersona = mPPPersona.ListarObjeto(new BEPersona(idPersona));
                        ePersona.EstadoPersona = EstadosPersona.Find(ep => ep.Id == idEstado);
                        pEntrega.listaPersonas.Add(ePersona);
                    }

                }
            }

            return pEntrega;

        }

        public BEEntrega ListarEntregaElementos(BEEntrega pEntrega)
        {
            MPPArticulo mPPArticulo = new MPPArticulo();
            MPPEstado_Elemento mPPEstados = new MPPEstado_Elemento();
            var articulos = mPPArticulo.ListarTodo();
            var Estados = mPPEstados.ListarTodo();

            pEntrega.listaElementos.Clear();
                
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

            var Consulta = conexion.LeerTodos(NodoPadre).Descendants("Entrega");

            if (Consulta.Count() > 0)
            {
                list = (from x in Consulta
                        select new BEEntrega
                        {
                            Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                            NroActa = Convert.ToString(x.Element("Nroacta")?.Value),
                            Fecha_entrega = Convert.ToDateTime(x.Element("FechaEntrega")?.Value),
                            Anio = Convert.ToInt32(x.Element("Anio")?.Value),
                            Unidad = new BEUnidad(Convert.ToInt32(x.Element("IdUnidad")?.Value)),
                            Observacion = Convert.ToString(x.Element("Observacion")?.Value)
                        }).ToList();
            }

            return list;

        }

    }
}
