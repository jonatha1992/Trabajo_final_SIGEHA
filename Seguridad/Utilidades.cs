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


        public static TextBox SetAutoCompleteTextBox<T>(TextBox textBox, IEnumerable<T> items, Func<T, string> selector)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(items.Select(selector).ToArray());

            textBox.AutoCompleteCustomSource = source;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            return textBox;
        }


        public static ComboBox SetAutoCompleteCombo<T>(ComboBox comboBox, IEnumerable<T> items, Func<T, string> selector)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(items.Select(selector).ToArray());

            comboBox.AutoCompleteCustomSource = source;
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            return comboBox;
        }

    }


}
