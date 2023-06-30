using BE;
using MPP;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class BLLBitacora
    {
        MPPBitacora mpPBitacora;

        public BLLBitacora()
        {
            mpPBitacora = new MPPBitacora();
        }

        public List<BEEvento> ListarTodo()
        {
            return mpPBitacora.ListarTodo();
        }
      

    }
}

