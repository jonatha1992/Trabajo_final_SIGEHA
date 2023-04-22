using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLEstado_Elemento : IGestor<BEEstado_Elemento>
    {
        MPPEstado_Articulo mPPEstado_Articulo;
        public BLLEstado_Elemento()
        {
            mPPEstado_Articulo = new MPPEstado_Articulo();
        }
        public bool Actualizar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public BEEstado_Elemento Agregar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public BEEstado_Elemento ListarObjeto(BEEstado_Elemento Object)
        {
            return mPPEstado_Articulo.ListarObjeto(Object);
        }

        public List<BEEstado_Elemento> ListarTodo()
        {
            return mPPEstado_Articulo.ListarTodo();
        }
    }
}
