using BE;
using Negocio;
//using ClosedXML.Excel;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Font = System.Drawing.Font;

namespace Presentacion_UI
{
    public partial class Form_Hallazgo : Form
    {
        public Form_Hallazgo(BEUsuario bEUsuario)
        {

            InitializeComponent();

            bLLElemento = new BLLElemento();
            bLLHallazgo = new BLLHallazgo();
            Usuario = bEUsuario;
        }


        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                listaCategorias = Form_Contenedor.Categorias;
                ListabEEstadoElementos = Form_Contenedor.EstadosElementos.FindAll(x => x.Nombre != "Entregado");
                comboBoxCategoria.DataSource = Form_Contenedor.Categorias;
                comboBoxEstado.DataSource = ListabEEstadoElementos;
                //dateTimePickerFechaHallazgo.Value = DateTime.Now;
                CargarCombo();
                CargarGrillaHallazgos();
                Habilitar();
                HabilitarElemento();
                ColocarNumero();

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

        BEHallazgo bEHallazgo;
        BEElemento bEElemento;



        BLLHallazgo bLLHallazgo;
        BLLElemento bLLElemento;

        List<BECategoria> listaCategorias;
        List<BEUrsa> ListaUrsas;
        List<BEUnidad> ListaUnidades;
        List<BEEstado_Elemento> ListabEEstadoElementos;



        //BANDERAS
        bool SeleccionHallazgo = false;
        bool SeleccionElemento = false;
        bool ModoCreacion = false;
        #endregion

        #region "Metodos"

        #region "MetodosElementos"

