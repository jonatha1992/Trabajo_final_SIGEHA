using BE;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_Bitacora : Form
    {
        public Form_Bitacora()
        {
            InitializeComponent();

            bEBitacora = new BEBitacora();
            bEBitacora.ListaEventos = bLLBitacora.ListarTodo();
        }

        BEBitacora bEBitacora;
        BLLBitacora bLLBitacora = new BLLBitacora();
        private void Form_Bitacora_Load(object sender, EventArgs e)
        {
            cargarGrilla(bEBitacora.ListaEventos);

        }

        void cargarGrilla(List<BEEvento> list)
        {
            DgvRegistros.DataSource = null;
            DgvRegistros.DataSource = list;
            DgvRegistros.Columns["Id"].Width = 30;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var lista = bEBitacora.ListaEventos.FindAll(x => x.Usuario.Contains(textBoxCriterio.Text) || x.Mensaje.Contains(textBoxCriterio.Text));
            cargarGrilla(lista);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargarGrilla(bEBitacora.ListaEventos);
        }

    }
}

