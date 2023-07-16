using BE;
using System.Data;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace Presentacion_UI
{
    public class BEReporte
    {
        BLLElemento BLLElemento;
        BLLHallazgo BLLHallazgo;
        BLLEntrega BLLEntrega;


        List<BEHallazgo> ListaHallazgo;
        List<BEEntrega> ListaEntregas;
        List<BEElemento> ListaElementos;
        public int Hallazgos { get; set; }
        public int Entregas { get; set; }
        public int Cant_Elementos_Resguardo { get; set; }
        public int Cant_Elementos_Entregado { get; set; }



        public BEReporte()
        {

            BLLElemento = new BLLElemento();
            BLLHallazgo = new BLLHallazgo();
            BLLEntrega = new BLLEntrega();

            ListaHallazgo = BLLHallazgo.ListarTodo();
            ListaEntregas = BLLEntrega.ListarTodo();
            ListaElementos = BLLElemento.ListarTodo();
        }


        public void HacerReporteGenerico()
        {
            Hallazgos = ListaHallazgo.Count();
            Entregas = ListaEntregas.Count();
            Cant_Elementos_Resguardo = Convert.ToInt32(ListaElementos.Where(x => x.Estado.Nombre == "Resguardo").Sum(x => x.Cantidad));
            Cant_Elementos_Entregado = Convert.ToInt32(ListaElementos.Where(x => x.Estado.Nombre == "Entregado").Sum(x => x.Cantidad));
        }

        public Chart HacerReporteHallazgos(BEUnidad bEUnidad, string periodo, Chart chart)
        {
            chart.Titles.Clear();
           
            Series serieHallazgos = chart.Series.FirstOrDefault();
            serieHallazgos.Points.Clear();
            List<BEHallazgo> hallazgosFiltrados;
       

            switch (periodo)
            {
                case "anual":

                    // Filtrar los hallazgos por la unidad y el año actual
                    int anioActual = DateTime.Now.Year;
                    hallazgosFiltrados = ListaHallazgo.Where(h => h.Unidad.Id == bEUnidad.Id && h.Anio == anioActual).ToList();

                    // Obtener los valores de hallazgos por mes utilizando LINQ
                    var hallazgosPorMes = Enumerable.Range(1, 12)
                            .Select(mes => new
                            {
                                Mes = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(mes),
                                Cantidad = hallazgosFiltrados.Count(h => h.FechaHallazgo.Month == mes)
                            }).ToList();


                    // Agregar los datos al gráfico
                    foreach (var item in hallazgosPorMes)
                    {
                        serieHallazgos.Points.AddXY(item.Mes, item.Cantidad);
                    }

                    chart.Titles.Add("Reporte Anual de Hallazgos");
                    break;

                case "semestral":
                    // Obtener el semestre actual
                    int semestreActual = (DateTime.Now.Month <= 6) ? 1 : 2;

                    hallazgosFiltrados = ListaHallazgo.Where(h => h.Unidad.Id == bEUnidad.Id &&
                                                      ((semestreActual == 1 && h.FechaHallazgo.Month <= 6) ||
                                                       (semestreActual == 2 && h.FechaHallazgo.Month >= 7)))
                                          .ToList();
                    // Obtener los meses correspondientes al semestre actual
                    var mesesSemestral = Enumerable.Range((semestreActual - 1) * 6 + 1, 6)
                        .Select(mes => new
                        {
                            Mes = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mes),
                            Cantidad = hallazgosFiltrados.Count(h => h.FechaHallazgo.Month == mes)
                        })
                        .ToList();



                    // Agregar los datos al gráfico
                    foreach (var item in mesesSemestral)
                    {
                        serieHallazgos.Points.AddXY(item.Mes, item.Cantidad);
                    }


                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Semestral de Hallazgos");
                    break;

                case "trimestral":
                    // Obtener el trimestre actual
                    int trimestreActual = (DateTime.Now.Month - 1) / 3 + 1;

                    // Filtrar los hallazgos por la unidad y el trimestre actual
                    hallazgosFiltrados = ListaHallazgo.Where(h => h.Unidad.Id == bEUnidad.Id && ((DateTime.Now.Month - 1) / 3 + 1 == trimestreActual)).ToList();

                    // Obtener los valores de hallazgos por mes utilizando LINQ
                    var hallazgosPorTrimestral = Enumerable.Range((trimestreActual - 1) * 3 + 1, 3)
                        .Select(mes => new
                        {
                            Mes = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(mes),
                            Cantidad = hallazgosFiltrados.Count(h => h.FechaHallazgo.Month == mes)
                        }).ToList();

                    // Agregar los datos al gráfico
                    foreach (var item in hallazgosPorTrimestral)
                    {
                        serieHallazgos.Points.AddXY(item.Mes, item.Cantidad);
                    }

                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Trimestral de Hallazgos");

                    break;

                case "mensual":
                    // Filtrar los hallazgos por la unidad y el mes actual
                    int mesActual = DateTime.Now.Month;
                    hallazgosFiltrados = ListaHallazgo.Where(h => h.Unidad.Id == bEUnidad.Id && h.FechaHallazgo.Month == mesActual).ToList();

                    // Obtener los valores de hallazgos por día utilizando LINQ
                    var hallazgosPorDia = Enumerable.Range(1, DateTime.DaysInMonth(DateTime.Now.Year, mesActual))
                        .Select(dia => new
                        {
                            Dia = dia.ToString(),
                            Cantidad = hallazgosFiltrados.Count(h => h.FechaHallazgo.Day == dia)
                        }).ToList();

         
                    // Agregar los datos al gráfico
                    foreach (var item in hallazgosPorDia)
                    {
                        serieHallazgos.Points.AddXY(item.Dia, item.Cantidad);
                    }


                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Mensual de Hallazgos");

                    break;

                default:
                    // Período no válido
                    break;

            }

            return chart;
        }

        public Chart HacerReporteEntregas(BEUnidad bEUnidad, string periodo, Chart chart)
        {
            chart.Titles.Clear();
            Series serieEntregas = chart.Series.FirstOrDefault();
            serieEntregas.Points.Clear();
            List<BEEntrega> entregasFiltradas;
       

            switch (periodo)
            {
                case "anual":
                    // Filtrar las entregas por la unidad y el año actual
                    int anioActual = DateTime.Now.Year;
                    entregasFiltradas = ListaEntregas.Where(e => e.Unidad.Id == bEUnidad.Id && e.Fecha_entrega.Year == anioActual).ToList();

                    // Obtener los valores de entregas por mes utilizando LINQ
                    var entregasPorMes = Enumerable.Range(1, 12)
                        .Select(mes => new
                        {
                            Mes = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(mes),
                            Cantidad = entregasFiltradas.Count(e => e.Fecha_entrega.Month == mes)
                        }).ToList();

                    // Agregar los datos al gráfico
                    foreach (var item in entregasPorMes)
                    {
                        serieEntregas.Points.AddXY(item.Mes, item.Cantidad);
                    }

                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Anual de Entregas");

                    break;

                case "semestral":
                    // Obtener el semestre actual
                    int semestreActual = (DateTime.Now.Month <= 6) ? 1 : 2;

                    // Filtrar las entregas por la unidad y el semestre actual

                    entregasFiltradas = ListaEntregas.Where(h => h.Unidad.Id == bEUnidad.Id &&
                                            ((semestreActual == 1 && h.Fecha_entrega.Month <= 6) ||
                                             (semestreActual == 2 && h.Fecha_entrega.Month >= 7)))
                                .ToList();

                    // Obtener los valores de entregas por mes utilizando LINQ
                    var entregasSemestral = Enumerable.Range((semestreActual - 1) * 6 + 1, 6)
                        .Select(mes => new
                        {
                            Mes = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(mes),
                            Cantidad = entregasFiltradas.Count(e => e.Fecha_entrega.Month == mes)
                        }).ToList();



                    // Agregar los datos al gráfico
                    foreach (var item in entregasSemestral)
                    {
                        serieEntregas.Points.AddXY(item.Mes, item.Cantidad);
                    }

                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Semestral de Entregas");

                    break;

                case "trimestral":
                    // Obtener el trimestre actual
                    int trimestreActual = (DateTime.Now.Month - 1) / 3 + 1;

                    // Filtrar las entregas por la unidad y el trimestre actual
                    entregasFiltradas = ListaEntregas.Where(e => e.Unidad.Id == bEUnidad.Id && ((DateTime.Now.Month - 1) / 3 + 1 == trimestreActual)).ToList();

                    // Obtener los valores de entregas por mes utilizando LINQ
                    var entregasPorTrimestral = Enumerable.Range((trimestreActual - 1) * 3 + 1, 3)
                        .Select(mes => new
                        {
                            Mes = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(mes),
                            Cantidad = entregasFiltradas.Count(e => e.Fecha_entrega.Month == mes)
                        }).ToList();

                    // Agregar los datos al gráfico
                    foreach (var item in entregasPorTrimestral)
                    {
                        serieEntregas.Points.AddXY(item.Mes, item.Cantidad);
                    }

                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Trimestral de Entregas");

                    break;

                case "mensual":
                    // Filtrar las entregas por la unidad y el mes actual
                    int mesActual = DateTime.Now.Month;
                    entregasFiltradas = ListaEntregas.Where(e => e.Unidad.Id == bEUnidad.Id && e.Fecha_entrega.Month == mesActual).ToList();

                    // Obtener los valores de entregas por día utilizando LINQ
                    var entregasPorDia = Enumerable.Range(1, DateTime.DaysInMonth(DateTime.Now.Year, mesActual))
                        .Select(dia => new
                        {
                            Dia = dia.ToString(),
                            Cantidad = entregasFiltradas.Count(e => e.Fecha_entrega.Day == dia)
                        }).ToList();

                    // Agregar los datos al gráfico
                    foreach (var item in entregasPorDia)
                    {
                        serieEntregas.Points.AddXY(item.Dia, item.Cantidad);
                    }

                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Mensual de Entregas");

                    break;

                default:
                    // Período no válido
                    break;
            }


            return chart;
        }
        public Chart HacerReporteCategorias(BEUnidad bEUnidad, string periodo, Chart chart)
        {
            chart.Titles.Clear();
            Series serieElementos = chart.Series.FirstOrDefault();
            serieElementos.Points.Clear();
            List<BEElemento> elementosFiltrados;
            List<BEHallazgo> hallazgosFiltrados;
            List<string> categorias;
     
            switch (periodo)
            {
                case "anual":
                    // Filtrar las entregas por la unidad y el año actual
                    int anioActual = DateTime.Now.Year;
                    hallazgosFiltrados = ListaHallazgo.Where(h => h.Unidad.Id == bEUnidad.Id && h.FechaHallazgo.Year == anioActual).ToList();

                    foreach (BEHallazgo item in hallazgosFiltrados)
                    {
                        item.listaElementos = BLLHallazgo.ListarHallazgoElementos(item).listaElementos;
                    }

                    // Obtener los elementos correspondientes a los hallazgos filtrados
                    elementosFiltrados = hallazgosFiltrados.SelectMany(h => h.listaElementos).ToList();


                    categorias = elementosFiltrados.Where(x => x.Estado.Nombre == "Resguardo")
                                                        .Select(e => e.Articulo.Categoria.Nombre)
                                                        .Distinct()
                                                        .ToList();

                    // Crear una serie para representar los elementos
                    foreach (var categoria in categorias)
                    {
                        var cantidad = elementosFiltrados.Where(e => e.Articulo.Categoria.Nombre == categoria)
                                                         .Sum(e => e.Cantidad);
                        serieElementos.Points.AddXY(categoria, cantidad);
                    }


                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Anual de Elementos en Resguardo");

                    break;

                case "semestral":
                    // Obtener el semestre actual
                    int semestreActual = (DateTime.Now.Month <= 6) ? 1 : 2;


                    // Filtrar los hallazgos por la unidad y el semestre actual
                    hallazgosFiltrados = ListaHallazgo.Where(h => h.Unidad.Id == bEUnidad.Id && ((DateTime.Now.Month <= 6 && h.FechaHallazgo.Month <= 6) || (DateTime.Now.Month > 6 && h.FechaHallazgo.Month > 6))).ToList();

                    foreach (BEHallazgo item in hallazgosFiltrados)
                    {
                        item.listaElementos = BLLHallazgo.ListarHallazgoElementos(item).listaElementos;
                    }

                    // Obtener los elementos correspondientes a los hallazgos filtrados
                    elementosFiltrados = hallazgosFiltrados.SelectMany(h => h.listaElementos).ToList();

                    categorias = elementosFiltrados.Where(x => x.Estado.Nombre == "Resguardo")
                                                                       .Select(e => e.Articulo.Categoria.Nombre)
                                                                       .Distinct()
                                                                       .ToList();



                    // Agregar los datos al gráfico
                    foreach (var categoria in categorias)
                    {
                        var cantidad = elementosFiltrados.Where(e => e.Articulo.Categoria.Nombre == categoria)
                                                         .Sum(e => e.Cantidad);
                        serieElementos.Points.AddXY(categoria, cantidad);
                    }

                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Semestral de Elementos en Resguardo");



                    break;

                case "trimestral":
                    // Obtener el trimestre actual
                    int trimestreActual = (DateTime.Now.Month - 1) / 3 + 1;

                    // Filtrar los hallazgos por la unidad y el trimestre actual
                    hallazgosFiltrados = ListaHallazgo.Where(h => h.Unidad.Id == bEUnidad.Id && ((DateTime.Now.Month - 1) / 3 + 1 == trimestreActual)).ToList();

                    foreach (BEHallazgo item in hallazgosFiltrados)
                    {
                        item.listaElementos = BLLHallazgo.ListarHallazgoElementos(item).listaElementos;
                    }

                    // Obtener los elementos correspondientes a los hallazgos filtrados
                    elementosFiltrados = hallazgosFiltrados.SelectMany(h => h.listaElementos).ToList();

                    categorias = elementosFiltrados.Where(x => x.Estado.Nombre == "Resguardo")
                                                                           .Select(e => e.Articulo.Categoria.Nombre)
                                                                           .Distinct()
                                                                           .ToList();


                    foreach (var categoria in categorias)
                    {
                        var cantidad = elementosFiltrados.Where(e => e.Articulo.Categoria.Nombre == categoria)
                                                         .Sum(e => e.Cantidad);
                        serieElementos.Points.AddXY(categoria, cantidad);
                    }


                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Trimestral de Elementos en Resguardo");

                    break;

                case "mensual":

                    // Filtrar los hallazgos por la unidad y el mes actual
                    int mesActual = DateTime.Now.Month;
                    hallazgosFiltrados = ListaHallazgo.Where(h => h.Unidad.Id == bEUnidad.Id && h.FechaHallazgo.Month == mesActual).ToList();

                    foreach (BEHallazgo item in hallazgosFiltrados)
                    {
                        item.listaElementos = BLLHallazgo.ListarHallazgoElementos(item).listaElementos;
                    }

                    // Obtener los elementos correspondientes a los hallazgos filtrados
                    elementosFiltrados = hallazgosFiltrados.SelectMany(h => h.listaElementos).ToList();

                    categorias = elementosFiltrados.Where(x => x.Estado.Nombre == "Resguardo")
                                                                                          .Select(e => e.Articulo.Categoria.Nombre)
                                                                                          .Distinct()
                                                                                          .ToList();


                    // Agregar los datos al gráfico
                    foreach (var categoria in categorias)
                    {
                        var cantidad = elementosFiltrados.Where(e => e.Articulo.Categoria.Nombre == categoria)
                                                         .Sum(e => e.Cantidad);
                        serieElementos.Points.AddXY(categoria, cantidad);
                    }
          
                    // Configurar el título del gráfico
                    chart.Titles.Add("Reporte Mensual de Elementos en Resguardo");
                    break;

                default:
                    // Período no válido
                    break;
            }
            return chart;
        }



    }



}






