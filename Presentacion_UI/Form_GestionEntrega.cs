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

            Usuario = (BEUsuario)Form_Contenedor.usuario.Clone();
        }


        void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
                Habilitar();

                ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE, dateTimePickerFechaEntrega.Value);
                listaEntreegaSeleccionado = new List<BEEntrega>();
                CargarGrillaEntregas();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #region "Campos"

        BEUsuario Usuario;
        BEUnidad bEUnidadGE;
        BEUrsa bEUrsa;

        BEEntrega BEEntregaSeleccionado;
        List<BEEntrega> ListaEntregasBase;
        List<BEEntrega> listaEntreegaSeleccionado;


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
                bEUnidadGE = Usuario.Destino as BEUnidad;
                bEUrsa = bEUnidadGE.Ursa;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUnidad.SelectedItem = bEUnidadGE;
                comboBoxUnidad.Text = bEUnidadGE.Nombre;
                comboBoxUrsa.Enabled = false;
                comboBoxUnidad.Enabled = false;
            }
            if (Usuario.Destino is BEUrsa) //destino region
            {
                bEUrsa = Usuario.Destino as BEUrsa;
                bEUnidadGE = bEUrsa.Unidades.First();
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

                if (BEEntregaSeleccionado != null)
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

            if (BEEntregaSeleccionado != null)
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
        void SeleccionarEntrega()  // lo que hace la funcion es recorrer el dgv y seleccioonar el hallazgo
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

        #region "Metodos"
        void limpiarCamposEntrega()
        {
            dateTimePickerFechaEntrega.Value = DateTime.Now;
            numericUpDownNroEntrega.Value = 0;
            textBoxObservacion.Text = "";
            checkBoxObservacion.Checked = false;
            BEEntregaSeleccionado = null;
        }
        void ComboBox()
        {
            if (BEEntregaSeleccionado != null) // si esta en modo creacion
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
            if (BEEntregaSeleccionado != null)
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


            if (ListaEntregasBase != null && ListaEntregasBase.Count > 0)
            {
                this.dgvHallazgos.DataSource = ListaEntregasBase;
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
        
        void HabilitarEntrega()
        {
            if (listaEntreegaSeleccionado?.Count > 0) // modo creacion
            {
                BEEntregaSeleccionado = listaEntreegaSeleccionado.First();

                if (BEEntregaSeleccionado != null) // SI YA ESTA SELECCIONADO
                {
                    numericUpDownNroEntrega.Value = bLLEntrega.ExtraerNro(BEEntregaSeleccionado.NroActa, bEUnidadGE);
                    labelNroEntrega.Text = BEEntregaSeleccionado.NroActa;

                    dateTimePickerFechaEntrega.Value = BEEntregaSeleccionado.Fecha_entrega;
                    if (!string.IsNullOrEmpty(BEEntregaSeleccionado.Observacion))
                    {
                        checkBoxObservacion.Checked = true;
                        textBoxObservacion.Text = BEEntregaSeleccionado.Observacion;
                    }
                }
                CargarGrillaElementos();
                CargarGrillaPersonas();

            }
            else
            {
                limpiarCamposEntrega();
                CargarGrillaEntregas();
                CargarGrillaElementos();
                CargarGrillaPersonas();

            }

            Habilitar();
        }


        bool VerficarCampos()
        {
            if (comboBoxUnidad.Text == ""
                || comboBoxUrsa.Text == ""
                || dateTimePickerFechaEntrega.Text == ""
                || numericUpDownNroEntrega.Value == 0
                || (bEUrsa.Unidades != null && !bEUrsa.Unidades.Exists(x => x.Nombre == comboBoxUnidad.Text)))
            {
                MessageBox.Show("Complete todos los campos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validar.VerificarNroActa(labelNroEntrega.Text, bEUnidadGE.Cod))
            {
                MessageBox.Show("Verifique el numero de Entrega\n\nEj. 1EZE/2020", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        BEEntrega CrearHallazgo()
        {

            BEEntregaSeleccionado.Fecha_entrega = dateTimePickerFechaEntrega.Value;
            BEEntregaSeleccionado.NroActa = labelNroEntrega.Text;
            BEEntregaSeleccionado.Unidad = bEUnidadGE;
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
                var result = MessageBox.Show($"Desea Modificar la Entrega {BEEntregaSeleccionado.NroActa}", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (VerficarCampos())
                    {
                        if (bLLEntrega.Actualizar(CrearHallazgo()))
                        {
                            bLLBitacora.RegistrarEvento(Usuario, $"Se modifico el nro Acta de Entrega {BEEntregaSeleccionado.NroActa}");
                            Habilitar();
                            CargarGrillaEntregas();
                            SeleccionarEntrega();
                            MessageBox.Show("La Entrega se modificó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
                // Construir la lista de elementos para mostrar en el MessageBox
                string elementosAEliminar = string.Join(Environment.NewLine, listaEntreegaSeleccionado.Select(h => h.NroActa));
                var result = MessageBox.Show($"Desea eliminar el/los siguientes Entrega: {Environment.NewLine}{elementosAEliminar}", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {

                    foreach (var item in listaEntreegaSeleccionado)
                    {
                        bLLEntrega.Eliminar(item);

                        bLLBitacora.RegistrarEvento(Usuario, $"eliminó el nro Acta de Entrega {item.NroActa}");
                    }


                    limpiarCamposEntrega();
                    ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE, dateTimePickerFechaEntrega.Value);
                    CargarGrillaEntregas();
                    CargarGrillaElementos();
                    CargarGrillaPersonas();
                    Habilitar();
                    MessageBox.Show("Las entregas se eliminaron correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            bEUnidadGE = (BEUnidad)comboBoxUnidad.SelectedItem;
            BEEntregaSeleccionado = null;
            limpiarCamposEntrega();
            ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE, dateTimePickerFechaEntrega.Value);
            CargarGrillaEntregas();
            Habilitar();

        }
        void dateTimePickerFechaHallazgo_ValueChanged(object sender, EventArgs e)
        {
            if (BEEntregaSeleccionado == null) // SI NO ESTA EN MODO CREACION 
            {
                ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE, dateTimePickerFechaEntrega.Value);
                CargarGrillaEntregas();
            }
            else
            {
                numericUpDownNroEntrega_ValueChanged(null, null);
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
                    var index = dgvHallazgos.CurrentRow.Index;

                    if (!valor) // Si se seleccionó con el tilde
                    {
                        dgvHallazgos.Rows[index].Cells["Seleccion"].Value = true;
                        var EntregaSeleccionada = (BEEntrega)dgvHallazgos.Rows[index].DataBoundItem;
                        listaEntreegaSeleccionado.Add(EntregaSeleccionada);
                    }
                    else  // Si se quiere deseleccionar
                    {
                        dgvHallazgos.Rows[e.RowIndex].Cells["Seleccion"].Value = false;
                        var EntregaSeleccionada = (BEEntrega)dgvHallazgos.Rows[index].DataBoundItem;
                        listaEntreegaSeleccionado.RemoveAll(elemento => elemento.Id == EntregaSeleccionada.Id);

                    }
                    HabilitarEntrega();
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
                ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE, dateTimePickerFechaEntrega.Value).FindAll(x => x.NroActa.Contains(nro));
                if (ListaEntregasBase.Count == 0)
                    MessageBox.Show("No se encontro ese nro de hallagos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    CargarGrillaEntregas();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCamposEntrega();
            ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE, dateTimePickerFechaEntrega.Value);
            CargarGrillaEntregas();
            CargarGrillaElementos();
            CargarGrillaPersonas();
            Habilitar();
        }

        private void numericUpDownNroEntrega_ValueChanged(object sender, EventArgs e)
        {
            if (BEEntregaSeleccionado != null)
            {
                labelNroEntrega.Text = numericUpDownNroEntrega.Value + bEUnidadGE.Cod + "/" + dateTimePickerFechaEntrega.Value.Year;
            }
        }

        private void numericUpDownNroEntrega_Leave(object sender, EventArgs e)
        {
            // Verificar si el valor está vacío o si es menor al valor mínimo permitido.
            if (string.IsNullOrWhiteSpace(numericUpDownNroEntrega.Text) || numericUpDownNroEntrega.Value < numericUpDownNroEntrega.Minimum)
            {
                numericUpDownNroEntrega.Value = numericUpDownNroEntrega.Minimum;
            }
        }

    }
}