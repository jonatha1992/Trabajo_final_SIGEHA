using BE;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualBasic;
using Negocio;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using Color = System.Drawing.Color;
using Font = System.Drawing.Font;

namespace Presentacion_UI
{
    public partial class Form_GestionEntrega : Form
    {
        public Form_GestionEntrega()
        {

            InitializeComponent();

            bLLEntrega = new BLLEntrega();
            bLLBitacora = new BLLBitacora();

            Usuario = Form_Contenedor.usuario;
        }


        void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
                Habilitar();

                ListaEntregas = bLLEntrega.ListarTodo(bEUnidad, dateTimePickerFechaEntrega.Value);
                CargarGrillaEntregas();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #region "Propiedades"

        BEUsuario Usuario;
        BEUnidad bEUnidad;
        BEUrsa bEUrsa;

        BEEntrega BEEntregaSeleccionado;
        List<BEEntrega> ListaEntregas;
        BLLEntrega bLLEntrega;
        BLLBitacora bLLBitacora;



        bool SeleccionEntrega = false;
        #endregion

        #region "Metodos"

        #region "MetodosElementos"

        void CargarCombo()
        {
            if (Usuario.Destino is BEUnidad)//destino unidad
            {
                bEUnidad = Usuario.Destino as BEUnidad;
                bEUrsa = bEUnidad.Ursa;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUnidad.SelectedItem = bEUnidad;
                comboBoxUnidad.Text = bEUnidad.Nombre;
                comboBoxUrsa.Enabled = false;
                comboBoxUnidad.Enabled = false;
            }
            if (Usuario.Destino is BEUrsa) //destino region
            {
                bEUrsa = Usuario.Destino as BEUrsa;
                bEUnidad = bEUrsa.Unidades.First();
                comboBoxUnidad.DataSource = bEUrsa.Unidades;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUrsa.Enabled = false;
            }
        }

        void CargarGrillaElementos()
        {
            try
            {
                DgvElementos.DataSource = null;

                if (SeleccionEntrega)
                {

                    DgvElementos.DataSource = bLLEntrega.ListarEntregaElementos(BEEntregaSeleccionado).listaElementos;

                    if (DgvElementos.DataSource != null || BEEntregaSeleccionado.listaElementos.Count > 0)
                    {
                        this.DgvElementos.Columns["Id"].Width = 35;
                        this.DgvElementos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                        this.DgvElementos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                        this.DgvElementos.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);

                    }
                    if (DgvElementos.DataSource == null || DgvElementos.Rows.Count == 0)
                    {
                        DgvElementos.ColumnHeadersVisible = false;
                    }
                    else
                    {
                        DgvElementos.ColumnHeadersVisible = true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}"); ;
            }
        }

        void CargarGrillaPersonas()
        {
            DgvPersonas.DataSource = null;

            if (SeleccionEntrega)
            {
                BEEntregaSeleccionado.listaPersonas = bLLEntrega.ListarEntregaPersonas(BEEntregaSeleccionado).listaPersonas;
                DgvPersonas.DataSource = BEEntregaSeleccionado.listaPersonas;

                if (BEEntregaSeleccionado.listaPersonas != null || BEEntregaSeleccionado.listaPersonas?.Count > 0)
                {

                    this.DgvPersonas.Columns["Id"].Visible = false;
                    this.DgvPersonas.Columns["Telefono"].Visible = false;
                    this.DgvPersonas.Columns["Ocupacion"].Visible = false;
                    this.DgvPersonas.Columns["Domicilio"].Visible = false;
                    this.DgvPersonas.Columns["NombreCompleto"].HeaderText = "Apellido y Nombre";
                    this.DgvPersonas.Columns["EstadoPersona"].HeaderText = "Estado";
                    this.DgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    this.DgvPersonas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    this.DgvPersonas.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                    this.DgvPersonas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);

                }
            }

            if (DgvPersonas.DataSource == null || DgvPersonas.Rows.Count == 0)
            {
                DgvPersonas.ColumnHeadersVisible = false;
            }
            else
            {
                DgvPersonas.ColumnHeadersVisible = true;
            }


        }
        void SeleccionarHallazgo()  // lo que hace la funcion es recorrer el dgv y seleccioonar el hallazgo
        {
            foreach (DataGridViewRow item in dgvHallazgos.Rows)
            {
                if (item.Cells["NroActa"].Value.ToString() == BEEntregaSeleccionado.NroActa)
                {
                    item.Cells["Seleccion"].Value = true;
                    item.Selected = true;
                }
            }
        }

