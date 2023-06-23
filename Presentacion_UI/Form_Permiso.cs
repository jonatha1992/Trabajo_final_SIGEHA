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
    public partial class FormPermisos : Form
    {
        public FormPermisos()
        {
            InitializeComponent();
        }


        BLLPermiso bllpermiso;
        BERol beRol;
        private void FormPermisos_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNombreFamilia_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void cmdSeleccionarRol_Click(object sender, EventArgs e)
        {
            var tmp = (BERol)this.comboRol.SelectedItem;
            beRol = new BERol();
            beRol.Id = tmp.Id;
            beRol.Nombre = tmp.Nombre;

            MostrarRol(true);
        }

        void MostrarRol(bool init)
        {
            if (beRol == null) return;


            IList<BEComponente> rol = null;
            
            if (init)
            {
                //traigo los hijos de la base
                rol = bllpermiso.ObternerPermisosRol(beRol.Id.ToString());

                foreach (var i in rol)
                    beRol.AgregarHijo(i);
            }
            else
            {
                rol = beRol.Hijos;
            }

            this.treeConfigurarRol.Nodes.Clear();

            TreeNode root = new TreeNode(beRol.Nombre);
            root.Tag = beRol;
            this.treeConfigurarRol.Nodes.Add(root);

            foreach (var item in rol)
            {
                MostrarEnTreeView(root, item);
            }

            treeConfigurarRol.ExpandAll();
        }


        void MostrarEnTreeView(TreeNode tn, BEComponente c)
        {   //muetro en el treeview los componenes sean familia con sus patentes
            TreeNode n = new TreeNode(c.Nombre);
            tn.Tag = c;
            tn.Nodes.Add(n);
            if (c.Hijos != null)
                foreach (var item in c.Hijos)
                {  //funcion recursiva
                    MostrarEnTreeView(n, item);
                }

        }

    }
}
