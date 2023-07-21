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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Persona));
            this.comboBoxTipoPersona = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOcupacion = new System.Windows.Forms.TextBox();
            this.labelOcupacion = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.DgvPersonas = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInstructor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDniInstructor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelJerarquia = new System.Windows.Forms.Label();
            this.comboBoxJerarquia = new System.Windows.Forms.ComboBox();
            this.textBoxNombreInstructor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLegajo = new System.Windows.Forms.TextBox();
            this.panelDescubridor = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNombreDescr_Prop = new System.Windows.Forms.TextBox();
            this.textBoxDniDescubridor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTestigo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombreTestigo = new System.Windows.Forms.TextBox();
            this.textBoxDniTestigo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customTitleBar1 = new Seguridad.CustomTitleBar();
            this.buttonAgregar = new Seguridad.RJButton();
            this.buttonLimpiar = new Seguridad.RJButton();
            this.buttonBuscar = new Seguridad.RJButton();
            this.buttonModificar = new Seguridad.RJButton();
            this.buttonEliminar = new Seguridad.RJButton();
            this.button_Aceptar = new Seguridad.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).BeginInit();
            this.panelInstructor.SuspendLayout();
            this.panelDescubridor.SuspendLayout();
            this.panelTestigo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTipoPersona
            // 
            this.comboBoxTipoPersona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTipoPersona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoPersona.FormattingEnabled = true;
            this.comboBoxTipoPersona.Location = new System.Drawing.Point(167, 50);
            this.comboBoxTipoPersona.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipoPersona.Name = "comboBoxTipoPersona";
            this.comboBoxTipoPersona.Size = new System.Drawing.Size(170, 23);
            this.comboBoxTipoPersona.TabIndex = 1;
            this.comboBoxTipoPersona.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoPersona_SelectedIndexChanged);
            this.comboBoxTipoPersona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCategoria_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(61, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tipo de Actor:";
            // 
            // textBoxOcupacion
            // 
            this.textBoxOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOcupacion.Location = new System.Drawing.Point(151, 64);
            this.textBoxOcupacion.Name = "textBoxOcupacion";
            this.textBoxOcupacion.Size = new System.Drawing.Size(267, 21);
            this.textBoxOcupacion.TabIndex = 4;
            // 
            // labelOcupacion
            // 
            this.labelOcupacion.AutoSize = true;
            this.labelOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOcupacion.ForeColor = System.Drawing.Color.White;
            this.labelOcupacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelOcupacion.Location = new System.Drawing.Point(62, 69);
            this.labelOcupacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOcupacion.Name = "labelOcupacion";
            this.labelOcupacion.Size = new System.Drawing.Size(79, 15);
            this.labelOcupacion.TabIndex = 62;
            this.labelOcupacion.Text = "Ocupación:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(151, 130);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(191, 21);
            this.textBoxTelefono.TabIndex = 6;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.Color.White;
            this.labelTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTelefono.Location = new System.Drawing.Point(74, 133);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(67, 15);
            this.labelTelefono.TabIndex = 64;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDomicilio.Location = new System.Drawing.Point(150, 98);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(267, 21);
            this.textBoxDomicilio.TabIndex = 5;
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomicilio.ForeColor = System.Drawing.Color.White;
            this.labelDomicilio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDomicilio.Location = new System.Drawing.Point(69, 103);
            this.labelDomicilio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(72, 15);
            this.labelDomicilio.TabIndex = 68;
            this.labelDomicilio.Text = "Domicilio:";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.ForeColor = System.Drawing.Color.White;
            this.labelDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDNI.Location = new System.Drawing.Point(111, 8);
            this.labelDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(35, 15);
            this.labelDNI.TabIndex = 86;
            this.labelDNI.Text = "DNI:";
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
            this.DgvPersonas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvPersonas.EnableHeadersVisualStyles = false;
            this.DgvPersonas.Location = new System.Drawing.Point(510, 70);
            this.DgvPersonas.Margin = new System.Windows.Forms.Padding(2);
            this.DgvPersonas.MultiSelect = false;
            this.DgvPersonas.Name = "DgvPersonas";
            this.DgvPersonas.ReadOnly = true;
            this.DgvPersonas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvPersonas.RowHeadersVisible = false;
            this.DgvPersonas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.DgvPersonas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvPersonas.RowTemplate.Height = 60;
            this.DgvPersonas.RowTemplate.ReadOnly = true;
            this.DgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPersonas.Size = new System.Drawing.Size(498, 175);
            this.DgvPersonas.TabIndex = 87;
            this.DgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPersonas_CellContentClick);
            this.DgvPersonas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvPersonas_RowsAdded);
            this.DgvPersonas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvPersonas_RowsRemoved);
            // 
            // Sel
            // 
            this.Sel.FalseValue = "";
            this.Sel.HeaderText = "";
            this.Sel.IndeterminateValue = "";
            this.Sel.Name = "Sel";
            this.Sel.ReadOnly = true;
            this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sel.TrueValue = "";
            this.Sel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(704, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 89;
            this.label1.Text = "Intervinientes";
            // 
            // panelInstructor
            // 
            this.panelInstructor.Controls.Add(this.label3);
            this.panelInstructor.Controls.Add(this.textBoxDniInstructor);
            this.panelInstructor.Controls.Add(this.label6);
            this.panelInstructor.Controls.Add(this.labelJerarquia);
            this.panelInstructor.Controls.Add(this.comboBoxJerarquia);
            this.panelInstructor.Controls.Add(this.textBoxNombreInstructor);
            this.panelInstructor.Controls.Add(this.label2);
            this.panelInstructor.Controls.Add(this.textBoxLegajo);
            this.panelInstructor.Location = new System.Drawing.Point(3, 178);
            this.panelInstructor.Name = "panelInstructor";
            this.panelInstructor.Size = new System.Drawing.Size(465, 131);
            this.panelInstructor.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 96;
            this.label3.Text = "Nombre completo:";
            // 
            // textBoxDniInstructor
            // 
            this.textBoxDniInstructor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxDniInstructor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDniInstructor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDniInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDniInstructor.Location = new System.Drawing.Point(150, 34);
            this.textBoxDniInstructor.MaxLength = 10;
            this.textBoxDniInstructor.Name = "textBoxDniInstructor";
            this.textBoxDniInstructor.Size = new System.Drawing.Size(170, 21);
            this.textBoxDniInstructor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(107, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 98;
            this.label6.Text = "DNI:";
            // 
            // labelJerarquia
            // 
            this.labelJerarquia.AutoSize = true;
            this.labelJerarquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJerarquia.ForeColor = System.Drawing.Color.White;
            this.labelJerarquia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelJerarquia.Location = new System.Drawing.Point(74, 104);
            this.labelJerarquia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJerarquia.Name = "labelJerarquia";
            this.labelJerarquia.Size = new System.Drawing.Size(72, 15);
            this.labelJerarquia.TabIndex = 94;
            this.labelJerarquia.Text = "Jerarquia:";
            // 
            // comboBoxJerarquia
            // 
            this.comboBoxJerarquia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxJerarquia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxJerarquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJerarquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJerarquia.FormattingEnabled = true;
            this.comboBoxJerarquia.Location = new System.Drawing.Point(149, 98);
            this.comboBoxJerarquia.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxJerarquia.Name = "comboBoxJerarquia";
            this.comboBoxJerarquia.Size = new System.Drawing.Size(248, 23);
            this.comboBoxJerarquia.TabIndex = 12;
            // 
            // textBoxNombreInstructor
            // 
            this.textBoxNombreInstructor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNombreInstructor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNombreInstructor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNombreInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreInstructor.Location = new System.Drawing.Point(149, 67);
            this.textBoxNombreInstructor.Name = "textBoxNombreInstructor";
            this.textBoxNombreInstructor.Size = new System.Drawing.Size(286, 21);
            this.textBoxNombreInstructor.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(87, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 91;
            this.label2.Text = "Legajo:";
            // 
            // textBoxLegajo
            // 
            this.textBoxLegajo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxLegajo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxLegajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLegajo.Location = new System.Drawing.Point(151, 2);
            this.textBoxLegajo.MaxLength = 10;
            this.textBoxLegajo.Name = "textBoxLegajo";
            this.textBoxLegajo.Size = new System.Drawing.Size(170, 21);
            this.textBoxLegajo.TabIndex = 9;
            // 
            // panelDescubridor
            // 
            this.panelDescubridor.Controls.Add(this.label8);
            this.panelDescubridor.Controls.Add(this.textBoxNombreDescr_Prop);
            this.panelDescubridor.Controls.Add(this.textBoxDniDescubridor);
            this.panelDescubridor.Controls.Add(this.label7);
            this.panelDescubridor.Controls.Add(this.textBoxOcupacion);
            this.panelDescubridor.Controls.Add(this.labelOcupacion);
            this.panelDescubridor.Controls.Add(this.labelDomicilio);
            this.panelDescubridor.Controls.Add(this.textBoxDomicilio);
            this.panelDescubridor.Controls.Add(this.textBoxTelefono);
            this.panelDescubridor.Controls.Add(this.labelTelefono);
            this.panelDescubridor.Location = new System.Drawing.Point(3, 3);
            this.panelDescubridor.Name = "panelDescubridor";
            this.panelDescubridor.Size = new System.Drawing.Size(457, 169);
            this.panelDescubridor.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(18, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 15);
            this.label8.TabIndex = 95;
            this.label8.Text = "Nombre completo:";
            // 
            // textBoxNombreDescr_Prop
            // 
            this.textBoxNombreDescr_Prop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNombreDescr_Prop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNombreDescr_Prop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNombreDescr_Prop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreDescr_Prop.Location = new System.Drawing.Point(151, 32);
            this.textBoxNombreDescr_Prop.Name = "textBoxNombreDescr_Prop";
            this.textBoxNombreDescr_Prop.Size = new System.Drawing.Size(267, 21);
            this.textBoxNombreDescr_Prop.TabIndex = 3;
            // 
            // textBoxDniDescubridor
            // 
            this.textBoxDniDescubridor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxDniDescubridor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDniDescubridor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDniDescubridor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDniDescubridor.Location = new System.Drawing.Point(151, 0);
            this.textBoxDniDescubridor.MaxLength = 10;
            this.textBoxDniDescubridor.Name = "textBoxDniDescubridor";
            this.textBoxDniDescubridor.Size = new System.Drawing.Size(170, 21);
            this.textBoxDniDescubridor.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(68, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 86;
            this.label7.Text = "DNI / PAS:";
            // 
            // panelTestigo
            // 
            this.panelTestigo.Controls.Add(this.label4);
            this.panelTestigo.Controls.Add(this.textBoxNombreTestigo);
            this.panelTestigo.Controls.Add(this.textBoxDniTestigo);
            this.panelTestigo.Controls.Add(this.labelDNI);
            this.panelTestigo.Location = new System.Drawing.Point(3, 315);
            this.panelTestigo.Name = "panelTestigo";
            this.panelTestigo.Size = new System.Drawing.Size(465, 73);
            this.panelTestigo.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(21, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 97;
            this.label4.Text = "Nombre completo:";
            // 
            // textBoxNombreTestigo
            // 
            this.textBoxNombreTestigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNombreTestigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNombreTestigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNombreTestigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreTestigo.Location = new System.Drawing.Point(149, 34);
            this.textBoxNombreTestigo.Name = "textBoxNombreTestigo";
            this.textBoxNombreTestigo.Size = new System.Drawing.Size(253, 21);
            this.textBoxNombreTestigo.TabIndex = 8;
            // 
            // textBoxDniTestigo
            // 
            this.textBoxDniTestigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxDniTestigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDniTestigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDniTestigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDniTestigo.Location = new System.Drawing.Point(149, 3);
            this.textBoxDniTestigo.MaxLength = 10;
            this.textBoxDniTestigo.Name = "textBoxDniTestigo";
            this.textBoxDniTestigo.Size = new System.Drawing.Size(170, 21);
            this.textBoxDniTestigo.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelDescubridor);
            this.flowLayoutPanel1.Controls.Add(this.panelInstructor);
            this.flowLayoutPanel1.Controls.Add(this.panelTestigo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(476, 175);
            this.flowLayoutPanel1.TabIndex = 95;
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.BackColor = System.Drawing.Color.SlateGray;
            this.customTitleBar1.CloseButtonVisible = true;
            this.customTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTitleBar1.Icon = ((System.Drawing.Image)(resources.GetObject("customTitleBar1.Icon")));
            this.customTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.customTitleBar1.MaximizeButtonVisible = false;
            this.customTitleBar1.MinimizeButtonVisible = false;
            this.customTitleBar1.Name = "customTitleBar1";
            this.customTitleBar1.Size = new System.Drawing.Size(1020, 25);
            this.customTitleBar1.TabIndex = 96;
            this.customTitleBar1.Title = "Interinientes";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.buttonAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.buttonAgregar.BorderColor = System.Drawing.Color.White;
            this.buttonAgregar.BorderRadius = 20;
            this.buttonAgregar.BorderSize = 0;
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.Location = new System.Drawing.Point(63, 261);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(98, 33);
            this.buttonAgregar.TabIndex = 45;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextColor = System.Drawing.Color.White;
            this.buttonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonLimpiar.BorderColor = System.Drawing.Color.Transparent;
            this.buttonLimpiar.BorderRadius = 20;
            this.buttonLimpiar.BorderSize = 0;
            this.buttonLimpiar.FlatAppearance.BorderSize = 0;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
            this.buttonLimpiar.Location = new System.Drawing.Point(433, 41);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(65, 31);
            this.buttonLimpiar.TabIndex = 45;
            this.buttonLimpiar.TextColor = System.Drawing.Color.White;
            this.buttonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonBuscar.BorderRadius = 20;
            this.buttonBuscar.BorderSize = 0;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Image = global::Presentacion_UI.Properties.Resources.lupa;
            this.buttonBuscar.Location = new System.Drawing.Point(346, 41);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(86, 31);
            this.buttonBuscar.TabIndex = 44;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextColor = System.Drawing.Color.White;
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.buttonModificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.buttonModificar.BorderColor = System.Drawing.Color.White;
            this.buttonModificar.BorderRadius = 20;
            this.buttonModificar.BorderSize = 0;
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.Color.Black;
            this.buttonModificar.Image = global::Presentacion_UI.Properties.Resources.boton_editar;
            this.buttonModificar.Location = new System.Drawing.Point(196, 261);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(105, 33);
            this.buttonModificar.TabIndex = 97;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.TextColor = System.Drawing.Color.Black;
            this.buttonModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonEliminar.BorderColor = System.Drawing.Color.White;
            this.buttonEliminar.BorderRadius = 20;
            this.buttonEliminar.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.Location = new System.Drawing.Point(335, 261);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(108, 33);
            this.buttonEliminar.TabIndex = 98;
            this.buttonEliminar.Text = "Quitar";
            this.buttonEliminar.TextColor = System.Drawing.Color.White;
            this.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Aceptar.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Aceptar.BorderColor = System.Drawing.SystemColors.Control;
            this.button_Aceptar.BorderRadius = 20;
            this.button_Aceptar.BorderSize = 2;
            this.button_Aceptar.FlatAppearance.BorderSize = 0;
            this.button_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Aceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Aceptar.ForeColor = System.Drawing.Color.White;
            this.button_Aceptar.Location = new System.Drawing.Point(897, 259);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(111, 40);
            this.button_Aceptar.TabIndex = 99;
            this.button_Aceptar.Text = "Finalizar";
            this.button_Aceptar.TextColor = System.Drawing.Color.White;
            this.button_Aceptar.UseVisualStyleBackColor = false;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // Form_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1020, 303);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.customTitleBar1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvPersonas);
            this.Controls.Add(this.comboBoxTipoPersona);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Persona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intervinientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPersonas_FormClosing);
            this.Load += new System.EventHandler(this.FormPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).EndInit();
            this.panelInstructor.ResumeLayout(false);
            this.panelInstructor.PerformLayout();
            this.panelDescubridor.ResumeLayout(false);
            this.panelDescubridor.PerformLayout();
            this.panelTestigo.ResumeLayout(false);
            this.panelTestigo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTipoPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOcupacion;
        private System.Windows.Forms.Label labelOcupacion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.DataGridView DgvPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInstructor;
        private System.Windows.Forms.TextBox textBoxNombreInstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLegajo;
        private System.Windows.Forms.Panel panelTestigo;
        private System.Windows.Forms.TextBox textBoxNombreTestigo;
        private System.Windows.Forms.TextBox textBoxDniTestigo;
        private System.Windows.Forms.Panel panelDescubridor;
        private System.Windows.Forms.TextBox textBoxNombreDescr_Prop;
        private System.Windows.Forms.TextBox textBoxDniDescubridor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelJerarquia;
        private System.Windows.Forms.ComboBox comboBoxJerarquia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDniInstructor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Seguridad.CustomTitleBar customTitleBar1;
        private Seguridad.RJButton buttonAgregar;
        private Seguridad.RJButton buttonLimpiar;
        private Seguridad.RJButton buttonBuscar;
        private Seguridad.RJButton buttonModificar;
        private Seguridad.RJButton buttonEliminar;
        private Seguridad.RJButton button_Aceptar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
    }
}