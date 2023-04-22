using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPPUnidad : IGestor<BEUnidad>
    {
        Conexion conexion = new Conexion();


        public bool Actualizar(BEUnidad Object)
        {
            throw new NotImplementedException();
        }

        public BEUnidad Agregar(BEUnidad Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEUnidad Object)
        {
            throw new NotImplementedException();
        }

        public BEUnidad ListarObjeto(BEUnidad Punidad)
        {

            DataTable Tabla;

            Tabla = conexion.Leer($" Select Ursa.* ,Unidad.* From Unidad INNER JOIN Ursa ON Unidad.[Id ursa] = Ursa.Id where (Unidad.Id = {Punidad.Id} )");
            MPPUrsa mPPUrsa = new MPPUrsa();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {

                    Punidad.Id = int.Parse(fila["Unidad.Id"].ToString());
                    Punidad.Cod = fila["Cod"].ToString();
                    Punidad.NombreUnidad = fila["Unidad.Nombre"].ToString();

                    BEUrsa ursa = new BEUrsa(Convert.ToInt32(fila["Ursa.Id"]));
                    ursa.NombreUrsa = fila["Ursa.Nombre"].ToString();
                    Punidad.Ursa = ursa;
                }
            }
            else
            { Punidad = null; }
            return Punidad;
        }

        public List<BEUnidad> ListarTodo()
        {
            //Declaro el objeto datatable para guardar los datos y luego pasarlos a lista
            DataTable Tabla;
            MPPUrsa mPPUrsa = new MPPUrsa();
            var listaUrsas = mPPUrsa.ListarTodo();
            Tabla = conexion.Leer("Select * From Unidad");
            List<BEUnidad> ListaUnidad = new List<BEUnidad>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEUnidad Bunidad = new BEUnidad();

                    Bunidad.Id = int.Parse(fila["Id"].ToString());
                    Bunidad.Cod = fila["Cod"].ToString();
                    Bunidad.NombreUnidad = fila["Nombre"].ToString();

                    Bunidad.Ursa = new BEUrsa(Convert.ToInt32(fila["Id ursa"]));
                    ListaUnidad.Add(Bunidad);
                }
            }
            else
            { ListaUnidad = null; }
            return ListaUnidad;
        }
    }
}
