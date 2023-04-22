using Abstraccion;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

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

        public BEUrsa ListarObjeto(BEUrsa pUrsa)
        {
            DataTable Tabla;
            Tabla = conexion.Leer($" SELECT Ursa.*, Unidad.* FROM Unidad INNER JOIN Ursa ON Unidad.[Id ursa] = Ursa.Id where (Ursa.Id = {pUrsa.Id} )");

            if (Tabla.Rows.Count > 0)
            {
                pUrsa.Unidades = new List<BEUnidad>();
               
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEUnidad Bunidad = new BEUnidad();
                    Bunidad.Id = int.Parse(fila["Unidad.Id"].ToString());
                    Bunidad.Cod = fila["Cod"].ToString();
                    Bunidad.NombreUnidad = fila["Unidad.Nombre"].ToString();

                    pUrsa.Unidades.Add(Bunidad);

                }
            }
            else
            { pUrsa = null; }
            return pUrsa;
        }

        public List<BEUrsa> ListarTodo()
        {
            DataTable Tabla;
            Tabla = conexion.Leer("SELECT * FROM Ursa ");
            List<BEUrsa> listaRegionales = new List<BEUrsa>();

            //MPPUnidad mPPUnidad = new MPPUnidad();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {

                    BEUrsa Bursa = new BEUrsa(Convert.ToInt32(fila["Id"]));
                    Bursa.NombreUrsa = fila["Nombre"].ToString();
                    Bursa = ListarObjeto(Bursa);
                    
                    //Bursa.Unidades = new List<BEUnidad>();



                    //var Tabla2 = conexion.Leer($"SELECT * FROM Unidad where [Id ursa]= {Bursa.Id} ");


                    //foreach (DataRow fila2 in Tabla2.Rows)
                    //{
                    //    BEUnidad Bunidad = new BEUnidad();

                    //    Bunidad.Id = int.Parse(fila2["Id"].ToString());
                    //    Bunidad.Cod = fila2["Cod"].ToString();
                    //    Bunidad.NombreUnidad = fila2["Nombre"].ToString();

                    //    Bursa.Unidades.Add(Bunidad);
                    //}
                    listaRegionales.Add(Bursa);
                }
            }
            else
            { listaRegionales = null; }
            return listaRegionales;
        }
    }
}
