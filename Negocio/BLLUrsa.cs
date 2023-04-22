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

        public BEUrsa ListarObjeto(BEUsuario bEUsuario)
        {
            var lista = mPPUrsa.ListarTodo();
            var tipo = bEUsuario.Id;
            BEUrsa ursa = new BEUrsa();
            switch (tipo)
            {
                case "REGION1":
                    ursa = lista.Find(x => x.Id == 1);
                    break;
                case "REGION2":
                    ursa = lista.Find(x => x.Id == 2);
                    break;
                case "REGION3":
                    ursa = lista.Find(x => x.Id == 3);
                    break;
                case "REGION4":
                    ursa = lista.Find(x => x.Id == 3);
                    break;
                case "REGION5":
                    ursa = lista.Find(x => x.Id == 3);
                    break;
            }
            return ursa;
        }

        public List<BEUrsa> ListarTodo()
        {
            return mPPUrsa.ListarTodo();
        }


    }
}
