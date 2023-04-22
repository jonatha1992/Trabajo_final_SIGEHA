using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

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

        public BEEstado_Persona ListarObjeto(BEEstado_Persona estadoPersona)
        {
            DataTable Tabla;

            Tabla = conexion.Leer($"Select * From Estado_Persona where (Id = {estadoPersona.Id})");

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    estadoPersona.Id = int.Parse(fila["Id"].ToString());
                    estadoPersona.Estado = fila["Estado"].ToString();
                }
            }
            else
            { estadoPersona = null; }
            return estadoPersona;
        }

        public List<BEEstado_Persona> ListarTodo()
        {
            DataTable Tabla;

            Tabla = conexion.Leer("Select * From Estado_Persona");
            List<BEEstado_Persona> ListaEstado = new List<BEEstado_Persona>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEEstado_Persona estadoPersona = new BEEstado_Persona();
                    estadoPersona.Id = int.Parse(fila["Id"].ToString());
                    estadoPersona.Estado = fila["Estado"].ToString();
                    ListaEstado.Add(estadoPersona);
                }
            }
            else
            { ListaEstado = null; }
            return ListaEstado;
        }
    }
}
