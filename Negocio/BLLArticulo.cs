using Abstraccion;
using BE;
using MPP;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLArticulo : IGestor<BEArticulo>
    {
        MPPArticulo mpParticulo;

        public BLLArticulo()
        {
            mpParticulo = new MPPArticulo();
        }

        public bool Actualizar(BEArticulo Object)
        {
            throw new System.NotImplementedException();
        }

        public BEArticulo Agregar(BEArticulo Object)
        {
            throw new System.NotImplementedException();
        }

        public List<BEArticulo> ListarTodo()
        {
            return mpParticulo.ListarTodo();
        }

        public bool Eliminar(BEArticulo Object)
        {
            throw new System.NotImplementedException();
        }

        public BEArticulo ListarObjeto(BEArticulo Object)
        {
            throw new System.NotImplementedException();
        }


    }
}

