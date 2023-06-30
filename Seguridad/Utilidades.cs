using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad
{
    public class Utilidades
    {
        public static Control LimpiarControles(Control control)
        {
            if (control is TextBox textBox)
            {
                textBox.Text = string.Empty;
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.SelectedIndex = -1;
            }
            else if (control is TreeView treeView)
            {
                treeView.Nodes.Clear();
            }
            else if (control is Label label)
            {
                label.Text = "";
            }
            return control;
        }

    }
}
