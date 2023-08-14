namespace Presentacion_UI
{
    partial class Form_BackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BackUp));
            this.DgvBackups = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRestaurar = new Seguridad.RJButton();
            this.btnGenerarBackUP = new Seguridad.RJButton();
            this.customTitleBar1 = new Seguridad.CustomTitleBar();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBackups)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBackups
            // 
            this.DgvBackups.AllowUserToAddRows = false;
            this.DgvBackups.AllowUserToDeleteRows = false;
            this.DgvBackups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvBackups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBackups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvBackups.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvBackups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvBackups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBackups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBackups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBackups.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBackups.Location = new System.Drawing.Point(150, 60);
            this.DgvBackups.Margin = new System.Windows.Forms.Padding(2);
            this.DgvBackups.MultiSelect = false;
            this.DgvBackups.Name = "DgvBackups";
            this.DgvBackups.ReadOnly = true;
            this.DgvBackups.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBackups.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvBackups.RowHeadersVisible = false;
            this.DgvBackups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DgvBackups.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvBackups.RowTemplate.Height = 60;
            this.DgvBackups.RowTemplate.ReadOnly = true;
            this.DgvBackups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBackups.Size = new System.Drawing.Size(510, 247);
            this.DgvBackups.TabIndex = 87;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(382, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 90;
            this.label5.Text = "BackUps";
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonRestaurar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonRestaurar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRestaurar.BorderRadius = 20;
            this.buttonRestaurar.BorderSize = 0;
            this.buttonRestaurar.FlatAppearance.BorderSize = 0;
            this.buttonRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestaurar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonRestaurar.ForeColor = System.Drawing.Color.White;
            this.buttonRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestaurar.Image")));
            this.buttonRestaurar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRestaurar.Location = new System.Drawing.Point(19, 182);
            this.buttonRestaurar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(115, 44);
            this.buttonRestaurar.TabIndex = 95;
            this.buttonRestaurar.Text = "Restaurar";
            this.buttonRestaurar.TextColor = System.Drawing.Color.White;
            this.buttonRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRestaurar.UseVisualStyleBackColor = false;
            this.buttonRestaurar.Click += new System.EventHandler(this.buttonRestaurar_Click);
            // 
            // btnGenerarBackUP
            // 
            this.btnGenerarBackUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGenerarBackUP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGenerarBackUP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGenerarBackUP.BorderRadius = 20;
            this.btnGenerarBackUP.BorderSize = 0;
            this.btnGenerarBackUP.FlatAppearance.BorderSize = 0;
            this.btnGenerarBackUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarBackUP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGenerarBackUP.ForeColor = System.Drawing.Color.White;
            this.btnGenerarBackUP.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarBackUP.Image")));
            this.btnGenerarBackUP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenerarBackUP.Location = new System.Drawing.Point(19, 105);
            this.btnGenerarBackUP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerarBackUP.Name = "btnGenerarBackUP";
            this.btnGenerarBackUP.Size = new System.Drawing.Size(115, 44);
            this.btnGenerarBackUP.TabIndex = 94;
            this.btnGenerarBackUP.Text = "Generar";
            this.btnGenerarBackUP.TextColor = System.Drawing.Color.White;
            this.btnGenerarBackUP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarBackUP.UseVisualStyleBackColor = false;
            this.btnGenerarBackUP.Click += new System.EventHandler(this.btnGenerarBackUP_Click);
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.BackColor = System.Drawing.Color.SlateGray;
            this.customTitleBar1.CloseButtonVisible = true;
            this.customTitleBar1.Color_Borde = System.Drawing.Color.SteelBlue;
            this.customTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTitleBar1.Icon = null;
            this.customTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.customTitleBar1.MaximizeButtonVisible = false;
            this.customTitleBar1.MinimizeButtonVisible = false;
            this.customTitleBar1.Name = "customTitleBar1";
            this.customTitleBar1.Size = new System.Drawing.Size(671, 25);
            this.customTitleBar1.TabIndex = 93;
            this.customTitleBar1.Title = "Backup";
            // 
            // Form_BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(671, 328);
            this.Controls.Add(this.buttonRestaurar);
            this.Controls.Add(this.btnGenerarBackUP);
            this.Controls.Add(this.customTitleBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgvBackups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_BackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackUps";
            this.Load += new System.EventHandler(this.Form_BackUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBackups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvBackups;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private System.Windows.Forms.Label label5;
        private Seguridad.CustomTitleBar customTitleBar1;
        private Seguridad.RJButton btnGenerarBackUP;
        private Seguridad.RJButton buttonRestaurar;
    }
}