        #endregion

        #region "MetodosHallazgo"
        void limpiarCamposEntrega()
        {
            dateTimePickerFechaEntrega.Value = DateTime.Now;
            textBoxNroActa.Text = "";
            textBoxObservacion.Text = "";
            checkBoxObservacion.Checked = false;
            SeleccionEntrega = false;
            BEEntregaSeleccionado = null;
        }
        void ComboBox()
        {
            if (SeleccionEntrega) // si esta en modo creacion
            {
                comboBoxUnidad.Text = BEEntregaSeleccionado.Unidad.Nombre;

                if (Usuario.Destino is BEUrsa)
                    comboBoxUnidad.Enabled = false;
            }
            else
            {
                if (Usuario.Destino is BEUrsa)
                    comboBoxUnidad.Enabled = true;

            }
        }
        void Botones()
        {
            if (SeleccionEntrega)
            {
                buttonEliminar.Visible = true;
                button_Modificar.Visible = true;
            }
            else
            {
                button_Modificar.Visible = false;
                buttonEliminar.Visible = false;
            }

        }
        void Habilitar()
        {
            Botones();
            ComboBox();
        }
        void CargarGrillaEntregas()
        {
            this.dgvHallazgos.DataSource = null;


            if (ListaEntregas != null && ListaEntregas.Count > 0)
            {
                this.dgvHallazgos.DataSource = ListaEntregas;
                this.dgvHallazgos.Columns["NroActa"].HeaderText = "Nro Entrega";
                this.dgvHallazgos.Columns["Fecha_entrega"].HeaderText = "Fecha Entrega";
                this.dgvHallazgos.Columns["Anio"].HeaderText = "Año";
                this.dgvHallazgos.Columns["Unidad"].Visible = false;
                this.dgvHallazgos.Columns["FechaActa"].Visible = false;
                this.dgvHallazgos.Columns["Id"].Visible = false;
                this.dgvHallazgos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                this.dgvHallazgos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                this.dgvHallazgos.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
                this.dgvHallazgos.Columns["Seleccion"].Visible = true;

                this.dgvHallazgos.ClearSelection();
            }
            else
            {
                this.dgvHallazgos.Columns["Seleccion"].Visible = false;

            }
        }
        void VerificarEntregaSeleccionados()
        {
            SeleccionEntrega = false;

            foreach (DataGridViewRow row in dgvHallazgos.Rows)
            {
                var valorCelda = row.Cells[0].Value;
                var valor = valorCelda as bool? ?? false;

                if (valor)
                {
                    SeleccionEntrega = true;
                    if (BEEntregaSeleccionado?.Id != ((BEEntrega)row.DataBoundItem).Id) // SI YA ESTA SELECCIONADO
                    {
                        BEEntregaSeleccionado = bLLEntrega.ListarObjeto((BEEntrega)row.DataBoundItem);
                    }
                    textBoxNroActa.Text = BEEntregaSeleccionado.NroActa;
                    dateTimePickerFechaEntrega.Value = BEEntregaSeleccionado.Fecha_entrega;

                    if (!string.IsNullOrEmpty(BEEntregaSeleccionado.Observacion))
                    {
                        checkBoxObservacion.Checked = true;
                        textBoxObservacion.Text = BEEntregaSeleccionado.Observacion;
                    }

                    CargarGrillaElementos();
                    CargarGrillaPersonas();
                    Habilitar();
                    break;
                }
            }
            if (!SeleccionEntrega)
            {
                BEEntregaSeleccionado = null;
                CargarGrillaEntregas();
                CargarGrillaElementos();
                CargarGrillaPersonas();
                limpiarCamposEntrega();
                Habilitar();
            }
        }
        bool VerficarCampos()
        {
            if (comboBoxUnidad.Text == ""
                || comboBoxUrsa.Text == ""
                || dateTimePickerFechaEntrega.Text == ""
                || textBoxNroActa.Text == ""
                || (bEUrsa.Unidades != null && !bEUrsa.Unidades.Exists(x => x.Nombre == comboBoxUnidad.Text)))
            {
                MessageBox.Show("Complete todos los campos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validar.VerificarNroActa(textBoxNroActa.Text, bEUnidad.Cod))
            {
                MessageBox.Show("Verifique el numero de Entrega\n\nEj. 0001EZE/2020", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        BEEntrega CrearHallazgo()
        {
            if (!SeleccionEntrega)// agregar
            {
                BEEntregaSeleccionado = new BEEntrega();
            }

            BEEntregaSeleccionado.Fecha_entrega = dateTimePickerFechaEntrega.Value;
            BEEntregaSeleccionado.NroActa = textBoxNroActa.Text;
            BEEntregaSeleccionado.Unidad = bEUnidad;
            BEEntregaSeleccionado.Anio = dateTimePickerFechaEntrega.Value.Year;
            BEEntregaSeleccionado.Observacion = textBoxObservacion.Text;

            return BEEntregaSeleccionado;
        }
        #endregion

        #endregion
        #region "Botones"

        void button_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerficarCampos())
                {
                    if (bLLEntrega.Actualizar(CrearHallazgo()))
                    {
                        bLLBitacora.RegistrarEvento(Usuario, $"Se modifico el nro Acta de Entrega {BEEntregaSeleccionado.NroActa}");
                        Habilitar();
                        CargarGrillaEntregas();
                        SeleccionarHallazgo();
                        MessageBox.Show("La Entrega se modificó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bLLEntrega.Eliminar(BEEntregaSeleccionado))
                {
                    bLLBitacora.RegistrarEvento(Usuario, $"Se elimino el nro Acta de Entrega {BEEntregaSeleccionado.NroActa}");
                    limpiarCamposEntrega();
                    ListaEntregas = bLLEntrega.ListarTodo(bEUnidad, dateTimePickerFechaEntrega.Value);
                    CargarGrillaEntregas();
                    CargarGrillaElementos();
                    CargarGrillaPersonas();
                    Habilitar();
                    MessageBox.Show("El Hallazgo se eliminó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion



        #region "Entrega"

        void comboBoxUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            bEUnidad = (BEUnidad)comboBoxUnidad.SelectedItem;
            BEEntregaSeleccionado = null;
            limpiarCamposEntrega();
            ListaEntregas = bLLEntrega.ListarTodo(bEUnidad, dateTimePickerFechaEntrega.Value);
            CargarGrillaEntregas();
            Habilitar();

        }
        void dateTimePickerFechaHallazgo_ValueChanged(object sender, EventArgs e)
        {

            if (!SeleccionEntrega) // SI NO ESTA EN MODO CREACION 
            {
                CargarGrillaEntregas();
            }


        }

        #endregion


        #region "Datagridview funciones"

        void dgvHallazgos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica si se hizo clic en la columna "Seleccion"
                if (e.ColumnIndex == this.dgvHallazgos.Columns["Seleccion"].Index)
                {
                    // Obtiene el valor actual de la celda "Seleccion"
                    var valorCelda = dgvHallazgos.Rows[e.RowIndex].Cells["Seleccion"].Value;
                    var valor = valorCelda as bool? ?? false; // Asigna false si el valor es null

                    if (!valor) // Si se seleccionó con el tilde
                    {
                        var index = dgvHallazgos.CurrentRow.Index;
                        dgvHallazgos.Rows[index].Cells["Seleccion"].Value = true;
                    }
                    else  // Si se quiere deseleccionar
                    {
                        dgvHallazgos.Rows[e.RowIndex].Cells["Seleccion"].Value = false;
                    }
                    VerificarEntregaSeleccionados();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Texto box funciones"
        void textBoxNroActa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloEnterossSinEspacios(e);
        }
        void textBoxLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NoSaltosDelinea(e);
        }

        #endregion
        void checkBoxObservacion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxObservacion.Checked)
            {
                textBoxObservacion.Visible = true;
            }
            else
            {
                textBoxObservacion.Visible = false;
                textBoxObservacion.Text = "";
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string nro = Interaction.InputBox("Por favor, ingrese el número de Entrega a buscar", "Busqueda por Nro Acta", "");

            if (!string.IsNullOrEmpty(nro))
            {
                ListaEntregas = bLLEntrega.ListarTodo(bEUnidad, dateTimePickerFechaEntrega.Value).FindAll(x => x.NroActa.Contains(nro));
                if (ListaEntregas.Count == 0)
                    MessageBox.Show("No se encontro ese nro de hallagos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    CargarGrillaEntregas();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCamposEntrega();
            ListaEntregas = bLLEntrega.ListarTodo(bEUnidad, dateTimePickerFechaEntrega.Value);
            CargarGrillaEntregas();
            CargarGrillaElementos();
            CargarGrillaPersonas();
            Habilitar();
        }

    }
}