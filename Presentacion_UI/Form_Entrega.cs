using BE;
using Negocio;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_Entrega : Form
    {
        public Form_Entrega(BEUsuario User)
        {
            InitializeComponent();

            bLLElemento = new BLLElemento();
            bLLEntrega = new BLLEntrega();

            Usuario = User;

        }


        private void Form_Entrega_Load(object sender, EventArgs e)
        {

            CargarCombo();
            ListaArticulos = Form_Contenedor.Articulos;
            comboBoxEstado.DataSource = Form_Contenedor.EstadosElementos;
            MostrarEntregas();
            Habilitar();
            ColocarNumero();
        }

        #region "Campos y Banderas"


        bool SeleccionEntrega = false;
        bool SeleccionElementoBusqueda = false;
        bool ModoCreacion = false;

        BLLEntrega bLLEntrega;
        BLLElemento bLLElemento;


        BEEntrega bEEntrega;

        List<BEUrsa> ListaUrsas;
        List<BEUnidad> ListaUnidades;
        BEUrsa bEUrsa;
        BEUnidad bEUnidad;
        BEUsuario Usuario;


        List<BEArticulo> ListaArticulos;
        List<ElementoBusqueda> listaElementosBusqueda;
        List<BEEntrega> listaEntregas;
        #endregion

        #region "Metodos"

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

            comboBoxCategoria.DataSource = Form_Contenedor.Categorias;
            comboBoxArticulo.DataSource = ((BECategoria)comboBoxCategoria.SelectedItem).Articulos;
        }
        void BuscarEntrega()
        {
            foreach (DataGridViewRow item in dgvEntregas.Rows)
            {
                if (item.Cells["NroActa"].Value.ToString() == bEEntrega.NroActa)
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
                dgvEntregas.Enabled = false;
            }
            else
            {
                dgvEntregas.Enabled = true;
            }
        }
        void Botones()
        {

            if (SeleccionEntrega)
            {
                if (Usuario.Rol == "UNIDAD")
                {
                    buttonEliminar.Visible = false;

                    if (ModoCreacion)
                    {
                        buttonAgregar.Visible = false;
                        buttonModificar.Visible = true;
                        buttonFinalizar.Visible = true;
                        buttonCargarPersonas.Visible = true;

                    }
                    else
                    {
                        buttonAgregar.Visible = true;
                        buttonEliminar.Visible = false;
                        buttonFinalizar.Visible = false;
                        buttonModificar.Visible = false;
                        groupBoxEntrega.Enabled = false;
                    }
                }
                else //REGION O ADMIN
                {
                    buttonModificar.Visible = true;
                    buttonEliminar.Visible = true;
                    buttonAgregar.Visible = false;
                    buttonFinalizar.Visible = false;
                }

                if (VerificarCantidadPersonas())
                {
                    buttonCargarPersonas.BackColor = Color.Green;

                    //if (bEEntrega.listaElementos?.Count > 0)
                    //{
                    //    buttonImprimir.Visible = true;

                    //}
                }
                else
                {
                    buttonCargarPersonas.BackColor = Color.Red;
                }



            }
            else
            {


                if (Usuario.Rol == "UNIDAD")
                {
                    buttonAgregar.Visible = true;
                }
                else // ADMIN O REGION
                {
                    buttonAgregar.Visible = false;
                }

                buttonModificar.Visible = false;
                buttonEliminar.Visible = false;
                buttonCargarPersonas.Visible = false;
                buttonImprimir.Visible = false;
                buttonFinalizar.Visible = false;
                groupBoxEntrega.Enabled = true;

            }

            if (bEEntrega?.listaElementos?.Count > 0)
            {
                buttonImprimir.Visible = true;
            }
            else buttonImprimir.Visible = false;


            if (SeleccionElementoBusqueda) buttonCambiarEstado.Enabled = true;

            else buttonCambiarEstado.Enabled = false;


        }
        void Combobox()
        {
            if (SeleccionEntrega)
            {
                comboBoxUnidad.Text = bEEntrega.Unidad.Nombre;
                comboBoxUnidad.Enabled = false;
                comboBoxUrsa.Enabled = false;

                if (ModoCreacion)
                {
                    comboBoxEstado.DataSource = Form_Contenedor.EstadosElementos.FindAll(x => x.Nombre == "Entregado" || x.Nombre == "Resguardo");
                    comboBoxEstado.Text = "Entregado";
                }

            }
            else
            {
                comboBoxEstado.DataSource = Form_Contenedor.EstadosElementos;
                comboBoxUrsa.Enabled = true;
                comboBoxUnidad.Enabled = true;
            }
            comboBoxUrsa.Enabled = Usuario.Rol == "REGION" || Usuario.Rol == "UNIDAD" ? false : true;
            comboBoxUnidad.Enabled = Usuario.Rol == "UNIDAD" ? false : true;
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

            if (bEEntrega.listaPersonas != null)
            {
                if (bEEntrega.listaPersonas?.Count == 4)
                {
                    cumple = true;
                }
                if (bEEntrega.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Testigo") && bEEntrega.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Descubridor") && bEEntrega.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Instructor"))
                {
                    cumple = true;
                }

            }
            return cumple;
        }

        void MostrarElementosBusqueda()
        {
            if (listaElementosBusqueda.Count != 0 || listaElementosBusqueda == null)
            {
                DgvBusqueda.DataSource = null;
                DgvBusqueda.DataSource = listaElementosBusqueda;
                DgvBusqueda.Columns["Select"].Visible = true;
                DgvBusqueda.Columns["Id"].Width = 30;
                DgvBusqueda.Columns["Cantidad"].Width = 30;
                DgvBusqueda.Columns["Cantidad"].HeaderText = "Cant";
                DgvBusqueda.Columns["Fecha_hallazgo"].HeaderText = "Fecha Hallazgo";
                DgvBusqueda.Columns["Fecha_hallazgo"].Width= 58;
                DgvBusqueda.Columns["Lugar"].Width = 60;
                DgvBusqueda.Columns["Select"].Width = 25;
                DgvBusqueda.Columns["Descripcion"].Width = 140;
                DgvBusqueda.Columns["Estado"].Width = 65;
                DgvBusqueda.Columns["Hallazgo"].Width = 80;
                DgvBusqueda.Columns["Entrega"].Width = 83;
                this.DgvBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.DgvBusqueda.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                this.DgvBusqueda.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                this.DgvBusqueda.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
                this.DgvBusqueda.ClearSelection();

                foreach (DataGridViewRow row in DgvBusqueda.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        row.Cells["Select"].Value = false;
                    }
                }
            }
            else
            {
                DgvBusqueda.Columns["Select"].Visible = false;
                MessageBox.Show("¡No existen elementos con esa descripción!\n\n\tRealicé una nueva busqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void MostrarElementosEntrega()
        {
            DgvElementosEntrega.DataSource = null;

            if (SeleccionEntrega)
            {
                if (ModoCreacion)
                {
                    bEEntrega = bLLEntrega.ListarObjetoElementos(bEEntrega);
                    DgvElementosEntrega.DataSource = bEEntrega.listaElementos;
                }
                else
                {
                    DgvElementosEntrega.DataSource = bEEntrega.listaElementos;
                }


                if (bEEntrega != null && bEEntrega.listaElementos?.Count > 0)
                {
                    DgvElementosEntrega.Columns["Id"].Width = 30;
                    DgvElementosEntrega.Columns["Cantidad"].Width = 45;
                    DgvElementosEntrega.Columns["Estado"].Width = 60;
                    DgvElementosEntrega.Columns["Articulo"].Width = 80;
                    this.DgvElementosEntrega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    this.DgvElementosEntrega.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    this.DgvElementosEntrega.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                    this.DgvElementosEntrega.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
                    this.DgvElementosEntrega.ClearSelection();
                }
                else
                {
                    if (!ModoCreacion)
                    {
                        var result = MessageBox.Show("La Entrega no contiene elementos\n\n¿Desea eliminar la entrega?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            if (bLLEntrega.Eliminar(bEEntrega))
                            {
                                MessageBox.Show("La Entrega se elimino correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCamposEntrega();
                                MostrarEntregas();
                                Habilitar();
                            }
                        }
                    }

                }
            }
        }
        void MostrarEntregas()
        {
            dgvEntregas.DataSource = null;
            //listaEntregas = bLLEntrega.ListarTodo(bEUnidad, dateTimePickerFechaEntrega.Value.Year);
            listaEntregas = bLLEntrega.ListarTodo(bEUnidad, dateTimePickerFechaEntrega.Value);

            if (listaEntregas != null && listaEntregas.Count > 0)
            {
                dgvEntregas.DataSource = listaEntregas;
                this.dgvEntregas.Columns["Id"].Visible = false;
                this.dgvEntregas.Columns["NroActa"].HeaderText = "Entrega";
                this.dgvEntregas.Columns["FechaActa"].Visible = false;
                this.dgvEntregas.Columns["Fecha_entrega"].HeaderText = "Fecha Entrega";
                this.dgvEntregas.Columns["Anio"].HeaderText = "Año";
                this.dgvEntregas.Columns["Seleccion"].Visible = true;
                this.dgvEntregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dgvEntregas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                this.dgvEntregas.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                this.dgvEntregas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);

                foreach (DataGridViewRow row in dgvEntregas.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        row.Cells["Seleccion"].Value = false;
                    }
                }
                //this.dgvEntregas.ClearSelection();

            }
            else
            {
                this.dgvEntregas.Columns["Seleccion"].Visible = false;
            }
        }
        void LimpiarbBusqueda()
        {
            DgvBusqueda.DataSource = null;
            DgvBusqueda.Columns["Select"].Visible = false;
        }
        void limpiarCamposBusqueda()
        {
            textBoxDescripcion.Text = "";
            dateTimePickerFechaHallazgo.Value = DateTime.Now;
            textBoxLugar.Text = "";
            checkBoxArticulo.Checked = false;
            checkBoxFecha.Checked = false;
        }
        bool VerficarCampos()
        {
            if (comboBoxUnidad.Text == "" || comboBoxUrsa.Text == "" || dateTimePickerFechaHallazgo.Text == "" || textBoxNroActa.Text == "")
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
        BEElemento CovertirElemento(ElementoBusqueda elementoBusqueda)
        {
            BEElemento Elemento = new BEElemento(elementoBusqueda.Id);
            Elemento = new BEElemento(elementoBusqueda.Id);
            Elemento.Estado = new BEEstado_Elemento();
            Elemento.Descripcion = elementoBusqueda.Descripcion.ToUpper();
            Elemento.Estado.Nombre = elementoBusqueda.Estado;
            Elemento.Cantidad = Convert.ToDouble(elementoBusqueda.Cantidad);
            Elemento.Articulo = ListaArticulos.Find(x => x.Nombre == elementoBusqueda.Articulo);
            return Elemento;
        }

        void BuscarElementos()
        {
            if (!checkBoxArticulo.Checked) // SI NO ESTA CHEKEADO POR ARTICULO
            {
                if (checkBoxFecha.Checked)// SI NO ESTA CHEKEADO POR DIA
                {
                    listaElementosBusqueda = bLLElemento.BusquedaElementos((BEArticulo)comboBoxArticulo.SelectedItem, textBoxDescripcion.Text, textBoxLugar.Text, dateTimePickerFechaHallazgo.Value, dateTimePickerFechaHallazgo.Value.Year, bEUnidad);

                }
                else
                {
                    listaElementosBusqueda = bLLElemento.BusquedaElementos((BEArticulo)comboBoxArticulo.SelectedItem, textBoxDescripcion.Text, textBoxLugar.Text, null, dateTimePickerFechaHallazgo.Value.Year, bEUnidad);
                }
            }
            else
            {
                if (checkBoxFecha.Checked) // SI ESTA CHEKEADO POR DIA
                {
                    listaElementosBusqueda = bLLElemento.BusquedaElementos(null, textBoxDescripcion.Text, textBoxLugar.Text, dateTimePickerFechaHallazgo.Value, dateTimePickerFechaHallazgo.Value.Year, bEUnidad);

                }
                else
                {
                    listaElementosBusqueda = bLLElemento.BusquedaElementos(null, textBoxDescripcion.Text, textBoxLugar.Text, null, dateTimePickerFechaHallazgo.Value.Year, bEUnidad);
                }
            }

        }
        void LimpiarCamposEntrega()
        {
            SeleccionEntrega = false;
            dateTimePickerFechaEntrega.Value = DateTime.Now;
            bEEntrega = null;
            DgvElementosEntrega.DataSource = null;
            ColocarNumero();
        }
        void ColocarNumero()
        {
            textBoxNroActa.Text = bLLEntrega.ObtenerNroActa(bEUnidad, dateTimePickerFechaEntrega.Value.Year);
        }
        BEEntrega CrearEntrega()
        {
            if (!SeleccionEntrega) // AGREGAR UNO NUEVO
            {
                bEEntrega = new BEEntrega();
                bEEntrega.NroActa = textBoxNroActa.Text;
                bEEntrega.Unidad = bEUnidad;
                bEEntrega.Fecha_entrega = dateTimePickerFechaEntrega.Value;
                bEEntrega.Anio = dateTimePickerFechaEntrega.Value.Year;
            }
            else // MODIFICAR Y ELIMINACION
            {
                bEEntrega.NroActa = textBoxNroActa.Text;
                bEEntrega.Unidad = bEUnidad;
                bEEntrega.Fecha_entrega = dateTimePickerFechaEntrega.Value;
                bEEntrega.Anio = dateTimePickerFechaEntrega.Value.Year;
            }
            return bEEntrega;
        }
        void VerificarEntregaSeleccionados()
        {
            SeleccionEntrega = false;

            foreach (DataGridViewRow row in dgvEntregas.Rows)
            {
                if ((bool)row.Cells[0].Value != false)
                {
                    SeleccionEntrega = true;

                    if (bEEntrega?.Id != ((BEEntrega)row.DataBoundItem).Id) // SI YA ESTA SELECCIONADO
                    {
                        bEEntrega = bLLEntrega.ListarObjeto((BEEntrega)row.DataBoundItem);
                    }
                    textBoxNroActa.Text = bEEntrega.NroActa;
                    dateTimePickerFechaHallazgo.Value = bEEntrega.Fecha_entrega;
                    MostrarElementosEntrega();

                    break;
                }
            }
            if (!SeleccionEntrega)
            {
                bEEntrega = null;
                MostrarEntregas();
                MostrarElementosEntrega();
                LimpiarCamposEntrega();
            }
            Habilitar();

        }
        void VerificarElementoSeleccionados()
        {
            SeleccionElementoBusqueda = false;

            foreach (DataGridViewRow row in DgvBusqueda.Rows)
            {
                if ((bool)row.Cells[0].Value != false)
                {
                    SeleccionElementoBusqueda = true;
                    buttonCambiarEstado.Enabled = true;
                    break;
                }
            }
            if (!SeleccionElementoBusqueda)
            {
                buttonCambiarEstado.Enabled = false;
            }
        }
        void colocarCheck()
        {
            if (bEEntrega.listaElementos != null)
            {
                foreach (DataGridViewRow row in DgvBusqueda.Rows)
                {
                    if (bEEntrega.listaElementos.Exists(x => x.Id == (int)row.Cells[1].Value))
                    {
                        row.Cells["Select"].Value = true;
                    }
                }
            }
        }
        #endregion

        #region "Botones"
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarbBusqueda();
                BuscarElementos();
                MostrarElementosBusqueda();
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
                if (VerficarCampos())
                {
                    bEEntrega = bLLEntrega.Agregar(CrearEntrega());

                    if (bEEntrega.Id != 0)
                    {
                        ModoCreacion = true;
                        SeleccionEntrega = true;

                        bEEntrega = bLLEntrega.ListarObjeto(bEEntrega);
                        MostrarEntregas();
                        BuscarEntrega();
                        MessageBox.Show($"La Entrega se creó {textBoxNroActa.Text} correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Habilitar();
                    }
                    else
                    {
                        MessageBox.Show($"El Nro.de Entrega {textBoxNroActa.Text} ya se encuentra utilizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MostrarEntregas();
                    if (Usuario.Rol == "UNIDAD")
                    {
                        dgvEntregas.Rows[0].Selected = true;
                        dgvEntregas.Rows[0].Cells["Seleccion"].Value = true;
                    }
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

                foreach (DataGridViewRow fila in dgvEntregas.Rows)
                {
                    if ((bool)fila.Cells[0].Value == true)
                    {
                        bLLEntrega.Eliminar((BEEntrega)fila.DataBoundItem);
                    }
                }
                MessageBox.Show("La Entrega se eliminó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposEntrega();
                MostrarEntregas();
                Habilitar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("¿Desea Realizar el cambio de estado del elemento?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    if (ModoCreacion) // si esta modo entrega
                    {
                        VerificarElementoSeleccionados();

                        if (SeleccionElementoBusqueda && SeleccionEntrega) // tiene que estar seleccionada la entrega y los elementos a entregar
                        {
                            if (comboBoxEstado.Text == "Entregado") //si esta seleccioando hallazgo y no se realiza la entrega
                            {
                                foreach (DataGridViewRow item in DgvBusqueda.Rows)
                                {
                                    if ((bool)item.Cells[0].Value == true)
                                    {
                                        BEElemento eElemento = CovertirElemento((ElementoBusqueda)item.DataBoundItem);

                                        if (eElemento.Estado.Nombre == "Resguardo") // solo se eran las entregas de aquellos elementos que esten en resguardo
                                        {
                                            eElemento.Estado = (BEEstado_Elemento)comboBoxEstado.SelectedItem;
                                            bLLElemento.AgregarElementoEntrega(bEEntrega, eElemento);

                                        }
                                    }
                                }
                            }
                            else // si se quiere cambiar el estado que no sea entregado tiene que ser los elementos que sean de la misma entrega
                            {
                                foreach (DataGridViewRow item in DgvBusqueda.Rows)
                                {
                                    if ((bool)item.Cells[0].Value == true)
                                    {
                                        var aux = (ElementoBusqueda)item.DataBoundItem;

                                        if (aux.Entrega == bEEntrega.NroActa)
                                        {
                                            BEElemento eElemento = CovertirElemento(aux);

                                            if (eElemento.Estado.Nombre == "Entregado") // si estaba entregado anteriormente lo volvemos a resguardo
                                            {
                                                eElemento.Estado = (BEEstado_Elemento)comboBoxEstado.SelectedItem;
                                                bLLElemento.EliminarElementoEntrega(eElemento);
                                            }

                                        }

                                    }
                                }
                            }
                            BuscarElementos();
                            MostrarElementosBusqueda();
                            MostrarElementosEntrega();
                            colocarCheck();
                            BuscarEntrega();
                        }
                        else
                        {
                            MessageBox.Show("No existe elementos seleccionados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else // SI NO ESTA EN MODO CREACION SOLO BUESQUEDA Y CAMBIA DE ESTADO MENOS ENTREGADO
                    {
                        VerificarElementoSeleccionados();

                        if (SeleccionElementoBusqueda) //SE VERIFICA SI HAY ELEMENTOS ELECIONADOS
                        {
                            if (comboBoxEstado.Text != "Entregado")  //SE VERIFICA QUE NO QUIERA HACER UNA ENTREGA 
                            {
                                foreach (DataGridViewRow item in DgvBusqueda.Rows)
                                {
                                    if ((bool)item.Cells[0].Value == true)
                                    {
                                        BEElemento eElemento = CovertirElemento((ElementoBusqueda)item.DataBoundItem);

                                        if (eElemento.Estado.Nombre != "Entregado") // SOLO SE HARAN LOS ELEMENTOS QUE NO FUERON ENTREGADOS
                                        {
                                            eElemento.Estado = (BEEstado_Elemento)comboBoxEstado.SelectedItem;
                                            bLLElemento.Actualizar(eElemento);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Creé una Entrega para cambiar el estado del elemento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }

                            BuscarElementos();
                            MostrarElementosBusqueda();
                        }
                        else
                        {

                            MessageBox.Show("No existe elementos seleccionados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
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
                Form_Persona form_Personas = new Form_Persona(bEEntrega);
                form_Personas.ShowDialog();

                bEEntrega = (BEEntrega)form_Personas.BePAdreHallazgo;

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
                if (bEEntrega.listaPersonas?.Count >= 3 && bEEntrega.listaElementos?.Count > 0)
                {
                    Form_Impresion form_Impresion = new Form_Impresion(bEEntrega);
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
        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bEEntrega.listaElementos == null || bEEntrega.listaElementos?.Count == 0)
                {
                    var result = MessageBox.Show("La Entrega no contiene elementos \n\n¿Desea finalizar la carga? \n\n Si decide finalizar se borrara la Entrega", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bLLEntrega.Eliminar(bEEntrega);
                        ModoCreacion = false;
                        //bEEntrega = null;
                        //SeleccionEntrega = false;
                        LimpiarCamposEntrega();
                        Habilitar();
                        MostrarEntregas();
                        MostrarElementosEntrega();
                        LimpiarbBusqueda();
                    }
                }
                else
                {
                    var result = MessageBox.Show("¿Desea finalizar el Entrega?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ModoCreacion = false;
                        //bEEntrega = null;
                        //SeleccionEntrega = false;
                        LimpiarCamposEntrega(); 
                        Habilitar();
                        MostrarEntregas();
                        MostrarElementosEntrega();
                        LimpiarbBusqueda();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Acciones Datagrid y Combobox"

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
                LimpiarCamposEntrega();
                MostrarEntregas();
                Habilitar();
            }
            else if (Usuario.Rol == "REGION")
            {
                bEUnidad = (BEUnidad)comboBoxUnidad.SelectedItem;
                LimpiarCamposEntrega();
                MostrarEntregas();
                Habilitar();
            }

        }

        private void dateTimePickerFechaEntrega_ValueChanged(object sender, EventArgs e)
        {

            if (!ModoCreacion && !SeleccionEntrega) // SI NO ESTA EN MODO CREACION 
            {
                MostrarEntregas();
            }
            if (!SeleccionEntrega && Usuario.Rol == "UNIDAD")
            {
                ColocarNumero();
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
                if (e.ColumnIndex == this.DgvBusqueda.Columns["Select"].Index)
                {
                    var Valor = (bool)DgvBusqueda.Rows[e.RowIndex].Cells["Select"].Value;
                    if (!Valor) // SI SELECCIONO CON EL TILDE
                    {
                        var index = DgvBusqueda.CurrentRow.Index;
                        DgvBusqueda.Rows[index].Cells["Select"].Value = true;
                        VerificarElementoSeleccionados();
                    }
                    else  // SACAR LA SELECCION 
                    {
                        DgvBusqueda.Rows[e.RowIndex].Cells["Select"].Value = false;
                        VerificarElementoSeleccionados();
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
                string Lugar = DgvBusqueda.Rows[e.RowIndex].Cells["Lugar"].Value.ToString();
                string Nroacta = DgvBusqueda.Rows[e.RowIndex].Cells["Hallazgo"].Value.ToString();
                listaElementosBusqueda = bLLElemento.BusquedaElementosHallazgo(Nroacta, Lugar);
                MostrarElementosBusqueda();
                MessageBox.Show($"¡Usted ah ingresado a los elementos del hallazgo\n\t\t{Nroacta} !", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvEntregas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!ModoCreacion)
            {
                if (e.ColumnIndex == this.dgvEntregas.Columns["Seleccion"].Index)
                {
                    var Valor = (bool)dgvEntregas.Rows[e.RowIndex].Cells["Seleccion"].Value;
                    if (!Valor) // SI SELECCIONO CON EL TILDE
                    {
                        var index = dgvEntregas.CurrentRow.Index;
                        dgvEntregas.Rows[index].Cells["Seleccion"].Value = true;
                        VerificarEntregaSeleccionados();
                    }
                    else  // SACAR LA SELECCION 
                    {
                        SeleccionEntrega = false;
                        dgvEntregas.Rows[e.RowIndex].Cells["Seleccion"].Value = false;
                        VerificarEntregaSeleccionados();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxArticulo.Checked)
            {
                comboBoxCategoria.Enabled = false;
                comboBoxArticulo.Enabled = false;
            }
            else
            {
                comboBoxArticulo.Enabled = true;
                comboBoxCategoria.Enabled = true;
            }

        }

    }
}
