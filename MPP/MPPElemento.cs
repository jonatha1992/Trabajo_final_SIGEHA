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
    public class MPPElemento : IGestor<BEElemento>
    {
        Conexion conexion = new Conexion();
        string NodoPadre = "Elementos";
        string NodoContenedor = "Elemento";
        public BEElemento Agregar(BEElemento pElemento)
        {
            throw new NotImplementedException();
        }

        public bool Agregar_Elemento_Hallazgo(BEHallazgo hallazgo, BEElemento elemento)
        {
            var NuevoID = conexion.ObtenerUltimoID(NodoPadre);

            XElement Elemento = new XElement("Elemento",
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
            XElement Elementoxml = conexion.LeerObjeto("Elemento", elemento.Id.ToString()); // Asume que LeerObjeto devuelve un XElement

            if (Elementoxml != null)
            {
                Elementoxml.Add(new XElement("IdEntrega", entrega.Id));  // Añade IdEntrega al Elemento
               
                return conexion.Actualizar("Elementos", elemento.Id.ToString(), Elementoxml); // Actualiza el Elemento entrega el XML
            }

            return false; // No se encontró el Elemento
        }

        public bool Eliminar_Elemento_Entrega(BEElemento elemento)
        {
            XElement Elementoxml = conexion.LeerObjeto("Elemento", elemento.Id.ToString()); // Asume que LeerObjeto devuelve un XElement

            if (Elementoxml != null)
            {
                Elementoxml.Element("IdEntrega")?.Remove(); // Elimina el nodo IdEntrega si existe
                return conexion.Actualizar("Elementos", elemento.Id.ToString(), Elementoxml); // Actualiza el Elemento entrega el XML
            }
            return false;
        }

        public bool Actualizar(BEElemento pElemento)
        {
            XElement Elemento = conexion.LeerObjeto("Elemento", pElemento.Id.ToString()); // Asume que LeerObjeto devuelve un XElement
            if (Elemento != null)
            {
                Elemento.SetElementValue("IdArticulo", pElemento.Articulo.Id);
                Elemento.SetElementValue("IdEstadoElemento", pElemento.Estado.Id);
                Elemento.SetElementValue("Descripcion", pElemento.Descripcion);
                Elemento.SetElementValue("Cantidad", pElemento.Cantidad);
                return conexion.Actualizar("Elementos", pElemento.Id.ToString(), Elemento); // Actualiza el Elemento entrega el XML
            }
            return false; // No se encontró el Elemento
        }
        public bool Eliminar(BEElemento pElemento)
        {
            return conexion.Eliminar(NodoPadre, pElemento.Id.ToString());
        }

        public string ObtenerNroHallazgo(BEElemento bEElemento)
        {
            // Obtener el XElement que corresponde al Elemento
            XElement elementoXml = conexion.LeerObjeto("Elemento", bEElemento.Id.ToString());

            if (elementoXml != null)
            {
                // Obtener el IdHallazgo del Elemento
                string idHallazgo = elementoXml.Element("IdHallazgo")?.Value;

                // Si hay un IdHallazgo, buscar el Hallazgo correspondiente
                if (!string.IsNullOrEmpty(idHallazgo))
                {
                    XElement hallazgoXml = conexion.LeerObjeto("Hallazgo", idHallazgo);

                    // Si el Hallazgo existe, retornar el número
                    if (hallazgoXml != null)
                    {
                        return hallazgoXml.Element("NroActa")?.Value;
                    }
                }
            }
            // Si no se encontró el Elemento o el Hallazgo, retornar un string vacío
            return "";
        }
        public string ObtenerNroEntrega(BEElemento bEElemento)
        {
            // Obtener el XElement que corresponde al Elemento
            XElement elementoXml = conexion.LeerObjeto("Elemento", bEElemento.Id.ToString());

            if (elementoXml != null)
            {
                // Obtener el IdEntrega del Elemento
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
            // Si no se encontró el Elemento o el Hallazgo, retornar un string vacío
            return "";

        }

        public List<BEElemento> ListarTodo()
        {
            List<BEElemento> lista = new List<BEElemento>();

            var Consulta = conexion.LeerTodos(NodoPadre).Descendants(NodoContenedor);

            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         select new BEElemento
                         {
                             Id = Convert.ToInt32((x.Element("Id")?.Value)),
                             Articulo = new BEArticulo(Convert.ToInt32(x.Element("IdArticulo")?.Value)),
                             Descripcion = Convert.ToString(x.Element("Descripcion")?.Value),
                             Cantidad = Convert.ToDouble(x.Element("Cantidad")?.Value),
                             Estado = new BEEstado_Elemento(Convert.ToInt32(x.Element("IdEstado")?.Value)),
                             Hallazgo= new BEHallazgo(Convert.ToInt32(x.Element("IdHallazgo")?.Value)),
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
            MPPArticulo mPPArticulo = new MPPArticulo();
            MPPEstado_Elemento mPPEstado_Elemento = new MPPEstado_Elemento();
            MPPHallazgo mPPHallazgo = new MPPHallazgo();
            MPPEntrega mPPEntrega = new MPPEntrega();

            var Estado_Elementos = mPPEstado_Elemento.ListarTodo();
            var Articulos = mPPArticulo.ListarTodo();
            var Entregas = mPPEntrega.ListarTodo();
            var Hallazgo = mPPHallazgo.ListarTodo().Find(x => x.NroActa == nroActa);




            if (Hallazgo != null)
            {
                foreach (BEElemento elemento in Hallazgo.listaElementos)
                {
                    ElementoBusqueda bElemento = new ElementoBusqueda();
                    bElemento.Id = elemento.Id;
                    bElemento.Cantidad = elemento.Cantidad.ToString();
                    bElemento.Descripcion = elemento.Descripcion;
                    bElemento.Articulo = Articulos.Find(x => x.Id == elemento.Articulo.Id).Nombre;
                    bElemento.Estado = Estado_Elementos.Find(x => x.Id == elemento.Estado.Id).Nombre;
                    bElemento.Hallazgo = Hallazgo.NroActa;
                    bElemento.Lugar = Hallazgo.LugarHallazgo;
                    bElemento.Fecha_hallazgo = Hallazgo.FechaHallazgo.ToString();
                    bElemento.Entrega = ObtenerNroEntrega(new BEElemento(bElemento.Id));
                    //bElemento.Entrega = ObtenerEntregaPorElemento(elemento);

                    lista.Add(bElemento);
                }
            }

            return lista;
        }

        //public string ObtenerEntregaPorElemento(BEElemento elemento)
        //{
        //    MPPElemento mPPElementos = new MPPElemento();

        //    IEnumerable<XElement> todosElementos = conexion.LeerTodos(NodoPadre);

        //    XElement elementoEncontrado = todosElementos.FirstOrDefault(x => (int)x.Element("Id") == elemento.Id);

        //    // Realizamos un chequeo de null para asegurarnos de que se encontró un Elemento con el Id
        //    if (elementoEncontrado != null)
        //    {
        //        // Ahora buscamos la entrega basada entrega el IdEntrega de elementoEncontrado
        //        MPPEntrega mPPEntrega = new MPPEntrega();
        //        IEnumerable<XElement> todasEntregas = conexion.LeerTodos("Entregas");

        //        int IdEntrega = (int)elementoEncontrado.Element("IdEntrega");

        //        XElement entregaEncontrada = todasEntregas.FirstOrDefault(x => (int)x.Element("Id") == IdEntrega);

        //        // Realizamos un chequeo de null para asegurarnos de que se encontró una Entrega con el Id
        //        if (entregaEncontrada != null)
        //        {
        //            return (string)entregaEncontrada.Element("NroActa");

        //        }
        //        else
        //        {
        //            throw new Exception($"No se encontró una Entrega con el Id: {IdEntrega}");
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception($"No se encontró un Elemento con el Id: {elemento.Id}");
        //    }
        //}
    }
}
