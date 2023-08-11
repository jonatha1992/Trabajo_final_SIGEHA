using BE;
using Negocio;
using Seguridad;
using System;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();

            customTitleBar1.MaximizeButtonVisible = false;
            customTitleBar1.MinimizeButtonVisible = false;
            customTitleBar1.CloseButtonVisible = false;

        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                this.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        BLLUsuario bLLUsuario;
        public BEUsuario Usuario;
        public bool Verificar()
        {
            try
            {
                if (Validar.SoloContraseña(textBoxUsuario.Text))
                {
                    if (Validar.SoloContraseña(TextBoxPassword1.Texto))
                    {
                        Usuario = bLLUsuario.ControlPasswword(textBoxUsuario.Text, Encriptacion.Encriptar(TextBoxPassword1.Texto));

                        if (Usuario != null)
                        {
                            Usuario = bLLUsuario.ListarObjeto(Usuario);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No coinciden la contrseña y el Usuario");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo alfabetico sin espacios");
                        TextBoxPassword1.Texto = String.Empty;
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Solo alfabetico sin espacios");
                    textBoxUsuario.Text = String.Empty;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;
            }

        }





        private void Form_Login_Load(object sender, EventArgs e)
        {
            bLLUsuario = new BLLUsuario();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonIngresar_Click(null, null);
            }
        }


    }
}
