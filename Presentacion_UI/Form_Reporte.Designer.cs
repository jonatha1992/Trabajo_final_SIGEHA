namespace Presentacion_UI
{
    partial class Form_Reporte
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reporte));
            this.comboBoxUnidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RadioButtonMensual = new Seguridad.RJRadioButton();
            this.RadioButtonTrimestral = new Seguridad.RJRadioButton();
            this.RadioButtonSemestral = new Seguridad.RJRadioButton();
            this.RadioButtonAnual = new Seguridad.RJRadioButton();
            this.chartHallazgos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalHallazgos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotalEntregas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelElementosResguardados = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelElementosEntregados = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chartEntregas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.customTitleBar1 = new Seguridad.CustomTitleBar();
            this.buttonAgregar = new Seguridad.RJButton();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHallazgos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUnidadEntrega
            // 
            this.comboBoxUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.comboBoxUnidad.FormattingEnabled = true;
            this.comboBoxUnidad.Location = new System.Drawing.Point(94, 28);
            this.comboBoxUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUnidad.Name = "comboBoxUnidadEntrega";
            this.comboBoxUnidad.Size = new System.Drawing.Size(196, 20);
            this.comboBoxUnidad.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(43, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "Unidad:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RadioButtonMensual);
            this.groupBox4.Controls.Add(this.RadioButtonTrimestral);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.RadioButtonSemestral);
            this.groupBox4.Controls.Add(this.comboBoxUnidad);
            this.groupBox4.Controls.Add(this.RadioButtonAnual);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(26, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 121);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Criterio";
            // 
            // RadioButtonMensual
            // 
            this.RadioButtonMensual.AutoSize = true;
            this.RadioButtonMensual.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.RadioButtonMensual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMensual.ForeColor = System.Drawing.Color.White;
            this.RadioButtonMensual.Location = new System.Drawing.Point(185, 93);
            this.RadioButtonMensual.MinimumSize = new System.Drawing.Size(0, 21);
            this.RadioButtonMensual.Name = "RadioButtonMensual";
            this.RadioButtonMensual.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RadioButtonMensual.Size = new System.Drawing.Size(84, 21);
            this.RadioButtonMensual.TabIndex = 112;
            this.RadioButtonMensual.Text = "Mensual";
            this.RadioButtonMensual.UnCheckedColor = System.Drawing.Color.Gray;
            this.RadioButtonMensual.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTrimestral
            // 
            this.RadioButtonTrimestral.AutoSize = true;
            this.RadioButtonTrimestral.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.RadioButtonTrimestral.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonTrimestral.ForeColor = System.Drawing.Color.White;
            this.RadioButtonTrimestral.Location = new System.Drawing.Point(66, 93);
            this.RadioButtonTrimestral.MinimumSize = new System.Drawing.Size(0, 21);
            this.RadioButtonTrimestral.Name = "RadioButtonTrimestral";
            this.RadioButtonTrimestral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RadioButtonTrimestral.Size = new System.Drawing.Size(90, 21);
            this.RadioButtonTrimestral.TabIndex = 111;
            this.RadioButtonTrimestral.Text = "Trimestral";
            this.RadioButtonTrimestral.UnCheckedColor = System.Drawing.Color.Gray;
            this.RadioButtonTrimestral.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSemestral
            // 
            this.RadioButtonSemestral.AutoSize = true;
            this.RadioButtonSemestral.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.RadioButtonSemestral.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonSemestral.ForeColor = System.Drawing.Color.White;
            this.RadioButtonSemestral.Location = new System.Drawing.Point(185, 66);
            this.RadioButtonSemestral.MinimumSize = new System.Drawing.Size(0, 21);
            this.RadioButtonSemestral.Name = "RadioButtonSemestral";
            this.RadioButtonSemestral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RadioButtonSemestral.Size = new System.Drawing.Size(91, 21);
            this.RadioButtonSemestral.TabIndex = 110;
            this.RadioButtonSemestral.Text = "Semestral";
            this.RadioButtonSemestral.UnCheckedColor = System.Drawing.Color.Gray;
            this.RadioButtonSemestral.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAnual
            // 
            this.RadioButtonAnual.AutoSize = true;
            this.RadioButtonAnual.Checked = true;
            this.RadioButtonAnual.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.RadioButtonAnual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonAnual.ForeColor = System.Drawing.Color.White;
            this.RadioButtonAnual.Location = new System.Drawing.Point(66, 66);
            this.RadioButtonAnual.MinimumSize = new System.Drawing.Size(0, 21);
            this.RadioButtonAnual.Name = "RadioButtonAnual";
            this.RadioButtonAnual.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RadioButtonAnual.Size = new System.Drawing.Size(69, 21);
            this.RadioButtonAnual.TabIndex = 109;
            this.RadioButtonAnual.TabStop = true;
            this.RadioButtonAnual.Text = "Anual";
            this.RadioButtonAnual.UnCheckedColor = System.Drawing.Color.Gray;
            this.RadioButtonAnual.UseVisualStyleBackColor = true;
            // 
            // chartHallazgos
            // 
            this.chartHallazgos.BackSecondaryColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "Tiempo";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Title = "Cantidad de Entregas";
            chartArea1.Name = "ChartArea1";
            this.chartHallazgos.ChartAreas.Add(chartArea1);
            this.chartHallazgos.Location = new System.Drawing.Point(26, 151);
            this.chartHallazgos.Name = "chartHallazgos";
            this.chartHallazgos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.MidnightBlue;
            series1.Name = "Serie";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartHallazgos.Series.Add(series1);
            this.chartHallazgos.Size = new System.Drawing.Size(589, 244);
            this.chartHallazgos.TabIndex = 101;
            this.chartHallazgos.Text = "chart2";
            title1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Hallazgos";
            title1.Text = "Hallazgos por tiempo";
            this.chartHallazgos.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.labelTotalHallazgos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(376, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 101);
            this.panel1.TabIndex = 102;
            // 
            // labelTotalHallazgos
            // 
            this.labelTotalHallazgos.AutoSize = true;
            this.labelTotalHallazgos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHallazgos.ForeColor = System.Drawing.Color.White;
            this.labelTotalHallazgos.Location = new System.Drawing.Point(20, 39);
            this.labelTotalHallazgos.Name = "labelTotalHallazgos";
            this.labelTotalHallazgos.Size = new System.Drawing.Size(74, 32);
            this.labelTotalHallazgos.TabIndex = 2;
            this.labelTotalHallazgos.Text = "1500";
            this.labelTotalHallazgos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hallazgo realizados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion_UI.Properties.Resources.Hallazgo;
            this.pictureBox1.Location = new System.Drawing.Point(135, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.labelTotalEntregas);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(618, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 101);
            this.panel2.TabIndex = 103;
            // 
            // labelTotalEntregas
            // 
            this.labelTotalEntregas.AutoSize = true;
            this.labelTotalEntregas.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEntregas.ForeColor = System.Drawing.Color.White;
            this.labelTotalEntregas.Location = new System.Drawing.Point(19, 39);
            this.labelTotalEntregas.Name = "labelTotalEntregas";
            this.labelTotalEntregas.Size = new System.Drawing.Size(74, 32);
            this.labelTotalEntregas.TabIndex = 3;
            this.labelTotalEntregas.Text = "1500";
            this.labelTotalEntregas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Entregas realizadas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion_UI.Properties.Resources.Oficial_Entrega;
            this.pictureBox2.Location = new System.Drawing.Point(125, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel3.Controls.Add(this.labelElementosResguardados);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(846, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 101);
            this.panel3.TabIndex = 104;
            // 
            // labelElementosResguardados
            // 
            this.labelElementosResguardados.AutoSize = true;
            this.labelElementosResguardados.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElementosResguardados.ForeColor = System.Drawing.Color.White;
            this.labelElementosResguardados.Location = new System.Drawing.Point(10, 39);
            this.labelElementosResguardados.Name = "labelElementosResguardados";
            this.labelElementosResguardados.Size = new System.Drawing.Size(119, 32);
            this.labelElementosResguardados.TabIndex = 4;
            this.labelElementosResguardados.Text = "1000000";
            this.labelElementosResguardados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Elementos Resguardados";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion_UI.Properties.Resources.Elememtos;
            this.pictureBox3.Location = new System.Drawing.Point(135, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Elementos Entregados";
            // 
            // labelElementosEntregados
            // 
            this.labelElementosEntregados.AutoSize = true;
            this.labelElementosEntregados.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElementosEntregados.ForeColor = System.Drawing.Color.White;
            this.labelElementosEntregados.Location = new System.Drawing.Point(19, 39);
            this.labelElementosEntregados.Name = "labelElementosEntregados";
            this.labelElementosEntregados.Size = new System.Drawing.Size(74, 32);
            this.labelElementosEntregados.TabIndex = 4;
            this.labelElementosEntregados.Text = "1500";
            this.labelElementosEntregados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel4.Controls.Add(this.labelElementosEntregados);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(1075, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 101);
            this.panel4.TabIndex = 105;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentacion_UI.Properties.Resources.Entrega;
            this.pictureBox4.Location = new System.Drawing.Point(130, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // chartEntregas
            // 
            this.chartEntregas.BackSecondaryColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Title = "Tiempo";
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.Title = "Cantidad de Entregas";
            chartArea2.Name = "ChartArea1";
            this.chartEntregas.ChartAreas.Add(chartArea2);
            this.chartEntregas.Location = new System.Drawing.Point(26, 401);
            this.chartEntregas.Name = "chartEntregas";
            this.chartEntregas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.MidnightBlue;
            series2.Name = "Serie";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartEntregas.Series.Add(series2);
            this.chartEntregas.Size = new System.Drawing.Size(589, 250);
            this.chartEntregas.TabIndex = 107;
            this.chartEntregas.Text = "chart2";
            title2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Entregas";
            title2.Text = "Entregas por tiempo";
            this.chartEntregas.Titles.Add(title2);
            // 
            // chartCategoria
            // 
            this.chartCategoria.BackSecondaryColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.Title = "Categorias";
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.Title = "Cantidad de elementos";
            chartArea3.Name = "ChartArea1";
            this.chartCategoria.ChartAreas.Add(chartArea3);
            this.chartCategoria.Location = new System.Drawing.Point(624, 151);
            this.chartCategoria.Name = "chartCategoria";
            this.chartCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.MidnightBlue;
            series3.Name = "Serie";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chartCategoria.Series.Add(series3);
            this.chartCategoria.Size = new System.Drawing.Size(655, 500);
            this.chartCategoria.TabIndex = 108;
            this.chartCategoria.Text = "chart2";
            title3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Categorias";
            title3.Text = "Elementos en reguardo";
            this.chartCategoria.Titles.Add(title3);
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.BackColor = System.Drawing.Color.SlateGray;
            this.customTitleBar1.CloseButtonVisible = true;
            this.customTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTitleBar1.Icon = global::Presentacion_UI.Properties.Resources.articulos_perdidos1;
            this.customTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.customTitleBar1.MaximizeButtonVisible = true;
            this.customTitleBar1.MinimizeButtonVisible = true;
            this.customTitleBar1.Name = "customTitleBar1";
            this.customTitleBar1.Size = new System.Drawing.Size(1300, 25);
            this.customTitleBar1.TabIndex = 109;
            this.customTitleBar1.Title = "Reporte";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.Green;
            this.buttonAgregar.BackgroundColor = System.Drawing.Color.Green;
            this.buttonAgregar.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgregar.BorderRadius = 20;
            this.buttonAgregar.BorderSize = 1;
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Image = global::Presentacion_UI.Properties.Resources.sobresalir;
            this.buttonAgregar.Location = new System.Drawing.Point(1180, 610);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(87, 41);
            this.buttonAgregar.TabIndex = 110;
            this.buttonAgregar.Text = "Excel";
            this.buttonAgregar.TextColor = System.Drawing.Color.White;
            this.buttonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonReporteExcel_Click);
            // 
            // Form_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1300, 663);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.customTitleBar1);
            this.Controls.Add(this.chartCategoria);
            this.Controls.Add(this.chartEntregas);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartHallazgos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form_Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Form_Reporte_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHallazgos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxUnidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHallazgos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalHallazgos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTotalEntregas;
        private System.Windows.Forms.Label labelElementosResguardados;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelElementosEntregados;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEntregas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoria;
        private Seguridad.RJRadioButton RadioButtonAnual;
        private Seguridad.RJRadioButton RadioButtonSemestral;
        private Seguridad.RJRadioButton RadioButtonTrimestral;
        private Seguridad.RJRadioButton RadioButtonMensual;
        private Seguridad.CustomTitleBar customTitleBar1;
        private Seguridad.RJButton buttonAgregar;
    }
}