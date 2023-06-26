using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Xml.Linq;

namespace MPP
{

    public class MPPPermiso
    {

        Conexion conexion;

        public MPPPermiso()
        {
            conexion = new Conexion();
        }



        public BEComponente GuardarComponente(BEComponente oComp, bool esrol)
        {
            try
            {
                var Id = conexion.ObtenerUltimoID("Permiso") + 1;

                XElement nuevoElemento = new XElement("Permiso",
                    new XElement("Id", Id),
                    new XElement("Nombre", oComp.Nombre),
                    new XElement("EsPermiso", !esrol));

                if (!esrol)
                {
                    nuevoElemento.Add(new XElement("Permiso", oComp.Nombre.ToString()));
                }

                if (!conexion.Agregar("Permiso", nuevoElemento))
                {
                    throw new Exception($"No se pudo agregar el componente {oComp.Nombre}.");
                }

                oComp.Id = Id; // El ID del último elemento agregado
                return oComp;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public bool Guardarrol(BERol oBErol)
        {
            try
            {
                // Eliminar todos los elementos de Permiso_Permiso con id_permiso_padre igual al Id del rol
                if (!conexion.Eliminar("Permiso_Permiso", oBErol.Id.ToString(), "IdPermisoPadre"))
                {
                    throw new Exception("No se pudo eliminar los elementos existentes.");
                }

                // Agregar nuevos elementos de Permiso_Permiso para cada hijo del rol
                foreach (var permiso in oBErol.Hijos)
                {
                    XElement nuevoElemento = new XElement("Permiso_Permiso",
                        new XElement("IdPermisoPadre", oBErol.Id),
                        new XElement("IdPermisoHijo", permiso.Id));

                    if (!conexion.Agregar("Permiso_Permiso", nuevoElemento))
                    {
                        throw new Exception($"No se pudo agregar el elemento con IdPermisoPadre {oBErol.Id} y IdPermisoHijo {permiso.Id}.");
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<BEPermiso> Listarpermisos()
        {

            //instancio un objeto de la clase datos para operar con la BD
            List<BEPermiso> Listapermiso = new List<BEPermiso>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            IEnumerable<XElement> Consulta = conexion.LeerTodos("Permiso");

            foreach (XElement permisoElement in Consulta)
            {
                // Crear un nuevo permiso y establecer sus propiedades basándose en los elementos del XML.
                if (Convert.ToBoolean(permisoElement.Element("EsPermiso").Value) == true)
                {
                    BEPermiso permiso = new BEPermiso
                    {
                        Id = int.Parse(permisoElement.Element("Id").Value),
                        Nombre = permisoElement.Element("Nombre").Value,
                    };
                    // Agregar el permiso a la lista.
                    Listapermiso.Add(permiso);
                }
            }
            return Listapermiso;
        }

        // GetAllrols

        public List<BERol> ListarRoles()
        {  //instancio un objeto de la clase datos para operar con la BD
            List<BERol> Listarol = new List<BERol>();

            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            IEnumerable<XElement> Consulta = conexion.LeerTodos("Permisos").Descendants("Permiso");

            foreach (XElement permisoElement in Consulta)
            {
                // Crear un nuevo permiso y establecer sus propiedades basándose en los elementos del XML.
                if (Convert.ToBoolean(permisoElement.Element("EsPersmiso").Value) == false)
                {
                    BERol rol = new BERol
                    {
                        Id = int.Parse(permisoElement.Element("Id").Value),
                        Nombre = permisoElement.Element("Nombre").Value,
                    };
                    // Agregar el permiso a la lista.
                    Listarol.Add(rol);
                }

            }

            return Listarol;
        }

        public IList<BEComponente> ObternerPermisosRol(BERol rol)
        {
            // LeerTodos para obtener todos los elementos de "Permiso"
            IList<BEPermiso> todosLosPermisos = Listarpermisos();

            var todosLosPermisosAsociados = conexion.LeerTodos("Permiso_Permiso");

            // Buscar todos los permisos asociado a este rol 
            var permisosAsociados = todosLosPermisosAsociados
                .Where(e => e.Element("IdPermisoPadre").Value == rol.Id.ToString());

            // Crear una lista para almacenar todos los permisos asociados a este rol
            var permisosLista = new List<BEComponente>();

            // Por cada permiso asociado, obtener todos sus permisos (recursivamente) y agregarlos a la lista
            foreach (var permisoAsociado in permisosAsociados)
            {
                BEPermiso permiso = todosLosPermisos.First(x => x.Id == Convert.ToInt32(permisoAsociado.Element("IdPermisoHijo")?.Value));

                permisosLista.Add(permiso);
            }

            return permisosLista;
        }


        public BEUsuario ObternerPermisoUsuario(BEUsuario user)
        {
            // Usar LeerTodos para obtener todos los elementos de "usuarios_permisos"
            var todosLosPermisosUsuario = conexion.LeerTodos("Usuario_Permiso");

            // Buscar todos roles asociados con este usuario
            var permisosUsuarios = todosLosPermisosUsuario
                .Where(up => up.Element("IdUsuario").Value == user.Id.ToString());

            // Limpiar la lista de permisos del usuario
            //user.Permisos.Clear();

            // Iterar sobre cada rol del usuario
            foreach (var permisoUsuario in permisosUsuarios)
            {
                // Recuperar el permiso o rol asociado con este permiso de usuario
                var permiso = conexion.LeerTodos("Permiso")
                    .FirstOrDefault(p => p.Element("Id").Value == permisoUsuario.Element("IdPermiso").Value);

                if (permiso == null)
                    continue;  // Ignorar si no se encontró el permiso

                BEComponente componente;
                {
                    componente = new BERol
                    {
                        Id = Convert.ToInt32(permiso.Element("Id").Value),
                        Nombre = permiso.Element("Nombre").Value,
                    };

                    // Obtener los permisos del rol

                    var permisosRol = ObternerPermisosRol(componente as BERol);
                    foreach (var permisoRol in permisosRol)
                    {
                        componente.AgregarHijo(permisoRol);
                    }
                }

                user.Permisos.Add(componente);
            }
            return user;
        }


        public void BuscarRolComponents(BERol rol)
        {
            rol.VaciarHijos();

            // Obtener todos los permisos asociados con el rol
            var permisosRol = ObternerPermisosRol(rol);

            foreach (var permiso in permisosRol)
            {
                rol.AgregarHijo(permiso);
            }
        }

    }

}
