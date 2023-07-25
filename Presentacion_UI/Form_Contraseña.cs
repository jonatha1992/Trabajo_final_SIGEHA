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
using DocumentFormat.OpenXml.Spreadsheet;
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


        BEUsuario eUsuario;
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


        bool VerficarCamposUsuario()
        {

            if (textBoxPassword1.Texto != textBoxPassword2.Texto)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if ( textBoxPassword1.Texto == ""  || textBoxPassword2.Texto == "")
            {
                MessageBox.Show("Complete todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            eUsuario.Password = Encriptacion.Encriptar(textBoxPassword1.Texto);
            eUsuario.DNI = textBoxDNI.Text;

            return true;

        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (VerficarCamposUsuario())
            {
                bLLUsuario.CambiarContraseña(eUsuario);
                MessageBox.Show("Se cambio la contraseña correctamente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information); 
                this.Close();
            }
        }
    }
}
