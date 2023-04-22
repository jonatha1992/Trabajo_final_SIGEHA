using Abstraccion;
using BE;
using MPP;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLJerarquia : IGestor<BEJerarquia>
    {

        MPPJerarquia mPPJerarquia;

        public BLLJerarquia()
        {
            mPPJerarquia = new MPPJerarquia();
        }

        public bool Actualizar(BEJerarquia Object)
        {
            throw new System.NotImplementedException();
        }

        public BEJerarquia Agregar(BEJerarquia Object)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(BEJerarquia Object)
        {
            throw new System.NotImplementedException();
        }

        public BEJerarquia ListarObjeto(BEJerarquia bECategoria)
        {
            return mPPJerarquia.ListarObjeto(bECategoria);
        }

        public List<BEJerarquia> ListarTodo()
        {
            var lista = mPPJerarquia.ListarTodo();
            lista.Sort();
            return lista;

        }


    }
}
