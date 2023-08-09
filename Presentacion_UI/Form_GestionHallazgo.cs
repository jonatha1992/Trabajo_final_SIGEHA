using BE;
using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class Form_GestionHallazgo : Form
    {
        public Form_GestionHallazgo()
        {

            InitializeComponent();

            bLLHallazgo = new BLLHallazgo();
            bLLBitacora = new BLLBitacora();

            Usuario = (BEUsuario)Form_Contenedor.usuario.Clone();
        }


        void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
                Habilitar();

                ListaHallazgosBase = bLLHallazgo.ListarTodo(bEUnidadGH, dateTimePickerFechaHallazgo.Value);
                listaHallazgosSeleccionado = new List<BEHallazgo>();

                CargarGrillaHallazgos();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #region "Campos Seleccionados"

        BEUsuario Usuario;
        BEUnidad bEUnidadGH;
        BEUrsa bEUrsa;

        BEHallazgo bEHallazgoSeleccionado;
        List<BEHallazgo> ListaHallazgosBase;
        List<BEHallazgo> listaHallazgosSeleccionado;
        BLLHallazgo bLLHallazgo;
        BLLBitacora bLLBitacora;



        #endregion

        #region "Metodos"

        #region "MetodosElementos"

        void CargarCombo()
        {
            if (Usuario.Destino is BEUnidad)//destino unidad
            {
                bEUnidadGH = Usuario.Destino as BEUnidad;
                bEUrsa = bEUnidadGH.Ursa;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUnidad.SelectedItem = bEUnidadGH;
                comboBoxUnidad.Text = bEUnidadGH.Nombre;
                comboBoxUrsa.Enabled = false;
                comboBoxUnidad.Enabled = false;
            }
            if (Usuario.Destino is BEUrsa) //destino region
            {
                bEUrsa = Usuario.Destino as BEUrsa;
                bEUnidadGH = bEUrsa.Unidades.First();
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


                if (bEHallazgoSeleccionado != null)
                {

                    DgvElementos.DataSource = bLLHallazgo.ListarHallazgoElementos(bEHallazgoSeleccionado).listaElementos;

                    if (DgvElementos.DataSource != null || bEHallazgoSeleccionado.listaElementos.Count > 0)
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

            if (bEHallazgoSeleccionado != null)
            {
                bEHallazgoSeleccionado.listaPersonas = bLLHallazgo.ListarHallazgoPersonas(bEHallazgoSeleccionado).listaPersonas;
                DgvPersonas.DataSource = bEHallazgoSeleccionado.listaPersonas;

                if (bEHallazgoSeleccionado.listaPersonas != null || bEHallazgoSeleccionado.listaPersonas?.Count > 0)
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
                if (item.Cells["NroActa"].Value.ToString() == bEHallazgoSeleccionado.NroActa)
                {
                    item.Cells["Seleccion"].Value = true;
                    item.Selected = true;
                }
            }
        }

        #endregion

        #region "Metodos"
        void limpiarCamposHallazgos()
        {
            dateTimePickerFechaActa.Value = DateTime.Now;
            dateTimePickerFechaHallazgo.Value = DateTime.Now;
            numericUpDownNro.Value = 0;
            textBoxLugar.Text = "";
            textBoxObservacion.Text = "";
            checkBoxObservacion.Checked = false;
            bEHallazgoSeleccionado = null;
        }
        void ComboBox()
        {
            if (bEHallazgoSeleccionado != null) // si esta en modo creacion
            {
                comboBoxUnidad.Text = bEHallazgoSeleccionado.Unidad.Nombre;

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

            if (bEHallazgoSeleccionado != null) // si esta en modo creacion
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
        void CargarGrillaHallazgos()
        {
            this.dgvHallazgos.DataSource = null;


            if (ListaHallazgosBase != null && ListaHallazgosBase.Count > 0)
            {
                this.dgvHallazgos.DataSource = ListaHallazgosBase;
                this.dgvHallazgos.Columns["NroActa"].HeaderText = "Nro Hallazgo";
                this.dgvHallazgos.Columns["FechaHallazgo"].HeaderText = "Fecha Hallazgo";
                this.dgvHallazgos.Columns["LugarHallazgo"].HeaderText = "Lugar";
                this.dgvHallazgos.Columns["Anio"].HeaderText = "Año";
                this.dgvHallazgos.Columns["Unidad"].Visible = false;
                this.dgvHallazgos.Columns["FechaActa"].Visible = false;
                this.dgvHallazgos.Columns["Id"].Visible = false;
                this.dgvHallazgos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                this.dgvHallazgos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                this.dgvHallazgos.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                this.dgvHallazgos.Columns["Seleccion"].Visible = true;


                this.dgvHallazgos.ClearSelection();
            }
            else
            {
                dgvHallazgos.ColumnHeadersVisible = true;

            }
        }

        void HabilitarHallazgo()
        {

            if (listaHallazgosSeleccionado?.Count > 0) // modo creacion
            {
                bEHallazgoSeleccionado = listaHallazgosSeleccionado.First();

                if (bEHallazgoSeleccionado != null) // SI YA ESTA SELECCIONADO
                {
                    textBoxLugar.Text = bEHallazgoSeleccionado.LugarHallazgo;
                    numericUpDownNro.Value = bLLHallazgo.ExtraerNro(bEHallazgoSeleccionado.NroActa,bEUnidadGH);
                    dateTimePickerFechaActa.Value = bEHallazgoSeleccionado.FechaActa ?? bEHallazgoSeleccionado.FechaHallazgo;
                    dateTimePickerFechaHallazgo.Value = bEHallazgoSeleccionado.FechaHallazgo;
                    if (!string.IsNullOrEmpty(bEHallazgoSeleccionado.Observacion))
                    {
                        checkBoxObservacion.Checked = true;
                        textBoxObservacion.Text = bEHallazgoSeleccionado.Observacion;
                    }

                }
                CargarGrillaElementos();
                CargarGrillaPersonas();

            }
            else
            {
                limpiarCamposHallazgos();
                CargarGrillaHallazgos();
                CargarGrillaElementos();
                CargarGrillaPersonas();

            }

            Habilitar();
        }

        bool VerficarCampos()
        {
            if (comboBoxUnidad.Text == ""
                || comboBoxUrsa.Text == ""
                || dateTimePickerFechaHallazgo.Text == ""
                || textBoxLugar.Text == ""
                || numericUpDownNro.Value== 0
                || (bEUrsa.Unidades != null && !bEUrsa.Unidades.Exists(x => x.Nombre == comboBoxUnidad.Text)))
            {
                MessageBox.Show("Complete todos los campos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validar.VerificarNroActa(labelNro.Text, bEUnidadGH.Cod))
            {
                MessageBox.Show("Verifique el numero de Hallazgo\n\nEj. 0001EZE/2020", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        BEHallazgo CrearHallazgo()
        {


            bEHallazgoSeleccionado.FechaHallazgo = dateTimePickerFechaHallazgo.Value;
            bEHallazgoSeleccionado.FechaActa = dateTimePickerFechaActa.Value;
            bEHallazgoSeleccionado.NroActa = labelNro.Text;
            bEHallazgoSeleccionado.Unidad = bEUnidadGH;
            bEHallazgoSeleccionado.Anio = dateTimePickerFechaHallazgo.Value.Year;
            bEHallazgoSeleccionado.LugarHallazgo = textBoxLugar.Text;
            bEHallazgoSeleccionado.Observacion = textBoxObservacion.Text;

            return bEHallazgoSeleccionado;
        }
        #endregion

        #endregion
        #region "Botones"

        void button_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Desea Modificar el Hallazgo {bEHallazgoSeleccionado.NroActa}", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (VerficarCampos())
                    {
                        if (bLLHallazgo.Actualizar(CrearHallazgo()))
                        {
                            bLLBitacora.RegistrarEvento(Usuario, $"Se modifico el nro Acta de Hallazgo {bEHallazgoSeleccionado.NroActa}");
                            Habilitar();
                            CargarGrillaHallazgos();
                            SeleccionarHallazgo();
                            MessageBox.Show("El Hallazgo se modificó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string elementosAEliminar = string.Join(Environment.NewLine, listaHallazgosSeleccionado.Select(h => h.NroActa));

                var result = MessageBox.Show($"Desea eliminar el/los siguientes Hallazgos: {Environment.NewLine}{elementosAEliminar}", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    foreach (var item in listaHallazgosSeleccionado)
                    {
                        bLLHallazgo.Eliminar(item);

                        bLLBitacora.RegistrarEvento(Usuario, $"eliminó el nro Acta de Hallazgo {item.NroActa}");
                    }
                    limpiarCamposHallazgos();
                    ListaHallazgosBase = bLLHallazgo.ListarTodo(bEUnidadGH, dateTimePickerFechaHallazgo.Value);
                    CargarGrillaHallazgos();
                    CargarGrillaElementos();
                    CargarGrillaPersonas();
                    Habilitar();
                    MessageBox.Show("El/los Hallazgos se eliminaron correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region "Hallazgo"
        void comboBoxUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            bEUnidadGH = (BEUnidad)comboBoxUnidad.SelectedItem;
            bEHallazgoSeleccionado = null;
            limpiarCamposHallazgos();
            ListaHallazgosBase = bLLHallazgo.ListarTodo(bEUnidadGH, dateTimePickerFechaHallazgo.Value);
            CargarGrillaHallazgos();
            Habilitar();

        }
        void dateTimePickerFechaHallazgo_ValueChanged(object sender, EventArgs e)
        {


            if (bEHallazgoSeleccionado == null) // SI NO ESTA EN MODO CREACION 
            {
                CargarGrillaHallazgos();
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
                        var bEHallazgoSeleccion = (BEHallazgo)dgvHallazgos.Rows[index].DataBoundItem;
                        listaHallazgosSeleccionado.Add(bEHallazgoSeleccion);

                    }
                    else  // Si se quiere deseleccionar
                    {
                        dgvHallazgos.Rows[e.RowIndex].Cells["Seleccion"].Value = false;

                        // Eliminar el elemento de la lista
                        var bEHallazgoSeleccion = (BEHallazgo)dgvHallazgos.Rows[index].DataBoundItem;
                        listaHallazgosSeleccionado.RemoveAll(elemento => elemento.Id == bEHallazgoSeleccion.Id);
                    }
                    HabilitarHallazgo();
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
            string nro = Interaction.InputBox("Por favor, ingrese el número de hallazgo a buscar", "Nro. de Acta ", "");

            if (!string.IsNullOrEmpty(nro))
            {
                ListaHallazgosBase = bLLHallazgo.ListarTodo(bEUnidadGH, dateTimePickerFechaHallazgo.Value).FindAll(x => x.NroActa.Contains(nro));
                if (ListaHallazgosBase.Count == 0)
                    MessageBox.Show("No se encontro ese nro de hallagos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    CargarGrillaHallazgos();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCamposHallazgos();
            ListaHallazgosBase = bLLHallazgo.ListarTodo(bEUnidadGH, dateTimePickerFechaHallazgo.Value);
            CargarGrillaHallazgos();
            CargarGrillaElementos();
            CargarGrillaPersonas();
            Habilitar();
        }

        private void numericUpDownNro_ValueChanged(object sender, EventArgs e)
        {
            if (bEHallazgoSeleccionado != null)
            {
                labelNro.Text = numericUpDownNro.Value + bEUnidadGH.Cod + "/" + dateTimePickerFechaHallazgo.Value.Year;
            }
        }

        private void numericUpDownNro_Leave(object sender, EventArgs e)
        {
            // Verificar si el valor está vacío o si es menor al valor mínimo permitido.
            if (string.IsNullOrWhiteSpace(numericUpDownNro.Text) || numericUpDownNro.Value < numericUpDownNro.Minimum)
            {
                numericUpDownNro.Value = numericUpDownNro.Minimum;
            }
        }
    }
}