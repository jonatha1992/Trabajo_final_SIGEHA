using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool Existe(BEComponente c, int id)
        {
            bool existe = false;

            if (c.Id.Equals(id))
                existe = true;
            else

                foreach (var item in c.Hijos)
                {

                    existe = Existe(item, id);
                    if (existe) return true;
                }
            return existe;
        }

        

        //método para guardar  los permisosm en la rol
        public BEComponente GuardarComponente(BEComponente p, bool esrol)
        {
            return oMPPPermiso.GuardarComponente(p, esrol);
        }

        //método para guardar  rols
        public void Guardarrol(BERol c)
        {
            oMPPPermiso.Guardarrol(c);
        }

        //método para taer todas las permisos
        public IList<BEPermiso> Listarpermisos()
        {
            return oMPPPermiso.Listarpermisos();
        }

        //método para taer todas las rols
        public IList<BERol> ListaRoles()
        {
            return oMPPPermiso.ListarRoles();
        }

        //método para taer todas las permisos
        public IList<BEComponente> ObternerPermisosRol(string rol)
        {
            return oMPPPermiso.ObternerPermisosRol(rol);

        }


        //método para taer los permisos de un usuario
        public List<string> ObternerPermisosUsuario(BEUsuario user)
        {
            user =  oMPPPermiso.ObternerPermisoUsuario(user);
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

        //método para taer todos las rols con sus permisos
        public void BuscarRolComponents(BERol rol)
        {
            oMPPPermiso.BuscarRolComponents(rol);
        }

    }

}
