using System;
using System.Windows.Forms;

namespace Seguridad
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
                pictureBox1raContrasena.Image = Properties.Resources.icons_visible;
                textBoxContraseña.UseSystemPasswordChar = false;
                visible = true;
            }
            else // Si está visible, se oculta
            {
                pictureBox1raContrasena.Image = Properties.Resources.icons_no_visible_16;
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
