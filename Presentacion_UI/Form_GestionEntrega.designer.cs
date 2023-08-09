using System;

namespace Presentacion_UI
{
    partial class Form_GestionEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GestionEntrega));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.DgvElementos = new System.Windows.Forms.DataGridView();
            this.customTitleBar1 = new Seguridad.CustomTitleBar();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvPersonas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaEntrega = new System.Windows.Forms.DateTimePicker();
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
            this.groupBoxDatosEntrega = new System.Windows.Forms.GroupBox();
            this.numericUpDownNroEntrega = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNroEntrega = new System.Windows.Forms.Label();
            this.buttonLimpiar = new Seguridad.RJButton();
            this.buttonBuscar = new Seguridad.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvElementos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallazgos)).BeginInit();
            this.groupBoxDatosEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNroEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.DgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.DefaultCellStyle = dataGridViewCellStyle26;
            this.DgvElementos.EnableHeadersVisualStyles = false;
            this.DgvElementos.MultiSelect = false;
            this.DgvElementos.Name = "DgvElementos";
            this.DgvElementos.ReadOnly = true;
            this.DgvElementos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.DgvElementos.RowHeadersVisible = false;
            this.DgvElementos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            this.DgvElementos.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.DgvElementos.RowTemplate.Height = 30;
            this.DgvElementos.RowTemplate.ReadOnly = true;
            this.DgvElementos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
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
            this.customTitleBar1.Title = "Gestión Entrega";
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
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.DgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.DefaultCellStyle = dataGridViewCellStyle30;
            this.DgvPersonas.EnableHeadersVisualStyles = false;
            this.DgvPersonas.MultiSelect = false;
            this.DgvPersonas.Name = "DgvPersonas";
            this.DgvPersonas.ReadOnly = true;
            this.DgvPersonas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.DgvPersonas.RowHeadersVisible = false;
            this.DgvPersonas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            this.DgvPersonas.RowsDefaultCellStyle = dataGridViewCellStyle32;
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // dateTimePickerFechaEntrega
            // 
            resources.ApplyResources(this.dateTimePickerFechaEntrega, "dateTimePickerFechaEntrega");
            this.dateTimePickerFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaEntrega.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFechaEntrega.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaEntrega.Name = "dateTimePickerFechaEntrega";
            this.dateTimePickerFechaEntrega.Value = new System.DateTime(2023, 8, 8, 14, 8, 34, 106);
            this.dateTimePickerFechaEntrega.ValueChanged += new System.EventHandler(this.dateTimePickerFechaHallazgo_ValueChanged);
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
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            resources.ApplyResources(this.dgvHallazgos, "dgvHallazgos");
            this.dgvHallazgos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHallazgos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion});
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvHallazgos.EnableHeadersVisualStyles = false;
            this.dgvHallazgos.MultiSelect = false;
            this.dgvHallazgos.Name = "dgvHallazgos";
            this.dgvHallazgos.ReadOnly = true;
            this.dgvHallazgos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvHallazgos.RowHeadersVisible = false;
            this.dgvHallazgos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            this.dgvHallazgos.RowsDefaultCellStyle = dataGridViewCellStyle36;
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
            // groupBoxDatosEntrega
            // 
            this.groupBoxDatosEntrega.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDatosEntrega.Controls.Add(this.numericUpDownNroEntrega);
            this.groupBoxDatosEntrega.Controls.Add(this.label6);
            this.groupBoxDatosEntrega.Controls.Add(this.labelNroEntrega);
            this.groupBoxDatosEntrega.Controls.Add(this.buttonLimpiar);
            this.groupBoxDatosEntrega.Controls.Add(this.buttonBuscar);
            this.groupBoxDatosEntrega.Controls.Add(this.buttonEliminar);
            this.groupBoxDatosEntrega.Controls.Add(this.checkBoxObservacion);
            this.groupBoxDatosEntrega.Controls.Add(this.button_Modificar);
            this.groupBoxDatosEntrega.Controls.Add(this.textBoxObservacion);
            this.groupBoxDatosEntrega.Controls.Add(this.label7);
            this.groupBoxDatosEntrega.Controls.Add(this.comboBoxUrsa);
            this.groupBoxDatosEntrega.Controls.Add(this.label5);
            this.groupBoxDatosEntrega.Controls.Add(this.dgvHallazgos);
            this.groupBoxDatosEntrega.Controls.Add(this.comboBoxUnidad);
            this.groupBoxDatosEntrega.Controls.Add(this.dateTimePickerFechaEntrega);
            this.groupBoxDatosEntrega.Controls.Add(this.label4);
            this.groupBoxDatosEntrega.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBoxDatosEntrega, "groupBoxDatosEntrega");
            this.groupBoxDatosEntrega.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatosEntrega.Name = "groupBoxDatosEntrega";
            this.groupBoxDatosEntrega.TabStop = false;
            // 
            // numericUpDownNroEntrega
            // 
            resources.ApplyResources(this.numericUpDownNroEntrega, "numericUpDownNroEntrega");
            this.numericUpDownNroEntrega.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownNroEntrega.Name = "numericUpDownNroEntrega";
            this.numericUpDownNroEntrega.ValueChanged += new System.EventHandler(this.numericUpDownNroEntrega_ValueChanged);
            this.numericUpDownNroEntrega.Leave += new System.EventHandler(this.numericUpDownNroEntrega_Leave);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // labelNroEntrega
            // 
            resources.ApplyResources(this.labelNroEntrega, "labelNroEntrega");
            this.labelNroEntrega.ForeColor = System.Drawing.Color.White;
            this.labelNroEntrega.Name = "labelNroEntrega";
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
            // Form_GestionEntrega
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvPersonas);
            this.Controls.Add(this.customTitleBar1);
            this.Controls.Add(this.DgvElementos);
            this.Controls.Add(this.groupBoxDatosEntrega);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_GestionEntrega";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvElementos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallazgos)).EndInit();
            this.groupBoxDatosEntrega.ResumeLayout(false);
            this.groupBoxDatosEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNroEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView DgvElementos;
        private Seguridad.CustomTitleBar customTitleBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPersonas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEntrega;
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
        private System.Windows.Forms.GroupBox groupBoxDatosEntrega;
        private Seguridad.RJButton buttonBuscar;
        private Seguridad.RJButton buttonLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNroEntrega;
        private System.Windows.Forms.NumericUpDown numericUpDownNroEntrega;
    }
}

