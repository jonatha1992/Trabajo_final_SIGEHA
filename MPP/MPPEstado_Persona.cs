using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Linq;

namespace MPP
{
    public class MPPEstado_Persona : IGestor<BEEstado_Persona>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BEEstado_Persona Object)
        {
            throw new NotImplementedException();
        }

        public BEEstado_Persona Agregar(BEEstado_Persona Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEEstado_Persona Object)
        {
            throw new NotImplementedException();
        }


        public BEEstado_Persona ListarObjeto(BEEstado_Persona pEstadoPersona)
        {
            string Nodo = "Estado_Personas";
            var Consulta = conexion.Leer2(Nodo).Descendants("Estado_Persona");

            if (Consulta.Count() > 0)
            {
                pEstadoPersona = (from x in Consulta
                                  where Convert.ToInt32(x.Element("Id")?.Value) > 0
                                  select new BEEstado_Persona
                                  {
                                      Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                      Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                                  }).FirstOrDefault();

            }
            else
            { pEstadoPersona = null; }
            return pEstadoPersona;
        }
        public List<BEEstado_Persona> ListarTodo()
        {
            string Nodo = "Estado_Personas";
            var Consulta = conexion.Leer2(Nodo).Descendants("Estado_Persona");


            List<BEEstado_Persona> lista = new List<BEEstado_Persona>();

            if (Consulta.Count() > 0)
            {
                lista = (from x in Consulta
                         where Convert.ToInt32(x.Element("Id")?.Value) > 0
                         select new BEEstado_Persona
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                         }).ToList<BEEstado_Persona>(); ;
            }
            else
            {
                lista = null;
            }

            return lista;
        }


    }
}
