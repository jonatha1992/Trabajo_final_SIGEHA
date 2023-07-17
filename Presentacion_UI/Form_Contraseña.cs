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
using Seguridad;

namespace Presentacion_UI
{
    public partial class Form_Contraseña : Form
    {
        public Form_Contraseña()
        {
            InitializeComponent();
        }


        BEUsuario eUsuario ;   
        BLLUsuario bLLUsuario;



        private void FormPermisos_Load(object sender, EventArgs e)
        {
            bLLUsuario = new BLLUsuario();  
            eUsuario = Form_Contenedor.usuario;

            textBoxNombre.Text = eUsuario.NombreCompleto;   
            textBoxUsuario.Text = eUsuario.NombreUsuario;   
            textBoxDNI.Text = eUsuario.DNI;  
            textBoxPassword1.Texto = Encriptacion.Desinciptar(eUsuario.Password);  
            textBoxPassword2.Texto = Encriptacion.Desinciptar(eUsuario.Password);  

        }

        private void buttonGuardarUsuario_Click(object sender, EventArgs e)
        {
            bLLUsuario.CambiarContraseña(eUsuario);
        }
    }
}
