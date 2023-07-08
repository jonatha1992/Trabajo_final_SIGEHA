using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPPersona : IGestor<BEPersona>
    {
        Conexion conexion = new Conexion();
        string NodoPadre = "Personas";
        string NodoContenedor = "Persona";
        public BEPersona Agregar(BEPersona bEPersona)
        {
            var NuevoID = conexion.ObtenerUltimoID(NodoPadre);

            XElement Persona = new XElement("Persona",
          new XElement("Id", NuevoID),
          new XElement("NombreCompleto", bEPersona.NombreCompleto),
          new XElement("DNI", bEPersona.DNI),
          new XElement("Domicilio", bEPersona.Domicilio),
          new XElement("Ocupacion", bEPersona.Ocupacion),
          new XElement("Telefono", bEPersona.Telefono)

          );

            conexion.Agregar(NodoPadre, Persona);

            bEPersona.Id = NuevoID;
            return bEPersona;
        }

        public bool Actualizar(BEPersona pPersona)
        {

            XElement bEPersona = new XElement("Persona",
                     new XElement("Id", pPersona.Id),
                     new XElement("DNI", pPersona.DNI),
                     new XElement("NombreCompleto", pPersona.NombreCompleto),
                     new XElement("Domicilio", pPersona.Domicilio),
                     new XElement("Ocupacion", pPersona.Ocupacion),
                     new XElement("Telefono", pPersona.Telefono)
                     );

            return conexion.Actualizar(NodoPadre, pPersona.Id.ToString(), bEPersona);
        }

        public bool Eliminar(BEPersona pPersona)
        {
            return conexion.Eliminar(NodoPadre, pPersona.Id.ToString());
        }

        public List<BEPersona> ListarTodo()
        {
            string Nodo = "Personas";
            var Consulta = conexion.LeerTodos(Nodo).Descendants("Persona");

            List<BEPersona> Lista = new List<BEPersona>();

            if (Consulta.Count() > 0)
            {
                Lista = (from x in Consulta
                         select new BEPersona
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             NombreCompleto = Convert.ToString(x.Element("NombreCompleto")?.Value),
                             DNI = Convert.ToString(x.Element("DNI")?.Value),
                             Telefono = Convert.ToString(x.Element("Telefono")?.Value),
                             Domicilio = Convert.ToString(x.Element("Domicilio")?.Value),
                             Ocupacion = Convert.ToString(x.Element("Ocupacion")?.Value),
                         }).ToList();
            }
            else
            { Lista = null; }
            return Lista;
        }

        public BEPersona ListarObjeto(BEPersona pPersona)
        {
            var Consulta = conexion.LeerObjeto(NodoContenedor, pPersona.Id.ToString());

            if (Consulta != null)
            {
                pPersona.Id = Convert.ToInt32(Convert.ToString(Consulta.Element("Id")?.Value));
                pPersona.NombreCompleto = Convert.ToString(Consulta.Element("NombreCompleto")?.Value);
                pPersona.DNI = Convert.ToString(Consulta.Element("DNI")?.Value);
                pPersona.Telefono = Convert.ToString(Consulta.Element("Telefono")?.Value);
                pPersona.Domicilio = Convert.ToString(Consulta.Element("Domicilio")?.Value);
                pPersona.Ocupacion = Convert.ToString(Consulta.Element("Ocupacion")?.Value);
            }
            else
            { pPersona = null; }
            return pPersona;
        }


        public bool AgregarPersonaHallazgo(BEHallazgo hallazgo, BEPersona ePersona)
        {


            XElement personaElement = new XElement("Hallazgo_Persona",
                    new XElement("IdHallazgo", hallazgo.Id),
                    new XElement("IdPersona", ePersona.Id),
                    new XElement("IdEstado", ePersona.EstadoPersona.Id));

            return conexion.Agregar("Hallazgo_Personas", personaElement);
        }

        public bool AgregarPersonaEntrega(BEEntrega entrega, BEPersona ePersona)
        {

            XElement personaElement = new XElement("Entrega_Persona",
                  new XElement("IdEntrega", entrega.Id),
                  new XElement("IdPersona", ePersona.Id),
                  new XElement("IdEstado", ePersona.EstadoPersona.Id));

            return conexion.Agregar("Entrega_Personas", personaElement);
        }


        public bool EliminarPersonaHallazgo(BEHallazgo hallazgo, BEPersona persona)
        {
            return conexion.EliminarConCriterio("Hallazgo_Personas", x => x.Element("IdHallazgo").Value == hallazgo.Id.ToString() && x.Element("IdPersona").Value == persona.Id.ToString());
        }

        public bool EliminarPersonaEntrega(BEEntrega entrega, BEPersona persona)
        {
            return conexion.EliminarConCriterio("Entrega_Personas", x => x.Element("IdEntrega").Value == entrega.Id.ToString() && x.Element("IdPersona").Value == persona.Id.ToString());
        }

    }
}
