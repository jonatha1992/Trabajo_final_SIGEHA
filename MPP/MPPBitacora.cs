using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace MPP
{
    public class MPPBitacora
    {
        DALBitacora DALBitacora;
        string NodoPadre = "Usuarios";
        string NodoContenedor = "Usuario";
        public MPPBitacora()
        {
            DALBitacora = new DALBitacora();
        }

        public List<BEEvento> ListarTodo()
        {


            return new List<BEEvento>();
        }


    }
}
