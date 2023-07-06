using BE;
using Negocio;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_Persona : Form
    {
        public Form_Persona(BEPAdreHallazgo bEPAdreHallazgo)
        {
            InitializeComponent();

            bLLEstado_Persona = new BLLEstado_Persona();
            bllPersonas = new BLLPersona();
            bLLInstructor = new BLLInstructor();
            bLLHallazgo = new BLLHallazgo();
            bLLEntrega = new BLLEntrega();
            bLLJerarquia = new BLLJerarquia();
            jerarquias = bLLJerarquia.ListarTodo();


            Type TipoObjeto = bEPAdreHallazgo.GetType();

            if (TipoObjeto == typeof(BEHallazgo))
            {
                BePAdreHallazgo = bEPAdreHallazgo as BEHallazgo;
                Hallazgo = true;
            }
            else
            { BePAdreHallazgo = bEPAdreHallazgo as BEEntrega; }

        }


        #region "Campos"

        public BEPAdreHallazgo BePAdreHallazgo;
        BEPersona persona;

        BLLPersona bllPersonas;
        BLLInstructor bLLInstructor;
        BLLHallazgo bLLHallazgo;
        BLLEntrega bLLEntrega;
        BLLEstado_Persona bLLEstado_Persona;
        BLLJerarquia bLLJerarquia;
        List<BEJerarquia> jerarquias;
        bool Hallazgo = false;
        bool Seleccion = false;
        #endregion




        private void FormPersonas_Load(object sender, EventArgs e)
        {
            if (BePAdreHallazgo.listaPersonas != null)
            { MostrarPersonas(); }
            else
            { BePAdreHallazgo.listaPersonas = new List<BEPersona>(); }

            CargarCombo();
            Habilitar();


        }


        #region "Funciones"

        public BEPAdreHallazgo ObtenerIntervinientes() => BePAdreHallazgo;
        void CargarCombo()
        {

            comboBoxJerarquia.DataSource = jerarquias;
            if (Hallazgo)
            {
                comboBoxTipoPersona.DataSource = bLLEstado_Persona.ListarTodo().FindAll(x => x.Nombre != "Propietario");
            }
            else
            {
                comboBoxTipoPersona.DataSource = bLLEstado_Persona.ListarTodo().FindAll(x => x.Nombre != "Descubridor");
            }
        }

        void Panel()
        {
            if (comboBoxTipoPersona.Text == "Instructor")
            {

                panelInstructor.Visible = true;
                panelDescubridor.Visible = false;
                panelTestigo.Visible = false;

            }
            else if (comboBoxTipoPersona.Text == "Testigo")
            {
                panelInstructor.Visible = false;
                panelDescubridor.Visible = false;
                panelTestigo.Visible = true;
            }
            else // si es descubridor o propietario
            {
                panelInstructor.Visible = false;
                panelDescubridor.Visible = true;
                panelTestigo.Visible = false;

            }
        }
        private void AgregarNoInstructor()
        {
            if (persona == null)
            {
                persona = bllPersonas.Agregar(CrearPersona());
                MessageBox.Show("El/La Interviniente se Agrego Correctamente a la Base de datos", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AgregarInstructor()
        {
            if (persona == null) // SI LA PERSONA NO SE ENCUENTRA EN LA BASE DE DATOS
            {
                persona = bLLInstructor.Agregar(CrearInstructor()); // SE AGREGA AL INSTRUCTOR
                MessageBox.Show("El/La Interviniente se Agrego Correctamente a la Base de datos", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AgregarPersonaHallazgo_Entrega()
        {
            if (persona.Id != 0)
            {
                persona.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;

                if (Hallazgo) // SI ES HALLAZGO
                    bllPersonas.AgregarPersonaHallazgo((BEHallazgo)BePAdreHallazgo, persona);
                else
                    bllPersonas.AgregarPersonaEntrega((BEEntrega)BePAdreHallazgo, persona);

                MostrarPersonas();
                LimpiarCampos();
                Habilitar();
            }
        }
        void Button()
        {
            if (Seleccion)
            {
                buttonAgregar.Visible = false;
                buttonModificar.Visible = true;
                buttonEleminar.Visible = true;
                buttonBuscar.Visible = false;
            }
            else
            {
                buttonBuscar.Visible = true;
                buttonAgregar.Visible = true;
                buttonModificar.Visible = false;
                buttonEleminar.Visible = false;
            }
        }
        void Habilitar()
        {
            Button();
            Panel();
        }
        void MostrarPersonas()
        {
            DgvPersonas.DataSource = null;

            if (Hallazgo)
            {
                BePAdreHallazgo.listaPersonas = bLLHallazgo.ListarHallazgoPersonas((BEHallazgo)BePAdreHallazgo).listaPersonas;
            }
            else
            {
                BePAdreHallazgo.listaPersonas = bLLEntrega.ListarObjetoPersonas((BEEntrega)BePAdreHallazgo).listaPersonas;
            }

            DgvPersonas.DataSource = BePAdreHallazgo.listaPersonas;

            if (BePAdreHallazgo.listaPersonas != null)
            {
                this.DgvPersonas.Columns["Sel"].Visible = true;
                this.DgvPersonas.Columns["Sel"].Width = 25;
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

                foreach (DataGridViewRow row in DgvPersonas.Rows)
                {
                    if (row.Cells["Sel"].Value == null)
                    {
                        row.Cells["Sel"].Value = false;
                    }
                }
            }
            else this.DgvPersonas.Columns["Sel"].Visible = false;

        }
        void LimpiarCampos()
        {
            switch (comboBoxTipoPersona.Text)
            {
                case "Instructor":
                    LimpiarControles(panelInstructor);
                    break;
                case "Testigo":
                    LimpiarControles(panelTestigo);
                    break;
                default:
                    LimpiarControles(panelDescubridor);
                    break;
            }
            Seleccion = false;
            persona = null;
        }

        void LimpiarControles(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Si el control es un TextBox, limpia su contenido
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                // Si el control tiene controles hijos, llama a la función de manera recursiva
                else if (c.Controls.Count > 0)
                {
                    LimpiarControles(c);
                }
            }
        }
        bool VerificarPersonas()
        {

            if (BePAdreHallazgo.listaPersonas?.Count >= 4)
            {
                MessageBox.Show($"Posee la maxima cantidad de intervinientes", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (BePAdreHallazgo.listaPersonas != null)
                {

                    if (BePAdreHallazgo.listaPersonas.Exists(x => x.Id == persona?.Id))
                    {
                        MessageBox.Show($"La persona  ya se encuentra asignada como interviniente ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        if ((BePAdreHallazgo.listaPersonas.FindAll(x => x.EstadoPersona.Nombre == "Testigo").Count == 2) && comboBoxTipoPersona.Text == "Testigo")
                        {
                            MessageBox.Show($"Ya posee 2 Testigos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            if (comboBoxTipoPersona.Text != "Testigo" && BePAdreHallazgo.listaPersonas.Exists(x => x.EstadoPersona.Nombre == comboBoxTipoPersona.Text))
                            {
                                MessageBox.Show($"Ya posee {comboBoxTipoPersona.Text} ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                            else
                            {
                                return true;

                            }
                        }

                    }

                }
                else
                {
                    return true;
                }

            }
        }

        void CargarDatos()
        {

            if (comboBoxTipoPersona.Text == "Instructor")
            {
                textBoxLegajo.Text = ((BEInstructor)persona).Legajo.ToString();
                textBoxNombreInstructor.Text = persona.NombreCompleto;
                comboBoxJerarquia.Text = ((BEInstructor)persona).Jerarquia.Jerarquia;
                textBoxDniInstructor.Text = persona.DNI;
            }
            else if (comboBoxTipoPersona.Text == "Testigo")
            {
                textBoxDniTestigo.Text = persona.DNI;
                textBoxNombreTestigo.Text = persona.NombreCompleto;
            }
            else // si es descubridor
            {
                textBoxDniTestigo.Text = persona.DNI;
                textBoxNombreDescr_Prop.Text = persona.NombreCompleto;
                textBoxTelefono.Text = persona.Telefono;
                textBoxOcupacion.Text = persona.Ocupacion;
                textBoxDomicilio.Text = persona.Domicilio;
            }
        }




        bool BuscarDatosPersona()
        {
            bool Encontrado = false;

            switch (comboBoxTipoPersona.Text)
            {
                case "Instructor":
                    persona = bLLInstructor.BuscarPorDNI_legajo(textBoxLegajo.Text);
                    if (persona == null)
                    {
                        persona = bllPersonas.BuscarPorDNI(textBoxDniInstructor.Text);
                        if (persona != null)
                        {
                            var result = MessageBox.Show("La persona se encuentra en la base de datos\n\n ¿Desea convertirla en oficial?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                bLLInstructor.Actualizar(CrearInstructor());
                                persona = bLLInstructor.BuscarPorDNI_legajo(textBoxLegajo.Text);
                            }
                        }
                    }
                    break;
                case "Testigo":
                    persona = bllPersonas.BuscarPorDNI(textBoxDniTestigo.Text);
                    break;
                default: //descubridor o Instructor
                    persona = bllPersonas.BuscarPorDNI(textBoxDniDescubridor.Text);
                    break;

            }

            if (persona != null)
            {
                CargarDatos();
                Encontrado = true;
            }
            else
            {
                persona = null;
                MessageBox.Show("La Persona no se encuentra en la Base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Encontrado;
        }

        bool ValidarCampos(string tipoPersona)
        {
            if (tipoPersona == "Instructor")
            {
                return textBoxLegajo.Text != "" && Validar.SoloEnteros(textBoxLegajo.Text) && textBoxNombreInstructor.Text != "" && textBoxDniInstructor.Text != "" && comboBoxJerarquia.Text != "";
            }
            else if (tipoPersona == "Testigo")
            {
                return textBoxDniTestigo.Text != "" && textBoxNombreTestigo.Text != "";
            }
            else // caso por propietario o descurridor  
            {
                return textBoxDniDescubridor.Text != "" && textBoxNombreDescr_Prop.Text != "" && textBoxOcupacion.Text != "" && textBoxDomicilio.Text != "";
            }
        }


        BEPersona CrearPersona()
        {
            if (!Seleccion)
            {
                persona = new BEPersona();
            }

            persona.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;

            if (comboBoxTipoPersona.Text == "Testigo")
            {
                persona.DNI = textBoxDniTestigo.Text.Trim();
                persona.NombreCompleto = textBoxNombreTestigo.Text.Trim();
            }
            else //Descrubridor / propietario
            {
                persona.DNI = textBoxDniDescubridor.Text.Trim();
                persona.NombreCompleto = textBoxNombreDescr_Prop.Text.Trim();
                persona.Telefono = textBoxTelefono.Text.Trim();
                persona.Domicilio = textBoxDomicilio.Text.Trim();
                persona.Ocupacion = textBoxOcupacion.Text.Trim();
            }

            return persona;
        }

        BEInstructor CrearInstructor()
        {
            if (!Seleccion)
            {
                persona = new BEInstructor();
            }
            persona.DNI = textBoxDniInstructor.Text.Trim();
            persona.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;
            persona.NombreCompleto = textBoxNombreInstructor.Text.Trim();
            ((BEInstructor)persona).Legajo = Convert.ToInt32(textBoxLegajo.Text.Trim());
            ((BEInstructor)persona).Jerarquia = ((BEJerarquia)comboBoxJerarquia.SelectedItem);

            return (BEInstructor)persona;
        }

        void VerificarPersonasSeleccionados()
        {
            Seleccion = false;

            foreach (DataGridViewRow row in DgvPersonas.Rows)
            {
                if ((bool)row.Cells[0].Value != false)
                {
                    Seleccion = true;
                    persona = (BEPersona)row.DataBoundItem;
                    break;
                }
            }
            if (!Seleccion)
            {
                persona = null;
                LimpiarCampos();
            }
            else
            {
                comboBoxTipoPersona.Text = persona.EstadoPersona.Nombre;
                CargarDatos();
            }
            Habilitar();
        }

        private void DgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.DgvPersonas.Columns["Sel"].Index)
                {
                    var Valor = (bool)DgvPersonas.Rows[e.RowIndex].Cells["Sel"].Value;

                    if (!Valor)
                    {
                        DgvPersonas.Rows[e.RowIndex].Cells["Sel"].Value = true;
                    }
                    else
                    {
                        DgvPersonas.Rows[e.RowIndex].Cells["Sel"].Value = false;
                    }
                    VerificarPersonasSeleccionados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Botones"


        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos(comboBoxTipoPersona.Text))
                {
                    if (VerificarPersonas())
                    {
                        switch (comboBoxTipoPersona.Text)
                        {
                            case "Instructor":
                                AgregarInstructor();
                                break;
                            default: //Descubridor o Propietario //propietario
                                AgregarNoInstructor();
                                break;
                        }

                        AgregarPersonaHallazgo_Entrega();


                    }
                    else
                    {
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Llene todos los campos Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Seleccion)
                {
                    if (ValidarCampos(comboBoxTipoPersona.Text))
                    {
                        DialogResult result = MessageBox.Show($"¿Desea Modificar el {comboBoxTipoPersona.Text} ?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                        if (result == DialogResult.Yes)
                        {
                            if (comboBoxTipoPersona.Text == "Instructor")
                            {
                                bLLInstructor.Actualizar(CrearInstructor());
                            }
                            else
                            {
                                bllPersonas.Actualizar(CrearPersona());
                            }
                            MessageBox.Show("El Interviniente se Modificó Correctamente", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            MostrarPersonas();
                            Habilitar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene todos los campos Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Seleccion)
                {
                    DialogResult result = MessageBox.Show($"¿Desea Eliminar el {comboBoxTipoPersona.Text} ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if (result == DialogResult.Yes)
                    {
                        if (Hallazgo)
                        {
                            foreach (DataGridViewRow fila in DgvPersonas.Rows)
                            {
                                if ((bool)fila.Cells[0].Value == true)
                                {
                                    bllPersonas.ElimnarPersonaHallazgo((BEHallazgo)BePAdreHallazgo, (BEPersona)fila.DataBoundItem);
                                }
                            }
                        }
                        else
                        {

                            foreach (DataGridViewRow fila in DgvPersonas.Rows)
                            {
                                if ((bool)fila.Cells[0].Value == true)
                                {
                                    bllPersonas.EliminarPersonaEntrega((BEEntrega)BePAdreHallazgo, (BEPersona)fila.DataBoundItem);
                                }
                            }
                        }

                        Seleccion = false;
                        LimpiarCampos();
                        MostrarPersonas();
                        Habilitar();
                        MessageBox.Show("El Interviniente se Elimino Correctamente", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione Interviniente Para eliminar  ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }

        }
        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult = DialogResult.OK;



            }
            catch (Exception ex)
            {

                throw new Exception($"{ex.Message}");
            }
        }

        #endregion

        #region "Datagrid"
        private void DgvPersonas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (DgvPersonas.Rows.Count == 4)
            {
                buttonAgregar.Visible = false;
            }
        }
        private void DgvPersonas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (DgvPersonas.Rows.Count < 4)
            {
                buttonAgregar.Visible = true;
            }
        }

        #endregion

        #region "ComboBox"
        private void comboBoxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region "TextBox"
        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonBuscar_Click(null, null);
            }

        }
        private void textBoxNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NoSaltosDelinea(e);
        }
        private void textBoxOcupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NoSaltosDelinea(e);
        }
        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NoSaltosDelinea(e);
        }
        private void textBoxDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NoSaltosDelinea(e);
        }

        #endregion
        private void FormPersonas_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (DialogResult != DialogResult.OK)
            {

                DialogResult result = MessageBox.Show("¿Desea finalizar la carga de los Intervinientes?", "Finalizar la Carga", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }

        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarDatosPersona();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Seleccion) // SI NO HAY SELECCION
            {
                Habilitar();
                LimpiarCampos();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Habilitar();
            LimpiarCampos();

        }
    }
}

