using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Xml.Linq;

namespace MPP
{
    public class MPPElemento : IGestor<BEElemento>
    {
        Conexion conexion = new Conexion();
        string NodoPadre = "Elementos";
        string NodoContenedor = "ElementoActa";
        public BEElemento Agregar(BEElemento pElemento)
        {
            throw new NotImplementedException();
        }

        public bool Agregar_Elemento_Hallazgo(BEHallazgo hallazgo, BEElemento elemento)
        {
            var NuevoID = conexion.ObtenerUltimoID(NodoPadre);

            XElement Elemento = new XElement("ElementoActa",
             new XElement("Id", NuevoID),
             new XElement("IdArticulo", elemento.Articulo.Id),
             new XElement("IdEstadoElemento", elemento.Estado.Id),
             new XElement("IdHallazgo", hallazgo.Id),
             new XElement("Descripcion", elemento.Descripcion),
             new XElement("Cantidad", elemento.Cantidad)
             );

            return conexion.Agregar(NodoPadre, Elemento);
        }

        public bool Agregar_Elemento_Entrega(BEEntrega entrega, BEElemento elemento)
        {
            XElement Elementoxml = conexion.LeerObjeto("ElementoActa", elemento.Id.ToString()); // Asume que LeerObjeto devuelve un XElement

            if (Elementoxml != null)
            {
                Elementoxml.Add(new XElement("IdEntrega", entrega.Id));  // Añade IdEntrega al ElementoActa
                Elementoxml.SetElementValue("IdEstadoElemento", elemento.Estado.Id);  // Añade IdEntrega al ElementoActa
               
                return conexion.Actualizar("Elementos", elemento.Id.ToString(), Elementoxml); // Actualiza el ElementoActa entrega el XML
            }

            return false; // No se encontró el ElementoActa
        }

        public bool Eliminar_Elemento_Entrega(BEElemento elemento)
        {
            XElement Elementoxml = conexion.LeerObjeto("ElementoActa", elemento.Id.ToString()); // Asume que LeerObjeto devuelve un XElement

            if (Elementoxml != null)
            {
                Elementoxml.Element("IdEntrega")?.Remove();
                Elementoxml.SetElementValue("IdEstadoElemento", elemento.Estado.Id);  // Añade IdEntrega al ElementoActa
                return conexion.Actualizar("Elementos", elemento.Id.ToString(), Elementoxml); // Actualiza el ElementoActa entrega el XML
            }
            return false;
        }

        public bool Actualizar(BEElemento pElemento)
        {
            XElement Elemento = conexion.LeerObjeto("ElementoActa", pElemento.Id.ToString()); // Asume que LeerObjeto devuelve un XElement
            if (Elemento != null)
            {
                Elemento.SetElementValue("IdArticulo", pElemento.Articulo.Id);
                Elemento.SetElementValue("IdEstadoElemento", pElemento.Estado.Id);
                Elemento.SetElementValue("Descripcion", pElemento.Descripcion);
                Elemento.SetElementValue("Cantidad", pElemento.Cantidad);
                return conexion.Actualizar("Elementos", pElemento.Id.ToString(), Elemento); // Actualiza el ElementoActa entrega el XML
            }
            return false; // No se encontró el ElementoActa
        }
        public bool Eliminar(BEElemento pElemento)
        {
            return conexion.Eliminar(NodoPadre, pElemento.Id.ToString());
        }

