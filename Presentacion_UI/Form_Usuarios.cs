using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Windows.Forms;
using BE;
using Negocio;
using Seguridad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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



        private void FormPermisos_Load(object sender, EventArgs e)
        {
            oBLLUsu = new BLLUsuario();
            oBLLPermiso = new BLLPermiso();
            comboBoxUsuarios.DataSource = oBLLUsu.ListarTodo();
            comboBoxRoles.DataSource = oBLLPermiso.ListaRoles();
            comboBoxDestino.DataSource = Form_Contenedor.Ursas;
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
            TreeNode hijo;
            if (c is BEPermiso)
            {
                hijo = new TreeNode(c.Descripcion);
            }
            else
            {
                hijo = new TreeNode(c.Nombre);
            }
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
                seleccion = oBLLUsu.ListarObjeto(seleccion);
                labelDestino.Text = seleccion.Destino != null ? seleccion.Destino.ToString() : "No tiene asginada";

                textBoxNombre.Text = seleccion.NombreCompleto;
                textBoxDNI.Text = seleccion.DNI;
                textBoxUsuario.Text = seleccion.NombreUsuario;
                textBoxPassword1.Texto = Encriptacion.Desinciptar(seleccion.Password);
                textBoxPassword2.Texto = Encriptacion.Desinciptar(seleccion.Password);


                if (seleccion.Permisos.Count > 0)
                {
                    MostrarPermisos(seleccion);

                    var rol = seleccion.Permisos.First();

                    foreach (BEComponente item in comboBoxRoles.Items)
                    {
                        if (item.Id == rol.Id)
                        {
                            comboBoxRoles.SelectedItem = item;
                            break;
                        }
                    }
                    comboBoxRoles_SelectedIndexChanged(null, null);
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
                    if (seleccion.NombreUsuario == "")
                    {
                        seleccion.NombreUsuario = textBoxUsuario.Text;
                    }

                    seleccion.Permisos.Add(comboBoxRoles.SelectedItem as BERol);
                    MostrarPermisos(seleccion);
                    comboBoxRoles_SelectedIndexChanged(null, null);
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
                    seleccion.Destino = comboBoxDestino.SelectedItem as BEUrsa;
                }
                else
                {
                    seleccion.Destino = comboBoxDestino.SelectedItem as BEUnidad;
                }
                labelDestino.Text = seleccion.Destino.ToString();
                MessageBox.Show($"Al usuario {seleccion.NombreUsuario} tiene como destino {comboBoxDestino.Text} ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                LimpiarFormulario();
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
                if (VerficarCamposUsuario())
                {
                    if (oBLLUsu.GuardarUsuario(seleccion))
                    {
                        LimpiarFormulario();
                        groupBoxDatosUsuario.Visible = false;
                        comboBoxUsuarios.DataSource = oBLLUsu.ListarTodo();
                        MessageBox.Show("Se ha Guardado los cambios con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El usuario no tiene asignado ningun destino", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

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
                    comboBoxDestino.SelectedItem = seleccion.Destino;
                }
                else
                {
                    groupBoxDestino.Visible = false;
                }
            }

        }

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (oBLLUsu.Eliminar(seleccion))
                {
                    LimpiarFormulario();
                    groupBoxDatosUsuario.Visible = false;
                    comboBoxUsuarios.DataSource = oBLLUsu.ListarTodo();
                    MessageBox.Show($"El Usuario {seleccion.NombreUsuario} se ha eliminado de la base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpiarFormulario()
        {
            seleccion = null;
            textBoxNombre.Text = "";
            textBoxDNI.Text = "";
            textBoxUsuario.Text = "";
            textBoxPassword1.Texto = "";
            textBoxPassword2.Texto = "";
            labelDestino.Text = "";
            treeViewPermisos.Nodes.Clear();

        }


        bool VerficarCamposUsuario()
        {

            if (seleccion.Permisos.Count == 0)
            {
                MessageBox.Show("El usuario no tiene un rol asignado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBoxPassword1.Texto != textBoxPassword2.Texto)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (textBoxUsuario.Text == "" || textBoxNombre.Text == "" || textBoxPassword1.Texto == "" || textBoxPassword2.Texto == "" || textBoxDNI.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            seleccion.NombreUsuario = textBoxUsuario.Text;
            seleccion.NombreCompleto = textBoxNombre.Text;
            seleccion.Password = Encriptacion.Encriptar(textBoxPassword1.Texto);
            seleccion.DNI = textBoxDNI.Text;

            return true;

        }
        private void buttonDesagsinarRol_Click(object sender, EventArgs e)
        {

            BERol rolSeleccionado = treeViewPermisos.SelectedNode.Tag as BERol;

            int cantidadEliminada = seleccion.Permisos.RemoveAll(x => x.Id == rolSeleccionado.Id);

            if (cantidadEliminada > 0)
            {
                MessageBox.Show("El rol se desasignó exitosamente.", "Desasignación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarPermisos(seleccion);
            }
            else
            {
                MessageBox.Show("No se encontró el rol en los permisos del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonDesagniarUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                seleccion.Destino = null;
                labelDestino.Text = "No tiene asignada";
                MessageBox.Show("El usuario ya NO posee destino asignado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeViewPermisos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Tag is BERol)
                {
                    BERol rol = e.Node.Tag as BERol;
                    buttonDesagsinarRol.Visible = true;
                }
                else
                {
                    buttonDesagsinarRol.Visible = false;
                }
            }
        }

        private void groupBoxDatosUsuario_Enter(object sender, EventArgs e)
        {

        }
    }
}
