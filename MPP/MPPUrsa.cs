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
    public class MPPUrsa : IGestor<BEUrsa>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BEUrsa Object)
        {
            throw new NotImplementedException();
        }

        public BEUrsa Agregar(BEUrsa Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEUrsa Object)
        {
            throw new NotImplementedException();
        }
         

        public BEUrsa ListarObjeto(BEUrsa pursa)
        {
            string Nodo = "Ursas";
            var Consulta = conexion.LeerTodos(Nodo).Descendants("Ursa");

            if (Consulta.Count() > 0)
            {
                pursa = (from x in Consulta
                              where Convert.ToInt32(x.Element("Id")?.Value) > 0
                              select new BEUrsa
                              {
                                  Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                  Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                              }).FirstOrDefault();

                Nodo = "Unidades";
                Consulta = conexion.LeerTodos(Nodo).Descendants("Unidad");
                if (Consulta.Count() > 0)
                {

                    pursa.Unidades= new List<BEUnidad>();

                    pursa.Unidades = (from x in Consulta
                                            where Convert.ToInt32(x.Element("Id_categoria")?.Value) == pursa.Id
                                            select new BEUnidad
                                            {
                                                Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                                Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                                                Cod = Convert.ToString(x.Element("Cod")?.Value),
                                                Ursa= new BEUrsa(pursa.Id)
                                            }).ToList<BEUnidad>();
                }
            }
            else
            { pursa = null; }
            return pursa;
        }
        public List<BEUrsa> ListarTodo()
        {
            string Nodo = "Ursas";
            var Consulta = conexion.LeerTodos(Nodo).Descendants("Ursa");


            List<BEUrsa> lista = new List<BEUrsa>();

            if (Consulta.Count() > 0)
            {
                 lista = (from x in Consulta
                             where Convert.ToInt32(x.Element("Id")?.Value) > 0
                             select new BEUrsa
                             {
                                 Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                                 Nombre = Convert.ToString(x.Element("Nombre")?.Value),
                             }).ToList<BEUrsa>(); ;
            }
            else
            {
                lista = null;
            }

            return lista;
        }
    }
}
