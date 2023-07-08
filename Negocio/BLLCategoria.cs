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
            var exixte = ListarTodo().Exists(x => x.Id == Object.Id);

            if (Object.Id == 0)
            {
                return false;
            }

            return mPPCateroria.Actualizar(Object);
        }

        public BECategoria Agregar(BECategoria Object)
        {
            var exixte = ListarTodo().Exists(x => x.Nombre == Object.Nombre);

            if (exixte)
            {
                return null;
            }

            return mPPCateroria.Agregar(Object);
        }

        public bool Eliminar(BECategoria Object)
        {
            var exixte = ListarTodo().Exists(x => x.Id == Object.Id);
            if (!exixte)
            {
                return false;
            }
            return mPPCateroria.Eliminar(Object);
        }

        public BECategoria ListarObjeto(BECategoria bECategoria)
        {
            return mPPCateroria.ListarObjeto(bECategoria);
        }

        public List<BECategoria> ListarTodo()
        {
            return  mPPCateroria.ListarTodo();
        }



    }
}
