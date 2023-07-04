using BE;
using Negocio;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_Bitacora : Form
    {
        public Form_Bitacora()
        {
            InitializeComponent();

        }
        List<BEEvento> listaEventos = new List<BEEvento>();
        BLLBitacora bLLBitacora = new BLLBitacora();
        private void Form_Bitacora_Load(object sender, EventArgs e)
        {
            listaEventos = bLLBitacora.ListarTodo();
            cargarGrilla(listaEventos);

        }

        void cargarGrilla(List<BEEvento> list)
        {
            DgvRegistros.DataSource = null;
            DgvRegistros.DataSource = list;
            DgvRegistros.Columns["Id"].Width = 30;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var lista = listaEventos.FindAll(x => x.Usuario.Contains(textBoxCriterio.Text) || x.Mensaje.Contains(textBoxCriterio.Text) );
            cargarGrilla(lista);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargarGrilla(listaEventos);
        }
    }
}

