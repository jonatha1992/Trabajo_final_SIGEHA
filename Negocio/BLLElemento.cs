using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Negocio
{
    public class BLLElemento : IGestor<BEElemento>
    {
        MPPElemento mPPElemento;


        public BLLElemento()
        {
            mPPElemento = new MPPElemento();

        }
        public bool Actualizar(BEElemento pElemento)
        {
            return mPPElemento.Actualizar(pElemento);
        }
        public bool AgregarElementoHallazgo(BEHallazgo eHallazgo, BEElemento elemento)
        {

            return mPPElemento.Agregar_Elemento_Hallazgo(eHallazgo, elemento);
        }
        public bool AgregarElementoEntrega(BEEntrega eEntrega, BEElemento elemento)
        {
            BLLEstado_Elemento bLLEstado_Elemento = new BLLEstado_Elemento();
            var estadoElemento = bLLEstado_Elemento.ListarTodo().Find(x => x.Nombre == "Entregado");

            if (elemento.Estado.Id == estadoElemento.Id)
            {
                return false;
            }
            elemento.Estado = estadoElemento;

            mPPElemento.Agregar_Elemento_Entrega(eEntrega, elemento);
            return Actualizar(elemento);
        }
        public bool EliminarElementoEntrega(BEEntrega eEntrega, BEElemento elemento)
        {
            BLLEstado_Elemento bLLEstado_Elemento = new BLLEstado_Elemento();
            var estadoResguardo = bLLEstado_Elemento.ListarTodo().Find(x => x.Nombre == "Resguardo");

            if (eEntrega.listaElementos.Exists(x => x.Id == elemento.Id))
            {
                mPPElemento.Eliminar_Elemento_Entrega(elemento);
                elemento.Estado = estadoResguardo;
                return Actualizar(elemento);
            }
            return false;
        }


        public BEElemento Agregar(BEElemento pElemeto)
        {
            return mPPElemento.Agregar(pElemeto);
        }

        public bool Eliminar(BEElemento pElemento)
        {
            return mPPElemento.Eliminar(pElemento);
        }
        public List<BEElemento> ListarTodo()
        {
            return mPPElemento.ListarTodo();
        }

        public BEElemento ListarObjeto(BEElemento pElemento)
        {
            return mPPElemento.ListarObjeto(pElemento);
        }

        public string ObtenerNroHallazgo(BEElemento pElemento)
        {
            string NroActa = mPPElemento.ObtenerNroHallazgo(pElemento);
            return NroActa;
        }

        public string ObtenerNroEntrega(BEElemento pElemento)
        {
            string NroActa = mPPElemento.ObtenerNroEntrega(pElemento);
            return NroActa;
        }

        public List<ElementoBusqueda> BusquedaElementos(DateTime? desde, DateTime? hasta, BECategoria bECategoria, BEArticulo bEArticulo, string lugar, string descripcion, BEUnidad unidad)
        {
            List<ElementoBusqueda> elementoBusquedas = new List<ElementoBusqueda>();

            BLLCategoria bLLCategoria = new BLLCategoria();
            BLLArticulo bLLArticulo = new BLLArticulo();
            BLLHallazgo bLLHallazgo = new BLLHallazgo();
            BLLEntrega bllEntregas = new BLLEntrega();
            BLLElemento bLLElemento = new BLLElemento();

            var categorias = bLLCategoria.ListarTodo();
            var articulos = bLLArticulo.ListarTodo(categorias);
            var hallazgos = bLLHallazgo.ListarTodo();
            var Entregas = bLLHallazgo.ListarTodo();
            var elementos = bLLElemento.ListarTodo();

            // Filtra por fechas
            if (desde != null && hasta != null)
            {
                hallazgos = hallazgos.Where(h => h.FechaHallazgo >= desde && h.FechaHallazgo <= hasta).ToList();
            }

            // Filtra por categoría
            if (bECategoria != null)
            {
                articulos = articulos.Where(a => a.Categoria.Id == bECategoria.Id).ToList();
            }

            // Filtra por artículo
            if (bEArticulo != null)
            {
                elementos = elementos.Where(e => e.Articulo.Id == bEArticulo.Id).ToList();
            }

            // Filtra por lugar
            if (!string.IsNullOrEmpty(lugar))
            {
                hallazgos = hallazgos.Where(h => h.LugarHallazgo.Contains(lugar)).ToList();
            }

            // Filtra por descripción
            if (!string.IsNullOrEmpty(descripcion))
            {
                elementos = elementos.Where(e => e.Descripcion.Contains(descripcion)).ToList();
            }

            // Filtra por unidad
            if (unidad != null)
            {
                hallazgos = hallazgos.Where(h => h.Unidad.Id == unidad.Id).ToList();
            }


            // Genera la lista de resultados
            elementoBusquedas = (from elemento in elementos
                                 join articulo in articulos on elemento.Articulo.Id equals articulo.Id
                                 join hallazgo in hallazgos on elemento.Hallazgo.Id equals hallazgo.Id
                                 join entrega in Entregas on elemento.Entrega.Id equals entrega.Id into entregasJoin
                                 from entrega in entregasJoin.DefaultIfEmpty()
                                 select new ElementoBusqueda
                                 {
                                     Id = elemento.Id,
                                     Fecha_hallazgo = hallazgo.FechaHallazgo.ToString("dd/MM/yyyy HH:mm "),
                                     Hallazgo = hallazgo.NroActa,
                                     Lugar = hallazgo.LugarHallazgo,
                                     Articulo = articulo.Nombre,
                                     Cantidad = elemento.Cantidad.ToString(),
                                     Descripcion = elemento.Descripcion,
                                     Estado = elemento.Estado.Nombre,
                                     Entrega = entrega != null ? entrega.NroActa : "No entregado"
                                 }).ToList();
            return elementoBusquedas;
        }


        public BEElemento CovertirElemento(ElementoBusqueda elementoBusqueda)
        {
            BLLArticulo bLLArticulo = new BLLArticulo();
            var articulos = bLLArticulo.ListarTodo();

            BEElemento Elemento = new BEElemento(elementoBusqueda.Id);
            Elemento = new BEElemento(elementoBusqueda.Id);
            Elemento.Estado = new BEEstado_Elemento();
            Elemento.Descripcion = elementoBusqueda.Descripcion.ToUpper();
            Elemento.Estado.Nombre = elementoBusqueda.Estado;
            Elemento.Cantidad = Convert.ToDouble(elementoBusqueda.Cantidad);
            Elemento.Articulo = articulos.Find(x => x.Nombre == elementoBusqueda.Articulo);
            return Elemento;
        }

        public List<ElementoBusqueda> BusquedaElementosHallazgo(string NroActa, string Lugar)
        {
            return mPPElemento.BusquedaElementosHallazgo(NroActa);
        }

    }
}
