using BE;
using MPP;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class BLLUsuario
    {
        MPPUsuario mpPUsuario;
        MPPPermiso mpPpermiso;

        public BLLUsuario()
        {
            mpPUsuario = new MPPUsuario();
            mpPpermiso = new MPPPermiso();
        }

        public List<BEUsuario> ListarTodo()
        {
            return mpPUsuario.ListarTodo();
        }
        public BEUsuario ListarObjeto(BEUsuario bEUsuario)
        {
            return mpPUsuario.ListarObjeto(bEUsuario);
        }


        public BEUsuario ControlPasswword(string nombre, string pass)
        {
            var usuario = ListarTodo().Find(x => x.NombreUsuario == nombre && x.Password == pass);
            if (usuario == null)
                return null;
            else
                return usuario;
        }


        public DataSet ObtenerElementosReporte(BEUrsa ursa, BEUnidad unidad = null)
        {
            return mpPUsuario.ObtenerElementosReporte(ursa, unidad);
        }


        public BEUsuario ListarUsuarioConPermisos(BEUsuario bEUsuario)
        {

            bEUsuario = mpPpermiso.ObternerPermisoUsuario(bEUsuario);

            return bEUsuario;
        }


        public bool verificarol(BEUsuario usuario)
        {
            foreach (var item in usuario.Permisos)
            {
                if (VerificarRolUsuario(item))
                {
                    return true;
                }

            }
            return false;
        }

        bool VerificarRolUsuario(BEComponente componente)
        {

            if (componente is BERol)
            {
                // Verificar si el rol es "Instructor" o "Supervisor"
                if (componente.Nombre == "Instructor" || componente.Nombre == "Supervisor")
                {
                    return true;
                }

                // Verificar los roles de los hijos recursivamente
                foreach (BEComponente hijo in componente.Hijos)
                {
                    if (VerificarRolUsuario(hijo))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool CambiarContraseña(BEUsuario oBEUsu)
        {
            return true;
        }
        public bool Eliminar(BEUsuario oBEUsu)
        {
            return mpPUsuario.Eliminar(oBEUsu);
        }

        public bool GuardarUsuario(BEUsuario oBEUsu)
        {
            if (oBEUsu.Id == 0)
            {
                mpPUsuario.Agregar(oBEUsu);
            }
            else
            {
                mpPUsuario.Actualizar(oBEUsu);
            }

            mpPUsuario.GuardarPermisosUsuario(oBEUsu);

            return true;
        }
    }
}

