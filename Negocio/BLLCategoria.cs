using Abstraccion;
using BE;
using MPP;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLCategoria : IGestor<BECategoria>
    {

        MPPCategoria mPPCateroria;

        public BLLCategoria()
        {
            mPPCateroria = new MPPCategoria();
        }

        public bool Actualizar(BECategoria Object)
        {
            throw new System.NotImplementedException();
        }

        public BECategoria Agregar(BECategoria Object)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(BECategoria Object)
        {
            throw new System.NotImplementedException();
        }

        public BECategoria ListarObjeto(BECategoria bECategoria)
        {
            return mPPCateroria.ListarObjeto(bECategoria);
        }

        public List<BECategoria> ListarTodo()
        {
            return mPPCateroria.ListarTodo();
        }


    }
}
