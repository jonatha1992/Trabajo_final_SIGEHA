using BE;
using ClosedXML.Excel;
using DAL;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;


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
            bLLPermiso = new BLLPermiso();
        }

        Form_Hallazgo form_Hallazgo;
        Form_Entrega form_Entrega;
        //BEUsuario usuario;
        BEUsuario usuario;

        BLLCategoria bLLCategoria;
        BLLPermiso bLLPermiso;

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


       


        public void CargarMenu()
        {

            List<string> listaToolStrip = ObternerTodosMenuStripItems(menuStrip1);
            List<string> permisosDelUsuario = bLLPermiso.ObternerPermisosUsuario(usuario);

            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                if (permisosDelUsuario.Contains(menuItem.Name))
                {
                    menuItem.Visible = true;

                    if (menuItem.DropDownItems != null)
                    {
                        foreach (ToolStripItem item in menuItem.DropDownItems)
                        {
                            if (permisosDelUsuario.Contains(item.Name))
                            {
                                item.Visible = true;
                            }
                            else
                            {
                                item.Visible = false;
                            }
                        }

                    }
                }
                else
                {
                    menuItem.Visible = false;
                }
            }
        }

        public List<string> ObternerTodosMenuStripItems(MenuStrip menuStrip)
        {
            List<string> items = new List<string>();

            foreach (ToolStripItem item in menuStrip.Items)
            {
                items.Add(item.Name);
                if (item is ToolStripMenuItem)
                {
                    items.AddRange(ObtenerDropDownItems((ToolStripMenuItem)item));
                }
            }

            return items;
        }

        private List<string> ObtenerDropDownItems(ToolStripMenuItem item)
        {
            List<string> items = new List<string>();

            foreach (ToolStripItem dropdownItem in item.DropDownItems)
            {
                items.Add(dropdownItem.Name);
                if (dropdownItem is ToolStripMenuItem)
                {
                    items.AddRange(ObtenerDropDownItems((ToolStripMenuItem)dropdownItem));
                }
            }

            return items;
        }


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
                //Articulos = Categorias.SelectMany(categoria => categoria.Articulos).ToList(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Application.Exit();
            }
        }



        private void hallazgoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                form_Hallazgo = new Form_Hallazgo(usuario);
                form_Hallazgo.ShowDialog();

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

            usuario = null;

            Form_Login form_login = new Form_Login();
            var result = form_login.ShowDialog();

            if (result == DialogResult.OK)
            {
                usuario = form_login.Usuario;
                CargarMenu();

            }
            else
            {
                Application.Exit();
            }

        }

        private void CrearHallazgo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void GestionPermisos_Click(object sender, EventArgs e)
        {
            Form_Permiso form_Permiso = new Form_Permiso();
            form_Permiso.Show();
            form_Permiso.MdiParent = this;


        }
    }
}
