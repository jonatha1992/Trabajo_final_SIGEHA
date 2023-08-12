using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPUsuario
    {
        Conexion conexion = new Conexion();
        string NodoPadre = "Usuarios";

        public BEUsuario Agregar(BEUsuario NuevoUser)
        {
            var NuevoID = conexion.ObtenerUltimoID(NodoPadre);

            XElement Usuario = new XElement("Usuario",
          new XElement("Id", NuevoID),
          new XElement("NombreUsuario", NuevoUser.NombreUsuario),
          new XElement("NombreCompleto", NuevoUser.NombreCompleto),
          new XElement("DNI", NuevoUser.DNI),
          new XElement("Password", NuevoUser.Password));

            if (NuevoUser.Destino is BEUnidad)
            {
                Usuario.Add(new XElement("IdUnidad", NuevoUser.Destino.Id));

            }
            if (NuevoUser.Destino is BEUrsa)
            {
                Usuario.Add(new XElement("IdUrsa", NuevoUser.Destino.Id));
            }






            NuevoUser.Id = NuevoID;
            conexion.Agregar(NodoPadre, Usuario);
            return NuevoUser;

        }
        public bool Actualizar(BEUsuario pUsuario)
        {
            try
            {
                XElement UsuarioExistente = conexion.LeerObjeto("Usuario", pUsuario.Id.ToString());

                if (UsuarioExistente != null)
                {
                    UsuarioExistente.SetElementValue("NombreUsuario", pUsuario.NombreUsuario);
                    UsuarioExistente.SetElementValue("NombreCompleto", pUsuario.NombreCompleto);
                    UsuarioExistente.SetElementValue("DNI", pUsuario.DNI);
                    UsuarioExistente.SetElementValue("Password", pUsuario.Password);

                    if (pUsuario.Destino is BEUnidad)
                    {
                        UsuarioExistente.SetElementValue("IdUnidad", pUsuario.Destino.Id);
                        UsuarioExistente.Element("IdUrsa")?.Remove();
                    }
                    else if (pUsuario.Destino is BEUrsa)
                    {
                        UsuarioExistente.SetElementValue("IdUrsa", pUsuario.Destino.Id);
                        UsuarioExistente.Element("IdUnidad")?.Remove();
                    }

                }
                return conexion.Actualizar(NodoPadre, pUsuario.Id.ToString(), UsuarioExistente);

            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
        public bool Eliminar(BEUsuario user)
        {
            return conexion.Eliminar(NodoPadre, user.Id.ToString());
        }

        public bool GuardarPermisosUsuario(BEUsuario oBEUsu)
        {
            try
            {
                // Elimina los permisos existentes del usuario
                conexion.Eliminar("Usuario_Permisos", oBEUsu.Id.ToString(), "IdUsuario", true);

                // Agrega los nuevos permisos
                foreach (var permiso in oBEUsu.Permisos)
                {
                    var permisoUsuarioElement = new XElement("Usuario_Permiso",
                        new XElement("IdUsuario", oBEUsu.Id),
                        new XElement("IdPermiso", permiso.Id));

                    conexion.Agregar("Usuario_Permisos", permisoUsuarioElement);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BEUsuario> ListarTodo()
        {
            string Nodo = "Usuarios";
            var Consulta = conexion.LeerTodos(Nodo).Descendants("Usuario");

            List<BEUsuario> lista = new List<BEUsuario>();

            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         select new BEUsuario
                         {
                             Id = Convert.ToInt32((x.Element("Id").Value)),
                             NombreUsuario = Convert.ToString(x.Element("NombreUsuario")?.Value),
                             NombreCompleto = Convert.ToString(x.Element("NombreCompleto")?.Value),
                             Password = Convert.ToString(x.Element("Password")?.Value),
                             DNI = Convert.ToString(x.Element("DNI")?.Value),
                             Destino = ObtenerDestino(x)

                         }).ToList();
            }
            else
            {
                lista = null;
            }
            return lista;
        }

        private BEDestino ObtenerDestino(XElement elemento)
        {
            XElement elementoIdUrsa = elemento.Element("IdUrsa");
            XElement elementoIdUnidad = elemento.Element("IdUnidad");

            if (elementoIdUrsa != null)
            {
                return new BEUrsa(Convert.ToInt32(elementoIdUrsa.Value));

            }
            else if (elementoIdUnidad != null)
            {
                return new BEUnidad(Convert.ToInt32(elementoIdUnidad.Value));
            }
            else
            {
                return null;
            }
        }


        public BEUsuario ListarObjeto(BEUsuario Usuario)
        {
            throw new NotImplementedException();
        }

       

    }
}
