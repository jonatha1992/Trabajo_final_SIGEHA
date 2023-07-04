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

        public BEUnidad ListarObjeto(BEUnidad unidad)
        {
            BLLUrsa bLLUrsa = new BLLUrsa();
            unidad = mPPUnidad.ListarObjeto(unidad);
            unidad.Ursa = bLLUrsa.ListarTodo().Find(x => x.Id == unidad.Ursa.Id);
            return unidad;
        }

        public List<BEUnidad> ListarTodo()
        {
            return mPPUnidad.ListarTodo();
        }


    }
}
