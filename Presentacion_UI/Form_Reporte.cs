using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Negocio;

namespace Presentacion_UI
{
    public partial class Form_Reporte : Form
    {
        public Form_Reporte()
        {
            InitializeComponent();
        }

        BEReporte Reporte;
        BEUrsa bEUrsa;
        BEUnidad bEUnidad;

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
            if (Form_Contenedor.usuario.Destino is BEUrsa)
            {
                bEUrsa = Form_Contenedor.usuario.Destino as BEUrsa;
                bEUnidad = bEUrsa.Unidades.First();
                comboBoxUnidad.DataSource = bEUrsa.Unidades;
            }

            if (Form_Contenedor.usuario.Destino is BEUnidad)
            {
                bEUnidad = Form_Contenedor.usuario.Destino as BEUnidad;
                bEUrsa = bEUnidad.Ursa;
                comboBoxUnidad.DataSource = new List<BEUnidad> { bEUnidad};
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

     
    }
}
