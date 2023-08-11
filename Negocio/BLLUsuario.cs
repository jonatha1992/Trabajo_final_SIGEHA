using Abstraccion;
using BE;
using MPP;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLUsuario : IGestor<BEUsuario>
    {
        MPPUsuario mpPUsuario;
        MPPPermiso mpPpermiso;
        BLLUnidad bllUnidad;
        BLLUrsa blllUrsa;

        public BLLUsuario()
        {
            mpPUsuario = new MPPUsuario();
            mpPpermiso = new MPPPermiso();
            bllUnidad = new BLLUnidad();
            blllUrsa = new BLLUrsa();
        }

        public List<BEUsuario> ListarTodo()
        {
            return mpPUsuario.ListarTodo(); ;
        }
        public BEUsuario ListarObjeto(BEUsuario bEUsuario)
        {

            bEUsuario = mpPpermiso.ObternerPermisoUsuario(bEUsuario);

            if (bEUsuario != null)
            {
                if (bEUsuario.Destino is BEUnidad)
                {
                    bEUsuario.Destino = bllUnidad.ListarObjeto(bEUsuario.Destino as BEUnidad);
                }
                if (bEUsuario.Destino is BEUrsa)
                {
                    bEUsuario.Destino = blllUrsa.ListarObjeto(bEUsuario.Destino as BEUrsa);
                }
            }

            return bEUsuario;



        }
        public BEUsuario ControlPasswword(string nombre, string pass)
        {
            var usuario = ListarTodo().Find(x => x.NombreUsuario == nombre && x.Password == pass);
            if (usuario == null)
                return null;
            else
                return usuario;
        }


        public bool UsuarioTieneRolInstructorOsupervisor(BEUsuario usuario)
        {
            foreach (var item in usuario.Permisos)
            {
                if (ComponenteEsInstructorOSupervisor(item))
                {
                    return true;
                }

            }
            return false;
        }
        bool ComponenteEsInstructorOSupervisor(BEComponente componente)
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
                    if (ComponenteEsInstructorOSupervisor(hijo))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CambiarContraseña(BEUsuario oBEUsu)
        {
            return mpPUsuario.Actualizar(oBEUsu);
        }
        public bool Eliminar(BEUsuario oBEUsu)
        {
            return mpPUsuario.Eliminar(oBEUsu);
        }


        /// <summary>
        /// lo que hace el metodo en si es verificar si es usuario es instructor o supervisor
        /// y no tiene un destino asignado no permite guardar el usuario hasta que no tenga un
        /// destino asginado
        /// </summary>
        public bool GuardarUsuario(BEUsuario oBEUsu)
        {
            if (UsuarioTieneRolInstructorOsupervisor(oBEUsu) && oBEUsu.Destino == null)
            {
                return false;
            }
            else
            {
                if (oBEUsu.Id == 0)
                {
                    Agregar(oBEUsu);
                }
                else
                {
                    Actualizar(oBEUsu);
                }
                mpPUsuario.GuardarPermisosUsuario(oBEUsu);
            }

            return true;
        }

        public BEUsuario Agregar(BEUsuario Object)
        {
            return mpPUsuario.Agregar(Object);
        }

        public bool Actualizar(BEUsuario Object)
        {
            return mpPUsuario.Actualizar(Object);
        }
    }
}

