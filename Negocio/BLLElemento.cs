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
            var estadoEntregado = bLLEstado_Elemento.ListarTodo().Find(x => x.Nombre == "Entregado");

            if (elemento.Estado.Id == estadoEntregado.Id)
            {
                return false;
            }
            elemento.Estado = estadoEntregado;

            return mPPElemento.Agregar_Elemento_Entrega(eEntrega, elemento);
        }
        public bool EliminarElementoEntrega(BEEntrega eEntrega, BEElemento elemento)
        {
            BLLEstado_Elemento bLLEstado_Elemento = new BLLEstado_Elemento();
            var estadoResguardo = bLLEstado_Elemento.ListarTodo().Find(x => x.Nombre == "Resguardo");

            if (eEntrega.listaElementos.Exists(x => x.Id == elemento.Id))
            {
                elemento.Estado = estadoResguardo;
                mPPElemento.Eliminar_Elemento_Entrega(elemento);
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
            
            return mPPElemento.BusquedaElementos( desde,  hasta, bECategoria, bEArticulo, lugar, descripcion, unidad);
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
