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
        //public Array GetAllPermission()
        //{
        //    return Enum.GetValues(typeof(BETipoPermiso));
        //}


        //public BEComponente GuardarComponente(BEComponente oComp, bool esrol)
        //{
        //    try
        //    {
        //        string consulta_sql = $@"INSERT INTO permiso (nombre,permiso) VALUES (@nombre,@permiso)";

        //        List<SqlParameter> LParametros = new List<SqlParameter>();
        //        LParametros.Add(new SqlParameter("nombre", oComp.Nombre));


        //        if (esrol)
        //            LParametros.Add(new SqlParameter("permiso", DBNull.Value));

        //        else
        //            LParametros.Add(new SqlParameter("permiso", oComp.Permiso.ToString()));

        //        oDatos.EscribirV2(consulta_sql, LParametros);

        //        string consulta_sql2 = "SELECT ID AS LastID FROM permiso WHERE ID = @@Identity";


        //        var id = oDatos.LeerScalar(consulta_sql2, null);
        //        oComp.Id = (int)id;
        //        return oComp;
        //    }
        //    catch (Exception e)
        //    {


        //        throw e;
        //    }

        //}


        //public bool Guardarrol(BERol oBErol)
        //{


        //    try
        //    {
        //        bool RTA = false;

        //        var Sql = $@"delete from permiso_permiso where id_permiso_padre=@id";

        //        List<SqlParameter> LParametros1 = new List<SqlParameter>();


        //        LParametros1.Add(new SqlParameter("id", oBErol.Id));
        //        oDatos.EscribirV2(Sql, LParametros1);

        //        foreach (var item in oBErol.Hijos)
        //        {
        //            string Sql2 = $@"insert into permiso_permiso (id_permiso_padre,id_permiso_hijo) values (@id_permiso_padre,@id_permiso_hijo) ";

        //            List<SqlParameter> LParametros2 = new List<SqlParameter>();

        //            LParametros2.Add(new SqlParameter("id_permiso_padre", oBErol.Id));
        //            LParametros2.Add(new SqlParameter("id_permiso_hijo", item.Id));

        //            Acceso oDatos2 = new Acceso();
        //            RTA = oDatos2.EscribirV2(Sql2, LParametros2); ;
        //        }
        //        return RTA;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;

        //    }


        //}


        public IList<BEPermiso> Listarpermisos()
        {

            //instancio un objeto de la clase datos para operar con la BD
            List<BEPermiso> Listapermiso = new List<BEPermiso>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            IEnumerable<XElement> Consulta = conexion.LeerTodos("Permisos").Descendants("Permiso");

            foreach (XElement permisoElement in Consulta)
            {
                // Crear un nuevo permiso y establecer sus propiedades basándose en los elementos del XML.
                if (Convert.ToBoolean(permisoElement.Element("EsPersmiso").Value) == true)
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

        public IList<BEComponente> GetAll(string rol)
        {
            var where = "is NULL";

            if (!String.IsNullOrEmpty(rol))
            {
                where = rol;
            }

            string Consulta = $@"with recursivo as (
                            select sp2.id_permiso_padre, sp2.id_permiso_hijo  from permiso_permiso SP2
                            where sp2.id_permiso_padre {where} --acá se va variando la rol que busco
                            UNION ALL 
                            select sp.id_permiso_padre, sp.id_permiso_hijo from permiso_permiso sp 
                            inner join recursivo r on r.id_permiso_hijo= sp.id_permiso_padre
                             )
                           select r.id_permiso_padre,r.id_permiso_hijo,p.id,p.nombre, p.permiso
                           from recursivo r 
                           inner join permiso p on r.id_permiso_hijo = p.id 
                           ";

            List<BEComponente> ListaComponente = new List<BEComponente>();
            DataSet Ds;
            Ds = oDatos.Leer(Consulta, null);

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    int id_padre = 0;
                    var id = Convert.ToInt32(fila["id"]);
                    var nombre = fila["nombre"].ToString();

                    var permiso = string.Empty;
                    if (fila["permiso"] != DBNull.Value)
                        permiso = fila["permiso"].ToString();

                    BEComponente c;

                    if (string.IsNullOrEmpty(permiso))
                        c = new BERol();
                    else
                        c = new BEPermiso();

                    c.Id = id;
                    c.Nombre = nombre;

                    if (!string.IsNullOrEmpty(permiso))

                        c.Permiso = (BETipoPermiso)Enum.Parse(typeof(BETipoPermiso), permiso);


                    var padre = GetComponent(id_padre, ListaComponente);

                    if (padre == null)
                    {
                        ListaComponente.Add(c);
                    }
                    else
                    {
                        padre.AgregarHijo(c);
                    }
                }
            }

            return ListaComponente;

        }

        private BEComponente GetComponent(int id, IList<BEComponente> Lista)
        {

            BEComponente component = Lista != null ? Lista.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;

            if (component == null && Lista != null)
            {
                foreach (var c in Lista)
                {

                    var l = GetComponent(id, c.Hijos);
                    if (l != null && l.Id == id) return l;
                    else
                    if (l != null)
                        return GetComponent(id, l.Hijos);

                }
            }



            return component;



        }

        public void ObternerComponentesUsuario(BEUsuario oBEUsu)
        {

            string Consulta = "select p.* from usuarios_permisos up inner join permiso p on up.id_permiso=p.id where id_usuario=@id";

            List<SqlParameter> LParametros = new List<SqlParameter>();
            LParametros.Add(new SqlParameter("id", oBEUsu.Id));
            DataSet Ds;
            oDatos = new Acceso();
            Ds = oDatos.Leer(Consulta, LParametros);

            oBEUsu.Permisos.Clear();

            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    int idp = Convert.ToInt32(fila["id"]);
                    string nombrep = fila["nombre"].ToString();
                    string permisop = String.Empty;

                    if (fila["permiso"] != DBNull.Value)
                        permisop = fila["permiso"].ToString();

                    BEComponente c1;

                    if (!String.IsNullOrEmpty(permisop))
                    {
                        c1 = new BEPermiso();
                        c1.Id = idp;
                        c1.Nombre = nombrep;
                        c1.Permiso = (BETipoPermiso)Enum.Parse(typeof(BETipoPermiso), permisop);
                        oBEUsu.Permisos.Add(c1);
                    }
                    else
                    {
                        c1 = new BERol();
                        c1.Id = idp;
                        c1.Nombre = nombrep;

                        var f = GetAll("=" + idp);

                        foreach (var rol in f)
                        {
                            c1.AgregarHijo(rol);
                        }
                        oBEUsu.Permisos.Add(c1);
                    }

                }

            }


        }
        public void FillFamilyComponents(BERol orol)
        {
            orol.VaciarHijos();
            foreach (var item in GetAll("=" + orol.Id))
            {
                orol.AgregarHijo(item);
            }
        }

    }

}
