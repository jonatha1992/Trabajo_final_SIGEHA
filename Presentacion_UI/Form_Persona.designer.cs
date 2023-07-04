namespace Presentacion_UI
{
    partial class Form_Persona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Persona));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoPersona = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.textBoxNombreApellido = new System.Windows.Forms.TextBox();
            this.textBoxOcupacion = new System.Windows.Forms.TextBox();
            this.labelOcupacion = new System.Windows.Forms.Label();
            this.textBoxTelefono_DNI = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.buttonEleminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label_DNI_PAS = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxJerarquia = new System.Windows.Forms.ComboBox();
            this.labelJerarquia = new System.Windows.Forms.Label();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.DgvPersonas = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 67);
            this.panel2.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intervenientes";
            // 
            // comboBoxTipoPersona
            // 
            this.comboBoxTipoPersona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTipoPersona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoPersona.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoPersona.FormattingEnabled = true;
            this.comboBoxTipoPersona.Location = new System.Drawing.Point(166, 82);
            this.comboBoxTipoPersona.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipoPersona.Name = "comboBoxTipoPersona";
            this.comboBoxTipoPersona.Size = new System.Drawing.Size(170, 27);
            this.comboBoxTipoPersona.TabIndex = 55;
            this.comboBoxTipoPersona.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoPersona_SelectedIndexChanged);
            this.comboBoxTipoPersona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCategoria_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(42, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tipo de Actor:";
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelNombreCompleto.ForeColor = System.Drawing.Color.White;
            this.labelNombreCompleto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNombreCompleto.Location = new System.Drawing.Point(6, 169);
            this.labelNombreCompleto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(150, 18);
            this.labelNombreCompleto.TabIndex = 56;
            this.labelNombreCompleto.Text = "Apellido y Nombre:";
            // 
            // textBoxNombreApellido
            // 
            this.textBoxNombreApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNombreApellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNombreApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNombreApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreApellido.Location = new System.Drawing.Point(166, 166);
            this.textBoxNombreApellido.Multiline = true;
            this.textBoxNombreApellido.Name = "textBoxNombreApellido";
            this.textBoxNombreApellido.Size = new System.Drawing.Size(248, 25);
            this.textBoxNombreApellido.TabIndex = 58;
            this.textBoxNombreApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreApellido_KeyPress);
            // 
            // textBoxOcupacion
            // 
            this.textBoxOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxOcupacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOcupacion.Location = new System.Drawing.Point(166, 205);
            this.textBoxOcupacion.Multiline = true;
            this.textBoxOcupacion.Name = "textBoxOcupacion";
            this.textBoxOcupacion.Size = new System.Drawing.Size(267, 27);
            this.textBoxOcupacion.TabIndex = 63;
            this.textBoxOcupacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOcupacion_KeyPress);
            // 
            // labelOcupacion
            // 
            this.labelOcupacion.AutoSize = true;
            this.labelOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelOcupacion.ForeColor = System.Drawing.Color.White;
            this.labelOcupacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelOcupacion.Location = new System.Drawing.Point(62, 212);
            this.labelOcupacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOcupacion.Name = "labelOcupacion";
            this.labelOcupacion.Size = new System.Drawing.Size(94, 18);
            this.labelOcupacion.TabIndex = 62;
            this.labelOcupacion.Text = "Ocupación:";
            // 
            // textBoxTelefono_DNI
            // 
            this.textBoxTelefono_DNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTelefono_DNI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono_DNI.Location = new System.Drawing.Point(166, 244);
            this.textBoxTelefono_DNI.Multiline = true;
            this.textBoxTelefono_DNI.Name = "textBoxTelefono_DNI";
            this.textBoxTelefono_DNI.Size = new System.Drawing.Size(267, 25);
            this.textBoxTelefono_DNI.TabIndex = 65;
            this.textBoxTelefono_DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelTelefono.ForeColor = System.Drawing.Color.White;
            this.labelTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTelefono.Location = new System.Drawing.Point(77, 251);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(79, 18);
            this.labelTelefono.TabIndex = 64;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Aceptar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_Aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Aceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Aceptar.Location = new System.Drawing.Point(735, 326);
            this.button_Aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(131, 34);
            this.button_Aceptar.TabIndex = 66;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = false;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDomicilio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDomicilio.Location = new System.Drawing.Point(166, 283);
            this.textBoxDomicilio.Multiline = true;
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(267, 25);
            this.textBoxDomicilio.TabIndex = 69;
            this.textBoxDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDomicilio_KeyPress);
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelDomicilio.ForeColor = System.Drawing.Color.White;
            this.labelDomicilio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDomicilio.Location = new System.Drawing.Point(72, 290);
            this.labelDomicilio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(84, 18);
            this.labelDomicilio.TabIndex = 68;
            this.labelDomicilio.Text = "Domicilio:";
            // 
            // buttonEleminar
            // 
            this.buttonEleminar.BackColor = System.Drawing.Color.Tomato;
            this.buttonEleminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold);
            this.buttonEleminar.ForeColor = System.Drawing.Color.Black;
            this.buttonEleminar.Image = global::Presentacion_UI.Properties.Resources.basura;
            this.buttonEleminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEleminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEleminar.Location = new System.Drawing.Point(330, 323);
            this.buttonEleminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEleminar.Name = "buttonEleminar";
            this.buttonEleminar.Size = new System.Drawing.Size(107, 35);
            this.buttonEleminar.TabIndex = 72;
            this.buttonEleminar.Text = "Eliminar";
            this.buttonEleminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEleminar.UseVisualStyleBackColor = false;
            this.buttonEleminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.Yellow;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold);
            this.buttonModificar.ForeColor = System.Drawing.Color.Black;
            this.buttonModificar.Image = global::Presentacion_UI.Properties.Resources.boton_editar;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonModificar.Location = new System.Drawing.Point(197, 324);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(111, 35);
            this.buttonModificar.TabIndex = 71;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold);
            this.buttonAgregar.ForeColor = System.Drawing.Color.Black;
            this.buttonAgregar.Image = global::Presentacion_UI.Properties.Resources.boton_agregar_Elemento;
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAgregar.Location = new System.Drawing.Point(80, 324);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(98, 35);
            this.buttonAgregar.TabIndex = 70;
            this.buttonAgregar.Text = "AgregarEvento";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label_DNI_PAS
            // 
            this.label_DNI_PAS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_DNI_PAS.AutoSize = true;
            this.label_DNI_PAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.label_DNI_PAS.ForeColor = System.Drawing.Color.White;
            this.label_DNI_PAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_DNI_PAS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_DNI_PAS.Location = new System.Drawing.Point(62, 130);
            this.label_DNI_PAS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DNI_PAS.Name = "label_DNI_PAS";
            this.label_DNI_PAS.Size = new System.Drawing.Size(93, 18);
            this.label_DNI_PAS.TabIndex = 75;
            this.label_DNI_PAS.Text = "D.N.I /PAS:";
            this.label_DNI_PAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxId
            // 
            this.textBoxId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(165, 127);
            this.textBoxId.MaxLength = 10;
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(170, 25);
            this.textBoxId.TabIndex = 77;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBuscar.Image = global::Presentacion_UI.Properties.Resources.lupa;
            this.buttonBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscar.Location = new System.Drawing.Point(347, 106);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(92, 45);
            this.buttonBuscar.TabIndex = 82;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxJerarquia
            // 
            this.comboBoxJerarquia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxJerarquia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxJerarquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJerarquia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJerarquia.FormattingEnabled = true;
            this.comboBoxJerarquia.Location = new System.Drawing.Point(166, 205);
            this.comboBoxJerarquia.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxJerarquia.Name = "comboBoxJerarquia";
            this.comboBoxJerarquia.Size = new System.Drawing.Size(248, 27);
            this.comboBoxJerarquia.TabIndex = 83;
            // 
            // labelJerarquia
            // 
            this.labelJerarquia.AutoSize = true;
            this.labelJerarquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelJerarquia.ForeColor = System.Drawing.Color.White;
            this.labelJerarquia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelJerarquia.Location = new System.Drawing.Point(73, 212);
            this.labelJerarquia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJerarquia.Name = "labelJerarquia";
            this.labelJerarquia.Size = new System.Drawing.Size(83, 18);
            this.labelJerarquia.TabIndex = 84;
            this.labelJerarquia.Text = "Jerarquia:";
            this.labelJerarquia.Visible = false;
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelLegajo.ForeColor = System.Drawing.Color.White;
            this.labelLegajo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLegajo.Location = new System.Drawing.Point(92, 130);
            this.labelLegajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(63, 18);
            this.labelLegajo.TabIndex = 85;
            this.labelLegajo.Text = "Legajo:";
            this.labelLegajo.Visible = false;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelDNI.ForeColor = System.Drawing.Color.White;
            this.labelDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDNI.Location = new System.Drawing.Point(114, 251);
            this.labelDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(41, 18);
            this.labelDNI.TabIndex = 86;
            this.labelDNI.Text = "DNI:";
            this.labelDNI.Visible = false;
            // 
            // DgvPersonas
            // 
            this.DgvPersonas.AllowUserToAddRows = false;
            this.DgvPersonas.AllowUserToDeleteRows = false;
            this.DgvPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPersonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPersonas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPersonas.Location = new System.Drawing.Point(498, 80);
            this.DgvPersonas.Margin = new System.Windows.Forms.Padding(2);
            this.DgvPersonas.MultiSelect = false;
            this.DgvPersonas.Name = "DgvPersonas";
            this.DgvPersonas.ReadOnly = true;
            this.DgvPersonas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPersonas.RowHeadersVisible = false;
            this.DgvPersonas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DgvPersonas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvPersonas.RowTemplate.Height = 60;
            this.DgvPersonas.RowTemplate.ReadOnly = true;
            this.DgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPersonas.Size = new System.Drawing.Size(475, 228);
            this.DgvPersonas.TabIndex = 87;
            this.DgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPersonas_CellContentClick);
            this.DgvPersonas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvPersonas_RowsAdded);
            this.DgvPersonas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvPersonas_RowsRemoved);
            // 
            // Sel
            // 
            this.Sel.FalseValue = "";
            this.Sel.HeaderText = "Sel";
            this.Sel.IndeterminateValue = "";
            this.Sel.Name = "Sel";
            this.Sel.ReadOnly = true;
            this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sel.TrueValue = "";
            this.Sel.Visible = false;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimpiar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLimpiar.Image = global::Presentacion_UI.Properties.Resources.volver_flecha;
            this.buttonLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLimpiar.Location = new System.Drawing.Point(448, 105);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(32, 45);
            this.buttonLimpiar.TabIndex = 88;
            this.buttonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 371);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.DgvPersonas);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelLegajo);
            this.Controls.Add(this.labelJerarquia);
            this.Controls.Add(this.comboBoxJerarquia);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label_DNI_PAS);
            this.Controls.Add(this.buttonEleminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxDomicilio);
            this.Controls.Add(this.labelDomicilio);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.textBoxTelefono_DNI);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxOcupacion);
            this.Controls.Add(this.labelOcupacion);
            this.Controls.Add(this.textBoxNombreApellido);
            this.Controls.Add(this.labelNombreCompleto);
            this.Controls.Add(this.comboBoxTipoPersona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Persona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intervinientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPersonas_FormClosing);
            this.Load += new System.EventHandler(this.FormPersonas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.TextBox textBoxNombreApellido;
        private System.Windows.Forms.TextBox textBoxOcupacion;
        private System.Windows.Forms.Label labelOcupacion;
        private System.Windows.Forms.TextBox textBoxTelefono_DNI;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.Button buttonEleminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label_DNI_PAS;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxJerarquia;
        private System.Windows.Forms.Label labelJerarquia;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.DataGridView DgvPersonas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}