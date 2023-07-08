using BE;
using Microsoft.Reporting.WinForms;
using System.Data;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public class BEReporte
    {
        BLLUnidad bLLUnidad;
        BLLUrsa bLLUrsa;
        BLLUsuario bLLUsuario;
        public BEReporte() { }
        public BEReporte(BEUsuario bEUsuario)
        {
            usuario = bEUsuario;
            bLLUnidad = new BLLUnidad();
            bLLUrsa = new BLLUrsa();
            bLLUsuario = new BLLUsuario();

            //if (usuario.Rol == "REGION")
            //{
            //    Ursa = bLLUrsa.ListarObjeto(usuario);
            //    reporte = bLLUsuario.ObtenerElementosReporte(Ursa);

            //}
            //if (usuario.Rol == "UNIDAD")
            //{
            //    Unidad = bLLUnidad.ListarObjeto(usuario);
            //    Ursa = Unidad.Ursa;
            //    reporte = bLLUsuario.ObtenerElementosReporte(Ursa, Unidad);
            //}

        }

        public DataSet reporte { get; set; }
        public BEUrsa Ursa { get; set; }
        public BEUnidad Unidad { get; set; }
        public BEUsuario usuario { get; set; }



        public int Hallazgos { get; set; }
        public int Entregas { get; set; }
        public int Cant_Elementos_Resguardo { get; set; }
        public int Cant_Elementos_Entregado { get; set; }


        public List<BEReporte> HacerReporte()
        {
            List<BEReporte> listado = new List<BEReporte>();


            BLLHallazgo bLLHallazgo = new BLLHallazgo();
            BLLEntrega bLLEntrega = new BLLEntrega();
            BLLUnidad bLLUnidad = new BLLUnidad();
            var listaHallazgo = bLLHallazgo.ListarTodo();
            var ListaEntrega = bLLEntrega.ListarTodo();
            var listUnidades = bLLUnidad.ListarTodo();

            foreach (BEUnidad item in listUnidades)
            {
                BEReporte reporte = new BEReporte();

                reporte.Ursa = item.Ursa;
                reporte.Unidad = item;
                reporte.Hallazgos = listaHallazgo.FindAll(x => x.Unidad.Id == item.Id).Count;
                reporte.Entregas = ListaEntrega.FindAll(x => x.Unidad.Id == item.Id).Count;
                foreach (BEHallazgo hallazgo in listaHallazgo)
                {
                    if (hallazgo.listaElementos != null && hallazgo.Unidad.Id == item.Id)
                    {
                        reporte.Cant_Elementos_Resguardo += hallazgo.listaElementos.FindAll(x => x.Estado.Nombre == "Resguardo").Count;

                    }
                }
                foreach (BEEntrega entrega in ListaEntrega)
                {
                    if (entrega.listaElementos != null && entrega.Unidad.Id == item.Id)
                    {
                        reporte.Cant_Elementos_Entregado += entrega.listaElementos.FindAll(x => x.Estado.Nombre == "Entregado").Count;
                    }
                }
                listado.Add(reporte);
            }
            return listado;
        }
    }

    

}






