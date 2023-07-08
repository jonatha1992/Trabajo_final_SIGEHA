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
    public class MPPInstructor : IGestor<BEInstructor>
    {
        Conexion conexion = new Conexion();

        string NodoPadre = "Personas";
        string NodoContenedor = "Persona";


        public BEInstructor Agregar(BEInstructor pinstructor)
        {
            var id = conexion.ObtenerUltimoID(NodoPadre);

            XElement nuevoInstructor = new XElement("Persona",
                new XElement("Id", id),
                new XElement("NombreCompleto", pinstructor.NombreCompleto),
                new XElement("DNI", pinstructor.DNI),
                new XElement("Legajo", pinstructor.Legajo),
                new XElement("IdJerarquia", pinstructor.Jerarquia.Id));

            conexion.Agregar(NodoPadre, nuevoInstructor);

            pinstructor.Id = id;

            return pinstructor;
        }


        public bool Actualizar(BEInstructor pinstructor)
        {

            // Crear un nuevo elemento XML con los datos actualizados.
            XElement elementoActualizado = new XElement("Persona",
                new XElement("NombreCompleto", pinstructor.NombreCompleto),
                new XElement("Legajo", pinstructor.Legajo),
                new XElement("IdJerarquia", pinstructor.Jerarquia.Id),
                new XElement("DNI", pinstructor.DNI)
            );

            // Llamar a la función de actualización con el elemento actualizado.
            return conexion.Actualizar(NodoPadre, pinstructor.Id.ToString(), elementoActualizado);


        }
        public bool Eliminar(BEInstructor Object)
        {
            throw new NotImplementedException();
        }

        public List<BEInstructor> ListarTodo()
        {
            try
            {
                var Consulta = conexion.LeerTodos(NodoPadre).Descendants("Persona");

                List<BEInstructor> lista = new List<BEInstructor>();

                if (Consulta.Count() > 0)
                {
                    lista = (from x in Consulta
                             where x.Element("Legajo")?.Value != null
                             select new BEInstructor
                             {
                                 Id = Convert.ToInt32(x.Element("Id")?.Value),
                                 NombreCompleto = Convert.ToString(x.Element("NombreCompleto")?.Value),
                                 DNI = Convert.ToString(x.Element("DNI")?.Value),
                                 Legajo = Convert.ToInt32(x.Element("Legajo")?.Value),
                                 Jerarquia = new BEJerarquia(Convert.ToInt32(x.Element("IdJerarquia")?.Value)),
                             }).ToList();
                }
                else
                {
                    lista = null;
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public BEInstructor ListarObjeto(BEInstructor instructor)
        {
            MPPJerarquia mPPJerarquia = new MPPJerarquia();

            var Consulta = conexion.LeerObjeto(NodoContenedor, instructor.Id.ToString());

            if (Consulta != null)
            {
                instructor.Id = Convert.ToInt32(Convert.ToString(Consulta.Element("Id")?.Value));
                instructor.Legajo = Convert.ToInt32(Consulta.Element("Legajo")?.Value);
                instructor.NombreCompleto = Convert.ToString(Consulta.Element("NombreCompleto")?.Value);
                instructor.DNI = Convert.ToString(Consulta.Element("DNI")?.Value);
                instructor.Telefono = Convert.ToString(Consulta.Element("Telefono")?.Value);
                instructor.Domicilio = Convert.ToString(Consulta.Element("Domicilio")?.Value);
                instructor.Ocupacion = Convert.ToString(Consulta.Element("Ocupacion")?.Value);
                instructor.Jerarquia = mPPJerarquia.ListarObjeto(new BEJerarquia(Convert.ToInt32(Consulta.Element("IdJerarquia")?.Value)));
            }
            else
            { instructor = null; }
            return instructor;
        }
    }
}
