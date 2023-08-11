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

        public BEArticulo Agregar(BEArticulo Object)
        {
            var exixte = ListarTodo().Exists(x => x.Nombre == Object.Nombre);

            if (exixte)
            {
                return null;
            }

            return mpParticulo.Agregar(Object);
        }
        public bool Eliminar(BEArticulo Object)
        {
            var exixte = ListarTodo().Exists(x => x.Id == Object.Id);
            if (!exixte)
            {
                return false;
            }
            return mpParticulo.Eliminar(Object);
        }

        public bool Actualizar(BEArticulo Object)
        {

            var exixte = ListarTodo().Exists(x => x.Id == Object.Id);

            if (Object.Id == 0)
            {
                return false;
            }

            return mpParticulo.Actualizar(Object);
        }

        public BEArticulo ListarObjeto(BEArticulo Object)
        {
            if (Object.Id == 0)
            {
                return null;
            }
            return mpParticulo.ListarObjeto(Object);
        }

        public List<BEArticulo> ListarTodo()
        {

            return mpParticulo.ListarTodo();
        }

    }
}

