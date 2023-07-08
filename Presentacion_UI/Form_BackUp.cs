using BE;
using Negocio;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_BackUp : Form
    {
        public Form_BackUp()
        {
            InitializeComponent();

        }
        void cargarGrilla()
        {
            DgvBackups.DataSource = null;
            DgvBackups.DataSource = bLLBackUp.ListarTodo();
        }


        BLLBitacora bLLBitacora = new BLLBitacora();
        BLLBackUp bLLBackUp = new BLLBackUp();
        private void btnGenerarBackUP_Click(object sender, EventArgs e)
        {
            var nombre = bLLBackUp.GenerarBackup();
            bLLBitacora.RegistrarEvento(Form_Contenedor.usuario, $"Genero el BackUp {nombre}");
            cargarGrilla();
            MessageBox.Show($"Se genero el {nombre} con exito ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonRestaurar_Click(object sender, EventArgs e)
        {

            BEBackUp bEBackUp = new BEBackUp();

            if (DgvBackups.CurrentRow != null) // Verificar si hay una fila seleccionada
            {
                bEBackUp = DgvBackups.CurrentRow.DataBoundItem as BEBackUp;
                bLLBackUp.RestaurarBackup(bEBackUp);

                // Registrar el evento de restauración en la bitácora
                bLLBitacora.RegistrarEvento(Form_Contenedor.usuario, $"Restauro BackUp {bEBackUp.NombreArchivo}");
                cargarGrilla() ;
                MessageBox.Show($"Se restauro el {bEBackUp.NombreArchivo} con exito ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void Form_BackUp_Load(object sender, EventArgs e)
        {
            DgvBackups.DataSource = null;
            DgvBackups.DataSource = bLLBackUp.ListarTodo();

        }
    }
}