        public string ObtenerNroHallazgo(BEElemento bEElemento)
        {
            // Obtener el XElement que corresponde al ElementoActa
            XElement elementoXml = conexion.LeerObjeto("ElementoActa", bEElemento.Id.ToString());

            if (elementoXml != null)
            {
                // Obtener el IdHallazgo del ElementoActa
                string idHallazgo = elementoXml.Element("IdHallazgo")?.Value;

                // Si hay un IdHallazgo, buscar el Hallazgo correspondiente
                if (!string.IsNullOrEmpty(idHallazgo))
                {
                    XElement hallazgoXml = conexion.LeerObjeto("Hallazgo", idHallazgo);

                    // Si el Hallazgo existe, retornar el número
                    if (hallazgoXml != null)
                    {
                        return hallazgoXml.Element("Nroacta")?.Value;
                    }
                }
            }
            // Si no se encontró el ElementoActa o el Hallazgo, retornar un string vacío
            return "";
        }
        public string ObtenerNroEntrega(BEElemento bEElemento)
        {
            // Obtener el XElement que corresponde al ElementoActa
            XElement elementoXml = conexion.LeerObjeto("ElementoActa", bEElemento.Id.ToString());

            if (elementoXml != null)
            {
                // Obtener el IdEntrega del ElementoActa
                string idEntrega = elementoXml.Element("IdEntrega")?.Value;

                // Si hay un IdHallazgo, buscar el Hallazgo correspondiente
                if (!string.IsNullOrEmpty(idEntrega))
                {
                    XElement EntregaXml = conexion.LeerObjeto("Entrega", idEntrega);

                    // Si el Hallazgo existe, retornar el número
                    if (EntregaXml != null)
                    {
                        return EntregaXml.Element("NroActa")?.Value;
                    }
                }
            }
            // Si no se encontró el ElementoActa o el Hallazgo, retornar un string vacío
            return "No entregado";

        }

     
        public List<BEElemento> ListarTodo()
        {
            List<BEElemento> lista = new List<BEElemento>();

            var Estadoxml = conexion.LeerTodos("Estado_Elemento");
            var elementosxml = conexion.LeerTodos("ElementoActa");
            var articulosxml = conexion.LeerTodos("Articulo");
            var categoriasxml = conexion.LeerTodos("Categoria");

            if (elementosxml.Count() > 0)
            {
                lista = (from x in elementosxml
                         join Estado in Estadoxml on Convert.ToInt32(x.Element("IdEstadoElemento")?.Value) equals Convert.ToInt32(Estado.Element("Id")?.Value) into estadoJoin
                         from estado in estadoJoin.DefaultIfEmpty()
                         join articulo in articulosxml on Convert.ToInt32(x.Element("IdArticulo")?.Value) equals Convert.ToInt32(articulo.Element("Id")?.Value) into articuloJoin
                         from articulo in articuloJoin.DefaultIfEmpty()
                         join categoria in categoriasxml on Convert.ToInt32(articulo.Element("IdCategoria")?.Value) equals Convert.ToInt32(categoria.Element("Id")?.Value) into categoriaJoin
                         from categoria in categoriaJoin.DefaultIfEmpty()
                         select new BEElemento
                         {
                             Id = Convert.ToInt32(x.Element("Id")?.Value),
                             Articulo = new BEArticulo(
                                 Convert.ToInt32(articulo.Element("Id")?.Value),
                                 articulo.Element("Nombre")?.Value,
                                 new BECategoria(
                                     Convert.ToInt32(categoria.Element("Id")?.Value),
                                     categoria.Element("Nombre")?.Value
                                 )
                             ),
                             Descripcion = Convert.ToString(x.Element("Descripcion")?.Value),
                             Cantidad = Convert.ToDouble(x.Element("Cantidad")?.Value),
                             Estado = new BEEstado_Elemento(
                                 Convert.ToInt32(estado.Element("Id")?.Value),
                                 estado.Element("Nombre")?.Value
                             ),
                             Hallazgo = new BEHallazgo(Convert.ToInt32(x.Element("IdHallazgo")?.Value)),
                             Entrega = new BEEntrega(Convert.ToInt32(x.Element("IdEntrega")?.Value))
                         }).ToList();
            }

            return lista;
        }



