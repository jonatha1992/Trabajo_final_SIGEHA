using Abstraccion;
using BE;
using MPP;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLUnidad : IGestor<BEUnidad>
    {
        MPPUnidad mPPUnidad;

        public BLLUnidad()
        {
            mPPUnidad = new MPPUnidad();
        }

        public bool Actualizar(BEUnidad Object)
        {
            throw new System.NotImplementedException();
        }

        public BEUnidad Agregar(BEUnidad Object)
        {
            throw new System.NotImplementedException();
        }

        public bool Eliminar(BEUnidad Object)
        {
            throw new System.NotImplementedException();
        }

        public BEUnidad ListarObjeto(BEUnidad Object)
        {
            throw new System.NotImplementedException();
        }
        //public BEUnidad ListarObjeto(BEUsuario bEUsuario)
        //{
        //    var unidad = mPPUnidad.ListarTodo().Find(x => x.Cod == bEUsuario.Id);

        //    return unidad;
        //}
        public List<BEUnidad> ListarTodo()
        {
            return mPPUnidad.ListarTodo();
        }


    }
}
