using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Negocio;

namespace Presentacion_UI
{
    public partial class Form_Permiso : Form
    {
        public Form_Permiso()
        {
            InitializeComponent();
            bllpermiso = new BLLPermiso();
        }


        BLLPermiso bllpermiso;
        BERol beRol;

        private void FormPermisos_Load(object sender, EventArgs e)
        {
            cboRol.DataSource = bllpermiso.ListaRoles();
            cboPermisos.DataSource = bllpermiso.Listarpermisos();
        }


        private void btnSeleccionarRol_Click(object sender, EventArgs e)
        {

            try
            {
                beRol = (BERol)this.cboRol.SelectedItem;
                beRol.Id = beRol.Id;
                beRol.Nombre = beRol.Nombre;

                labelRol.Text = "";
                labelRol.Text += beRol.Nombre;
                MostrarArbolEnTreeView(beRol);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void MostrarArbolEnTreeView(BEComponente raiz)
        {
            if (raiz == null) return;

            this.treeRol.Nodes.Clear();

            TreeNode root = new TreeNode(raiz.Nombre);
            root.Tag = raiz;
            this.treeRol.Nodes.Add(root);

            MostrarHijosEnTreeView(root, raiz.Hijos);

            treeRol.ExpandAll();
        }

        void MostrarHijosEnTreeView(TreeNode padre, List<BEComponente> hijos)
        {
            if (hijos != null)
            {
                foreach (var hijo in hijos)
                {
                    TreeNode nodo = new TreeNode(hijo.Descripcion);
                    nodo.Tag = hijo;
                    padre.Nodes.Add(nodo);

                    MostrarHijosEnTreeView(nodo, hijo.Hijos); // Llamada recursiva
                }
            }
        }


        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (beRol != null)
                {
                    var existe = bllpermiso.ExistePermiso(beRol, cboPermisos.SelectedItem as BEPermiso);
                    if (existe)
                    {
                        MessageBox.Show("El Rol ya contiene ese Permiso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        beRol.AgregarHijo(cboPermisos.SelectedItem as BEPermiso);
                        MostrarArbolEnTreeView(beRol);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccion el Rol", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCrearRol_Click(object sender, EventArgs e)
        {
            try
            {
                BERol nuevoRol = new BERol();
                nuevoRol.Nombre = txtNombreRol.Text;
                bllpermiso.CrearComponente(nuevoRol, true);
                cboRol.DataSource = bllpermiso.ListaRoles();
                MessageBox.Show($"Se ha creado el Rol {nuevoRol.Nombre}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }

        }

        private void btnGuardarRol_Click(object sender, EventArgs e)
        {

            try
            {

                bllpermiso.GuardaRol(beRol);


                treeRol.Nodes.Clear();
                labelRol.Text = "";
                beRol = null;
                cboRol.DataSource = bllpermiso.ListaRoles();

                MessageBox.Show("Se guardo el Rol con los permisos Referenciados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminarPermiso_Click(object sender, EventArgs e)
        {
            // Verificar si hay un nodo seleccionado
            if (treeRol.SelectedNode != null)
            {
                // Obtener el nodo seleccionado y su nodo padre
                TreeNode nodoSeleccionado = treeRol.SelectedNode;
                TreeNode nodoPadre = nodoSeleccionado.Parent;
                BEPermiso permiso = nodoSeleccionado.Tag as BEPermiso;
                // Verificar si el nodo tiene un nodo padre
                if (nodoPadre != null)
                {
                    // Eliminar el nodo seleccionado del nodo padre
                    nodoPadre.Nodes.Remove(nodoSeleccionado);
                    beRol.EliminarHijo(permiso);
                }
                else
                {
                    var result = MessageBox.Show($"¿Desea eliminar el Rol {beRol.Nombre} ? \n\nTenga en cuenta que se eliminaran todos los permisos de los usuarios que esten asociados al Rol {beRol.Nombre}", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        bllpermiso.EliminarRol(beRol);

                        MessageBox.Show($"El Rol {beRol.Nombre} se ha borrado de la base de datos Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        treeRol.Nodes.Clear();
                        labelRol.Text = "";
                        beRol = null;
                        cboRol.DataSource = bllpermiso.ListaRoles();

                    }

                }
            }

            else
            {
                MessageBox.Show("Seleccione un nodo para eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
