using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

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

                DataTable Tabla;
                MPPJerarquia mPPJerarquia = new MPPJerarquia();
                var jerarquias = mPPJerarquia.ListarTodo();
                string Consulta = "SELECT * From Persona";
                Tabla = conexion.Leer(Consulta);

                List<BEInstructor> lista = new List<BEInstructor>();

                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow fila in Tabla.Rows)
                    {
                        if (fila["Legajo"].ToString() != "")
                        {
                            BEInstructor instructor = new BEInstructor();
                            instructor.Id = Convert.ToInt32(fila["Id"]);
                            instructor.DNI = fila["DNI"].ToString();
                            instructor.NombreCompleto = fila["Nombre completo"].ToString();
                            instructor.Domicilio = fila["Domicilio"].ToString();
                            instructor.Ocupacion = fila["Ocupacion"].ToString();
                            instructor.Telefono = fila["Telefono"].ToString();
                            instructor.Legajo = Convert.ToInt32(fila["Legajo"]);
                            instructor.Mail = fila["Mail"].ToString();
                            //instructor.Jerarquia =  mPPJerarquia.ListarObjeto( new BEJerarquia(Convert.ToInt32(fila["Id jerarquia"])));
                            instructor.Jerarquia = jerarquias.Find(x => x.Id == Convert.ToInt32(fila["Id jerarquia"]));

                            lista.Add(instructor);
                        }
                    }
                }
                else
                { lista = null; }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public BEInstructor ListarObjeto(BEInstructor instructor)
        {
            DataTable Tabla;

            string Consulta = $"SELECT * From Persona where ( Id = {instructor.Id} )";
            Tabla = conexion.Leer(Consulta);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    instructor.Id = Convert.ToInt32(fila["Id"]);
                    instructor.DNI = fila["DNI"].ToString();
                    instructor.NombreCompleto = fila["Nombre completo"].ToString();
                    instructor.Domicilio = fila["Domicilio"].ToString();
                    instructor.Ocupacion = fila["Ocupacion"].ToString();
                    instructor.Telefono = fila["Telefono"].ToString();
                    instructor.Legajo = Convert.ToInt32(fila["Legajo"]);
                    instructor.Mail = fila["Mail"].ToString();
                    instructor.Jerarquia = new BEJerarquia(Convert.ToInt32(fila["Id jerarquia"]));

                    var table = conexion.Leer($"SELECT * From Jerarquia where ( Id = {instructor.Jerarquia.Id} )");
                    instructor.Jerarquia.Jerarquia = table.Rows[0]["Jerarquia"].ToString();
                    instructor.Jerarquia.Abreviatura = table.Rows[0]["Abreviatura"].ToString();
                }
            }
            else
            { instructor = null; }
            return instructor;
        }
    }
}
