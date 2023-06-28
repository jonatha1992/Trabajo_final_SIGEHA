using Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class TextBoxPassword : UserControl
    {
        public TextBoxPassword()
        {
            InitializeComponent();
        }

        bool visible = false;

  

        private void pictureBox1raContrasena_Click(object sender, EventArgs e)
        {
            if (!visible) // Si está oculto, se muestra
            {
                pictureBox1raContrasena.Image = Properties.Resources.Visible;
                textBoxContraseña.UseSystemPasswordChar = false;
                visible = true;
            }
            else // Si está visible, se oculta
            {
                pictureBox1raContrasena.Image = Properties.Resources.No_Visible;
                textBoxContraseña.UseSystemPasswordChar = true;
                visible = false;
            }
        }

        public string Texto
        {
            get { return textBoxContraseña.Text; }
            set { textBoxContraseña.Text = value; }
        }

        public void Habilitacion(bool habilita)
        {
            textBoxContraseña.Enabled = habilita;
            pictureBox1raContrasena.Enabled = habilita;
        }

        public void Descrincriptar()
        {
            textBoxContraseña.Text = Encriptacion.Desinciptar(textBoxContraseña.Text);
        }


    }
}
