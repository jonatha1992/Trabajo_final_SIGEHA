namespace Presentacion_UI
{
    partial class FormPermisos
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
            this.cmdGuardarRol = new System.Windows.Forms.Button();
            this.treeConfigurarRol = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdAgregarPermiso = new System.Windows.Forms.Button();
            this.cmdSeleccionarRol = new System.Windows.Forms.Button();
            this.cboPermisos = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCrearRol = new System.Windows.Forms.Button();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPermisosDe = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGuardarRol
            // 
            this.cmdGuardarRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdGuardarRol.Location = new System.Drawing.Point(295, 288);
            this.cmdGuardarRol.Margin = new System.Windows.Forms.Padding(2);
            this.cmdGuardarRol.Name = "cmdGuardarRol";
            this.cmdGuardarRol.Size = new System.Drawing.Size(90, 26);
            this.cmdGuardarRol.TabIndex = 1;
            this.cmdGuardarRol.Text = "Guardar Rol";
            this.cmdGuardarRol.UseVisualStyleBackColor = true;
            // 
            // treeConfigurarRol
            // 
            this.treeConfigurarRol.Location = new System.Drawing.Point(295, 37);
            this.treeConfigurarRol.Margin = new System.Windows.Forms.Padding(2);
            this.treeConfigurarRol.Name = "treeConfigurarRol";
            this.treeConfigurarRol.Size = new System.Drawing.Size(262, 237);
            this.treeConfigurarRol.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdAgregarPermiso);
            this.groupBox2.Controls.Add(this.cmdSeleccionarRol);
            this.groupBox2.Controls.Add(this.cboPermisos);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboRol);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(258, 312);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles";
            // 
            // cmdAgregarPermiso
            // 
            this.cmdAgregarPermiso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdAgregarPermiso.Location = new System.Drawing.Point(13, 140);
            this.cmdAgregarPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAgregarPermiso.Name = "cmdAgregarPermiso";
            this.cmdAgregarPermiso.Size = new System.Drawing.Size(66, 32);
            this.cmdAgregarPermiso.TabIndex = 8;
            this.cmdAgregarPermiso.Text = "Agregar ";
            this.cmdAgregarPermiso.UseVisualStyleBackColor = true;
            // 
            // cmdSeleccionarRol
            // 
            this.cmdSeleccionarRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSeleccionarRol.Location = new System.Drawing.Point(10, 59);
            this.cmdSeleccionarRol.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSeleccionarRol.Name = "cmdSeleccionarRol";
            this.cmdSeleccionarRol.Size = new System.Drawing.Size(71, 32);
            this.cmdSeleccionarRol.TabIndex = 11;
            this.cmdSeleccionarRol.Text = "Configurar";
            this.cmdSeleccionarRol.UseVisualStyleBackColor = true;
            this.cmdSeleccionarRol.Click += new System.EventHandler(this.cmdSeleccionarRol_Click);
            // 
            // cboPermisos
            // 
            this.cboPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermisos.FormattingEnabled = true;
            this.cboPermisos.Location = new System.Drawing.Point(13, 117);
            this.cboPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.cboPermisos.Name = "cboPermisos";
            this.cboPermisos.Size = new System.Drawing.Size(234, 21);
            this.cboPermisos.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCrearRol);
            this.groupBox3.Controls.Add(this.txtNombreRol);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(13, 189);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(232, 113);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nuevo Rol";
            // 
            // buttonCrearRol
            // 
            this.buttonCrearRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCrearRol.Location = new System.Drawing.Point(12, 71);
            this.buttonCrearRol.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCrearRol.Name = "buttonCrearRol";
            this.buttonCrearRol.Size = new System.Drawing.Size(68, 32);
            this.buttonCrearRol.TabIndex = 4;
            this.buttonCrearRol.Text = "Crear";
            this.buttonCrearRol.UseVisualStyleBackColor = true;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(12, 41);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(201, 20);
            this.txtNombreRol.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Todos los Permisos";
            // 
            // comboRol
            // 
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(11, 35);
            this.comboRol.Margin = new System.Windows.Forms.Padding(2);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(234, 21);
            this.comboRol.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Todas los Roles";
            // 
            // labelPermisosDe
            // 
            this.labelPermisosDe.AutoSize = true;
            this.labelPermisosDe.Location = new System.Drawing.Point(377, 13);
            this.labelPermisosDe.Name = "labelPermisosDe";
            this.labelPermisosDe.Size = new System.Drawing.Size(70, 13);
            this.labelPermisosDe.TabIndex = 9;
            this.labelPermisosDe.Text = "Permisos de: ";
            // 
            // FormPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 325);
            this.Controls.Add(this.labelPermisosDe);
            this.Controls.Add(this.cmdGuardarRol);
            this.Controls.Add(this.treeConfigurarRol);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormPermisos";
            this.Text = "Gestion Permisos";
            this.Load += new System.EventHandler(this.FormPermisos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdGuardarRol;
        private System.Windows.Forms.TreeView treeConfigurarRol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdSeleccionarRol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCrearRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdAgregarPermiso;
        private System.Windows.Forms.ComboBox cboPermisos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPermisosDe;
    }
}