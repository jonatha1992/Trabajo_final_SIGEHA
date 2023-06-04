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
    public class MPPJerarquia : IGestor<BEJerarquia>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BEJerarquia Object)
        {
            throw new NotImplementedException();
        }

        public BEJerarquia Agregar(BEJerarquia Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEJerarquia Object)
        {
            throw new NotImplementedException();
        }

        public BEJerarquia ListarObjeto(BEJerarquia jerarquia)
        {
            string Nodo = "Jerarquias";
            var Consulta = conexion.Leer2(Nodo).Descendants("Jerarquia");

            if (Consulta.Count() > 0)
            {
                jerarquia = (from x in Consulta
                            where Convert.ToInt32(x.Element("Id")?.Value) == jerarquia.Id
                            select new BEJerarquia
                            {
                                Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                Jerarquia = Convert.ToString(x.Element("Jerarquia")?.Value),
                                Abreviatura = Convert.ToString(x.Element("Abreviatura")?.Value),
                            }).FirstOrDefault();
            }
            else
            { jerarquia = null; }
            return jerarquia;
        }

        public List<BEJerarquia> ListarTodo()
        {
            string Nodo = "Jerarquias";
            var Consulta = conexion.Leer2(Nodo).Descendants("Jerarquia");

            List<BEJerarquia> jerarquias = new List<BEJerarquia>();

            if (Consulta.Count() > 0)
            {
                jerarquias = (from x in Consulta
                             where Convert.ToInt32(x.Element("Id")?.Value) > 0
                             select new BEJerarquia
                             {
                                 Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                 Jerarquia = Convert.ToString(x.Element("Jerarquia")?.Value),
                                 Abreviatura = Convert.ToString(x.Element("Abreviatura")?.Value),
                             }).ToList<BEJerarquia>();
            }
            else
            { jerarquias = null; }
            return jerarquias;
        }
    }
}
