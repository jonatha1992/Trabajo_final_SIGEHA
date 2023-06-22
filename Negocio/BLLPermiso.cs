using Abstraccion;
using BE;
using MPP;
using System;
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
        public IList<BEComponente> GetAll(string rol)
        {
            return oMPPPermiso.GetAll(rol);

        }


        //método para taer los permisos de los usuaurios
        public void FillUserComponents(BEUsuario u)
        {
            oMPPPermiso.FillUserComponents(u);

        }

        //método para taer todos las rols con sus permisos
        public void FillFamilyComponents(BERol rol)
        {
            oMPPPermiso.FillFamilyComponents(rol);
        }

    }

}
