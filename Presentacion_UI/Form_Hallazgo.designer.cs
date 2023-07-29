namespace Presentacion_UI
{
    partial class Form_Hallazgo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Hallazgo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHallazgos = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEstado = new System.Windows.Forms.Label();
            this.groupBoxDatosHallazgo = new System.Windows.Forms.GroupBox();
            this.buttonFinalizarHallazgo = new Seguridad.RJButton();
            this.buttonEliminar = new Seguridad.RJButton();
            this.checkBoxObservacion = new System.Windows.Forms.CheckBox();
            this.button_Modificar = new Seguridad.RJButton();
            this.button_Agregar = new Seguridad.RJButton();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.comboBoxUrsa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNroActa = new System.Windows.Forms.TextBox();
            this.comboBoxUnidad = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaHallazgo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNroHallazgo = new System.Windows.Forms.Label();
            this.textBoxLugar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHallazgo = new System.Windows.Forms.Label();
            this.groupBoxDatosElementos = new System.Windows.Forms.GroupBox();
            this.btnEliminarElemento = new Seguridad.RJButton();
            this.btnModificarElemento = new Seguridad.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarElemento = new Seguridad.RJButton();
            this.NUPCantidad = new System.Windows.Forms.NumericUpDown();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.DgvElementos = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCargarPersonas = new Seguridad.RJButton();
            this.buttonImprimir = new Seguridad.RJButton();
            this.customTitleBar1 = new Seguridad.CustomTitleBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallazgos)).BeginInit();
            this.groupBoxDatosHallazgo.SuspendLayout();
            this.groupBoxDatosElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHallazgos
            // 
            this.dgvHallazgos.AllowUserToAddRows = false;
            this.dgvHallazgos.AllowUserToDeleteRows = false;
            this.dgvHallazgos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHallazgos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvHallazgos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHallazgos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHallazgos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            resources.ApplyResources(this.dgvHallazgos, "dgvHallazgos");
            this.dgvHallazgos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHallazgos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvHallazgos.EnableHeadersVisualStyles = false;
            this.dgvHallazgos.MultiSelect = false;
            this.dgvHallazgos.Name = "dgvHallazgos";
            this.dgvHallazgos.ReadOnly = true;
            this.dgvHallazgos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvHallazgos.RowHeadersVisible = false;
            this.dgvHallazgos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.dgvHallazgos.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvHallazgos.RowTemplate.Height = 32;
            this.dgvHallazgos.RowTemplate.ReadOnly = true;
            this.dgvHallazgos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHallazgos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHallazgos_CellContentClick);
            // 
            // Seleccion
            // 
            this.Seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seleccion.FillWeight = 30F;
            resources.ApplyResources(this.Seleccion, "Seleccion");
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.ReadOnly = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // labelEstado
            // 
            resources.ApplyResources(this.labelEstado, "labelEstado");
            this.labelEstado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEstado.Name = "labelEstado";
            // 
            // groupBoxDatosHallazgo
            // 
            this.groupBoxDatosHallazgo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDatosHallazgo.Controls.Add(this.buttonFinalizarHallazgo);
            this.groupBoxDatosHallazgo.Controls.Add(this.buttonEliminar);
            this.groupBoxDatosHallazgo.Controls.Add(this.checkBoxObservacion);
            this.groupBoxDatosHallazgo.Controls.Add(this.button_Modificar);
            this.groupBoxDatosHallazgo.Controls.Add(this.button_Agregar);
            this.groupBoxDatosHallazgo.Controls.Add(this.textBoxObservacion);
            this.groupBoxDatosHallazgo.Controls.Add(this.comboBoxUrsa);
            this.groupBoxDatosHallazgo.Controls.Add(this.label5);
            this.groupBoxDatosHallazgo.Controls.Add(this.textBoxNroActa);
            this.groupBoxDatosHallazgo.Controls.Add(this.comboBoxUnidad);
            this.groupBoxDatosHallazgo.Controls.Add(this.label13);
            this.groupBoxDatosHallazgo.Controls.Add(this.dateTimePickerFechaHallazgo);
            this.groupBoxDatosHallazgo.Controls.Add(this.label4);
            this.groupBoxDatosHallazgo.Controls.Add(this.labelNroHallazgo);
            this.groupBoxDatosHallazgo.Controls.Add(this.textBoxLugar);
            this.groupBoxDatosHallazgo.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBoxDatosHallazgo, "groupBoxDatosHallazgo");
            this.groupBoxDatosHallazgo.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatosHallazgo.Name = "groupBoxDatosHallazgo";
            this.groupBoxDatosHallazgo.TabStop = false;
            // 
            // buttonFinalizarHallazgo
            // 
            this.buttonFinalizarHallazgo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFinalizarHallazgo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFinalizarHallazgo.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonFinalizarHallazgo.BorderRadius = 20;
            this.buttonFinalizarHallazgo.BorderSize = 2;
            this.buttonFinalizarHallazgo.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonFinalizarHallazgo, "buttonFinalizarHallazgo");
            this.buttonFinalizarHallazgo.ForeColor = System.Drawing.Color.White;
            this.buttonFinalizarHallazgo.Name = "buttonFinalizarHallazgo";
            this.buttonFinalizarHallazgo.TextColor = System.Drawing.Color.White;
            this.buttonFinalizarHallazgo.UseVisualStyleBackColor = false;
            this.buttonFinalizarHallazgo.Click += new System.EventHandler(this.buttonFinalizarHallazgo_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonEliminar.BorderColor = System.Drawing.Color.White;
            this.buttonEliminar.BorderRadius = 20;
            this.buttonEliminar.BorderSize = 1;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonEliminar, "buttonEliminar");
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.TextColor = System.Drawing.Color.White;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // checkBoxObservacion
            // 
            resources.ApplyResources(this.checkBoxObservacion, "checkBoxObservacion");
            this.checkBoxObservacion.Name = "checkBoxObservacion";
            this.checkBoxObservacion.UseVisualStyleBackColor = true;
            this.checkBoxObservacion.CheckedChanged += new System.EventHandler(this.checkBoxObservacion_CheckedChanged);
            // 
            // button_Modificar
            // 
            this.button_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button_Modificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button_Modificar.BorderColor = System.Drawing.Color.White;
            this.button_Modificar.BorderRadius = 20;
            this.button_Modificar.BorderSize = 1;
            this.button_Modificar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Modificar, "button_Modificar");
            this.button_Modificar.ForeColor = System.Drawing.Color.Black;
            this.button_Modificar.Image = global::Presentacion_UI.Properties.Resources.boton_editar;
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.TextColor = System.Drawing.Color.Black;
            this.button_Modificar.UseVisualStyleBackColor = false;
            this.button_Modificar.Click += new System.EventHandler(this.button_Modificar_Click);
            // 
            // button_Agregar
            // 
            this.button_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button_Agregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button_Agregar.BorderColor = System.Drawing.Color.White;
            this.button_Agregar.BorderRadius = 20;
            this.button_Agregar.BorderSize = 1;
            this.button_Agregar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Agregar, "button_Agregar");
            this.button_Agregar.ForeColor = System.Drawing.Color.White;
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.TextColor = System.Drawing.Color.White;
            this.button_Agregar.UseVisualStyleBackColor = false;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBoxObservacion, "textBoxObservacion");
            this.textBoxObservacion.Name = "textBoxObservacion";
            // 
            // comboBoxUrsa
            // 
            this.comboBoxUrsa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUrsa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxUrsa, "comboBoxUrsa");
            this.comboBoxUrsa.FormattingEnabled = true;
            this.comboBoxUrsa.Name = "comboBoxUrsa";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // textBoxNroActa
            // 
            resources.ApplyResources(this.textBoxNroActa, "textBoxNroActa");
            this.textBoxNroActa.Name = "textBoxNroActa";
            this.textBoxNroActa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNroActa_KeyPress);
            // 
            // comboBoxUnidad
            // 
            this.comboBoxUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxUnidad, "comboBoxUnidad");
            this.comboBoxUnidad.FormattingEnabled = true;
            this.comboBoxUnidad.Name = "comboBoxUnidad";
            this.comboBoxUnidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnidad_SelectedIndexChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Name = "label13";
            // 
            // dateTimePickerFechaHallazgo
            // 
            resources.ApplyResources(this.dateTimePickerFechaHallazgo, "dateTimePickerFechaHallazgo");
            this.dateTimePickerFechaHallazgo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaHallazgo.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFechaHallazgo.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaHallazgo.Name = "dateTimePickerFechaHallazgo";
            this.dateTimePickerFechaHallazgo.Value = new System.DateTime(2023, 7, 2, 17, 6, 30, 441);
            this.dateTimePickerFechaHallazgo.ValueChanged += new System.EventHandler(this.dateTimePickerFechaHallazgo_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // labelNroHallazgo
            // 
            resources.ApplyResources(this.labelNroHallazgo, "labelNroHallazgo");
            this.labelNroHallazgo.ForeColor = System.Drawing.Color.White;
            this.labelNroHallazgo.Name = "labelNroHallazgo";
            // 
            // textBoxLugar
            // 
            this.textBoxLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBoxLugar, "textBoxLugar");
            this.textBoxLugar.Name = "textBoxLugar";
            this.textBoxLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLugar_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // labelHallazgo
            // 
            resources.ApplyResources(this.labelHallazgo, "labelHallazgo");
            this.labelHallazgo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHallazgo.Name = "labelHallazgo";
            // 
            // groupBoxDatosElementos
            // 
            resources.ApplyResources(this.groupBoxDatosElementos, "groupBoxDatosElementos");
            this.groupBoxDatosElementos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDatosElementos.Controls.Add(this.btnEliminarElemento);
            this.groupBoxDatosElementos.Controls.Add(this.btnModificarElemento);
            this.groupBoxDatosElementos.Controls.Add(this.label6);
            this.groupBoxDatosElementos.Controls.Add(this.btnAgregarElemento);
            this.groupBoxDatosElementos.Controls.Add(this.NUPCantidad);
            this.groupBoxDatosElementos.Controls.Add(this.comboBoxEstado);
            this.groupBoxDatosElementos.Controls.Add(this.label11);
            this.groupBoxDatosElementos.Controls.Add(this.textBoxDescripcion);
            this.groupBoxDatosElementos.Controls.Add(this.label10);
            this.groupBoxDatosElementos.Controls.Add(this.comboBoxCategoria);
            this.groupBoxDatosElementos.Controls.Add(this.label2);
            this.groupBoxDatosElementos.Controls.Add(this.label9);
            this.groupBoxDatosElementos.Controls.Add(this.label8);
            this.groupBoxDatosElementos.Controls.Add(this.comboBoxArticulo);
            this.groupBoxDatosElementos.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatosElementos.Name = "groupBoxDatosElementos";
            this.groupBoxDatosElementos.TabStop = false;
            // 
            // btnEliminarElemento
            // 
            this.btnEliminarElemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEliminarElemento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEliminarElemento.BorderColor = System.Drawing.Color.White;
            this.btnEliminarElemento.BorderRadius = 20;
            this.btnEliminarElemento.BorderSize = 1;
            this.btnEliminarElemento.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnEliminarElemento, "btnEliminarElemento");
            this.btnEliminarElemento.ForeColor = System.Drawing.Color.White;
            this.btnEliminarElemento.Name = "btnEliminarElemento";
            this.btnEliminarElemento.TextColor = System.Drawing.Color.White;
            this.btnEliminarElemento.UseVisualStyleBackColor = false;
            this.btnEliminarElemento.Click += new System.EventHandler(this.btnEliminarElemento_Click);
            // 
            // btnModificarElemento
            // 
            this.btnModificarElemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnModificarElemento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnModificarElemento.BorderColor = System.Drawing.Color.White;
            this.btnModificarElemento.BorderRadius = 20;
            this.btnModificarElemento.BorderSize = 1;
            this.btnModificarElemento.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnModificarElemento, "btnModificarElemento");
            this.btnModificarElemento.ForeColor = System.Drawing.Color.Black;
            this.btnModificarElemento.Image = global::Presentacion_UI.Properties.Resources.boton_editar;
            this.btnModificarElemento.Name = "btnModificarElemento";
            this.btnModificarElemento.TextColor = System.Drawing.Color.Black;
            this.btnModificarElemento.UseVisualStyleBackColor = false;
            this.btnModificarElemento.Click += new System.EventHandler(this.btnModificarElemento_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnAgregarElemento
            // 
            this.btnAgregarElemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnAgregarElemento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnAgregarElemento.BorderColor = System.Drawing.Color.White;
            this.btnAgregarElemento.BorderRadius = 20;
            this.btnAgregarElemento.BorderSize = 1;
            this.btnAgregarElemento.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAgregarElemento, "btnAgregarElemento");
            this.btnAgregarElemento.ForeColor = System.Drawing.Color.White;
            this.btnAgregarElemento.Name = "btnAgregarElemento";
            this.btnAgregarElemento.TextColor = System.Drawing.Color.White;
            this.btnAgregarElemento.UseVisualStyleBackColor = false;
            this.btnAgregarElemento.Click += new System.EventHandler(this.btnAgregarElemento_Click);
            // 
            // NUPCantidad
            // 
            this.NUPCantidad.DecimalPlaces = 2;
            resources.ApplyResources(this.NUPCantidad, "NUPCantidad");
            this.NUPCantidad.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.NUPCantidad.Name = "NUPCantidad";
            this.NUPCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxEstado, "comboBoxEstado");
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Name = "comboBoxEstado";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBoxDescripcion, "textBoxDescripcion");
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxCategoria, "comboBoxCategoria");
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // comboBoxArticulo
            // 
            this.comboBoxArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxArticulo, "comboBoxArticulo");
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxArticulo_KeyDown);
            // 
            // DgvElementos
            // 
            this.DgvElementos.AllowUserToAddRows = false;
            this.DgvElementos.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.DgvElementos, "DgvElementos");
            this.DgvElementos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvElementos.BackgroundColor = System.Drawing.Color.Black;
            this.DgvElementos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvElementos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvElementos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvElementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.DefaultCellStyle = dataGridViewCellStyle22;
            this.DgvElementos.EnableHeadersVisualStyles = false;
            this.DgvElementos.MultiSelect = false;
            this.DgvElementos.Name = "DgvElementos";
            this.DgvElementos.ReadOnly = true;
            this.DgvElementos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.DgvElementos.RowHeadersVisible = false;
            this.DgvElementos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.DgvElementos.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.DgvElementos.RowTemplate.Height = 30;
            this.DgvElementos.RowTemplate.ReadOnly = true;
            this.DgvElementos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvElementos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewElementos_CellContentClick);
            // 
            // Sel
            // 
            this.Sel.FalseValue = "";
            resources.ApplyResources(this.Sel, "Sel");
            this.Sel.IndeterminateValue = "";
            this.Sel.Name = "Sel";
            this.Sel.ReadOnly = true;
            this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sel.TrueValue = "";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Name = "label7";
            // 
            // buttonCargarPersonas
            // 
            this.buttonCargarPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonCargarPersonas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonCargarPersonas.BorderColor = System.Drawing.Color.White;
            this.buttonCargarPersonas.BorderRadius = 20;
            this.buttonCargarPersonas.BorderSize = 1;
            this.buttonCargarPersonas.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonCargarPersonas, "buttonCargarPersonas");
            this.buttonCargarPersonas.ForeColor = System.Drawing.Color.White;
            this.buttonCargarPersonas.Name = "buttonCargarPersonas";
            this.buttonCargarPersonas.TextColor = System.Drawing.Color.White;
            this.buttonCargarPersonas.UseVisualStyleBackColor = false;
            this.buttonCargarPersonas.Click += new System.EventHandler(this.buttonCargarPersonas_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonImprimir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonImprimir.BorderColor = System.Drawing.Color.White;
            this.buttonImprimir.BorderRadius = 20;
            this.buttonImprimir.BorderSize = 1;
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonImprimir, "buttonImprimir");
            this.buttonImprimir.ForeColor = System.Drawing.Color.White;
            this.buttonImprimir.Image = global::Presentacion_UI.Properties.Resources.impresora__2_;
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.TextColor = System.Drawing.Color.White;
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.BackColor = System.Drawing.Color.SlateGray;
            this.customTitleBar1.CloseButtonVisible = true;
            resources.ApplyResources(this.customTitleBar1, "customTitleBar1");
            this.customTitleBar1.Icon = ((System.Drawing.Image)(resources.GetObject("customTitleBar1.Icon")));
            this.customTitleBar1.MaximizeButtonVisible = true;
            this.customTitleBar1.MinimizeButtonVisible = true;
            this.customTitleBar1.Name = "customTitleBar1";
            this.customTitleBar1.Title = "Creación Hallazgos";
            // 
            // Form_Hallazgo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.customTitleBar1);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonCargarPersonas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvElementos);
            this.Controls.Add(this.groupBoxDatosElementos);
            this.Controls.Add(this.labelHallazgo);
            this.Controls.Add(this.groupBoxDatosHallazgo);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.dgvHallazgos);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Hallazgo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Hallazgo_FormClosing);
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallazgos)).EndInit();
            this.groupBoxDatosHallazgo.ResumeLayout(false);
            this.groupBoxDatosHallazgo.PerformLayout();
            this.groupBoxDatosElementos.ResumeLayout(false);
            this.groupBoxDatosElementos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvElementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHallazgos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.GroupBox groupBoxDatosHallazgo;
        private System.Windows.Forms.TextBox textBoxNroActa;
        private System.Windows.Forms.ComboBox comboBoxUnidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHallazgo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNroHallazgo;
        private System.Windows.Forms.TextBox textBoxLugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHallazgo;
        private System.Windows.Forms.GroupBox groupBoxDatosElementos;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxArticulo;
        private System.Windows.Forms.DataGridView DgvElementos;
        private System.Windows.Forms.NumericUpDown NUPCantidad;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.ComboBox comboBoxUrsa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxObservacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private Seguridad.RJButton buttonEliminar;
        private Seguridad.RJButton button_Modificar;
        private Seguridad.RJButton button_Agregar;
        private Seguridad.RJButton buttonFinalizarHallazgo;
        private Seguridad.RJButton btnEliminarElemento;
        private Seguridad.RJButton btnModificarElemento;
        private Seguridad.RJButton btnAgregarElemento;
        private Seguridad.RJButton buttonCargarPersonas;
        private Seguridad.RJButton buttonImprimir;
        private Seguridad.CustomTitleBar customTitleBar1;
    }
}

