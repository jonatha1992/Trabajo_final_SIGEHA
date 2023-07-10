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
    public class BEActa
    {

        BLLElemento bLLElemento;
        public BEInstructor Instructor { get; set; }
        public BEPersona Desc_Propie { get; set; }
        public BEPersona Testigo1 { get; set; }
        public BEPersona Testigo2 { get; set; }
        public BEHallazgo hallazgo { get; set; }
        public BEEntrega entrega { get; set; }
        Elemento Elemento;

        public ReportParameterCollection Parametros;
        public List<Elemento> elementos;
        public BEActa(BEPAdreHallazgo Padre)
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

        void llenarParametrosHallazgo()
        {
            Parametros = new ReportParameterCollection
                {
                    new ReportParameter("NroActa", hallazgo.NroActa),
                    new ReportParameter("Unidad", hallazgo.Unidad.Nombre),
                    new ReportParameter("FechaHallazgo", hallazgo.FechaHallazgo.ToShortDateString()),
                    new ReportParameter("HoraHallazgo", hallazgo.FechaHallazgo.ToShortTimeString()),
                    new ReportParameter("LugarHallazgo", hallazgo.LugarHallazgo.ToUpper()),
                    new ReportParameter("DiaActa", hallazgo.FechaActa?.Day.ToString() ?? DateTime.Now.Day.ToString()),
                    new ReportParameter("MesActa", hallazgo.FechaActa?.Month.ToString("MMM") ?? DateTime.Now.Month.ToString("MMM")),
                    new ReportParameter("AnoActa", hallazgo.FechaActa?.Year.ToString() ?? DateTime.Now.Year.ToString()),
                    new ReportParameter("HoraActa", hallazgo.FechaActa?.ToString("HH:mm") ?? DateTime.Now.ToString("HH:mm")),
                };
            if (!string.IsNullOrEmpty(hallazgo.Observacion))
            {
                Parametros.Add(new ReportParameter("Observacion","Observacion: " + hallazgo.Observacion));
            }

            AgregarParametrosComunes();
        }

        void llenarParametrosEntrega()
        {
            Parametros = new ReportParameterCollection
            {
                new ReportParameter("NroActa", entrega.NroActa),
                new ReportParameter("Unidad", entrega.Unidad.Nombre),
                new ReportParameter("Dia", entrega.Fecha_entrega.Day.ToString()),
                new ReportParameter("Mes", entrega.Fecha_entrega.ToString("MMMM")),
                new ReportParameter("Ano", entrega.Fecha_entrega.Year.ToString()),
                new ReportParameter("Hora", entrega.Fecha_entrega.ToShortTimeString()),
                new ReportParameter("ActaHallazgo", bLLElemento.ObtenerNroHallazgo(entrega.listaElementos.First()))
            };

            AgregarParametrosComunes();
        }
        void AgregarParametrosComunes()
        {
            if (Desc_Propie != null)
            {
                Parametros.Add(new ReportParameter("NombreDescubridor", Desc_Propie.NombreCompleto));
                Parametros.Add(new ReportParameter("DNIDescubridor", Desc_Propie.DNI));
                Parametros.Add(new ReportParameter("Ocupacion", Desc_Propie.Ocupacion));
                Parametros.Add(new ReportParameter("Telefono", Desc_Propie.Telefono));
                Parametros.Add(new ReportParameter("Domicilio", Desc_Propie.Domicilio));
            }

            if (Instructor != null)
            {
                Parametros.Add(new ReportParameter("NombreInstructor", $"{Instructor?.Jerarquia.Abreviatura} {Instructor?.NombreCompleto}"));
                Parametros.Add(new ReportParameter("LegajoInstructor", Instructor?.Legajo.ToString()));
            }

            if (Testigo1 != null)
            {
                Parametros.Add(new ReportParameter("DNITestigo1", Testigo1.DNI));
                Parametros.Add(new ReportParameter("NombreTestigo1", Testigo1.NombreCompleto));
            }

            if (Testigo2 != null)
            {
                Parametros.Add(new ReportParameter("DNITestigo2", Testigo2?.DNI));
                Parametros.Add(new ReportParameter("NombreTestigo2", Testigo2?.NombreCompleto));
            }
        }

    }

}






