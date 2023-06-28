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
                MostrarRol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void MostrarRol()
        {
            if (beRol == null) return;

            List<BEComponente> permiso = null;

            permiso = beRol.Hijos;


            this.treeRol.Nodes.Clear();

            TreeNode root = new TreeNode(beRol.Nombre);
            root.Tag = beRol;
            this.treeRol.Nodes.Add(root);

            foreach (var item in permiso)
            {
                MostrarEnTreeView(root, item);
            }

            treeRol.ExpandAll();
        }


        void MostrarEnTreeView(TreeNode tn, BEComponente c)
        {
            //muetro en el treeview los componenes sean familia con sus patentes
            TreeNode n = new TreeNode(c.Nombre);
            tn.Tag = c;
            tn.Nodes.Add(n);
            if (c.Hijos != null)
                foreach (var item in c.Hijos)
                {  //funcion recursiva
                    MostrarEnTreeView(n, item);
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
                        MessageBox.Show("El Rol ya contiene ese Permiso");
                    }
                    else
                    {
                        beRol.AgregarHijo(cboPermisos.SelectedItem as BEPermiso);
                        MostrarRol();
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

                // Verificar si el nodo tiene un nodo padre
                if (nodoPadre != null)
                {
                    // Eliminar el nodo seleccionado del nodo padre
                    nodoPadre.Nodes.Remove(nodoSeleccionado);
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar el nodo Raiz", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
