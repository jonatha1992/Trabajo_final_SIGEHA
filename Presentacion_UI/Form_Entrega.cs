﻿using BE;
using Negocio;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_Entrega : Form
    {
        public Form_Entrega()
        {
            InitializeComponent();

            bLLElemento = new BLLElemento();
            bllbitacora = new BLLBitacora();
            bLLEntrega = new BLLEntrega();
            bLLCategorias = new BLLCategoria();
            bLLArticulo = new BLLArticulo();
            Usuario = (BEUsuario)Form_Contenedor.usuario.Clone();

            ListaCategorias = bLLCategorias.ListarTodo();
            ListaArticulos = bLLArticulo.ListarTodo();

        }


        private void Form_Entrega_Load(object sender, EventArgs e)
        {

            CargarCombo();
            CargarGrillaEntregas();
            Habilitar();
            ColocarNumero();
        }

        #region "Campos y Banderas"


        bool SeleccionEntrega = false;

        bool ModoCreacion = false;

        BLLEntrega bLLEntrega;
        BLLElemento bLLElemento;
        BLLCategoria bLLCategorias;
        BLLArticulo bLLArticulo;
        BLLBitacora bllbitacora;

        BEEntrega bEEntregaSeleccionada;


        BEUrsa bEUrsa;
        BEUnidad bEUnidadE;
        BEUsuario Usuario;


        List<BEArticulo> ListaArticulos;
        List<BECategoria> ListaCategorias;
        List<ElementoBusqueda> listaElementosBusqueda;
        List<BEEntrega> listaEntregas;


        List<BEElemento> listaElementosAgregarEntrega;
        List<BEElemento> listaElementoEliminarEntrega;
        #endregion

        #region "Metodos"

        void CargarCombo()
        {
            if (Usuario.Destino is BEUnidad)//destino unidad
            {
                bEUnidadE = Usuario.Destino as BEUnidad;
                bEUrsa = bEUnidadE.Ursa;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUnidadFormEntrega.SelectedItem = bEUnidadE;
                comboBoxUnidadFormEntrega.Text = bEUnidadE.Nombre;
                comboBoxUrsa.Enabled = false;
                comboBoxUnidadFormEntrega.Enabled = false;
            }
            if (Usuario.Destino is BEUrsa) //destino region
            {
                bEUrsa = Usuario.Destino as BEUrsa;
                bEUnidadE = bEUrsa.Unidades.First();
                comboBoxUnidadFormEntrega.DataSource = bEUrsa.Unidades;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUrsa.Enabled = false;
            }


            comboBoxCategoria.DataSource = ListaCategorias;
            comboBoxArticulo.DataSource = ((BECategoria)comboBoxCategoria.SelectedItem).Articulos;
            comboBoxArticulo = Utilidades.SetAutoCompleteCombo(comboBoxArticulo, ListaArticulos, articulo => articulo.Nombre);


        }
        void SeleccionarEntrega()
        {
            foreach (DataGridViewRow item in dataGridViewEntregas.Rows)
            {
                if (item.Cells["NroActa"].Value.ToString() == bEEntregaSeleccionada.NroActa)
                {
                    item.Cells["Seleccion"].Value = true;
                    item.Selected = true;
                }
                else
                {
                    item.Cells["Seleccion"].Value = false;
                }
            }
        }
        void Dgv()
        {
            if (ModoCreacion)
            {
                dataGridViewEntregas.Enabled = false;
            }
            else
            {
                dataGridViewEntregas.Enabled = true;
            }
        }
        void Botones()
        {

            if (SeleccionEntrega)
            {

                if (ModoCreacion)
                {
                    buttonAgregar.Visible = false;
                    buttonModificar.Visible = true;
                    buttonEliminar.Visible = true;
                    buttonFinalizar.Visible = true;
                    buttonEliminarDeEntrega.Visible = true;
                    dataGridViewEntregas.Enabled = false;
                    buttonCargarPersonas.Visible = true;
                    buttonAgregarEntrega.Visible = listaElementosAgregarEntrega?.Count > 0 ? true : false;
                    buttonEliminarDeEntrega.Visible = listaElementoEliminarEntrega?.Count > 0 ? true : false;
                }
                else
                {
                    buttonAgregar.Visible = false;
                    buttonEliminar.Visible = false;
                    buttonFinalizar.Visible = false;
                    buttonModificar.Visible = false;
                    buttonCargarPersonas.Visible = false;
                    buttonAgregarEntrega.Visible = false;
                    buttonEliminarDeEntrega.Visible = false;
                    dataGridViewEntregas.Enabled = true;
                }

                if (VerificarCantidadPersonas())
                {
                    buttonCargarPersonas.BackColor = Color.Green;

                    if (bEEntregaSeleccionada.listaElementos?.Count > 0)
                    {
                        buttonImprimir.Visible = true;

                    }
                }
                else
                {
                    buttonCargarPersonas.BackColor = Color.Red;
                }

            } //SE SELECCIONO ALGO EN DGV ENTREGAS
            else  //MODO INICIAL
            {
                buttonAgregar.Visible = true;
                buttonModificar.Visible = false;
                buttonEliminar.Visible = false;
                buttonAgregarEntrega.Visible = false;
                buttonEliminarDeEntrega.Visible = false;
                buttonCargarPersonas.Visible = false;
                buttonImprimir.Visible = false;
                buttonFinalizar.Visible = false;
            }

        }
        void Combobox()
        {
            if (SeleccionEntrega)
            {
                this.comboBoxUnidadFormEntrega.Text = bEEntregaSeleccionada.Unidad.Nombre;
            }

        }

        void Habilitar()
        {
            Botones();
            Combobox();
            Dgv();
        }
        bool VerificarCantidadPersonas()
        {
            bool cumple = false;

            if (bEEntregaSeleccionada.listaPersonas != null)
            {
                if (bEEntregaSeleccionada.listaPersonas?.Count == 4)
                {
                    cumple = true;
                }
                if (bEEntregaSeleccionada.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Testigo") && bEEntregaSeleccionada.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Propietario") && bEEntregaSeleccionada.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Instructor"))
                {
                    cumple = true;
                }

            }
            return cumple;
        }

        void CargariGriilaElementosBusqueda()
        {
            if (listaElementosBusqueda.Count != 0 || listaElementosBusqueda == null)
            {
                DgvBusqueda.DataSource = null;
                DgvBusqueda.DataSource = listaElementosBusqueda;
                DgvBusqueda.Columns["Select"].Visible = ModoCreacion;
                DgvBusqueda.Columns["Id"].Width = 30;
                DgvBusqueda.Columns["Cantidad"].Width = 30;
                DgvBusqueda.Columns["Cantidad"].HeaderText = "Cant";
                DgvBusqueda.Columns["Fecha_hallazgo"].HeaderText = "Fecha Hallazgo";
                DgvBusqueda.Columns["Fecha_hallazgo"].Width = 58;
                DgvBusqueda.Columns["Lugar"].Width = 60;
                DgvBusqueda.Columns["Select"].Width = 25;
                DgvBusqueda.Columns["Descripcion"].Width = 140;
                DgvBusqueda.Columns["Estado"].Width = 65;
                DgvBusqueda.Columns["Hallazgo"].Width = 80;
                DgvBusqueda.Columns["Entrega"].Width = 83;
                DgvBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgvBusqueda.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                DgvBusqueda.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                DgvBusqueda.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
                DgvBusqueda.ClearSelection();
            }
            else
            {
                //DgvBusqueda.Columns["Select"].Visible = false;
                MessageBox.Show("¡No existen elementos con esa descripción!\n\n\tRealicé una nueva busqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void CargarGrillaElementosEntrega()
        {
            DgvElementosEntrega.DataSource = null;
            DgvElementosEntrega.Columns["Sel"].Visible = ModoCreacion;

            if (SeleccionEntrega)
            {
                if (ModoCreacion)
                {
                    bEEntregaSeleccionada = bLLEntrega.ListarEntregaElementos(bEEntregaSeleccionada);
                    DgvElementosEntrega.DataSource = bEEntregaSeleccionada.listaElementos;
                }
                else
                {
                    DgvElementosEntrega.DataSource = bEEntregaSeleccionada.listaElementos;
                }


                if (bEEntregaSeleccionada != null && bEEntregaSeleccionada.listaElementos?.Count > 0)
                {
                    DgvElementosEntrega.Columns["Sel"].Width = 20;
                    DgvElementosEntrega.Columns["Id"].Width = 30;
                    DgvElementosEntrega.Columns["Cantidad"].Width = 45;
                    DgvElementosEntrega.Columns["Estado"].Width = 60;
                    DgvElementosEntrega.Columns["Articulo"].Width = 80;
                    DgvElementosEntrega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DgvElementosEntrega.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    DgvElementosEntrega.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                    DgvElementosEntrega.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8F, FontStyle.Bold);
                    DgvElementosEntrega.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
                    DgvElementosEntrega.ClearSelection();
                }


                if (DgvElementosEntrega.DataSource == null || DgvElementosEntrega.Rows.Count == 0)
                {
                    DgvElementosEntrega.ColumnHeadersVisible = false;
                }
                else
                {
                    DgvElementosEntrega.ColumnHeadersVisible = true;
                }



            }
        }
        void CargarGrillaEntregas()
        {
            dataGridViewEntregas.DataSource = null;
            listaEntregas = bLLEntrega.ListarTodo(bEUnidadE, dateTimePickerFechaEntrega.Value);

            if (listaEntregas != null && listaEntregas.Count > 0)
            {
                dataGridViewEntregas.DataSource = listaEntregas;
                this.dataGridViewEntregas.Columns["Id"].Visible = false;
                this.dataGridViewEntregas.Columns["NroActa"].HeaderText = "Entrega";
                this.dataGridViewEntregas.Columns["FechaActa"].Visible = false;
                this.dataGridViewEntregas.Columns["Fecha_entrega"].HeaderText = "Fecha Entrega";
                this.dataGridViewEntregas.Columns["Anio"].HeaderText = "Año";
                this.dataGridViewEntregas.Columns["Seleccion"].Visible = true;
                this.dataGridViewEntregas.Columns["Seleccion"].Width = 25;

                this.dataGridViewEntregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridViewEntregas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                this.dataGridViewEntregas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                this.dataGridViewEntregas.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                this.dataGridViewEntregas.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                this.dataGridViewEntregas.ColumnHeadersVisible = true;

            }
            else
            {
                this.dataGridViewEntregas.ColumnHeadersVisible = false;
                //this.dataGridViewEntregas.Columns["Seleccion"].Visible = false;
            }
        }
        void LimpiarbBusqueda()
        {
            DgvBusqueda.DataSource = null;
            DgvBusqueda.Columns["Select"].Visible = false;
        }
        void limpiarCamposBusqueda()
        {
            dateTimePickerDesde.Value = DateTime.Now;
            dateTimePickerHasta.Value = DateTime.Now;
            numericUpDownHallazgo.Text = "0";
            textBoxDescripcion.Text = "";
            textBoxLugar.Text = "";
            checkBoxArticulo.Checked = false;
            checkBoxFecha.Checked = false;
            DgvBusqueda.DataSource = null;
        }
        bool VerficarCamposEntrega()
        {
            if (comboBoxUnidadFormEntrega.Text == ""
                || comboBoxUrsa.Text == ""
                || dateTimePickerDesde.Text == ""
                || numericUpDownNroEntrega.Value == 0)
            {
                MessageBox.Show("Complete todos los campos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validar.VerificarNroActa(labelNroEntrega.Text, bEUnidadE.Cod))
            {
                MessageBox.Show("Verifique el numero de Hallazgo\n\nEj. 1EZE/2020", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        void BuscarElementos()
        {
            DateTime? Desde = null;
            DateTime? Hasta = null;
            BECategoria bEcategoria = null;
            BEArticulo bEArticulo = null;
            string LugarHallazgo = "";
            string PDescripcion = "";
            string NroHallazgo = "";

            if (checkBoxFecha.Checked)
            {
                Desde = dateTimePickerDesde.Value;
                Hasta = dateTimePickerHasta.Value;
            }
            if (checkBoxCategoria.Checked && comboBoxCategoria.Enabled)
            {
                bEcategoria = (BECategoria)comboBoxCategoria.SelectedItem;
            }
            if (checkBoxArticulo.Checked && comboBoxArticulo.Enabled)
            {
                bEArticulo = (BEArticulo)comboBoxArticulo.SelectedItem;
            }
            if (checkBoxDescripcion.Checked && textBoxDescripcion.Enabled)
            {
                PDescripcion = textBoxDescripcion.Text;
            }
            if (checkBoxLugar.Checked && textBoxLugar.Enabled)
            {
                LugarHallazgo = textBoxLugar.Text;
            }

            if (checkBoxNroHallazgo.Checked && numericUpDownHallazgo.Enabled && numericUpDownHallazgo.Value != 0)
            {
                NroHallazgo = numericUpDownHallazgo.Text;

            }
            listaElementosBusqueda = bLLElemento.BusquedaElementos(Desde, Hasta, bEcategoria, bEArticulo, LugarHallazgo, PDescripcion, bEUnidadE, NroHallazgo);
        }
        void LimpiarCamposEntrega()
        {
            SeleccionEntrega = false;
            dateTimePickerFechaEntrega.Value = DateTime.Now;
            bEEntregaSeleccionada = null;
            DgvElementosEntrega.DataSource = null;
            listaElementosAgregarEntrega = null;
            listaElementoEliminarEntrega = null;
            ColocarNumero();
        }
        void ColocarNumero()
        {
            if (!SeleccionEntrega)
            {
                numericUpDownNroEntrega.Value = 0;
                numericUpDownNroEntrega.Value = bLLEntrega.ObtenerNroActa(bEUnidadE, dateTimePickerFechaEntrega.Value.Year);
            }
            //textBoxNroActa.Text = bLLEntrega.ObtenerNroActa(bEUnidad, dateTimePickerFechaEntrega.Value.Year);
        }
        BEEntrega CrearEntrega()
        {
            if (!SeleccionEntrega) // AGREGAR UNO NUEVO
            {
                bEEntregaSeleccionada = new BEEntrega();
            }
            bEEntregaSeleccionada.NroActa = labelNroEntrega.Text;
            bEEntregaSeleccionada.Unidad = bEUnidadE;
            bEEntregaSeleccionada.Fecha_entrega = dateTimePickerFechaEntrega.Value;
            bEEntregaSeleccionada.Anio = dateTimePickerFechaEntrega.Value.Year;
            bEEntregaSeleccionada.Observacion = textBoxObservacion.Text;

            listaElementoEliminarEntrega = new List<BEElemento>();
            listaElementosAgregarEntrega = new List<BEElemento>();
            return bEEntregaSeleccionada;
        }
        void VerificarEntregaSeleccionados()
        {
            SeleccionEntrega = false;

            foreach (DataGridViewRow row in dataGridViewEntregas.Rows)
            {
                var valorCelda = row.Cells[0].Value;
                var valor = valorCelda as bool? ?? false;

                if (valor)
                {
                    SeleccionEntrega = true;

                    if (bEEntregaSeleccionada?.Id != ((BEEntrega)row.DataBoundItem).Id) // SI YA ESTA SELECCIONADO
                    {
                        bEEntregaSeleccionada = bLLEntrega.ListarObjeto((BEEntrega)row.DataBoundItem);
                    }
                    //textBoxNroActa.Text = bEEntregaSeleccionada.NroActa;
                    numericUpDownNroEntrega.Value = bLLEntrega.ExtraerNro(bEEntregaSeleccionada.NroActa, bEEntregaSeleccionada.Unidad);
                    dateTimePickerDesde.Value = bEEntregaSeleccionada.Fecha_entrega;
                    CargarGrillaElementosEntrega();

                    break;
                }
            }
            if (!SeleccionEntrega)
            {
                bEEntregaSeleccionada = null;
                CargarGrillaEntregas();
                CargarGrillaElementosEntrega();
                LimpiarCamposEntrega();
            }
            Habilitar();

        }


        #endregion

        #region "Botones"
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarbBusqueda();
                BuscarElementos();
                CargariGriilaElementosBusqueda();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerficarCamposEntrega())
                {
                    bEEntregaSeleccionada = bLLEntrega.Agregar(CrearEntrega());

                    if (bEEntregaSeleccionada.Id != 0)
                    {
                        bllbitacora.RegistrarEvento(Usuario, $"Se genero el nro Acta de Entrega {bEEntregaSeleccionada.NroActa}");
                        ModoCreacion = true;
                        SeleccionEntrega = true;
                        CargarGrillaEntregas();
                        SeleccionarEntrega();
                        MessageBox.Show($"La Entrega se creó {labelNroEntrega.Text} correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Habilitar();
                    }
                    else
                    {
                        MessageBox.Show($"El Nro.de Entrega {labelNroEntrega.Text} ya se encuentra utilizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ColocarNumero();

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (bLLEntrega.Actualizar(CrearEntrega()))
                {
                    Habilitar();
                    CargarGrillaEntregas();
                    SeleccionarEntrega();
                    MessageBox.Show("La Entrega se modificó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bLLEntrega.Eliminar(bEEntregaSeleccionada))
                {
                    bllbitacora.RegistrarEvento(Usuario, $"Se elimino el nro Acta de Entrega {bEEntregaSeleccionada.NroActa}");
                    MessageBox.Show("La Entrega se eliminó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposEntrega();
                    CargarGrillaEntregas();
                    CargarGrillaElementosEntrega();
                    Habilitar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCargarPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Persona form_Personas = new Form_Persona(bEEntregaSeleccionada);
                form_Personas.ShowDialog();
                bEEntregaSeleccionada = (BEEntrega)form_Personas.BePAdreHallazgo;
                Habilitar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCamposBusqueda();
        }
        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                Form_Impresion form_Impresion = new Form_Impresion(bEEntregaSeleccionada);
                form_Impresion.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bEEntregaSeleccionada.listaElementos == null || bEEntregaSeleccionada.listaElementos.Count == 0)
                {
                    var result = MessageBox.Show("La Entrega no contiene elementos.\n\n¿Desea finalizar la carga?\n\nSi decide finalizar, se borrará la Entrega", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ModoCreacion = false;
                        bLLEntrega.Eliminar(bEEntregaSeleccionada);
                        LimpiarCamposEntrega();
                        Habilitar();
                        CargarGrillaEntregas();
                        //CargarGrillaElementosEntrega();
                        LimpiarbBusqueda();
                    }
                }
                else
                {
                    var result = MessageBox.Show("¿Desea finalizar la Entrega?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ModoCreacion = false;
                        LimpiarCamposEntrega();
                        Habilitar();
                        CargarGrillaEntregas();
                        //CargarGrillaElementosEntrega();
                        LimpiarbBusqueda();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region "Acciones Datagrid y Combobox"


        private void dateTimePickerFechaEntrega_ValueChanged(object sender, EventArgs e)
        {

            if (!ModoCreacion && !SeleccionEntrega) // SI NO ESTA EN MODO CREACION 
            {
                ColocarNumero();
                CargarGrillaEntregas();
            }

        }

        #endregion

        private void comboBoxCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBoxArticulo.DataSource = ((BECategoria)comboBoxCategoria.SelectedItem).Articulos;
        }

        private void DgvBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ModoCreacion)
                {
                    if (e.ColumnIndex == this.DgvBusqueda.Columns["Select"].Index)
                    {
                        var valorCelda = DgvBusqueda.Rows[e.RowIndex].Cells["Select"].Value;
                        var valorEntrega = (string)DgvBusqueda.Rows[e.RowIndex].Cells["Entrega"].Value;
                        var valor = valorCelda as bool? ?? false;
                        if (!valor && valorEntrega == "No entregado") // SI SELECCIONO CON EL TILDE
                        {

                            var index = e.RowIndex;
                            DgvBusqueda.Rows[index].Cells["Select"].Value = true;
                            var elemento = (ElementoBusqueda)DgvBusqueda.Rows[index].DataBoundItem;
                            listaElementosAgregarEntrega.Add(bLLElemento.CovertirElemento(elemento));
                        }
                        else  // SACAR LA SELECCION 
                        {
                            DgvBusqueda.Rows[e.RowIndex].Cells["Select"].Value = false;
                            var elementoBusqueda = (ElementoBusqueda)DgvBusqueda.Rows[e.RowIndex].DataBoundItem;
                            listaElementosAgregarEntrega.RemoveAll(elemento => elemento.Id == elementoBusqueda.Id);

                        }
                        Habilitar();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DgvBusqueda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.DgvBusqueda.Columns["Hallazgo"].Index)
            {
                string Nroacta = DgvBusqueda.Rows[e.RowIndex].Cells["Hallazgo"].Value.ToString();
                listaElementosBusqueda = bLLElemento.BusquedaElementosHallazgo(Nroacta);
                CargariGriilaElementosBusqueda();
                MessageBox.Show($"¡Usted ah ingresado a los elementos del hallazgo\n\t\t{Nroacta} !", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvEntregas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!ModoCreacion)
            {
                if (e.ColumnIndex == this.dataGridViewEntregas.Columns["Seleccion"].Index)
                {
                    // Obtiene el valor actual de la celda "Seleccion"
                    var valorCelda = dataGridViewEntregas.Rows[e.RowIndex].Cells["Seleccion"].Value;
                    var valor = valorCelda as bool? ?? false; // Asigna false si el valor es null

                    if (!valor) // SI SELECCIONO CON EL TILDE
                    {
                        var index = dataGridViewEntregas.CurrentRow.Index;
                        dataGridViewEntregas.Rows[index].Cells["Seleccion"].Value = true;
                    }
                    else  // SACAR LA SELECCION 
                    {
                        SeleccionEntrega = false;
                        dataGridViewEntregas.Rows[e.RowIndex].Cells["Seleccion"].Value = false;
                    }
                    VerificarEntregaSeleccionados();
                }
            }
        }

        private void checkBoxObservacion_CheckedChanged(object sender, EventArgs e)
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
        private void checkBoxNroHallazgo_CheckedChanged(object sender, EventArgs e)
        {

            numericUpDownHallazgo.Enabled = checkBoxNroHallazgo.Checked;
            numericUpDownHallazgo.Value = checkBoxNroHallazgo.Checked ? numericUpDownHallazgo.Value : 0;


        }
        private void comboBoxArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Obtener la sugerencia seleccionada en el ComboBox de artículos
                string sugerenciaSeleccionada = comboBoxArticulo.Text;

                var articulo = ListaArticulos.Find(x => x.Nombre == sugerenciaSeleccionada);
                if (articulo != null)
                {
                    comboBoxCategoria.SelectedItem = articulo.Categoria;
                    comboBoxCategoria.Text = articulo.Categoria.Nombre;
                    comboBoxArticulo.Text = articulo.Nombre;

                }


            }
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDesde.Enabled = checkBoxFecha.Checked;
            dateTimePickerHasta.Enabled = checkBoxFecha.Checked;
        }

        private void checkBoxLugar_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLugar.Enabled = checkBoxLugar.Checked;
            textBoxLugar.Text = checkBoxLugar.Checked ? textBoxLugar.Text : string.Empty;
        }

        private void checkBoxCatetegoria_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCategoria.Enabled = checkBoxCategoria.Checked;
        }

        private void checkBoxArticulo_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxArticulo.Enabled = checkBoxArticulo.Checked;
        }

        private void checkBoxDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDescripcion.Enabled = checkBoxDescripcion.Checked;
            textBoxDescripcion.Text = checkBoxDescripcion.Checked ? textBoxDescripcion.Text : string.Empty;

        }

        private void buttonAgregarAEntrega_Click(object sender, EventArgs e)
        {
            foreach (var elemento in listaElementosAgregarEntrega)
            {
                bLLElemento.AgregarElementoEntrega(bEEntregaSeleccionada, elemento);
            }
            CargarGrillaElementosEntrega();
            CargariGriilaElementosBusqueda();
            listaElementosAgregarEntrega.Clear();
            Habilitar();
        }

        private void buttonEliminarDeEntrega_Click(object sender, EventArgs e)
        {

            foreach (var elemento in listaElementoEliminarEntrega)
            {
                bLLElemento.EliminarElementoEntrega(bEEntregaSeleccionada, elemento);
            }

            CargarGrillaElementosEntrega();
            CargariGriilaElementosBusqueda();
            listaElementoEliminarEntrega.Clear();
            Habilitar();
        }

        private void DgvElementosEntrega_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == this.DgvElementosEntrega.Columns["Sel"].Index)
            {
                // Obtiene el valor actual de la celda "Seleccion"
                var valorCelda = DgvElementosEntrega.Rows[e.RowIndex].Cells["Sel"].Value;
                var valor = valorCelda as bool? ?? false; // Asigna false si el valor es null

                if (!valor) // SI SELECCIONO CON EL TILDE
                {
                    var index = DgvElementosEntrega.CurrentRow.Index;
                    DgvElementosEntrega.Rows[index].Cells["Sel"].Value = true;
                    listaElementoEliminarEntrega.Add((BEElemento)DgvElementosEntrega.Rows[index].DataBoundItem);

                }
                else  // SACAR LA SELECCION 
                {

                    DgvElementosEntrega.Rows[e.RowIndex].Cells["Sel"].Value = false;

                    // Eliminar el elemento de la lista
                    var elemento = (BEElemento)DgvElementosEntrega.Rows[e.RowIndex].DataBoundItem;
                    listaElementoEliminarEntrega.Remove(elemento);
                }
                Habilitar();
            }
        }

        private void numericUpDownNroEntrega_ValueChanged(object sender, EventArgs e)
        {
            labelNroEntrega.Text = numericUpDownNroEntrega.Value + bEUnidadE.Cod + "/" + dateTimePickerFechaEntrega.Value.Year;
        }

        private void numericUpDownNroEntrega_Leave(object sender, EventArgs e)
        {
            // Verificar si el valor está vacío o si es menor al valor mínimo permitido.
            if (string.IsNullOrWhiteSpace(numericUpDownNroEntrega.Text) || numericUpDownNroEntrega.Value < numericUpDownNroEntrega.Minimum)
            {
                numericUpDownNroEntrega.Value = numericUpDownNroEntrega.Minimum;
            }
        }

        private void comboBoxUnidadFormEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            bEUnidadE = (BEUnidad)comboBoxUnidadFormEntrega.SelectedItem;
            LimpiarCamposEntrega();
            CargarGrillaEntregas();
            Habilitar();

        }

        private void Form_Entrega_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModoCreacion)
            {
                if (bEEntregaSeleccionada.listaElementos == null || bEEntregaSeleccionada.listaElementos?.Count == 0)
                {
                    var result = MessageBox.Show("La entrega no contiene elementos \n¿Desea finalizar la carga? \n Si decide salir se borrara la entrega", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ModoCreacion = false;
                        bLLEntrega.Eliminar(bEEntregaSeleccionada);
                        this.Close();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    var result = MessageBox.Show("¿Desea salir de la carga de la entrega?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ModoCreacion = false;
                        this.Close();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }

            }
        }
    }
}
