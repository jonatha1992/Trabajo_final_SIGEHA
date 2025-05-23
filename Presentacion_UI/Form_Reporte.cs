﻿using BE;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_Reporte : Form
    {
        public Form_Reporte()
        {
            InitializeComponent();
            bUsuario = (BEUsuario)Form_Contenedor.usuario.Clone();
        }

        BEReporte Reporte;
        BEUrsa bEUrsa;
        BEUnidad bEUnidad;
        BEUsuario bUsuario;

        private void Form_Reporte_Load(object sender, EventArgs e)
        {

            Reporte = new BEReporte();
            Reporte.HacerReporteGenerico();
            CargarCombo();
            SucripcionEventos();

            labelTotalHallazgos.Text = Reporte.Hallazgos.ToString();
            labelTotalEntregas.Text = Reporte.Entregas.ToString();
            labelElementosEntregados.Text = Reporte.Cant_Elementos_Entregado.ToString();
            labelElementosResguardados.Text = Reporte.Cant_Elementos_Resguardo.ToString();


            RadiocButtonClick(null, null);
        }

        void CargarCombo()
        {
            comboBoxUnidad.DataSource = null;
            if (bUsuario.Destino is BEUrsa)
            {
                bEUrsa = bUsuario.Destino as BEUrsa;
                bEUnidad = bEUrsa.Unidades.First();
                comboBoxUnidad.DataSource = bEUrsa.Unidades;
            }

            if (bUsuario.Destino is BEUnidad)
            {
                bEUnidad = bUsuario.Destino as BEUnidad;
                bEUrsa = bEUnidad.Ursa;
                comboBoxUnidad.DataSource = new List<BEUnidad> { bEUnidad };
                comboBoxUnidad.Text = bEUnidad.Nombre;
            }
        }

        public void SucripcionEventos()
        {
            RadioButtonAnual.Click += RadiocButtonClick;
            RadioButtonMensual.Click += RadiocButtonClick;
            RadioButtonSemestral.Click += RadiocButtonClick;
            RadioButtonTrimestral.Click += RadiocButtonClick;
            comboBoxUnidad.SelectedIndexChanged += RadiocButtonClick;
            comboBoxUnidad.SelectedIndexChanged += RadiocButtonClick;


        }
        void RadiocButtonClick(object sender, EventArgs e)
        {
            try
            {
                bEUnidad = comboBoxUnidad.SelectedItem as BEUnidad;
                ActualizarGraficos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarGraficos()
        {
            if (RadioButtonAnual.Checked)
            {
                chartHallazgos = Reporte.HacerReporteHallazgos(bEUnidad, "anual", chartHallazgos);
                chartEntregas = Reporte.HacerReporteEntregas(bEUnidad, "anual", chartEntregas);
                chartCategoria = Reporte.HacerReporteCategorias(bEUnidad, "anual", chartCategoria);
            }
            else if (RadioButtonSemestral.Checked)
            {
                chartHallazgos = Reporte.HacerReporteHallazgos(bEUnidad, "semestral", chartHallazgos);
                chartEntregas = Reporte.HacerReporteEntregas(bEUnidad, "semestral", chartEntregas);
                chartCategoria = Reporte.HacerReporteCategorias(bEUnidad, "semestral", chartCategoria);
            }
            else if (RadioButtonTrimestral.Checked)
            {
                chartHallazgos = Reporte.HacerReporteHallazgos(bEUnidad, "trimestral", chartHallazgos);
                chartEntregas = Reporte.HacerReporteEntregas(bEUnidad, "trimestral", chartEntregas);
                chartCategoria = Reporte.HacerReporteCategorias(bEUnidad, "trimestral", chartCategoria);
            }
            else if (RadioButtonMensual.Checked)
            {
                chartHallazgos = Reporte.HacerReporteHallazgos(bEUnidad, "mensual", chartHallazgos);
                chartEntregas = Reporte.HacerReporteEntregas(bEUnidad, "mensual", chartEntregas);
                chartCategoria = Reporte.HacerReporteCategorias(bEUnidad, "mensual", chartCategoria);
            }
        }

        private void buttonReporteExcel_Click(object sender, EventArgs e)
        {
            try
            {

                XLWorkbook wb = new XLWorkbook();
                string esc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                SaveFileDialog file = new SaveFileDialog();

                wb.AddWorksheet(Reporte.GenerarReporteExcel(bUsuario));

                file.Filter = "Excel Files | *.xlsx";
                file.FileName = $"Reporte {DateTime.Today.Day + DateTime.Today.ToString("MMMM").ToUpper() + DateTime.Now.Year.ToString()}";


                wb.Worksheet("Elementos").Columns().AdjustToContents();
                //wb.Worksheet("Hallazgos - Actores").Columns().AdjustToContents();
                //wb.Worksheet("Entrega - Actores").Columns().AdjustToContents();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(file.FileName);
                    Process.Start(file.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RadioButtonAnual_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
