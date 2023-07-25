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
    public partial class Form_GestionHallazgo : Form
    {
        public Form_GestionHallazgo()
        {

            InitializeComponent();

            bLLHallazgo = new BLLHallazgo();
            bLLBitacora = new BLLBitacora();

            Usuario = Form_Contenedor.usuario;
        }


        void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
                Habilitar();

                ListaHallazgos = bLLHallazgo.ListarTodo(bEUnidad, dateTimePickerFechaHallazgo.Value);
                CargarGrillaHallazgos();

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

        BEHallazgo bEHallazgoSeleccionado;
        List<BEHallazgo> ListaHallazgos;
        BLLHallazgo bLLHallazgo;
        BLLBitacora bLLBitacora;



        bool SeleccionHallazgo = false;
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

                if (SeleccionHallazgo)
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

            if (SeleccionHallazgo)
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

        #region "MetodosHallazgo"
        void limpiarCamposHallazgos()
        {
            dateTimePickerFechaActa.Value = DateTime.Now;
            dateTimePickerFechaHallazgo.Value = DateTime.Now;
            textBoxNroActa.Text = "";
            textBoxLugar.Text = "";
            textBoxObservacion.Text = "";
            checkBoxObservacion.Checked = false;
            SeleccionHallazgo = false;
            bEHallazgoSeleccionado = null;
        }
        void ComboBox()
        {
            if (SeleccionHallazgo) // si esta en modo creacion
            {
                comboBoxUnidad.Text = bEHallazgoSeleccionado.Unidad.Nombre;
            }
        }
        void Botones()
        {
            if (SeleccionHallazgo)
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


            if (ListaHallazgos != null && ListaHallazgos.Count > 0)
            {
                this.dgvHallazgos.DataSource = ListaHallazgos;
                this.dgvHallazgos.Columns["NroActa"].HeaderText = "Nro Hallazgo";
                this.dgvHallazgos.Columns["FechaHallazgo"].HeaderText = "Fecha Hallazgo";
                this.dgvHallazgos.Columns["LugarHallazgo"].HeaderText = "Lugar";
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
        void VerificarHallazgosSeleccionados()
        {
            SeleccionHallazgo = false;

            foreach (DataGridViewRow row in dgvHallazgos.Rows)
            {
                var valorCelda = row.Cells[0].Value;
                var valor = valorCelda as bool? ?? false;

                if (valor)
                {
                    SeleccionHallazgo = true;
                    if (bEHallazgoSeleccionado?.Id != ((BEHallazgo)row.DataBoundItem).Id) // SI YA ESTA SELECCIONADO
                    {
                        bEHallazgoSeleccionado = bLLHallazgo.ListarObjeto((BEHallazgo)row.DataBoundItem);
                    }
                    textBoxLugar.Text = bEHallazgoSeleccionado.LugarHallazgo;
                    textBoxNroActa.Text = bEHallazgoSeleccionado.NroActa;
                    dateTimePickerFechaActa.Value = bEHallazgoSeleccionado.FechaActa ?? bEHallazgoSeleccionado.FechaHallazgo;
                    dateTimePickerFechaHallazgo.Value = bEHallazgoSeleccionado.FechaHallazgo;

                    if (!string.IsNullOrEmpty(bEHallazgoSeleccionado.Observacion))
                    {
                        checkBoxObservacion.Checked = true;
                        textBoxObservacion.Text = bEHallazgoSeleccionado.Observacion;
                    }

                    CargarGrillaElementos();
                    CargarGrillaPersonas();
                    Habilitar();
                    break;
                }
            }
            if (!SeleccionHallazgo)
            {
                bEHallazgoSeleccionado = null;
                CargarGrillaHallazgos();
                CargarGrillaElementos();
                CargarGrillaPersonas();
                limpiarCamposHallazgos();
                Habilitar();
            }
        }
        bool VerficarCampos()
        {
            if (comboBoxUnidad.Text == ""
                || comboBoxUrsa.Text == ""
                || dateTimePickerFechaHallazgo.Text == ""
                || textBoxLugar.Text == ""
                || textBoxNroActa.Text == ""
                || (bEUrsa.Unidades != null && !bEUrsa.Unidades.Exists(x => x.Nombre == comboBoxUnidad.Text)))
            {
                MessageBox.Show("Complete todos los campos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validar.VerificarNroHallazgo(textBoxNroActa.Text))
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
            if (!SeleccionHallazgo)// agregar
            {
                bEHallazgoSeleccionado = new BEHallazgo();
            }
            bEHallazgoSeleccionado.FechaHallazgo = dateTimePickerFechaHallazgo.Value;
            bEHallazgoSeleccionado.FechaActa = DateTime.Now;
            bEHallazgoSeleccionado.NroActa = textBoxNroActa.Text;
            bEHallazgoSeleccionado.Unidad = bEUnidad;
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bLLHallazgo.Eliminar(bEHallazgoSeleccionado))
                {
                    bLLBitacora.RegistrarEvento(Usuario, $"Se elimino el nro Acta  de Hallazgo {bEHallazgoSeleccionado.NroActa}");
                    limpiarCamposHallazgos();
                    ListaHallazgos = bLLHallazgo.ListarTodo(bEUnidad, dateTimePickerFechaHallazgo.Value);
                    CargarGrillaHallazgos();
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




        #region "Hallazgo"

        void comboBoxUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            bEUnidad = (BEUnidad)comboBoxUnidad.SelectedItem;
            bEHallazgoSeleccionado = null;
            limpiarCamposHallazgos();
            ListaHallazgos = bLLHallazgo.ListarTodo(bEUnidad, dateTimePickerFechaHallazgo.Value);
            CargarGrillaHallazgos();
            Habilitar();

        }
        void dateTimePickerFechaHallazgo_ValueChanged(object sender, EventArgs e)
        {

            if (!SeleccionHallazgo) // SI NO ESTA EN MODO CREACION 
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

                    if (!valor) // Si se seleccionó con el tilde
                    {
                        var index = dgvHallazgos.CurrentRow.Index;
                        dgvHallazgos.Rows[index].Cells["Seleccion"].Value = true;
                    }
                    else  // Si se quiere deseleccionar
                    {
                        dgvHallazgos.Rows[e.RowIndex].Cells["Seleccion"].Value = false;
                    }
                    VerificarHallazgosSeleccionados();
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
                ListaHallazgos = bLLHallazgo.ListarTodo(bEUnidad, dateTimePickerFechaHallazgo.Value).FindAll(x => x.NroActa.Contains(nro));
                if (ListaHallazgos.Count == 0)
                    MessageBox.Show("No se encontro ese nro de hallagos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    CargarGrillaHallazgos();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCamposHallazgos();
            ListaHallazgos = bLLHallazgo.ListarTodo(bEUnidad, dateTimePickerFechaHallazgo.Value);
            CargarGrillaHallazgos();
            CargarGrillaElementos();
            CargarGrillaPersonas(); 
            Habilitar();
        }

    }
}