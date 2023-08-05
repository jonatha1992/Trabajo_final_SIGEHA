using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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

        #region "campos"
        BLLUsuario oBLLUsu;
        BLLPermiso oBLLPermiso;
        BLLUnidad bLLUnidad;
        BLLUrsa bLLUrsa;
        BEUsuario seleccion;
        List<BEUnidad> Unidades { get; set; }
        List<BEUrsa> Ursas { get; set; }
        #endregion

        #region "Metodos"

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
        void DeshabilitarCarga()
        {
            groupBoxDatosUsuario.Enabled = false;
            ButtonEliminarUsuario.Visible = false;
        }

        void HabilitarCargaConfig()
        {
            groupBoxDatosUsuario.Enabled = true;
            ButtonEliminarUsuario.Visible = true;
        }
        void HabilitarCargaNuevo()
        {
            groupBoxDatosUsuario.Enabled = true;
            ButtonEliminarUsuario.Visible = false;
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
                MessageBox.Show("El usuario no tiene un rol asignado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBoxPassword1.Texto != textBoxPassword2.Texto)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (textBoxUsuario.Text == ""
                || textBoxNombre.Text == ""
                || textBoxPassword1.Texto == ""
                || textBoxPassword2.Texto == ""
                || textBoxDNI.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validar.VerificarNroDocumento(textBoxDNI.Text))
            {
                MessageBox.Show("Complete bien el Nro de documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            seleccion.NombreUsuario = textBoxUsuario.Text;
            seleccion.NombreCompleto = textBoxNombre.Text;
            seleccion.Password = Encriptacion.Encriptar(textBoxPassword1.Texto);
            seleccion.DNI = textBoxDNI.Text;

            return true;

        }


        #endregion


        #region "Eventos"
        void FormPermisos_Load(object sender, EventArgs e)
        {
            oBLLUsu = new BLLUsuario();
            oBLLPermiso = new BLLPermiso();
            bLLUnidad = new BLLUnidad();
            bLLUrsa = new BLLUrsa();

            Unidades = bLLUnidad.ListarTodo();
            Ursas = bLLUrsa.ListarTodo();
            comboBoxUsuarios.DataSource = oBLLUsu.ListarTodo();
            comboBoxRoles.DataSource = oBLLPermiso.ListaRoles();
            comboBoxDestino.DataSource = Ursas;
            groupBoxDatosUsuario.Enabled = false;
        }
        void rbtnUrsa_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDestino.DataSource = null;
            comboBoxDestino.DataSource = Ursas;
        }
        void rbtnUnidad_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDestino.DataSource = null;
            comboBoxDestino.DataSource = Unidades;
        }
        void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                if (oBLLUsu.UsuarioTieneRolInstructorOsupervisor(seleccion))
                {
                    groupBoxDestino.Enabled = true;

                    if (seleccion.Destino is BEUrsa)
                    {
                        radiobuttonUrsa.Checked = true;
                    }
                    else
                    {
                        RadioButtonUnidad.Checked = true;
                    }
                    comboBoxDestino.SelectedItem = seleccion.Destino;
                }
                else
                {
                    groupBoxDestino.Enabled = false;
                }
            }

        }
        void treeViewPermisos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Tag is BERol)
                {
                    BERol rol = e.Node.Tag as BERol;
                    ButtonDesasignarRol.Visible = true;
                }
                else
                {
                    ButtonDesasignarRol.Visible = false;
                }
            }
        }
        #endregion


        #region "Botones"
        private void ButtonConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCargaConfig();
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
        private void ButtonGenerarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarFormulario();
                HabilitarCargaNuevo();
                seleccion = new BEUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonDesagsinarRol_Click(object sender, EventArgs e)
        {

            BERol rolSeleccionado = treeViewPermisos.SelectedNode.Tag as BERol;

            int cantidadEliminada = seleccion.Permisos.RemoveAll(x => x.Id == rolSeleccionado.Id);

            if (cantidadEliminada > 0)
            {
                MessageBox.Show("El rol se desasignó exitosamente.", "Desasignación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonDesasignarRol.Visible = false;
                MostrarPermisos(seleccion);
            }
            else
            {
                MessageBox.Show("No se encontró el rol en los permisos del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (oBLLUsu.Eliminar(seleccion))
                {
                    LimpiarFormulario();
                    DeshabilitarCarga();

                    comboBoxUsuarios.DataSource = oBLLUsu.ListarTodo();
                    MessageBox.Show($"El Usuario  se ha eliminado de la base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonAsignarRol_Click(object sender, EventArgs e)
        {
            try
            {
                var existe = seleccion.Permisos.Exists(x => x.Id == (comboBoxRoles.SelectedItem as BERol).Id);
                if (!existe)
                {
                    if (seleccion.NombreUsuario == "" || seleccion.NombreUsuario == null)
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
        void buttonAsignarDestino_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDestino.DataSource != null)
                {
                    if (radiobuttonUrsa.Checked)
                    {
                        seleccion.Destino = comboBoxDestino.SelectedItem as BEUrsa;
                    }
                    else
                    {
                        seleccion.Destino = comboBoxDestino.SelectedItem as BEUnidad;
                    }
                    labelDestino.Text = seleccion.Destino?.ToString();
                    MessageBox.Show($"Al usuario {seleccion.NombreUsuario} tiene como destino {comboBoxDestino.Text} ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonDesagniarDestino_Click(object sender, EventArgs e)
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
        void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerficarCamposUsuario())
                {
                    if (oBLLUsu.GuardarUsuario(seleccion))
                    {
                        LimpiarFormulario();
                        DeshabilitarCarga();
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

        #endregion


    }
}
