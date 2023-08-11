using BE;
using MPP;
using System.Collections.Generic;

namespace Negocio
{
    public class BLLPermiso
    {

        //instancio el objeto Mapper de permisos
        MPPPermiso oMPPPermiso;
        public BLLPermiso()
        {
            oMPPPermiso = new MPPPermiso();
        }

        //método para sabner si existe

        public bool ExistePermiso(BEComponente Contenedor, BEComponente Nuevo)
        {
            bool existe = false;

            if (Contenedor.Id.Equals(Nuevo.Id))
                existe = true;
            else

                foreach (var item in Contenedor.Hijos)
                {

                    existe = ExistePermiso(item, Nuevo);
                    if (existe) return true;
                }
            return existe;
        }




        //método para crear Roles y permisos
        public BEComponente CrearComponente(BEComponente p, bool esrol)
        {
            return oMPPPermiso.CrearComponente(p, esrol);
        }

        //método para guardar  rols
        public void GuardaRol(BERol c)
        {
            oMPPPermiso.GuardarRol(c);
        }

        //método para taer todas las permisos
        public List<BEPermiso> Listarpermisos()
        {

            return oMPPPermiso.Listarpermisos();
        }

        //método para taer todas las rols
        public List<BERol> ListaRoles()
        {
            var roles = oMPPPermiso.ListarRoles();
            foreach (var rol in roles)
            {
                var permisos = ObternerPermisosRol(rol);

                foreach (var permiso in permisos)
                {
                    rol.AgregarHijo(permiso);
                }
            }

            return roles;
        }

        //método para taer todas las permisos
        public List<BEComponente> ObternerPermisosRol(BERol rol)
        {
            return oMPPPermiso.ObternerPermisosRol(rol);

        }
        public bool EliminarRol(BERol rol)
        {
            return oMPPPermiso.EliminarRol(rol);
        }

        //método para taer los permisos de un usuario para el menu
        public List<string> ObternerPermisosMenu(BEUsuario user)
        {
            if (user.Permisos.Count == 0)
            {
                user = oMPPPermiso.ObternerPermisoUsuario(user);
            }

            List<string> nombresPermisos = new List<string>();

            foreach (var permiso in user.Permisos)
            {
                AgregarNombresPermisos(permiso, nombresPermisos);
            }
            return nombresPermisos;

        }

        private void AgregarNombresPermisos(BEComponente permiso, List<string> nombresPermisos)
        {
            nombresPermisos.Add(permiso.Nombre);
            if (permiso is BERol rol)
            {
                foreach (var permisoHijo in rol.Hijos)
                {
                    AgregarNombresPermisos(permisoHijo, nombresPermisos);
                }
            }
        }




    }

}
