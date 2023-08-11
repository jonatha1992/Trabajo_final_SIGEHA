using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;

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

            elemento.Estado = estadoEntregado;
            return mPPElemento.Agregar_Elemento_Entrega(eEntrega, elemento);
        }
        public bool EliminarElementoEntrega(BEEntrega eEntrega, BEElemento elemento)
        {
            BLLEstado_Elemento bLLEstado_Elemento = new BLLEstado_Elemento();
            var estadoResguardo = bLLEstado_Elemento.ListarTodo().Find(x => x.Nombre == "Resguardo");

            elemento.Estado = estadoResguardo;
            return mPPElemento.Eliminar_Elemento_Entrega(elemento);
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

        public List<ElementoBusqueda> BusquedaElementos(DateTime? desde, DateTime? hasta, BECategoria bECategoria, BEArticulo bEArticulo, string lugar, string descripcion, BEUnidad unidad, string nrohallazgo)
        {

            if (!string.IsNullOrEmpty(nrohallazgo))
            {
                // Asegurarse de que nrohallazgo tenga siempre cuatro cifras con ceros a la izquierda
                nrohallazgo = nrohallazgo.PadLeft(4, '0').Substring(0, 4);
            }
            return mPPElemento.BusquedaElementos(desde, hasta, bECategoria, bEArticulo, lugar, descripcion, unidad, nrohallazgo);
        }

        public BEElemento CovertirElemento(ElementoBusqueda elementoBusqueda)
        {
            BEElemento bEElemento = ListarObjeto(new BEElemento(elementoBusqueda.Id));
            return bEElemento;

        }

        public List<ElementoBusqueda> BusquedaElementosHallazgo(string NroActa)
        {
            return mPPElemento.BusquedaElementosHallazgo(NroActa);
        }



    }
}
