using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;


namespace MPP
{
    public class MPPEstado_Articulo : IGestor<BEEstado_Elemento>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }
        public BEEstado_Elemento Agregar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public BEEstado_Elemento ListarObjeto(BEEstado_Elemento BEntidad)
        {
            DataTable Tabla;
            Tabla = conexion.Leer($"Select * From Estado_Elemento where (Id = {BEntidad.Id})");


            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEntidad.Id = int.Parse(fila["Id"].ToString());
                    BEntidad.Nombre = fila["Estado"].ToString();
                }
            }
            else
            { BEntidad = null; }
            return BEntidad;
        }

        public List<BEEstado_Elemento> ListarTodo()
        {
            DataTable Tabla;
            conexion = new Conexion();
            Tabla = conexion.Leer("Select * From Estado_Elemento");
            List<BEEstado_Elemento> ListaEstado = new List<BEEstado_Elemento>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEEstado_Elemento BEntidad = new BEEstado_Elemento();
                    BEntidad.Id = int.Parse(fila["Id"].ToString());
                    BEntidad.Nombre = fila["Estado"].ToString();
                    ListaEstado.Add(BEntidad);
                }
            }
            else
            { ListaEstado = null; }
            return ListaEstado;
        }
    }
}
