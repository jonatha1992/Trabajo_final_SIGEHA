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
using DocumentFormat.OpenXml.Drawing.Charts;
using Negocio;

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
            
        }


        private void buttonConfigurar_Click(object sender, EventArgs e)
        {
            seleccion = (BEUsuario)comboBoxUsuarios.SelectedItem;

            //hago una copia del objeto para no modificr el que esta en el combo.
            tmp = new BEUsuario();
            tmp.Id = seleccion.Id;
            tmp.NombreCompleto = seleccion.NombreCompleto;
            oBLLPermiso.ObternerPermisosUsuario(tmp);

            MostrarPermisos(tmp);
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

       
        
    }
}
