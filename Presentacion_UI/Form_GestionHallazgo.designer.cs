using System;

namespace Presentacion_UI
{
    partial class Form_GestionHallazgo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GestionHallazgo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEstado = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.DgvElementos = new System.Windows.Forms.DataGridView();
            this.customTitleBar1 = new Seguridad.CustomTitleBar();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvPersonas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLugar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaHallazgo = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxUnidad = new System.Windows.Forms.ComboBox();
            this.dgvHallazgos = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUrsa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.button_Modificar = new Seguridad.RJButton();
            this.checkBoxObservacion = new System.Windows.Forms.CheckBox();
            this.buttonEliminar = new Seguridad.RJButton();
            this.groupBoxDatosHallazgo = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new Seguridad.RJButton();
            this.dateTimePickerFechaActa = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscar = new Seguridad.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownNro = new System.Windows.Forms.NumericUpDown();
            this.labelNro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvElementos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallazgos)).BeginInit();
            this.groupBoxDatosHallazgo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNro)).BeginInit();
            this.SuspendLayout();
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
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label32.Name = "label32";
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
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.DgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.DefaultCellStyle = dataGridViewCellStyle38;
            this.DgvElementos.EnableHeadersVisualStyles = false;
            this.DgvElementos.MultiSelect = false;
            this.DgvElementos.Name = "DgvElementos";
            this.DgvElementos.ReadOnly = true;
            this.DgvElementos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.DgvElementos.RowHeadersVisible = false;
            this.DgvElementos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            this.DgvElementos.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.DgvElementos.RowTemplate.Height = 30;
            this.DgvElementos.RowTemplate.ReadOnly = true;
            this.DgvElementos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.BackColor = System.Drawing.Color.SlateGray;
            this.customTitleBar1.CloseButtonVisible = true;
            resources.ApplyResources(this.customTitleBar1, "customTitleBar1");
            this.customTitleBar1.Icon = global::Presentacion_UI.Properties.Resources.articulos_perdidos1;
            this.customTitleBar1.MaximizeButtonVisible = true;
            this.customTitleBar1.MinimizeButtonVisible = true;
            this.customTitleBar1.Name = "customTitleBar1";
            this.customTitleBar1.Title = "Gestión Hallazgo";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // DgvPersonas
            // 
            this.DgvPersonas.AllowUserToAddRows = false;
            this.DgvPersonas.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.DgvPersonas, "DgvPersonas");
            this.DgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPersonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPersonas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvPersonas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvPersonas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.DgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.DefaultCellStyle = dataGridViewCellStyle42;
            this.DgvPersonas.EnableHeadersVisualStyles = false;
            this.DgvPersonas.MultiSelect = false;
            this.DgvPersonas.Name = "DgvPersonas";
            this.DgvPersonas.ReadOnly = true;
            this.DgvPersonas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.DgvPersonas.RowHeadersVisible = false;
            this.DgvPersonas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.Black;
            this.DgvPersonas.RowsDefaultCellStyle = dataGridViewCellStyle44;
            this.DgvPersonas.RowTemplate.Height = 60;
            this.DgvPersonas.RowTemplate.ReadOnly = true;
            this.DgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // textBoxLugar
            // 
            this.textBoxLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBoxLugar, "textBoxLugar");
            this.textBoxLugar.Name = "textBoxLugar";
            this.textBoxLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLugar_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // dateTimePickerFechaHallazgo
            // 
            resources.ApplyResources(this.dateTimePickerFechaHallazgo, "dateTimePickerFechaHallazgo");
            this.dateTimePickerFechaHallazgo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaHallazgo.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFechaHallazgo.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaHallazgo.Name = "dateTimePickerFechaHallazgo";
            this.dateTimePickerFechaHallazgo.Value = new System.DateTime(2023, 8, 8, 17, 1, 45, 476);
            this.dateTimePickerFechaHallazgo.ValueChanged += new System.EventHandler(this.dateTimePickerFechaHallazgo_ValueChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Name = "label13";
            // 
            // comboBoxUnidad
            // 
            this.comboBoxUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUnidad.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxUnidad, "comboBoxUnidad");
            this.comboBoxUnidad.Name = "comboBoxUnidad";
            this.comboBoxUnidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnidad_SelectedIndexChanged);
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
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
            resources.ApplyResources(this.dgvHallazgos, "dgvHallazgos");
            this.dgvHallazgos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHallazgos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion});
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.DefaultCellStyle = dataGridViewCellStyle46;
            this.dgvHallazgos.EnableHeadersVisualStyles = false;
            this.dgvHallazgos.MultiSelect = false;
            this.dgvHallazgos.Name = "dgvHallazgos";
            this.dgvHallazgos.ReadOnly = true;
            this.dgvHallazgos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dgvHallazgos.RowHeadersVisible = false;
            this.dgvHallazgos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.Black;
            this.dgvHallazgos.RowsDefaultCellStyle = dataGridViewCellStyle48;
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // comboBoxUrsa
            // 
            this.comboBoxUrsa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUrsa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxUrsa, "comboBoxUrsa");
            this.comboBoxUrsa.FormattingEnabled = true;
            this.comboBoxUrsa.Name = "comboBoxUrsa";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Name = "label7";
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBoxObservacion, "textBoxObservacion");
            this.textBoxObservacion.Name = "textBoxObservacion";
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
            // checkBoxObservacion
            // 
            resources.ApplyResources(this.checkBoxObservacion, "checkBoxObservacion");
            this.checkBoxObservacion.Name = "checkBoxObservacion";
            this.checkBoxObservacion.UseVisualStyleBackColor = true;
            this.checkBoxObservacion.CheckedChanged += new System.EventHandler(this.checkBoxObservacion_CheckedChanged);
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
            // groupBoxDatosHallazgo
            // 
            this.groupBoxDatosHallazgo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDatosHallazgo.Controls.Add(this.labelNro);
            this.groupBoxDatosHallazgo.Controls.Add(this.numericUpDownNro);
            this.groupBoxDatosHallazgo.Controls.Add(this.label6);
            this.groupBoxDatosHallazgo.Controls.Add(this.buttonLimpiar);
            this.groupBoxDatosHallazgo.Controls.Add(this.dateTimePickerFechaActa);
            this.groupBoxDatosHallazgo.Controls.Add(this.label2);
            this.groupBoxDatosHallazgo.Controls.Add(this.buttonBuscar);
            this.groupBoxDatosHallazgo.Controls.Add(this.buttonEliminar);
            this.groupBoxDatosHallazgo.Controls.Add(this.labelEstado);
            this.groupBoxDatosHallazgo.Controls.Add(this.checkBoxObservacion);
            this.groupBoxDatosHallazgo.Controls.Add(this.button_Modificar);
            this.groupBoxDatosHallazgo.Controls.Add(this.textBoxObservacion);
            this.groupBoxDatosHallazgo.Controls.Add(this.label7);
            this.groupBoxDatosHallazgo.Controls.Add(this.comboBoxUrsa);
            this.groupBoxDatosHallazgo.Controls.Add(this.label5);
            this.groupBoxDatosHallazgo.Controls.Add(this.dgvHallazgos);
            this.groupBoxDatosHallazgo.Controls.Add(this.comboBoxUnidad);
            this.groupBoxDatosHallazgo.Controls.Add(this.label13);
            this.groupBoxDatosHallazgo.Controls.Add(this.dateTimePickerFechaHallazgo);
            this.groupBoxDatosHallazgo.Controls.Add(this.label4);
            this.groupBoxDatosHallazgo.Controls.Add(this.textBoxLugar);
            this.groupBoxDatosHallazgo.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBoxDatosHallazgo, "groupBoxDatosHallazgo");
            this.groupBoxDatosHallazgo.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatosHallazgo.Name = "groupBoxDatosHallazgo";
            this.groupBoxDatosHallazgo.TabStop = false;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonLimpiar.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLimpiar.BorderRadius = 20;
            this.buttonLimpiar.BorderSize = 1;
            this.buttonLimpiar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonLimpiar, "buttonLimpiar");
            this.buttonLimpiar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.TextColor = System.Drawing.Color.White;
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // dateTimePickerFechaActa
            // 
            resources.ApplyResources(this.dateTimePickerFechaActa, "dateTimePickerFechaActa");
            this.dateTimePickerFechaActa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaActa.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFechaActa.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaActa.Name = "dateTimePickerFechaActa";
            this.dateTimePickerFechaActa.Value = new System.DateTime(2023, 7, 2, 17, 6, 30, 441);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonBuscar.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBuscar.BorderRadius = 20;
            this.buttonBuscar.BorderSize = 1;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonBuscar, "buttonBuscar");
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Image = global::Presentacion_UI.Properties.Resources.lupa;
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.TextColor = System.Drawing.Color.White;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // numericUpDownNro
            // 
            resources.ApplyResources(this.numericUpDownNro, "numericUpDownNro");
            this.numericUpDownNro.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownNro.Name = "numericUpDownNro";
            this.numericUpDownNro.ValueChanged += new System.EventHandler(this.numericUpDownNro_ValueChanged);
            this.numericUpDownNro.Leave += new System.EventHandler(this.numericUpDownNro_Leave);
            // 
            // labelNro
            // 
            resources.ApplyResources(this.labelNro, "labelNro");
            this.labelNro.ForeColor = System.Drawing.Color.White;
            this.labelNro.Name = "labelNro";
            // 
            // Form_GestionHallazgo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvPersonas);
            this.Controls.Add(this.customTitleBar1);
            this.Controls.Add(this.DgvElementos);
            this.Controls.Add(this.groupBoxDatosHallazgo);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_GestionHallazgo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvElementos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallazgos)).EndInit();
            this.groupBoxDatosHallazgo.ResumeLayout(false);
            this.groupBoxDatosHallazgo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView DgvElementos;
        private Seguridad.CustomTitleBar customTitleBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPersonas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHallazgo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxUnidad;
        private System.Windows.Forms.DataGridView dgvHallazgos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxUrsa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private Seguridad.RJButton button_Modificar;
        private System.Windows.Forms.CheckBox checkBoxObservacion;
        private Seguridad.RJButton buttonEliminar;
        private System.Windows.Forms.GroupBox groupBoxDatosHallazgo;
        private Seguridad.RJButton buttonBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaActa;
        private System.Windows.Forms.Label label2;
        private Seguridad.RJButton buttonLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownNro;
        private System.Windows.Forms.Label labelNro;
    }
}

