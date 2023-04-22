using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

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
            DataTable Tabla;
            Tabla = conexion.Leer($"SELECT * FROM Jerarquia WHERE ( Id = {jerarquia.Id}) ");

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    jerarquia.Jerarquia = fila["Jerarquia"].ToString();
                    jerarquia.Abreviatura = fila["Abreviatura"].ToString();
                }
            }
            else
            { jerarquia = null; }
            return jerarquia;
        }

        public List<BEJerarquia> ListarTodo()
        {
            DataTable Tabla;
            Tabla = conexion.Leer("Select * From Jerarquia");
            List<BEJerarquia> ListasJerarquia = new List<BEJerarquia>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEJerarquia jerarquia = new BEJerarquia();
                    jerarquia.Id = Convert.ToInt32(fila["Id"]);
                    jerarquia.Jerarquia = fila["Jerarquia"].ToString();
                    jerarquia.Abreviatura = fila["Abreviatura"].ToString();
                    ListasJerarquia.Add(jerarquia);
                }
            }
            else
            { ListasJerarquia = null; }
            return ListasJerarquia;
        }
    }
}
