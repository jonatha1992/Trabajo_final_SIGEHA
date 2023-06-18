using Abstraccion;
using BE;
using MPP;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLPermiso : IGestor<BEPermiso>
    {

        MPPPermiso mPPPermiso;

        public BLLPermiso()
        {
            mPPPermiso = new MPPPermiso();
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
            return mPPCateroria.ListarTodo();
        }


        public void  BuscarPermisosUsuario(BEInstructor usuario)
        {

        }

    }
}
