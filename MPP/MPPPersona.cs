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
        public BEPersona Agregar(BEPersona bEPersona)
        {
            string consulta = "INSERT INTO Persona " +
                        " ([Nombre completo], Ocupacion, Telefono, DNI, Domicilio ) " +
                        $" VALUES('{bEPersona.NombreCompleto.Trim()}'" +
                        $",'{bEPersona.Ocupacion.Trim()}'" +
                        $",'{bEPersona.Telefono.Trim()}'" +
                        $",'{bEPersona.DNI.Trim()}'" +
                        $",'{bEPersona.Domicilio.Trim()}')";

            conexion.Escribir(consulta);
            DataTable Tabla = conexion.Leer($"Select Id From Persona WHERE ( DNI = '{bEPersona.DNI}' )");
            bEPersona.Id = Convert.ToInt32(Tabla.Rows[0]["Id"]);
            return bEPersona;
        }

        public bool Actualizar(BEPersona bEPersona)
        {
            string consulta = "UPDATE Persona " +
                        $"SET Domicilio = '{bEPersona.Domicilio.Trim()}' " +
                        $", [Nombre completo] = '{bEPersona.NombreCompleto.Trim()}'" +
                        $", Ocupacion =  '{bEPersona.Ocupacion.Trim()}' " +
                        $", Telefono = '{bEPersona.Telefono.Trim()}' " +
                        $", DNI = '{bEPersona.DNI.Trim()}' " +
                        $" WHERE ( Id =  {bEPersona.Id} )";

            return conexion.Escribir(consulta);
        }

        public bool Eliminar(BEPersona pPersona)
        {
            string consulta = $" DELETE FROM Persona WHERE (Id = {pPersona.Id} )";
            return conexion.Escribir(consulta);
        }

        public List<BEPersona> ListarTodo()
        {
            string Nodo = "Personas";
            var Consulta = conexion.Leer2(Nodo).Descendants("Persona");

            List<BEPersona> Lista = new List<BEPersona>();

            if (Consulta.Count() > 0)
            {
                Lista = (from x in Consulta
                         select new BEPersona
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             NombreCompleto = Convert.ToString(x.Element("Nombrecompleto")?.Value),
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
            string Nodo = "Personas";
            var Consulta = conexion.Leer2(Nodo).Descendants("Persona");


            if (Consulta.Count() > 0)
            {
               pPersona = (from x in Consulta
                         where Convert.ToInt32(x.Element("Id")?.Value) == pPersona.Id
                         select new BEPersona
                         {
                             Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
                             NombreCompleto = Convert.ToString(x.Element("Nombrecompleto")?.Value),
                             DNI = Convert.ToString(x.Element("DNI")?.Value),
                             Telefono = Convert.ToString(x.Element("Telefono")?.Value),
                             Domicilio = Convert.ToString(x.Element("Domicilio")?.Value),
                             Ocupacion = Convert.ToString(x.Element("Ocupacion")?.Value),
                         }).FirstOrDefault();
            }
            else
            { pPersona = null; }
            return pPersona;
        }


        public List<BEPersona> ListarPersonasHallazgo(BEHallazgo hallazgo)
        {
            DataTable Tabla;
            string consulta = $"Select * From Hallazgo_Persona where( [Id hallazgo] = {hallazgo.Id})";

            Tabla = conexion.Leer(consulta);

            List<BEPersona> ListaPersonas = new List<BEPersona>();
            MPPPersona mPPPersona = new MPPPersona();
            MPPInstructor mPPInstructor = new MPPInstructor();
            MPPEstado_Persona mPPEstado_Persona = new MPPEstado_Persona();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEPersona persona = new BEPersona(Convert.ToInt32(fila["Id persona"]));
                    mPPPersona.ListarObjeto(persona);

                    BEEstado_Persona estado = new BEEstado_Persona(Convert.ToInt32(fila["Id estado"]));
                    mPPEstado_Persona.ListarObjeto(estado);
                    persona.EstadoPersona = estado;

                    ListaPersonas.Add(persona);
                }
            }
            else
            {
                ListaPersonas = null;
            }
            return ListaPersonas;
        }


        public List<BEPersona> ListarPersonaEntrega(BEEntrega entrega)
        {
            DataTable Tabla;
            string consulta = $"Select * From Entrega_Persona where( [Id entrega] = {entrega.Id})";

            List<BEPersona> ListaPersonas = new List<BEPersona>();
            MPPPersona mPPPersona = new MPPPersona();
            MPPInstructor mPPInstructor = new MPPInstructor();
            MPPEstado_Persona mPPEstado_Persona = new MPPEstado_Persona();

            Tabla = conexion.Leer(consulta);


            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEPersona persona = new BEPersona(Convert.ToInt32(fila["Id persona"]));
                    mPPPersona.ListarObjeto(persona);

                    BEEstado_Persona estado = new BEEstado_Persona(Convert.ToInt32(fila["Id estado"]));
                    mPPEstado_Persona.ListarObjeto(estado);
                    persona.EstadoPersona = estado;

                    ListaPersonas.Add(persona);
                }
            }
            else
            {
                ListaPersonas = null;
            }
            return ListaPersonas;

        }

        public bool AgregarPersonaHallazgo(BEHallazgo hallazgo, BEPersona ePersona)
        {
            string consulta = "INSERT INTO Hallazgo_Persona ([Id Hallazgo], [Id persona], [Id estado]) " +
                              $"VALUES( {hallazgo.Id} , {ePersona.Id}, {ePersona.EstadoPersona.Id})";

            return conexion.Escribir(consulta);
        }

        public bool AgregarPersonaEntrega(BEEntrega entrega, BEPersona ePersona)
        {

            string consulta = " INSERT INTO Entrega_Persona ([Id entrega], [Id persona], [id estado]) " +
                             $" VALUES( {entrega.Id},{ePersona.Id} , {ePersona.EstadoPersona.Id} )";

            conexion.Escribir(consulta);
            return true;

        }


        public bool EliminarPersonaHallazgo(BEHallazgo hallazgo, BEPersona persona)
        {
            string consulta = "";

            consulta = "DELETE FROM Hallazgo_Persona " +
                       $"WHERE ([Id hallazgo] = {hallazgo.Id}) " +
                       $"AND ([Id persona] = {persona.Id} )";

            return conexion.Escribir(consulta);
        }

        public bool EliminarPersonaEntrega(BEEntrega entrega, BEPersona persona)
        {
            string consulta = "";

            consulta = "DELETE FROM Entrega_Persona " +
                       $"WHERE ([Id entrega] = {entrega.Id} ) " +
                       $"AND ( [Id persona] = {persona.Id} )";

            return conexion.Escribir(consulta);
        }

    }
}
