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
        bool Conversion = false;
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

            if (Hallazgo)
            {
                comboBoxTipoPersona.DataSource = bLLEstado_Persona.ListarTodo().FindAll(x => x.Estado != "Propietario");
            }
            else
            {
                comboBoxTipoPersona.DataSource = bLLEstado_Persona.ListarTodo().FindAll(x => x.Estado != "Descubridor");
            }
        }

        void Label()
        {
            if (comboBoxTipoPersona.Text == "Instructor")
            {
                label_DNI_PAS.Visible = false;
                labelOcupacion.Visible = false;
                labelTelefono.Visible = false;
                labelDomicilio.Visible = false;
                labelJerarquia.Visible = true;
                labelLegajo.Visible = true;
                labelDNI.Visible = true;
            }
            else if (comboBoxTipoPersona.Text == "Testigo")
            {
                label_DNI_PAS.Visible = true;
                labelTelefono.Visible = false;
                labelDomicilio.Visible = false;
                labelJerarquia.Visible = false;
                labelLegajo.Visible = false;
                labelOcupacion.Visible = false;
                labelDNI.Visible = false;
            }
            else
            {
                label_DNI_PAS.Visible = true;
                labelOcupacion.Visible = true;
                labelTelefono.Visible = true;
                labelDomicilio.Visible = true;
                labelJerarquia.Visible = false;
                labelLegajo.Visible = false;
                labelDNI.Visible = false;
            }
        }
        void TextBox()
        {
            if (comboBoxTipoPersona.Text == "Instructor")
            {
                textBoxOcupacion.Visible = false;
                textBoxDomicilio.Visible = false;
                textBoxTelefono_DNI.Visible = true;
            }
            else if (comboBoxTipoPersona.Text == "Testigo")
            {
                textBoxOcupacion.Visible = false;
                textBoxDomicilio.Visible = false;
                textBoxTelefono_DNI.Visible = false;
            }
            else
            {
                textBoxOcupacion.Visible = true;
                textBoxDomicilio.Visible = true;
                textBoxTelefono_DNI.Visible = true;
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
        void ComboBox()
        {
            if (comboBoxTipoPersona.Text == "Instructor")
            {
                comboBoxJerarquia.Visible = true;
                comboBoxJerarquia.DataSource = jerarquias;
                comboBoxJerarquia.Text = persona == null ? "" : ((BEInstructor)persona).Jerarquia.Jerarquia;

            }
            else
            {
                comboBoxJerarquia.Visible = false;
                comboBoxJerarquia.DataSource = null;
            }

            if (Seleccion)
                comboBoxTipoPersona.Enabled = false;
            else
                comboBoxTipoPersona.Enabled = true;

        }
        void Habilitar()
        {
            Button();
            ComboBox();
            Label();
            TextBox();
        }
        void MostrarPersonas()
        {
            DgvPersonas.DataSource = null;

            if (Hallazgo)
            {
                BePAdreHallazgo.listaPersonas = bLLHallazgo.ListarObjetoPersonas((BEHallazgo)BePAdreHallazgo).listaPersonas;
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
            textBoxDomicilio.Text = "";
            textBoxNombreApellido.Text = "";
            textBoxOcupacion.Text = "";
            textBoxTelefono_DNI.Text = "";
            comboBoxTipoPersona.Text = Seleccion ? comboBoxTipoPersona.Text : "Seleccione";
            comboBoxJerarquia.Text = comboBoxTipoPersona.Text == "Instructor" ? "Seleccione" : "";
            textBoxId.Text = "";
            comboBoxJerarquia.Text = "";
            persona = null;
            Conversion = false;
        }


        private bool VerificarPersonas()
        {

            if (BePAdreHallazgo.listaPersonas?.Count >= 4)
            {
                MessageBox.Show($"Posee la maxima cantidad de intervinientes", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            { //todo: verificar la carga de personas
                if (BePAdreHallazgo.listaPersonas != null)
                {

                    if (BePAdreHallazgo.listaPersonas.Exists(x => x.Id == persona?.Id))
                    {
                        MessageBox.Show($"La persona {textBoxId.Text} ya se encuentra asignada como interviniente ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        if ((BePAdreHallazgo.listaPersonas.FindAll(x => x.EstadoPersona.Estado == "Testigo").Count == 2) && comboBoxTipoPersona.Text == "Testigo")
                        {
                            MessageBox.Show($"Ya posee 2 Testigos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            if (comboBoxTipoPersona.Text != "Testigo" && BePAdreHallazgo.listaPersonas.Exists(x => x.EstadoPersona.Estado == comboBoxTipoPersona.Text))
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

        void CargarPersona()
        {

            if (comboBoxTipoPersona.Text == "Instructor")
            {
                textBoxId.Text = ((BEInstructor)persona).Legajo.ToString();
                textBoxNombreApellido.Text = persona.NombreCompleto;
                comboBoxJerarquia.Text = ((BEInstructor)persona).Jerarquia.Jerarquia;
                textBoxTelefono_DNI.Text = persona.DNI;
            }
            else if (comboBoxTipoPersona.Text == "Testigo")
            {
                textBoxId.Text = persona.DNI;
                textBoxNombreApellido.Text = persona.NombreCompleto;
            }
            else // si es descubridor
            {
                textBoxTelefono_DNI.Text = persona.Telefono;
                textBoxId.Text = persona.DNI;
                textBoxNombreApellido.Text = persona.NombreCompleto;
                textBoxOcupacion.Text = persona.Ocupacion;
                textBoxDomicilio.Text = persona.Domicilio;
                textBoxTelefono_DNI.Text = persona.Telefono;
            }
        }
        private bool BuscarDatosPersona()
        {
            bool Encontrado = false;

            if (comboBoxTipoPersona.Text == "Instructor")
            {
                persona = bLLInstructor.ListarTodo().Find(x => x.Legajo == Convert.ToInt32(textBoxId.Text));

                if (persona == null) // si no se encuentra el legajo busca el dni si esta registrado anteriormente
                {
                    persona = bllPersonas.ListarTodo().Find(x => x.DNI == textBoxTelefono_DNI.Text);

                    if (persona != null)
                    {
                        var result = MessageBox.Show("El DNI consultado se encuentra en la base de datos\n\n¿Desea registrarlo como Oficial? ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {

                            textBoxNombreApellido.Text = persona.NombreCompleto;
                            Conversion = true;
                            return true;
                        }

                    }
                }
            }
            else
            {
                persona = bllPersonas.ListarTodo().Find(x => x.DNI == textBoxId.Text);
            }

            if (persona != null)
            {
                CargarPersona();
                Encontrado = true;
            }
            else
            {
                persona = null;
                MessageBox.Show("La Persona no se encuentra en la Base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Encontrado;
        }
        public bool VerificarCampos()
        {
            if (comboBoxTipoPersona.Text == "Instructor")
            {
                if (textBoxId.Text == "" || !Validar.SoloEnteros(textBoxId.Text) || textBoxNombreApellido.Text == "" || textBoxTelefono_DNI.Text == "" || comboBoxJerarquia.Text == "")
                {
                    MessageBox.Show("Llene todos los campos para agregar al Oficial Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (comboBoxTipoPersona.Text == "Testigo")
            {
                if (textBoxId.Text == "" || textBoxNombreApellido.Text == "")
                {
                    MessageBox.Show("Llene todos los campos para agregar al Testigo Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    return true;
                }
            }

            else
            {
                if (textBoxId.Text == "" || textBoxNombreApellido.Text == "" || textBoxOcupacion.Text == "" || textBoxDomicilio.Text == "")
                {
                    MessageBox.Show("Llene todos los campos Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }
        private BEPersona ObtenerPersona()
        {
            if (!Seleccion)
            {
                persona = new BEPersona();
            }

            persona.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;

            if (comboBoxTipoPersona.Text == "Testigo")
            {
                persona.DNI = textBoxId.Text.Trim();
                persona.NombreCompleto = textBoxNombreApellido.Text.Trim();
            }
            else
            {
                persona.DNI = textBoxId.Text.Trim();
                persona.NombreCompleto = textBoxNombreApellido.Text.Trim();
                persona.Telefono = textBoxTelefono_DNI.Text.Trim();
                persona.Domicilio = textBoxDomicilio.Text.Trim();
                persona.Ocupacion = textBoxOcupacion.Text.Trim();
            }

            return persona;
        }

        private BEInstructor ObtenerInstructor()
        {
            if (!Seleccion)
            {
                persona = new BEInstructor();
            }
            persona.DNI = textBoxTelefono_DNI.Text.Trim();
            persona.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;
            persona.NombreCompleto = textBoxNombreApellido.Text.Trim();
            ((BEInstructor)persona).Legajo = Convert.ToInt32(textBoxId.Text.Trim());
            ((BEInstructor)persona).Jerarquia = ((BEJerarquia)comboBoxJerarquia.SelectedItem);

            return (BEInstructor)persona;
        }

        private BEInstructor ConvertirPersona_A_Instructor(BEPersona bEPersona)
        {
            int ID = bEPersona.Id;

            bEPersona = new BEInstructor();
            bEPersona.Id = ID;
            bEPersona.DNI = textBoxTelefono_DNI.Text.Trim();
            bEPersona.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;
            bEPersona.NombreCompleto = textBoxNombreApellido.Text.Trim();
            ((BEInstructor)bEPersona).Legajo = Convert.ToInt32(textBoxId.Text.Trim());
            ((BEInstructor)bEPersona).Jerarquia = ((BEJerarquia)comboBoxJerarquia.SelectedItem);

            return (BEInstructor)bEPersona;
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
                comboBoxTipoPersona.Text = persona.EstadoPersona.Estado;
                CargarPersona();
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
                if (VerificarCampos())
                {
                    if (VerificarPersonas())
                    {
                        if (comboBoxTipoPersona.Text == "Instructor")
                        {
                            if (Conversion) //pasar de persona a instructor
                            {
                                bLLInstructor.Conversion(ConvertirPersona_A_Instructor(persona));
                                Conversion = false;
                            }

                            persona = bLLInstructor.ListarTodo().Find(x => x.Legajo == Convert.ToInt32(textBoxId.Text));

                            if (persona == null) // SI LA PERSONA NO SE ENCUENTRA EN LA BASE DE DATOS
                            {
                                persona = bLLInstructor.Agregar(ObtenerInstructor()); // SE AGREGA AL INSTRUCTOR

                                if (persona.Id != 0)
                                {
                                    MessageBox.Show("El/La Interviniente se Agrego Correctamente a la Base de datos", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                            else // se actualizan los datos que ya tiene la persona cargada
                            {
                                Seleccion = true;
                                bLLInstructor.Actualizar(ObtenerInstructor());
                            }


                        }
                        else // si es NO es instructor
                        {
                            persona = bllPersonas.ListarTodo().Find(x => x.DNI == textBoxId.Text);

                            if (persona == null)
                            {
                                persona = bllPersonas.Agregar(ObtenerPersona());
                                if (persona.Id != 0)
                                {
                                    MessageBox.Show("El/La Interviniente se Agrego Correctamente a la Base de datos", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                Seleccion = true;
                                bllPersonas.Actualizar(ObtenerPersona());
                            }
                        }


                        if (persona.Id != 0)
                        {
                            if (Hallazgo) // SI ES HALLAZGO
                            {
                                persona.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;
                                bllPersonas.AgregarPersonaHallazgo((BEHallazgo)BePAdreHallazgo, persona);
                            }
                            else
                            {
                                persona.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;
                                bllPersonas.AgregarPersonaEntrega((BEEntrega)BePAdreHallazgo, persona);
                            }
                            Seleccion = false;
                            MostrarPersonas();
                            LimpiarCampos();
                            Habilitar();
                        }


                    }
                    else
                    {
                        Seleccion = false;
                        LimpiarCampos();
                    }
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
                    if (VerificarCampos())
                    {
                        DialogResult result = MessageBox.Show($"¿Desea Modificar el {comboBoxTipoPersona.Text} {textBoxNombreApellido.Text}?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                        if (result == DialogResult.Yes)
                        {
                            if (comboBoxTipoPersona.Text == "Instructor")
                            {
                                bLLInstructor.Actualizar(ObtenerInstructor());
                            }
                            else
                            {
                                bllPersonas.Actualizar(ObtenerPersona());
                                MessageBox.Show("El Interviniente se Modificó Correctamente", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            Seleccion = false;
                            LimpiarCampos();
                            MostrarPersonas();
                            Habilitar();
                        }
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
                    DialogResult result = MessageBox.Show($"¿Desea Eliminar el {comboBoxTipoPersona.Text} {textBoxNombreApellido.Text}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
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

            if (comboBoxTipoPersona.Text == "Seleccione")
            {
                MessageBox.Show("Elija el categoria de la persona para realizar busqueda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else if (textBoxId.Text == "")
            {
                if (comboBoxTipoPersona.Text == "Instructor")
                {
                    MessageBox.Show("Coloque el Legajo a buscar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Coloque el DNI a buscar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiarCampos();
            }
            else
            {
                BuscarDatosPersona();
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
            Seleccion = false;
            Habilitar();
            LimpiarCampos();
        }
    }
}

