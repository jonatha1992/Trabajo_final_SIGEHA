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
            mPPElemento.Agregar_Elemento_Entrega(eEntrega, elemento);

            return Actualizar(elemento);
        }
        public bool EliminarElementoEntrega(BEElemento elemento)
        {
            mPPElemento.Eliminar_Elemento_Entrega(elemento);
            return Actualizar(elemento);
        }


        public BEElemento Agregar(BEElemento pElemeto)
        {
            throw new NotImplementedException();
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

        public List<ElementoBusqueda> BusquedaElementos(BEArticulo bEArticulo, string Descripcion, string LugarHallazgo, DateTime? Dia, int anio, BEUnidad unidad)
        {
            return mPPElemento.BusquedaElementos(bEArticulo, Descripcion, LugarHallazgo, Dia, anio, unidad);
        }

        public List<ElementoBusqueda> BusquedaElementosHallazgo(string NroActa, string Lugar)
        {

            return mPPElemento.BusquedaElementosHallazgo(NroActa);
        }

    }
}
