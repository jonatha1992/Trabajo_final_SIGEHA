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
            this.btnGenerarBackUP = new System.Windows.Forms.Button();
            this.buttonRestaurar = new System.Windows.Forms.Button();
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
            this.DgvBackups.Location = new System.Drawing.Point(128, 60);
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
            this.DgvBackups.Size = new System.Drawing.Size(490, 247);
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
            this.label5.Location = new System.Drawing.Point(327, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 90;
            this.label5.Text = "BackUps";
            // 
            // btnGenerarBackUP
            // 
            this.btnGenerarBackUP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerarBackUP.Location = new System.Drawing.Point(28, 107);
            this.btnGenerarBackUP.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarBackUP.Name = "btnGenerarBackUP";
            this.btnGenerarBackUP.Size = new System.Drawing.Size(84, 38);
            this.btnGenerarBackUP.TabIndex = 91;
            this.btnGenerarBackUP.Text = "Generar BackUp";
            this.btnGenerarBackUP.UseVisualStyleBackColor = true;
            this.btnGenerarBackUP.Click += new System.EventHandler(this.btnGenerarBackUP_Click);
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRestaurar.Location = new System.Drawing.Point(28, 167);
            this.buttonRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(84, 38);
            this.buttonRestaurar.TabIndex = 92;
            this.buttonRestaurar.Text = "Restaurar BackUp";
            this.buttonRestaurar.UseVisualStyleBackColor = true;
            this.buttonRestaurar.Click += new System.EventHandler(this.buttonRestaurar_Click);
            // 
            // Form_BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(629, 328);
            this.Controls.Add(this.buttonRestaurar);
            this.Controls.Add(this.btnGenerarBackUP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgvBackups);
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
        private System.Windows.Forms.Button btnGenerarBackUP;
        private System.Windows.Forms.Button buttonRestaurar;
    }
}