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
    public class Reporte
    {
        BLLUnidad bLLUnidad;
        BLLUrsa bLLUrsa;
        BLLUsuario bLLUsuario;
        public Reporte() { }
        public Reporte(BEUsuario bEUsuario)
        {
            usuario = bEUsuario;
            bLLUnidad = new BLLUnidad();
            bLLUrsa = new BLLUrsa();
            bLLUsuario = new BLLUsuario();

            if (usuario.Rol == "REGION")
            {
                Ursa = bLLUrsa.ListarObjeto(usuario);
                reporte = bLLUsuario.ObtenerElementosReporte(Ursa);

            }
            if (usuario.Rol == "UNIDAD")
            {
                Unidad = bLLUnidad.ListarObjeto(usuario);
                Ursa = Unidad.Ursa;
                reporte = bLLUsuario.ObtenerElementosReporte(Ursa, Unidad);
            }

        }

        public DataSet reporte { get; set; }
        public BEUrsa Ursa { get; set; }
        public BEUnidad Unidad { get; set; }
        public BEUsuario usuario { get; set; }



        public int Hallazgos { get; set; }
        public int Entregas { get; set; }
        public int Cant_Elementos_Resguardo { get; set; }
        public int Cant_Elementos_Entregado { get; set; }


        public List<Reporte> HacerReporte()
        {
            List<Reporte> listado = new List<Reporte>();


            BLLHallazgo bLLHallazgo = new BLLHallazgo();
            BLLEntrega bLLEntrega = new BLLEntrega();
            BLLUnidad bLLUnidad = new BLLUnidad();
            var listaHallazgo = bLLHallazgo.ListarTodo();
            var ListaEntrega = bLLEntrega.ListarTodo();
            var listUnidades = bLLUnidad.ListarTodo();

            foreach (BEUnidad item in listUnidades)
            {
                Reporte reporte = new Reporte();

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

    public class Acta
    {
        public Acta(BEPAdreHallazgo Padre)
        {
            bLLElemento = new BLLElemento();
            Elemento = new Elemento();

            if (Padre.listaPersonas != null)
            {
                foreach (var item in Padre.listaPersonas)
                {
                    if (item is BEInstructor)
                    {
                        Instructor = (BEInstructor)item;
                    }
                    else
                    {
                        if (item.EstadoPersona.Nombre == "Descubridor" || item.EstadoPersona.Nombre == "Propietario")
                        {
                            Desc_Propie = item;
                        }
                        else if (item.EstadoPersona.Nombre == "Testigo")
                        {
                            if (Testigo1 == null)
                            {
                                Testigo1 = item;
                            }
                            else
                            {

                                Testigo2 = item;
                            }
                        }

                    }
                }
            }

            elementos = Elemento.CrearListaElementos(Padre.listaElementos);
            if (Padre is BEHallazgo)
            {
                hallazgo = (BEHallazgo)Padre;
                llenarParametrosHallazgo();
            }
            else
            {
                entrega = (BEEntrega)Padre;
                llenarParametrosEntrega();
            }

        }

        BLLElemento bLLElemento;
        public BEInstructor Instructor { get; set; }
        public BEPersona Desc_Propie { get; set; }
        public BEPersona Testigo1 { get; set; }
        public BEPersona Testigo2 { get; set; }
        public BEHallazgo hallazgo { get; set; }
        public BEEntrega entrega { get; set; }

        public ReportParameterCollection Parametros;
        public List<Elemento> elementos;

        Elemento Elemento;
        void llenarParametrosHallazgo()
        {
            Parametros = new ReportParameterCollection(){ new ReportParameter("NroActa",hallazgo.NroActa),
                                                                                    new ReportParameter("Unidad", hallazgo.Unidad.Nombre),
                                                                                    new ReportParameter("FechaHallazgo", hallazgo.FechaHallazgo.ToShortDateString()),
                                                                                    new ReportParameter("HoraHallazgo", hallazgo.FechaHallazgo.ToShortTimeString()),
                                                                                    new ReportParameter("LugarHallazgo",hallazgo.LugarHallazgo.ToUpper())
                                                                                   };
            if (Desc_Propie != null)
            {
                ReportParameter paramtero = new ReportParameter("NombreDescubridor", Desc_Propie.NombreCompleto);
                ReportParameter paramtero2 = new ReportParameter("DNIDescubridor", Desc_Propie.DNI);
                ReportParameter paramtero3 = new ReportParameter("Ocupacion", Desc_Propie.Ocupacion);
                ReportParameter paramtero4 = new ReportParameter("Telefono", Desc_Propie.Telefono);
                ReportParameter paramtero5 = new ReportParameter("Domicilio", Desc_Propie.Domicilio);
                
                Parametros.Add(paramtero);
                Parametros.Add(paramtero2);
                Parametros.Add(paramtero3);
                Parametros.Add(paramtero4);
                Parametros.Add(paramtero5);
            }
            
            
            if (Instructor!= null)
            {
                ReportParameter paramtero = new ReportParameter("NombreInstructor", Instructor?.Jerarquia.Abreviatura + " " + Instructor?.NombreCompleto);
                ReportParameter paramtero2 = new ReportParameter("LegajoInstructor", Instructor?.Legajo.ToString());

                Parametros.Add(paramtero);
                Parametros.Add(paramtero2);
            }
            if (Testigo1 != null)
            {
                ReportParameter paramtero = new ReportParameter("DNITestigo1", Testigo1.DNI);
                ReportParameter paramtero2 = new ReportParameter("NombreTestigo1", Testigo1.NombreCompleto);

                Parametros.Add(paramtero);
                Parametros.Add(paramtero2);
            }
            if (Testigo2 != null)
            {
                ReportParameter paramtero = new ReportParameter("DNITestigo2", Testigo2.DNI);
                ReportParameter paramtero2 = new ReportParameter("NombreTestigo2", Testigo2.NombreCompleto);
                Parametros.Add(paramtero);
                Parametros.Add(paramtero2);
            }

        }
        void llenarParametrosEntrega()
        {
            Parametros = new ReportParameterCollection(){ new ReportParameter("NroActa",entrega.NroActa),
                                                                                    new ReportParameter("Unidad",entrega.Unidad.Nombre),
                                                                                    new ReportParameter("Dia", entrega.Fecha_entrega.Day.ToString()),
                                                                                    new ReportParameter("Mes", entrega.Fecha_entrega.ToString("MMMM")),
                                                                                    new ReportParameter("Ano", entrega.Fecha_entrega.Year.ToString()),
                                                                                    new ReportParameter("Hora", entrega.Fecha_entrega.ToShortTimeString()),
                                                                                    new ReportParameter("ActaHallazgo", bLLElemento.ObtenerNroHallazgo(entrega.listaElementos.First())),
                                                                                    };

            if (Desc_Propie != null)
            {
                ReportParameter paramtero = new ReportParameter("NombrePropietario", Desc_Propie.NombreCompleto);
                ReportParameter paramtero2 = new ReportParameter("DNIPropietario", Desc_Propie.DNI);
                ReportParameter paramtero4 = new ReportParameter("Telefono", Desc_Propie.Telefono);
                ReportParameter paramtero5 = new ReportParameter("Domicilio", Desc_Propie.Domicilio);

                Parametros.Add(paramtero);
                Parametros.Add(paramtero2);
                Parametros.Add(paramtero4);
                Parametros.Add(paramtero5);
            }


            if (Instructor != null)
            {
                ReportParameter paramtero = new ReportParameter("NombreInstructor", Instructor?.Jerarquia.Abreviatura + " " + Instructor?.NombreCompleto);
                ReportParameter paramtero2 = new ReportParameter("LegajoInstructor", Instructor?.Legajo.ToString());

                Parametros.Add(paramtero);
                Parametros.Add(paramtero2);
            }

            if (Testigo1 != null)
            {
                ReportParameter paramtero = new ReportParameter("DNITestigo1", Testigo1.DNI);
                ReportParameter paramtero2 = new ReportParameter("NombreTestigo1", Testigo1.NombreCompleto);

                Parametros.Add(paramtero);
                Parametros.Add(paramtero2);
            }
            if (Testigo2 != null)
            {
                ReportParameter paramtero = new ReportParameter("DNITestigo2", Testigo2?.DNI);
                ReportParameter paramtero2 = new ReportParameter("NombreTestigo2", Testigo2?.NombreCompleto);

                Parametros.Add(paramtero);
                Parametros.Add(paramtero2);
            }
        }

    }

}






