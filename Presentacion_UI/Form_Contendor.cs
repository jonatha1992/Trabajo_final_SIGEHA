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

            bLLPermiso = new BLLPermiso();
            bLLBitacora = new BLLBitacora();

        }

        Form_Hallazgo form_Hallazgo;
        Form_Entrega form_Entrega;
        Form_Reporte form_Reporte;
        Form_Contraseña form_Contraseña;
        Form_Login form_login;
        Form_Usuarios form_Usuarios;
        Form_Permiso form_Permiso;
        Form_BackUp form_backUp;
        Form_Bitacora form_bitacora;
        Form_GestionHallazgo form_gestionHallazgo;
        Form_GestionEntrega form_GestionEntrega;

        BLLPermiso bLLPermiso;
        BLLBitacora bLLBitacora;

        public static BEUsuario usuario;




        void CargarMenu()
        {

            //List<string> listaToolStrip = ObternerTodosMenuStripItems(menuStrip1);
            List<string> permisosDelUsuario = bLLPermiso.ObternerPermisosMenu(usuario);

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
            Login.Visible = true;
            CambiarContrasena.Visible = true;

        }

        //public List<string> ObternerTodosMenuStripItems(MenuStrip menuStrip)
        //{
        //    List<string> items = new List<string>();

        //    foreach (ToolStripItem item in menuStrip.Items)
        //    {
        //        items.Add(item.Name);
        //        if (item is ToolStripMenuItem)
        //        {
        //            items.AddRange(ObtenerDropDownItems((ToolStripMenuItem)item));
        //        }
        //    }

        //    return items;
        //}
        //private List<string> ObtenerDropDownItems(ToolStripMenuItem item)
        //{
        //    List<string> items = new List<string>();

        //    foreach (ToolStripItem dropdownItem in item.DropDownItems)
        //    {
        //        items.Add(dropdownItem.Name);
        //        if (dropdownItem is ToolStripMenuItem)
        //        {
        //            items.AddRange(ObtenerDropDownItems((ToolStripMenuItem)dropdownItem));
        //        }
        //    }

        //    return items;
        //}


        private void Form_Contenedor_Load(object sender, EventArgs e)
        {

            try
            {
                Conexion conexion = new Conexion();
                if (conexion.TestConection())
                {
                    loginToolStripMenuItem_Click(null, null);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (usuario != null) // si ya hay una secion iniciada
                {
                    if (form_login == null || form_login.IsDisposed)
                    {
                        var result = MessageBox.Show("¿Desea finalizar la Sesion?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            menuStrip1.Enabled = false;
                            usuario = null;
                            form_login = new Form_Login();
                            form_login.MdiParent = this;
                            form_login.FormClosed += Form_Login_FormClosed;
                            form_login.Show();
                        }
                    }
                }
                else // primer inicio
                {
                    if (form_login == null || form_login.IsDisposed)
                    {
                        this.WindowState = FormWindowState.Maximized;
                        usuario = null;
                        form_login = new Form_Login();
                        form_login.MdiParent = this;
                        form_login.FormClosed += Form_Login_FormClosed;
                        form_login.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                if (form_login.Usuario != null)
                {
                    usuario = form_login.Usuario;
                    form_login = null;
                    CargarMenu();
                    menuStrip1.Enabled = true;
                    toolStripStatusLabelUsuario.Text = usuario.NombreUsuario;
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CrearHallazgo_Click(object sender, EventArgs e)
        {
            try
            {
                if (form_Hallazgo == null || form_Hallazgo.IsDisposed)
                {
                    form_Hallazgo = new Form_Hallazgo();
                    form_Hallazgo.MdiParent = this;
                    form_Hallazgo.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GestionUsuarios_Click(object sender, EventArgs e)
        {

            try
            {
                if (form_Usuarios == null || form_Usuarios.IsDisposed)
                {
                    form_Usuarios = new Form_Usuarios();
                    form_Usuarios.MdiParent = this;
                    form_Usuarios.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GestionPermisos_Click(object sender, EventArgs e)
        {

            try
            {
                if (form_Permiso == null || form_Permiso.IsDisposed)
                {
                    form_Permiso = new Form_Permiso();
                    form_Permiso.MdiParent = this;
                    form_Permiso.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CambiarContrasena_Click(object sender, EventArgs e)
        {

            try
            {
                if (form_Contraseña == null || form_Contraseña.IsDisposed)
                {
                    form_Contraseña = new Form_Contraseña();
                    form_Contraseña.MdiParent = this;
                    form_Contraseña.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Mensaje de error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void BackUp_Click(object sender, EventArgs e)
        {

            try
            {
                if (form_backUp == null || form_backUp.IsDisposed)
                {
                    form_backUp = new Form_BackUp();
                    form_backUp.MdiParent = this;
                    form_backUp.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bitacora_Click(object sender, EventArgs e)
        {
            try
            {
                if (form_bitacora == null || form_bitacora.IsDisposed)
                {
                    form_bitacora = new Form_Bitacora();
                    form_bitacora.MdiParent = this;
                    form_bitacora.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void GestionHallazgo_Click(object sender, EventArgs e)
        {
            try
            {
                if (form_gestionHallazgo == null || form_gestionHallazgo.IsDisposed)
                {
                    form_gestionHallazgo = new Form_GestionHallazgo();
                    form_gestionHallazgo.MdiParent = this;
                    form_gestionHallazgo.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarEntrega_Click(object sender, EventArgs e)
        {
            try
            {
                if (form_Entrega == null || form_Entrega.IsDisposed)
                {
                    form_Entrega = new Form_Entrega();
                    form_Entrega.MdiParent = this;
                    form_Entrega.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GestionEntrega_Click(object sender, EventArgs e)
        {
            try
            {
                if (form_GestionEntrega == null || form_GestionEntrega.IsDisposed)
                {
                    form_GestionEntrega = new Form_GestionEntrega();
                    form_GestionEntrega.MdiParent = this;
                    form_GestionEntrega.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (form_Reporte == null || form_Reporte.IsDisposed)
                {
                    form_Reporte = new Form_Reporte();
                    form_Reporte.MdiParent = this;
                    form_Reporte.Show();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
