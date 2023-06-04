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


        public BEInstructor Agregar(BEInstructor pinstructor)
        {
            string consulta = "INSERT INTO Persona " +
                      " ([Nombre completo],DNI,Legajo,[Id jerarquia]) " +
                        $" VALUES('{pinstructor.NombreCompleto.Trim()}'" +
                        $",{pinstructor.DNI.Trim()}" +
                        $",{pinstructor.Legajo}" +
                        $",{pinstructor.Jerarquia.Id})";

            conexion.Escribir(consulta);

            DataTable Tabla = conexion.Leer($"Select Id From Persona WHERE ( Legajo = {pinstructor.Legajo} )");
            pinstructor.Id = Convert.ToInt32(Tabla.Rows[0]["Id"]);
            return pinstructor;

        }

        public bool Conversion(BEInstructor pinstructor)
        {
            string consulta = $" UPDATE  Persona SET  " +
                                    $"[Nombre completo] = '{pinstructor.NombreCompleto.Trim()}'" +
                                    $", [Id jerarquia] = {pinstructor.Jerarquia.Id}" +
                                    $",Legajo = {pinstructor.Legajo}" +
                                    $" WHERE ( Id =  {pinstructor.Id})";

            return conexion.Escribir(consulta);
        }
        public bool Actualizar(BEInstructor pinstructor)
        {
            string consulta = $" UPDATE  Persona SET  " +
                              $"[Nombre completo] = '{pinstructor.NombreCompleto.Trim()}'" +
                              $", [Id jerarquia] = {pinstructor.Jerarquia.Id}" +
                              $" WHERE ( Legajo =  {pinstructor.Legajo} )";

            return conexion.Escribir(consulta);
        }

        public bool Eliminar(BEInstructor Object)
        {
            throw new NotImplementedException();
        }

        public List<BEInstructor> ListarTodo()
        {
            try
            {
                string Nodo = "Instructores";
                var Consulta = conexion.Leer2(Nodo).Descendants("Instructor");

                List<BEInstructor> lista = new List<BEInstructor>();

                if (Consulta.Count() > 0)
                {
                    var lista2 = from x in Consulta
                                     //where x.Element("Id_rol")?.Value.ToString() != ""
                                 select new BEInstructor
                                 {
                                     Id = Convert.ToInt32(Convert.ToString(x.Element("Id_persona")?.Value)),
                                     Legajo = Convert.ToInt32(Convert.ToString(x.Element("Legajo")?.Value)),
                                     Destino = new BEDestino(Convert.ToInt32(Convert.ToString(x.Element("Id_destino")?.Value))),
                                     Password = Convert.ToString(x.Element("Password")?.Value),
                                     Rol = new BERol(Convert.ToInt32(Convert.ToString(x.Element("Id_rol")?.Value))),
                                     Mail = Convert.ToString(x.Element("Mail")?.Value),
                                     Jerarquia = new BEJerarquia(Convert.ToInt32(Convert.ToString(x.Element("Id_jerarquia")?.Value))),
                                 };

                    lista = lista2.ToList<BEInstructor>();
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


        public List<BEInstructor> ListarUsuarios()
        {
            try
            {
                string Nodo = "Instructores";
                var Consulta = conexion.Leer2(Nodo).Descendants("Instructor");

                List<BEInstructor> lista = new List<BEInstructor>();

                if (Consulta.Count() > 0)
                {
                    lista = (from x in Consulta
                             where x.Element("Id_rol")?.Value.ToString() != ""
                             select new BEInstructor
                             {
                                 Id = Convert.ToInt32(Convert.ToString(x.Element("Id_persona")?.Value)),
                                 Legajo = Convert.ToInt32(Convert.ToString(x.Element("Legajo")?.Value)),
                                 Destino = new BEDestino(Convert.ToInt32(Convert.ToString(x.Element("Id_destino")?.Value))),
                                 Password = Convert.ToString(x.Element("Password")?.Value),
                                 Rol = new BERol(Convert.ToInt32(Convert.ToString(x.Element("Id_rol")?.Value))),
                                 Mail = Convert.ToString(x.Element("Mail")?.Value),
                                 Jerarquia = new BEJerarquia(Convert.ToInt32(Convert.ToString(x.Element("Id_jerarquia")?.Value))),
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
            //MPPRol mPPRol= new MPPRol();
            MPPPersona mPPPersona = new MPPPersona();

            var persona = mPPPersona.ListarObjeto(instructor);
            instructor.NombreCompleto = persona.NombreCompleto;
            instructor.DNI = persona.DNI;
            instructor.Telefono = persona.Telefono;
            instructor.Domicilio = persona.Domicilio;
            instructor.Ocupacion = persona.Ocupacion;
            instructor.Jerarquia = mPPJerarquia.ListarObjeto(instructor.Jerarquia);

            return instructor;
        }
    }
}
