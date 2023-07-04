using Abstraccion;
using BE;
using MPP;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLUrsa : IGestor<BEUrsa>
    {
        MPPUrsa mPPUrsa;

        public BLLUrsa()
        {
            mPPUrsa = new MPPUrsa();
        }

        public bool Actualizar(BEUrsa Object)
        {
            throw new System.NotImplementedException();
        }

        public BEUrsa Agregar(BEUrsa Object)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(BEUrsa Object)
        {
            throw new System.NotImplementedException();
        }

        public BEUrsa ListarObjeto(BEUrsa Object)
        {
            return mPPUrsa.ListarObjeto(Object);
        }

        public List<BEUrsa> ListarTodo()
        {
            return mPPUrsa.ListarTodo();
        }


    }
}
