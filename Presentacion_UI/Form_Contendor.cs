using BE;
using ClosedXML.Excel;
using DAL;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_Contenedor : Form
    {
        public Form_Contenedor()
        {
            InitializeComponent();

            bLLCategoria = new BLLCategoria();
            bLLArticulo = new BLLArticulo();
            bLLUnidad = new BLLUnidad();
            bLLUrsa = new BLLUrsa();
            bLLEstado_Elemento = new BLLEstado_Elemento();
        }

        Form_Hallazgo form_Hallazgo;
        Form_Entrega form_Entrega;
        //BEUsuario usuario;
        BEInstructor usuario;

        BLLCategoria bLLCategoria;
        BLLArticulo bLLArticulo;
        BLLUnidad bLLUnidad;
        BLLUrsa bLLUrsa;
        BLLEstado_Elemento bLLEstado_Elemento;

        public static List<BECategoria> Categorias { get; set; }
        public static List<BEArticulo> Articulos { get; set; }
        public static List<BEEstado_Elemento> EstadosElementos { get; set; }
        public static List<BEUrsa> Ursas { get; set; }
        public static List<BEUnidad> Unidades { get; set; }
        public static BEUrsa Ursa { get; set; }
        public static BEUnidad Unidad { get; set; }


        private void Form_Contenedor_Load(object sender, EventArgs e)
        {

            try
            {
                Conexion conexion = new Conexion();
                if (conexion.TestConection())
                {
                    loginToolStripMenuItem_Click(null, null);
                }

                Categorias = bLLCategoria.ListarTodo();
                Articulos = bLLArticulo.ListarTodo();
                EstadosElementos = bLLEstado_Elemento.ListarTodo();
                Ursas = bLLUrsa.ListarTodo();
                Unidades = bLLUnidad.ListarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }



        private void hallazgoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //form_Hallazgo = new Form_Hallazgo(usuario);
                //form_Hallazgo.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void entregaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                //form_Entrega = new Form_Entrega(usuario);
                //form_Entrega.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //Reporte reporte = new Reporte(usuario);

                XLWorkbook wb = new XLWorkbook();
                string esc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                SaveFileDialog file = new SaveFileDialog();

                //wb.AddWorksheet(reporte.reporte);

                file.Filter = "Excel Files | *.xlsx";
                file.FileName = $"Reporte {DateTime.Today.Day + DateTime.Today.ToString("MMMM").ToUpper() + DateTime.Now.Year.ToString()}";


                wb.Worksheet("Elementos").Columns().AdjustToContents();
                wb.Worksheet("Hallazgos - Actores").Columns().AdjustToContents();
                wb.Worksheet("Entrega - Actores").Columns().AdjustToContents();
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hallazgoToolStripMenuItem.Enabled = false;
            entregaToolStripMenuItem1.Enabled = false;
            reporteToolStripMenuItem.Enabled = false;
            usuario = null;
            labelUsuario.Text = "";

            Form_Login form_login = new Form_Login();
            var result = form_login.ShowDialog();
            //var result = form_login.Show();

            if (result == DialogResult.OK)
            {
                usuario = form_login.Usuario;
                hallazgoToolStripMenuItem.Enabled = true;
                entregaToolStripMenuItem1.Enabled = true;
                reporteToolStripMenuItem.Enabled = true;
                labelUsuario.Text = "Usuario: " + usuario.NombreCompleto;
               
                //Ursa = bLLUrsa.ListarObjeto(usuario);
                //Unidad = bLLUnidad.ListarObjeto(usuario);

            }
            else
            {
                Application.Exit();
            }

        }


    }
}
