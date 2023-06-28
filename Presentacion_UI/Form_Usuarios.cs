using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Windows.Forms;
using BE;
using Negocio;
using Seguridad;

namespace Presentacion_UI
{
    public partial class Form_Usuarios : Form
    {
        public Form_Usuarios()
        {
            InitializeComponent();
        }


        BLLUsuario oBLLUsu;
        BLLPermiso oBLLPermiso;
        BEUsuario seleccion;
        BEUsuario tmp;



        private void FormPermisos_Load(object sender, EventArgs e)
        {
            oBLLUsu = new BLLUsuario();
            oBLLPermiso = new BLLPermiso();
            comboBoxUsuarios.DataSource = oBLLUsu.ListarTodo();
            comboBoxRoles.DataSource = oBLLPermiso.ListaRoles();
            groupBoxDatosUsuario.Visible = false;
        }


        void MostrarPermisos(BEUsuario u)
        {
            this.treeViewPermisos.Nodes.Clear();
            TreeNode root = new TreeNode(u.NombreUsuario);

            foreach (var item in u.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.treeViewPermisos.Nodes.Add(root);
            this.treeViewPermisos.ExpandAll();
        }
        void LlenarTreeView(TreeNode padre, BEComponente c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.Hijos)
            {
                LlenarTreeView(hijo, item);
            }

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {

            try
            {
                groupBoxDatosUsuario.Visible = true;
                seleccion = (BEUsuario)comboBoxUsuarios.SelectedItem;
                labelUsuario.Text = seleccion.NombreUsuario;

                seleccion = oBLLUsu.ListarUsuarioConPermisos(seleccion);

                MostrarPermisos(seleccion);

                textBoxNombre.Text = seleccion.NombreCompleto;
                textBoxDNI.Text = seleccion.DNI;
                textBoxUsuario.Text = seleccion.NombreUsuario;
                textBoxPassword1.Texto = seleccion.Password;
                textBoxPassword2.Texto = seleccion.Password;
                var rol = seleccion.Permisos.First();

                foreach (BEComponente item in comboBoxRoles.Items)
                {
                    if (item.Id == rol.Id)
                    {
                        comboBoxRoles.SelectedItem = item;
                        break;
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rbtnUrsa_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDestino.DataSource = null;
            comboBoxDestino.DataSource = Form_Contenedor.Ursas;
        }

        private void rbtnUnidad_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDestino.DataSource = null;
            comboBoxDestino.DataSource = Form_Contenedor.Unidades;
        }

        private void buttonAsignarRol_Click(object sender, EventArgs e)
        {

            try
            {


                var existe = seleccion.Permisos.Exists(x => x.Id == (comboBoxRoles.SelectedItem as BERol).Id);

                if (!existe)
                {
                    seleccion.Permisos.Add(comboBoxRoles.SelectedItem as BERol);

                    MostrarPermisos(seleccion);
                }
                else
                {

                    MessageBox.Show("El usuario ya posee es rol", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAsignarDestino_Click(object sender, EventArgs e)
        {

            try
            {

                if (rbtnUrsa.Checked)
                {
                    seleccion.Ursa = comboBoxDestino.SelectedItem as BEUrsa;
                    seleccion.Unidad = null;
                }
                else
                {
                    seleccion.Unidad = comboBoxDestino.SelectedItem as BEUnidad;
                    seleccion.Ursa = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGenerarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxDatosUsuario.Visible = true;
                seleccion = new BEUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                //groupBoxDatosUsuario.Visible = false;
                seleccion = null;
                labelUsuario.Text = "";
                Utilidades.LimpiarControlesEnGroupBox(groupBoxDatosUsuario);

                MessageBox.Show("Se ha Guardado los cambios con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                if (oBLLUsu.verificarol(seleccion))
                {
                    groupBoxDestino.Visible = true;
                    if (seleccion.Ursa != null)
                    {
                        comboBoxDestino.SelectedItem = seleccion.Ursa;
                    }
                    else // pertenece a una unidad 
                    {
                        comboBoxDestino.SelectedItem = seleccion.Unidad;
                    }
                }
                else
                {
                    groupBoxDestino.Visible = true;
                }
            }

        }
    }
}
