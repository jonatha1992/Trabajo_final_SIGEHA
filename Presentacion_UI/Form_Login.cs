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
using Seguridad;

namespace Presentacion_UI
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            } 
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BLLUsuario bLLUsuario;
        BLLInstructor bLLInstructor;
        public BEInstructor Usuario;

        public bool Verificar()
        {
            try
            {
                if (Validar.SoloContraseña(textBoxUsuario.Text))
                {
                    if (Validar.SoloContraseña(textBoxPassword.Text))
                    {
                        Usuario = bLLInstructor.ControlPasswword(textBoxUsuario.Text, textBoxPassword.Text);
                        if (Usuario != null)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No coinciden la contrseña o Usuario");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo alfabetico sin espacios");
                        textBoxPassword.Text = String.Empty;
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
            //bLLUsuario = new BLLUsuario();

            bLLInstructor = new BLLInstructor();

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
