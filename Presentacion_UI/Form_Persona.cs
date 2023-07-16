using BE;
using Negocio;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
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

            llenarSugerencias();
            SuscrpcionEventos();



            Type TipoObjeto = bEPAdreHallazgo.GetType();

            if (TipoObjeto == typeof(BEHallazgo))
            {
                BePAdreHallazgo = bEPAdreHallazgo as BEHallazgo;
                Hallazgo = true;
            }
            else
            { BePAdreHallazgo = bEPAdreHallazgo as BEEntrega; }

        }

        void llenarSugerencias()
        {
            var personas = bllPersonas.ListarTodo();
            var Instructores = bLLInstructor.ListarTodo();
            textBoxLegajo = Utilidades.SetAutoCompleteTextBox(textBoxLegajo, Instructores, instructor => instructor.Legajo.ToString());
            textBoxDniDescubridor = Utilidades.SetAutoCompleteTextBox(textBoxDniDescubridor, personas, persona => persona.DNI);
            textBoxDniTestigo = Utilidades.SetAutoCompleteTextBox(textBoxDniTestigo, personas, persona => persona.DNI);
        }


        #region "Campos"

        public BEPAdreHallazgo BePAdreHallazgo;
        BEPersona personaSeleccionada;

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
            { CargarGrilla(); }
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
        void AgregarNoInstructorBase() //para agregar a la base de datos
        {
            if (personaSeleccionada == null) //significa que no lo busco 
            {
                var person = CrearPersona();
                if (!bllPersonas.VerficarSiExisteDni(person.DNI))
                {
                    personaSeleccionada = bllPersonas.Agregar(personaSeleccionada);
                    MessageBox.Show("El/La Interviniente se Agrego Correctamente a la Base de datos", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var person =CrearPersona();
                var result = MessageBox.Show("La persona seleccionada ya se encuentra registrada \n ¿desea cambiar sus datos con la informacion nueva?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    bllPersonas.Actualizar(person);
                    personaSeleccionada = bllPersonas.ListarObjeto(person);
                    MessageBox.Show("Se cambiaron los datos con exito", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        void AgregarInstructorBase() //agregar  instructor a la base 
        {
            if (personaSeleccionada == null) // SI LA PERSONA fue buscada
            {
                var instructor = CrearInstructor();
                if (!bLLInstructor.VerficarExiste_DNI_Legajo(instructor.Legajo, instructor.DNI))
                {
                    personaSeleccionada = bLLInstructor.Agregar(instructor); // SE AGREGA AL INSTRUCTOR
                    MessageBox.Show("El/La Interviniente se Agrego Correctamente a la Base de datos", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Ya existe oficiales con esos datos busquelo primero", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var instructor = CrearInstructor();
                var result = MessageBox.Show("La persona seleccionada ya se encuentra registrada \n ¿desea cambiar sus datos con la informacion nueva?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    bllPersonas.Actualizar(instructor);
                    personaSeleccionada = bllPersonas.ListarObjeto(instructor);
                    MessageBox.Show("Se cambiaron los datos con exito", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        void AgregarPersonaHallazgo_Entrega() //AGREGACION DE LA PERSONA A LA ENTREGA O HALLAZGO SEGUN CORRESPONDA
        {
            if (personaSeleccionada?.Id != 0)
            {
                personaSeleccionada.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;

                if (Hallazgo) // SI ES HALLAZGO
                    bllPersonas.AgregarPersonaHallazgo((BEHallazgo)BePAdreHallazgo, personaSeleccionada);
                else
                    bllPersonas.AgregarPersonaEntrega((BEEntrega)BePAdreHallazgo, personaSeleccionada);

                CargarGrilla();
                LimpiarCampos();
                Habilitar();
            }
            else
                MessageBox.Show("No se ha podido agregar la persona", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        void CargarGrilla()
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
            personaSeleccionada = null;
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

                    if (BePAdreHallazgo.listaPersonas.Exists(x => x.Id == personaSeleccionada?.Id || x.DNI == textBoxDniDescubridor.Text || x.DNI == textBoxDniTestigo.Text || x.DNI == textBoxDniInstructor.Text))
                    {
                        MessageBox.Show($"La personaSeleccionada  ya se encuentra asignada como interviniente ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                return true;
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
                if (personaSeleccionada is BEInstructor)
                {
                    textBoxLegajo.Text = ((BEInstructor)personaSeleccionada).Legajo.ToString();
                    comboBoxJerarquia.Text = ((BEInstructor)personaSeleccionada).Jerarquia.Jerarquia;
                }
                textBoxNombreInstructor.Text = personaSeleccionada.NombreCompleto;
                textBoxDniInstructor.Text = personaSeleccionada.DNI;
            }
            else if (comboBoxTipoPersona.Text == "Testigo")
            {
                textBoxDniTestigo.Text = personaSeleccionada.DNI;
                textBoxNombreTestigo.Text = personaSeleccionada.NombreCompleto;
            }
            else // si es descubridor
            {
                textBoxDniDescubridor.Text = personaSeleccionada.DNI;
                textBoxNombreDescr_Prop.Text = personaSeleccionada.NombreCompleto;
                textBoxTelefono.Text = personaSeleccionada.Telefono;
                textBoxOcupacion.Text = personaSeleccionada.Ocupacion;
                textBoxDomicilio.Text = personaSeleccionada.Domicilio;
            }
        }
        bool BuscarDatosPersona()
        {
            bool Encontrado = false;

            switch (comboBoxTipoPersona.Text)
            {
                case "Instructor":
                    personaSeleccionada = bLLInstructor.BuscarPor_legajo_dni(textBoxLegajo.Text, textBoxDniInstructor.Text);
                    if (personaSeleccionada == null)
                    {
                        personaSeleccionada = bllPersonas.BuscarPorDNI(textBoxDniInstructor.Text);
                        if (personaSeleccionada != null)
                        {
                            var result = MessageBox.Show("La persona seleccionada se encuentra en la base de datos\n\n ¿Desea convertirla en oficial?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                if (ValidarCampos(comboBoxTipoPersona.Text))
                                {
                                    if (bLLInstructor.BuscarPor_legajo_dni(textBoxLegajo.Text) == null)
                                    {
                                        Seleccion = true; //esto es para que no me cree una nueva instancia
                                        bLLInstructor.Actualizar(CoversionPersonaInstructor());
                                        personaSeleccionada = bLLInstructor.BuscarPor_legajo_dni(textBoxLegajo.Text);
                                        MessageBox.Show("El cambio se realizo con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                        MessageBox.Show("El legajo ya ha sido utilizado por otro ofical", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                    MessageBox.Show("Complete todos los campos segun corresponda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    break;
                case "Testigo":
                    personaSeleccionada = bllPersonas.BuscarPorDNI(textBoxDniTestigo.Text);
                    break;
                default: //descubridor o Instructor
                    personaSeleccionada = bllPersonas.BuscarPorDNI(textBoxDniDescubridor.Text);
                    break;

            }

            if (personaSeleccionada != null)
            {
                CargarDatos();
                Encontrado = true;
            }
            else
            {
                LimpiarCampos();
                MessageBox.Show("La Persona no se encuentra en la Base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Encontrado;
        }


        bool ValidarCampos(string tipoPersona)
        {
            switch (tipoPersona)
            {
                case "Instructor":
                    return !string.IsNullOrEmpty(textBoxLegajo.Text) &&
                        !string.IsNullOrEmpty(textBoxNombreInstructor.Text) &&
                        !string.IsNullOrEmpty(textBoxDniInstructor.Text) &&
                        !string.IsNullOrEmpty(comboBoxJerarquia.Text) &&
                        Validar.SoloAlfabetico_Con_Espacios(textBoxNombreInstructor.Text) &&
                        Validar.SoloEnteros(textBoxLegajo.Text) &&
                        Validar.VerificarNroDocumento(textBoxDniInstructor.Text);


                case "Testigo":
                    return !string.IsNullOrEmpty(textBoxDniTestigo.Text) &&
                        !string.IsNullOrEmpty(textBoxNombreTestigo.Text) &&
                        Validar.SoloAlfabetico_Con_Espacios(textBoxNombreTestigo.Text) &&
                        Validar.VerificarNroDocumento(textBoxDniTestigo.Text);

                default: // caso por propietario o descubridor
                    return !string.IsNullOrEmpty(textBoxDniDescubridor.Text) &&
                        !string.IsNullOrEmpty(textBoxNombreDescr_Prop.Text) &&
                        !string.IsNullOrEmpty(textBoxOcupacion.Text) &&
                        !string.IsNullOrEmpty(textBoxDomicilio.Text) &&
                        Validar.SoloAlfabetico_Con_Espacios(textBoxNombreDescr_Prop.Text) &&
                        Validar.VerificarNroDocumento(textBoxDniDescubridor.Text);
            }
        }


        BEPersona CrearPersona()
        {
            if (!Seleccion)
            {
                personaSeleccionada = new BEPersona();
            }

            personaSeleccionada.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;

            if (comboBoxTipoPersona.Text == "Testigo")
            {
                personaSeleccionada.DNI = textBoxDniTestigo.Text.Trim();
                personaSeleccionada.NombreCompleto = textBoxNombreTestigo.Text.Trim();
            }
            else //Descrubridor / propietario
            {
                personaSeleccionada.DNI = textBoxDniDescubridor.Text.Trim();
                personaSeleccionada.NombreCompleto = textBoxNombreDescr_Prop.Text.Trim();
                personaSeleccionada.Telefono = textBoxTelefono.Text.Trim();
                personaSeleccionada.Domicilio = textBoxDomicilio.Text.Trim();
                personaSeleccionada.Ocupacion = textBoxOcupacion.Text.Trim();
            }

            return personaSeleccionada;
        }
        BEInstructor CrearInstructor()
        {
            if (!Seleccion)
            {
                personaSeleccionada = new BEInstructor();
            }
            personaSeleccionada.DNI = textBoxDniInstructor.Text.Trim();
            personaSeleccionada.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;
            personaSeleccionada.NombreCompleto = textBoxNombreInstructor.Text.Trim();
            ((BEInstructor)personaSeleccionada).Legajo = Convert.ToInt32(textBoxLegajo.Text.Trim());
            ((BEInstructor)personaSeleccionada).Jerarquia = ((BEJerarquia)comboBoxJerarquia.SelectedItem);

            return (BEInstructor)personaSeleccionada;
        }
        BEInstructor CoversionPersonaInstructor()
        {
            var instructor = new BEInstructor();
            instructor.Id = personaSeleccionada.Id;
            instructor.DNI = textBoxDniInstructor.Text.Trim();
            instructor.EstadoPersona = (BEEstado_Persona)comboBoxTipoPersona.SelectedItem;
            instructor.NombreCompleto = textBoxNombreInstructor.Text.Trim();
            instructor.Legajo = Convert.ToInt32(textBoxLegajo.Text.Trim());
            instructor.Jerarquia = ((BEJerarquia)comboBoxJerarquia.SelectedItem);

            return instructor;
        }
        void VerificarPersonasSeleccionados()
        {
            Seleccion = false;

            foreach (DataGridViewRow row in DgvPersonas.Rows)
            {
                if ((bool)row.Cells[0].Value != false)
                {
                    Seleccion = true;
                    personaSeleccionada = (BEPersona)row.DataBoundItem;
                    break;
                }
            }
            if (!Seleccion)
            {
                personaSeleccionada = null;
                LimpiarCampos();
            }
            else
            {
                comboBoxTipoPersona.Text = personaSeleccionada.EstadoPersona.Nombre;
                CargarDatos();
            }
            Habilitar();
        }
        void DgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        void buttonAgregar_Click(object sender, EventArgs e)
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
                                AgregarInstructorBase();
                                break;
                            default: //Descubridor o Propietario //propietario
                                AgregarNoInstructorBase();
                                break;
                        }
                        AgregarPersonaHallazgo_Entrega();
                    }
                    else
                        LimpiarCampos();
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

        void buttonModificar_Click(object sender, EventArgs e)
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
                            CargarGrilla();
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
        void buttonEliminar_Click(object sender, EventArgs e)
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
                        CargarGrilla();
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
        void button_Aceptar_Click(object sender, EventArgs e)
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
        void buttonBuscar_Click(object sender, EventArgs e)
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
        void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Habilitar();
            LimpiarCampos();

        }

        #endregion

        #region "Datagrid"
        void DgvPersonas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (DgvPersonas.Rows.Count == 4)
            {
                buttonAgregar.Visible = false;
            }
        }
        void DgvPersonas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (DgvPersonas.Rows.Count < 4)
            {
                buttonAgregar.Visible = true;
            }
        }

        #endregion

        #region "ComboBox"
        void comboBoxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        #region "TextBox"



        void SuscrpcionEventos()
        {
            textBoxLegajo.KeyDown += TextBox_Buscar;
            textBoxDniDescubridor.KeyDown += TextBox_Buscar;
            textBoxDniTestigo.KeyDown += TextBox_Buscar;
            textBoxNombreInstructor.KeyPress += TextBox_KeyPress;
            textBoxNombreTestigo.KeyPress += TextBox_KeyPress;
            textBoxNombreDescr_Prop.KeyPress += TextBox_KeyPress;
            textBoxOcupacion.KeyPress += TextBox_KeyPress;
            textBoxTelefono.KeyPress += TextBox_KeyPress;
            textBoxDomicilio.KeyPress += TextBox_KeyPress;
        }
        void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NoSaltosDelinea(e);
        }

        void TextBox_Buscar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                buttonBuscar_Click(null, null);
            }
        }

        #endregion
        void FormPersonas_FormClosing(object sender, FormClosingEventArgs e)
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
        void comboBoxTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Seleccion) // SI NO HAY SELECCION
            {
                Habilitar();
                LimpiarCampos();
            }
        }
    }
}

