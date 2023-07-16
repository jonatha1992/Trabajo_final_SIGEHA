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
    public partial class Form_Contraseña : Form
    {
        public Form_Contraseña()
        {
            InitializeComponent();
        }


        BLLUsuario oBLLUsu;
        BLLPermiso oBLLPermiso;
        BEUsuario seleccion;



        private void FormPermisos_Load(object sender, EventArgs e)
        {
            
        }




    }
}