        void CargarCombo()
        {
            if (Usuario.Rol == "REGION")
            {
                bEUrsa = Form_Contenedor.Ursa;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUnidad.DataSource = bEUrsa.Unidades;
            }
            else if (Usuario.Rol == "UNIDAD")
            {
                bEUnidad = Form_Contenedor.Unidad;
                bEUrsa = Form_Contenedor.Ursas.Find(x => x.Id == bEUnidad.Ursa.Id);
                comboBoxUnidad.Text = bEUnidad.Nombre;
                comboBoxUrsa.Text = bEUrsa.Nombre;
            }
            else
            {
                ListaUnidades = Form_Contenedor.Unidades;
                ListaUrsas = Form_Contenedor.Ursas;
                comboBoxUrsa.DataSource = ListaUrsas;
                comboBoxUnidad.DataSource = ListaUnidades;
            }
        }
        bool VerificarCamposElementos()
        {
            if (comboBoxCategoria.Text != "Seleccione")
            {
                if (comboBoxArticulo.Text != "Seleccione")
                {
                    if (textBoxDescripcion.Text != "")
                    {
                       // if (textBoxCantidad.Text != "")
                        if (NUPCantidad.Text != "0")
                        {
                            if (comboBoxEstado.Text != "Seleccione") { return true; }
                            else
                            {
                                MessageBox.Show("Seleccione el estado del elemento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;

                            }
                        }
                        else
                        {
                            MessageBox.Show("Complete la cantidad ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Complete la descripción del elemento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el Articulo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione el Categoria de elemento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        void HabilitarElemento()
        {
            if (SeleccionElemento)
            {
                if (bEElemento != null)
                {
                    comboBoxCategoria.Text = bEElemento.Articulo.Categoria.Nombre;
                    comboBoxArticulo.Text = bEElemento.Articulo.NombreArticulo;
                    comboBoxEstado.Text = bEElemento.Estado.Nombre;
                    //textBoxCantidad.Text = bEElemento.Cantidad.ToString();
                    NUPCantidad.Text = bEElemento.Cantidad.ToString();
                    textBoxDescripcion.Text = bEElemento.Descripcion;
                }

                btnAgregarElemento.Visible = false;
                btnModificarElemento.Visible = true;
                btnEliminarElemento.Visible = true;
            }
            else
            {
                comboBoxCategoria.Text = "Seleccione";
                comboBoxArticulo.Text = "Seleccione";
                comboBoxEstado.Text = "Seleccione";
             //   textBoxCantidad.Text = "";
                textBoxDescripcion.Text = "";
                NUPCantidad.Text = "1";

                btnAgregarElemento.Visible = true;
                btnModificarElemento.Visible = false;
                btnEliminarElemento.Visible = false;
                bEElemento = null;
            }
        }
        void CargarGrillaElementos()
        {
            try
            {
                DgvElementos.DataSource = null;
                this.DgvElementos.Columns["Sel"].Visible = false;

                if (SeleccionHallazgo)
                {
                    if (ModoCreacion)
                    {
                        DgvElementos.DataSource = bLLHallazgo.ListarObjetoElementos(bEHallazgo).listaElementos;
                        this.DgvElementos.Columns["Sel"].Visible = true;
                        this.DgvElementos.Columns["Sel"].Width = 30;
                    }
                    else
                    {
                        DgvElementos.DataSource = bEHallazgo.listaElementos;
                        this.DgvElementos.Columns["Sel"].Visible = false;
                    }


                    if (DgvElementos.DataSource != null)
                    {

                        this.DgvElementos.Columns["Id"].Width = 35;
                        this.DgvElementos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        this.DgvElementos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                        this.DgvElementos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                        this.DgvElementos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);

                        foreach (DataGridViewRow row in DgvElementos.Rows)
                        {
                            if (row.Cells[0].Value == null)
                            {
                                row.Cells["Sel"].Value = false;
                            }
                        }
                    }
                    else
                    {
                        this.DgvElementos.Columns["Sel"].Visible = false;
                        if (!ModoCreacion)
                        {
                            var result = MessageBox.Show("El Hallazgo no contiene elementos\n\n¿Desea eliminar el Hallazgo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (result == DialogResult.Yes)
                            {
                                if (bLLHallazgo.Eliminar(bEHallazgo))
                                {
                                    MessageBox.Show("El Hallazgo se elimino correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarGrillaHallazgos();
                                    limpiarCamposHallazgos();
                                    Habilitar();
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}"); ;
            }
        }

        void BuscarHallazgo()
        {
            foreach (DataGridViewRow item in dgvHallazgos.Rows)
            {
                if (item.Cells["NroActa"].Value.ToString() == bEHallazgo.NroActa)
                {
                    item.Cells["Seleccion"].Value = true;
                    item.Selected = true;
                }
            }
        }
        private BEElemento CrearElemento()
        {
            if (!SeleccionElemento)
            {
                bEElemento = new BEElemento();
                bEElemento.Articulo = comboBoxArticulo.SelectedItem as BEArticulo;
                bEElemento.Estado = comboBoxEstado.SelectedItem as BEEstado_Elemento;
                //bEElemento.Cantidad = double.Parse(textBoxCantidad.Text);
                bEElemento.Cantidad = double.Parse(NUPCantidad.Text);
                bEElemento.Descripcion = textBoxDescripcion.Text;
            }
            else
            {
                bEElemento.Articulo = comboBoxArticulo.SelectedItem as BEArticulo;
                bEElemento.Estado = comboBoxEstado.SelectedItem as BEEstado_Elemento;
                // bEElemento.Cantidad = double.Parse(textBoxCantidad.Text);
                bEElemento.Cantidad = double.Parse(NUPCantidad.Text);
                bEElemento.Descripcion = textBoxDescripcion.Text;
            }

            return bEElemento;
        }
        #endregion

        #region "MetodosHallazgo"
        void limpiarCamposHallazgos()
        {
            textBoxLugar.Text = "";
            textBoxNroActa.Text = "";
            dateTimePickerFechaHallazgo.Value = DateTime.Now;
            SeleccionHallazgo = false;
            ColocarNumero();
        }
        void ColocarNumero()
        {
            if (!SeleccionHallazgo)
            {
                textBoxNroActa.Text = bLLHallazgo.ObtenerNroActa(bEUnidad, dateTimePickerFechaHallazgo.Value.Year);
            }
        }
        void ComboBox()
        {
            if (SeleccionHallazgo)
            {
                comboBoxUnidad.Text = bEHallazgo.Unidad.Nombre;
                comboBoxUnidad.Enabled = false;
                comboBoxUrsa.Enabled = false;
            }
            else
            {
                comboBoxUrsa.Enabled = true;
                comboBoxUnidad.Enabled = true;
            }


            comboBoxUrsa.Enabled = Usuario.Rol == "REGION" || Usuario.Rol == "UNIDAD" ? false : true;
            comboBoxUnidad.Enabled = Usuario.Rol == "UNIDAD" ? false : true;
        }
        bool VerificarCantidadPersonas()
        {
            bool cumple = false;

            if (bEHallazgo.listaPersonas != null)
            {
                if (bEHallazgo.listaPersonas?.Count == 4)
                {
                    cumple = true;
                }
                if (bEHallazgo.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Testigo") && bEHallazgo.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Descubridor") && bEHallazgo.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Instructor"))
                {
                    cumple = true;
                }

            }
            return cumple;
        }
        void Botones()
        {
            if (SeleccionHallazgo)
            {
                if (Usuario.Rol == "UNIDAD") //UNIDAD
                {
                    buttonEliminar.Visible = false;

                    if (ModoCreacion)// SI ESTA EN MODO CREACION
                    {
                        button_Agregar.Visible = false;
                        button_Modificar.Visible = true;
                        buttonFinalizarHallazgo.Visible = true;
                        groupBoxDatosElementos.Enabled = true;
                        buttonCargarPersonas.Visible = true;

                    }
                    else //SI NO ESTA EN MODO CREACION
                    {
                        groupBoxDatosElementos.Enabled = false;
                        groupBoxDatosHallazgo.Enabled = false;
                        buttonImprimir.Visible = false;

                    }
                }
                else //REGION O ADMIN
                {
                    button_Modificar.Visible = true;
                    buttonEliminar.Visible = true;
                    button_Agregar.Visible = false;
                    buttonFinalizarHallazgo.Visible = false;
                }


                if (VerificarCantidadPersonas())
                {
                    buttonCargarPersonas.BackColor = Color.Green;

                    if (bEHallazgo.listaElementos?.Count > 0)
                    {
                        buttonImprimir.Visible = true;

                    }
                }
                else
                {
                    buttonCargarPersonas.BackColor = Color.Red;
                }

                if (bEHallazgo?.listaElementos?.Count > 0)
                {
                    buttonImprimir.Visible = true;
                }
                else
                {
                    buttonImprimir.Visible = false;
                }


            }
            else // si no se selecciono ningun hallazgo
            {
                if (Usuario.Rol == "UNIDAD")
                {
                    button_Agregar.Visible = true;
                }
                else // ADMIN O REGION
                {
                    button_Agregar.Visible = false;
                }

                groupBoxDatosHallazgo.Enabled = true;
                groupBoxDatosElementos.Enabled = false;
                button_Modificar.Visible = false;
                buttonEliminar.Visible = false;
                buttonCargarPersonas.Visible = false;
                buttonImprimir.Visible = false;
                buttonFinalizarHallazgo.Visible = false;
            }
        }

        void Dgv()
        {
            if (ModoCreacion)
            {
                DgvElementos.Enabled = true;
            }
            else
            {
                dgvHallazgos.Enabled = true;
            }
        }
        void Label()
        {
            if (SeleccionHallazgo)
                labelHallazgo.Text = $"N° Hallazgo: {bEHallazgo.NroActa}";
            else
                labelHallazgo.Text = "";
        }
        void Habilitar()
        {
            Botones();
            ComboBox();
            Label();
            Dgv();
        }
        void CargarGrillaHallazgos()
        {
            this.dgvHallazgos.DataSource = null;

           // List<BEHallazgo> Lista = bLLHallazgo.ListarTodo(bEUnidad, dateTimePickerFechaHallazgo.Value.Year);
            List<BEHallazgo> Lista = bLLHallazgo.ListarTodo(bEUnidad, dateTimePickerFechaHallazgo.Value);

            if (Lista != null && Lista.Count > 0)
            {
                this.dgvHallazgos.DataSource = Lista;
                this.dgvHallazgos.Columns["NroActa"].HeaderText = "Nro Hallazgo";
                this.dgvHallazgos.Columns["FechaHallazgo"].HeaderText = "Fecha Hallazgo";
                this.dgvHallazgos.Columns["LugarHallazgo"].HeaderText = "Lugar";
                this.dgvHallazgos.Columns["Anio"].HeaderText = "Año";
                this.dgvHallazgos.Columns["Unidad"].Visible = false;
                this.dgvHallazgos.Columns["FechaActa"].Visible = false;
                this.dgvHallazgos.Columns["Id"].Visible = false;
                this.dgvHallazgos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dgvHallazgos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                this.dgvHallazgos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                this.dgvHallazgos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
                this.dgvHallazgos.Columns["Seleccion"].Visible = true;

                foreach (DataGridViewRow row in dgvHallazgos.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        row.Cells["Seleccion"].Value = false;
                    }
                }
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
                if ((bool)row.Cells[0].Value != false)
                {
                    SeleccionHallazgo = true;
                    if (bEHallazgo?.Id != ((BEHallazgo)row.DataBoundItem).Id) // SI YA ESTA SELECCIONADO
                    {

                        bEHallazgo = bLLHallazgo.ListarObjeto((BEHallazgo)row.DataBoundItem);
                    }
                    textBoxLugar.Text = bEHallazgo.LugarHallazgo;
                    textBoxNroActa.Text = bEHallazgo.NroActa;
                    dateTimePickerFechaHallazgo.Value = bEHallazgo.FechaHallazgo;
                    CargarGrillaElementos();

                    break;
                }
            }
            if (!SeleccionHallazgo)
            {
                bEHallazgo = null;
                CargarGrillaHallazgos();
                CargarGrillaElementos();
                limpiarCamposHallazgos();
            }
            Habilitar();

        }

        bool VerficarCampos()
        {
            if (comboBoxUnidad.Text == "" || comboBoxUrsa.Text == "" || dateTimePickerFechaHallazgo.Text == "" || textBoxLugar.Text == "" || textBoxNroActa.Text == "")
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
                bEHallazgo = new BEHallazgo();
                bEHallazgo.FechaHallazgo = dateTimePickerFechaHallazgo.Value;
                bEHallazgo.NroActa = textBoxNroActa.Text;
                bEHallazgo.Unidad = bEUnidad;
                bEHallazgo.Anio = dateTimePickerFechaHallazgo.Value.Year;
                bEHallazgo.LugarHallazgo = textBoxLugar.Text;

            }
            else //MODificar o eliminar
            {
                bEHallazgo.FechaHallazgo = dateTimePickerFechaHallazgo.Value;
                bEHallazgo.NroActa = textBoxNroActa.Text;
                bEHallazgo.Unidad = bEUnidad;
                bEHallazgo.Anio = dateTimePickerFechaHallazgo.Value.Year;
                bEHallazgo.LugarHallazgo = textBoxLugar.Text;
            }
            return bEHallazgo;
        }
        #endregion

        #endregion
        #region "Botones"

        #region "Hallazgo"
        private void button_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerficarCampos())
                {
                    bEHallazgo = bLLHallazgo.Agregar(CrearHallazgo());

                    if (bEHallazgo.Id != 0)
                    {
                        ModoCreacion = true;
                        SeleccionHallazgo = true;
                        bEHallazgo = bLLHallazgo.ListarObjeto(bEHallazgo);
                        Habilitar();
                        CargarGrillaHallazgos();
                        BuscarHallazgo();
                        MessageBox.Show($"El Hallazgo se creo {textBoxNroActa.Text} correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"El Nro. de Hallazgo {textBoxNroActa.Text} ya se encuentra utilizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ColocarNumero();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }
        }
        private void button_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerficarCampos())
                {
                    if (bLLHallazgo.Actualizar(CrearHallazgo()))
                    {
                        Habilitar();
                        CargarGrillaHallazgos();
                        BuscarHallazgo();

                        MessageBox.Show("El Hallazgo se modifico correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                foreach (DataGridViewRow fila in dgvHallazgos.Rows)
                {
                    if ((bool)fila.Cells[0].Value == true)
                    {
                        bLLHallazgo.Eliminar((BEHallazgo)fila.DataBoundItem);
                    }
                }

                limpiarCamposHallazgos();
                CargarGrillaHallazgos();
                CargarGrillaElementos();
                Habilitar();
                MessageBox.Show("El Hallazgo se elimino correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region "Elemento"
        private void btnAgregarElemento_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarCamposElementos())
                {
                    CrearElemento();
                    if (bLLElemento.AgregarElementoHallazgo(bEHallazgo, bEElemento))
                    {
                        CargarGrillaElementos();
                        HabilitarElemento();
                        Habilitar();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarElemento_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeleccionElemento)
                {
                    if (VerificarCamposElementos())
                    {
                        CrearElemento();
                        if (bLLElemento.Actualizar(bEElemento))
                        {
                            SeleccionElemento = false;
                            CargarGrillaElementos();
                            HabilitarElemento();
                            Habilitar();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEliminarElemento_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeleccionElemento)
                {

                    foreach (DataGridViewRow fila in DgvElementos.Rows)
                    {
                        if ((bool)fila.Cells[0].Value == true)
                        {
                            bLLElemento.Eliminar((BEElemento)fila.DataBoundItem);
                        }
                    }

                    SeleccionElemento = false;
                    CargarGrillaElementos();
                    HabilitarElemento();
                    Habilitar();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (bEHallazgo.listaPersonas?.Count >= 3 && bEHallazgo.listaElementos?.Count > 0)
                {
                    Form_Impresion form_Impresion = new Form_Impresion(bEHallazgo);
                    form_Impresion.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"No posee la cantidad de intervinientes para imprimir el acta", "Requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                Form_Persona formPersonas;
                formPersonas = new Form_Persona(bEHallazgo);

                formPersonas.ShowDialog();

                bEHallazgo = (BEHallazgo)formPersonas.BePAdreHallazgo;

                //if (bEHallazgo.listaPersonas?.Count > 2)
                //{
                //    buttonCargarPersonas.BackColor = Color.Green;
                //}
                //else
                //{
                //    buttonCargarPersonas.BackColor = Color.Red;
                //}
                Habilitar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        #endregion
        #region "Combobox Funciones"
        #region "Elemento"

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxArticulo.DataSource = ((BECategoria)comboBoxCategoria.SelectedItem).Articulos;

        }
        private void dataGridViewElementos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ModoCreacion)
            {
                if (e.ColumnIndex == this.DgvElementos.Columns["Sel"].Index)
                {
                    var Valor = (bool)DgvElementos.Rows[e.RowIndex].Cells["Sel"].Value;
                    var Index = DgvElementos.CurrentRow.Index;
                    if (Valor == false)
                    {
                        DgvElementos.Rows[Index].Cells["Sel"].Value = true;
                    }
                    else
                    {
                        DgvElementos.Rows[Index].Cells["Sel"].Value = false;
                    }
                    VerificarElementosSeleccionados();
                }
            }
        }
        void VerificarElementosSeleccionados()
        {
            SeleccionElemento = false;

            foreach (DataGridViewRow row in DgvElementos.Rows)
            {
                if ((bool)row.Cells[0].Value != false)
                {
                    SeleccionElemento = true;
                    bEElemento = (BEElemento)row.DataBoundItem;
                    break;
                }
            }
            if (!SeleccionElemento)
            {
                bEElemento = null;

            }
            HabilitarElemento();
        }

        #endregion

        #region "Hallazgo"
        private void comboBoxUrsa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Usuario.Rol == "ADMIN")
            {

                bEUrsa = (BEUrsa)comboBoxUrsa.SelectedItem;
                comboBoxUnidad.DataSource = bEUrsa.Unidades;
            }
            else if (Usuario.Rol == "REGION")
            {
                comboBoxUnidad.DataSource = bEUrsa.Unidades;
            }



        }
        private void comboBoxUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Usuario.Rol == "ADMIN")
            {
                bEUnidad = (BEUnidad)comboBoxUnidad.SelectedItem;
                bEHallazgo = null;
                limpiarCamposHallazgos();
                CargarGrillaHallazgos();
                CargarGrillaElementos();
                Habilitar();
            }
            else if (Usuario.Rol == "REGION")
            {
                bEUnidad = (BEUnidad)comboBoxUnidad.SelectedItem;
                bEHallazgo = null;
                limpiarCamposHallazgos();
                CargarGrillaHallazgos();
                CargarGrillaElementos();
                Habilitar();
            }

        }
        private void dateTimePickerFechaHallazgo_ValueChanged(object sender, EventArgs e)
        {


            if (!ModoCreacion && !SeleccionHallazgo) // SI NO ESTA EN MODO CREACION 
            {
                CargarGrillaHallazgos();
            }
            if (!SeleccionHallazgo && Usuario.Rol == "UNIDAD")
            {
                ColocarNumero();
            }

        }

        #endregion

        #endregion

        #region "Datagridview funciones"

        private void dgvHallazgos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!ModoCreacion)
                {
                    if (e.ColumnIndex == this.dgvHallazgos.Columns["Seleccion"].Index)
                    {
                        var Valor = (bool)dgvHallazgos.Rows[e.RowIndex].Cells["Seleccion"].Value;
                        if (!Valor) // SI SELECCIONO CON EL TILDE
                        {
                            //if (!ModoCreacion) // SI NO ESTA EN MODO CREACION
                            //{
                            var index = dgvHallazgos.CurrentRow.Index;
                            dgvHallazgos.Rows[index].Cells["Seleccion"].Value = true;
                            VerificarHallazgosSeleccionados();
                            //}

                        }
                        else  // SACAR LA SELECCION 
                        {
                            //if (!ModoCreacion)
                            //{
                            dgvHallazgos.Rows[e.RowIndex].Cells["Seleccion"].Value = false;
                            VerificarHallazgosSeleccionados();

                            //}
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Texto box funciones"
        private void textBoxNroActa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloEnterossSinEspacios(e);
        }
        private void textBoxLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NoSaltosDelinea(e);
        }

        #endregion

        private void buttonFinalizarHallazgo_Click(object sender, EventArgs e)
        {

            try
            {
                if (bEHallazgo.listaElementos == null || bEHallazgo.listaElementos?.Count == 0)
                {
                    var result = MessageBox.Show("El Hallazgo no contiene elementos \n\n¿Desea finalizar la carga?\n\n Si decide finalizar, ¡se borrara el Hallazgo creado!", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bLLHallazgo.Eliminar(bEHallazgo);
                        ModoCreacion = false;
                        bEHallazgo = null;
                        SeleccionHallazgo = false;
                        SeleccionElemento = false;
                        Habilitar();
                        CargarGrillaHallazgos();
                        CargarGrillaElementos();
                        limpiarCamposHallazgos();
                    }
                }
                else if (bEHallazgo.listaPersonas == null || bEHallazgo.listaPersonas?.Count == 0)
                {
                    var result = MessageBox.Show("El Hallazgo no contiene el minimo de intervinientes para imprimir el Acta\n\n¿Desea finalizar la carga?\n\n Si decide finalizar, ¡No podra imprimir el Hallazgo!", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ModoCreacion = false;
                        bEHallazgo = null;
                        SeleccionHallazgo = false;
                        SeleccionElemento = false;
                        Habilitar();
                        CargarGrillaHallazgos();
                        CargarGrillaElementos();
                        limpiarCamposHallazgos();
                    }
                }

                else
                {
                    var result = MessageBox.Show("¿Desea finalizar el Hallazgo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ModoCreacion = false;
                        bEHallazgo = null;
                        SeleccionHallazgo = false;
                        SeleccionElemento = false;
                        Habilitar();
                        CargarGrillaHallazgos();
                        CargarGrillaElementos();
                        limpiarCamposHallazgos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form_Hallazgo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (ModoCreacion)
                {
                    if (bEHallazgo.listaElementos == null || bEHallazgo.listaElementos?.Count == 0)
                    {
                        var result = MessageBox.Show("El Hallazgo no contiene elementos \n¿Desea finalizar la carga? \n Si decide salir se borrara el Hallazgo", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ModoCreacion = false;
                            bLLHallazgo.Eliminar(bEHallazgo);
                            this.Close();
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        var result = MessageBox.Show("¿Desea salir de la carga de Hallazgo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}