        public BEElemento ListarObjeto(BEElemento bElemento)
        {

            MPPArticulo mPPArticulo = new MPPArticulo();
            MPPEstado_Elemento mPPEstado_Articulo = new MPPEstado_Elemento();

            var x = conexion.LeerObjeto(NodoContenedor, bElemento.Id.ToString());

            if (x != null)
            {
                bElemento.Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value));
                bElemento.Cantidad = Convert.ToDouble(x.Element("Cantidad")?.Value);
                bElemento.Descripcion = Convert.ToString(x.Element("Descripcion")?.Value);
                bElemento.Articulo = mPPArticulo.ListarObjeto(new BEArticulo(Convert.ToInt32(x.Element("IdArticulo")?.Value)));
                bElemento.Estado = mPPEstado_Articulo.ListarObjeto(new BEEstado_Elemento(Convert.ToInt32(x.Element("IdEstadoElemento")?.Value)));
                bElemento.Hallazgo = new BEHallazgo(Convert.ToInt32(x.Element("IdHallazgo")?.Value));
                bElemento.Entrega = new BEEntrega (Convert.ToInt32(x.Element("IdEntrega")?.Value));
            }
            else
            { bElemento = null; }
            return bElemento;

        }
        public List<ElementoBusqueda> BusquedaElementosHallazgo(string nroActa)
        {
            List<ElementoBusqueda> lista = new List<ElementoBusqueda>();
            MPPHallazgo mPPHallazgo = new MPPHallazgo();

         
            var Hallazgo = mPPHallazgo.ListarTodo().Find(x => x.NroActa == nroActa);

            Hallazgo = mPPHallazgo.ListarHallazgoElementos(Hallazgo);
            


            if (Hallazgo != null)
            {
                foreach (BEElemento elemento in Hallazgo.listaElementos)
                {
                    ElementoBusqueda bElemento = new ElementoBusqueda();
                    bElemento.Id = elemento.Id;
                    bElemento.Cantidad = elemento.Cantidad.ToString();
                    bElemento.Descripcion = elemento.Descripcion;
                    bElemento.Articulo = elemento.Articulo.Nombre;
                    bElemento.Estado = elemento.Estado.Nombre;
                    bElemento.Hallazgo = Hallazgo.NroActa;
                    bElemento.Lugar = Hallazgo.LugarHallazgo;
                    bElemento.Fecha_hallazgo = Hallazgo.FechaHallazgo.ToString();
                    bElemento.Entrega = ObtenerNroEntrega(new BEElemento(bElemento.Id));

                    lista.Add(bElemento);
                }
            }

            return lista;
        }


        public List<ElementoBusqueda> BusquedaElementos(DateTime? desde, DateTime? hasta, BECategoria bECategoria, BEArticulo bEArticulo, string lugar, string descripcion, BEUnidad unidad ,string nroHallazgo)
        {
            List<ElementoBusqueda> elementoBusquedas = new List<ElementoBusqueda>();

            

            var categorias = conexion.LeerTodos("Categoria");
            var articulos = conexion.LeerTodos("Articulo"); 
            var hallazgos = conexion.LeerTodos("Hallazgo"); 
            var Entregas = conexion.LeerTodos("Entrega");
            var elementos = conexion.LeerTodos("ElementoActa");
            var Estados = conexion.LeerTodos("Estado_Elemento");

            // Filtra por fechas
            if (desde != null && hasta != null)
            {
                hallazgos = hallazgos.Where(h => Convert.ToDateTime(h.Element("FechaHallazgo").Value) 
                       >= desde && Convert.ToDateTime(h.Element("FechaHallazgo").Value) <= hasta).ToList();
            }

            // Filtra por categoría
            if (bECategoria != null)
            {
                articulos = articulos.Where(a => Convert.ToInt32(a.Element("IdCategoria").Value) == bECategoria.Id).ToList();
            }

            // Filtra por artículo
            if (bEArticulo != null)
            {
                elementos = elementos.Where(e => Convert.ToInt32(e.Element("IdArticulo").Value) == bEArticulo.Id).ToList();
            }

            // Filtra nro Hallazgo
            if (!string.IsNullOrEmpty(nroHallazgo))
            {
                hallazgos = hallazgos.Where(h => Convert.ToString(h.Element("Nroacta").Value).Contains(nroHallazgo)).ToList();
            }

            // Filtra por lugar
            if (!string.IsNullOrEmpty(lugar))
            {
                hallazgos = hallazgos.Where(h => Convert.ToString(h.Element("LugarHallazgo").Value).Contains(lugar)).ToList();
            }


            // Filtra por descripción
            if (!string.IsNullOrEmpty(descripcion))
            {
                elementos = elementos.Where(e => Convert.ToString(e.Element("Descripcion").Value).Contains(descripcion)).ToList();
            }

            // Filtra por unidad
            if (unidad != null)
            {
                hallazgos = hallazgos.Where(h => Convert.ToInt32(h.Element("IdUnidad").Value) == unidad.Id).ToList();
            }

            // Genera la lista de resultados
            elementoBusquedas = (from elemento in elementos
                                 join articulo in articulos on Convert.ToInt32(elemento.Element("IdArticulo").Value) equals Convert.ToInt32(articulo.Element("Id").Value)
                                 join hallazgo in hallazgos on Convert.ToInt32(elemento.Element("IdHallazgo").Value) equals Convert.ToInt32(hallazgo.Element("Id").Value)
                                 join estado in Estados on Convert.ToInt32(elemento.Element("IdEstadoElemento").Value) equals Convert.ToInt32(estado.Element("Id").Value)
                                 join entrega in Entregas on Convert.ToInt32(elemento.Element("IdEntrega")?.Value) equals Convert.ToInt32(entrega.Element("Id").Value) into entregasJoin
                                 from entrega in entregasJoin.DefaultIfEmpty()
                                 select new ElementoBusqueda
                                 {
                                     Id = Convert.ToInt32(elemento.Element("Id").Value),
                                     Fecha_hallazgo = DateTime.Parse(hallazgo.Element("FechaHallazgo").Value).ToString("dd/MM/yyyy HH:mm"),
                                     Hallazgo = hallazgo.Element("Nroacta").Value,
                                     Lugar = hallazgo.Element("LugarHallazgo").Value,
                                     Articulo = articulo.Element("Nombre").Value,
                                     Cantidad = elemento.Element("Cantidad").Value,
                                     Descripcion = elemento.Element("Descripcion").Value,
                                     Estado = estado.Element("Nombre").Value,
                                     Entrega = entrega != null ? entrega.Element("Nroacta").Value : "No entregado"
                                 }).ToList();

            return elementoBusquedas;
        }

        
    }
}
