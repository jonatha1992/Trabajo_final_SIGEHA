using BE;
using MPP;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class BLLUsuario
    {
        MPPUsuario mpPUsuario;

        public BLLUsuario()
        {
            mpPUsuario = new MPPUsuario();
        }

        public List<BEUsuario> ListarTodo()
        {
            return mpPUsuario.ListarTodo();
        }

        public BEUsuario ControlPasswword(string user, string pass)
        {
            var usuario = ListarTodo().Find(x => x.Id == user && x.contraseña == pass);
            if (usuario == null)
            {
                return null;

            }
            else { return usuario; }
        }

        public DataSet ObtenerElementosReporte(BEUrsa ursa, BEUnidad unidad = null)
        {
            return mpPUsuario.ObtenerElementosReporte(ursa, unidad);
        }
    }
}

