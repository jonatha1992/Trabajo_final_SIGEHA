namespace Presentacion_UI
{
    partial class Form_Usuarios
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
            this.treeViewPermisos = new System.Windows.Forms.TreeView();
            this.buttonGuardarPermisos = new System.Windows.Forms.Button();
            this.labelPermisosDe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfigurar = new System.Windows.Forms.Button();
            this.grupBoxUsuarios = new System.Windows.Forms.GroupBox();
            this.buttonGuardarUsuario = new System.Windows.Forms.Button();
            this.buttonEliminarUsuarario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grupBoxUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Location = new System.Drawing.Point(583, 39);
            this.treeViewPermisos.Margin = new System.Windows.Forms.Padding(1);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(254, 255);
            this.treeViewPermisos.TabIndex = 0;
            // 
            // buttonGuardarPermisos
            // 
            this.buttonGuardarPermisos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuardarPermisos.Location = new System.Drawing.Point(20, 236);
            this.buttonGuardarPermisos.Margin = new System.Windows.Forms.Padding(1);
            this.buttonGuardarPermisos.Name = "buttonGuardarPermisos";
            this.buttonGuardarPermisos.Size = new System.Drawing.Size(107, 32);
            this.buttonGuardarPermisos.TabIndex = 1;
            this.buttonGuardarPermisos.Text = "Guardar Permisos";
            this.buttonGuardarPermisos.UseVisualStyleBackColor = true;
            // 
            // labelPermisosDe
            // 
            this.labelPermisosDe.AutoSize = true;
            this.labelPermisosDe.Location = new System.Drawing.Point(680, 18);
            this.labelPermisosDe.Name = "labelPermisosDe";
            this.labelPermisosDe.Size = new System.Drawing.Size(70, 13);
            this.labelPermisosDe.TabIndex = 3;
            this.labelPermisosDe.Text = "Permisos de: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre Completo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGuardarUsuario);
            this.groupBox1.Controls.Add(this.textBoxContraseña);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxDNI);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 278);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de NombreUsuario";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(19, 78);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(182, 20);
            this.textBoxDNI.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "DNI";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(19, 123);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(182, 20);
            this.textBoxUsuario.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "NombreUsuario";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(19, 39);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(182, 20);
            this.textBoxNombre.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Contraseña";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Enabled = false;
            this.textBoxContraseña.Location = new System.Drawing.Point(19, 173);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(182, 20);
            this.textBoxContraseña.TabIndex = 31;
            this.textBoxContraseña.Text = "PAPA1234";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rol";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(20, 136);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(195, 21);
            this.comboBoxRoles.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(19, 162);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 32);
            this.button3.TabIndex = 24;
            this.button3.Text = "Asignar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(20, 38);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(195, 21);
            this.comboBoxUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // buttonConfigurar
            // 
            this.buttonConfigurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfigurar.Location = new System.Drawing.Point(20, 62);
            this.buttonConfigurar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfigurar.Name = "buttonConfigurar";
            this.buttonConfigurar.Size = new System.Drawing.Size(66, 32);
            this.buttonConfigurar.TabIndex = 24;
            this.buttonConfigurar.Text = "Configurar";
            this.buttonConfigurar.UseVisualStyleBackColor = true;
            this.buttonConfigurar.Click += new System.EventHandler(this.buttonConfigurar_Click);
            // 
            // grupBoxUsuarios
            // 
            this.grupBoxUsuarios.Controls.Add(this.buttonEliminarUsuarario);
            this.grupBoxUsuarios.Controls.Add(this.buttonConfigurar);
            this.grupBoxUsuarios.Controls.Add(this.button3);
            this.grupBoxUsuarios.Controls.Add(this.label1);
            this.grupBoxUsuarios.Controls.Add(this.buttonGuardarPermisos);
            this.grupBoxUsuarios.Controls.Add(this.comboBoxUsuarios);
            this.grupBoxUsuarios.Controls.Add(this.comboBoxRoles);
            this.grupBoxUsuarios.Controls.Add(this.label5);
            this.grupBoxUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupBoxUsuarios.Location = new System.Drawing.Point(293, 26);
            this.grupBoxUsuarios.Name = "grupBoxUsuarios";
            this.grupBoxUsuarios.Size = new System.Drawing.Size(271, 278);
            this.grupBoxUsuarios.TabIndex = 2;
            this.grupBoxUsuarios.TabStop = false;
            this.grupBoxUsuarios.Text = "Gestion";
            // 
            // buttonGuardarUsuario
            // 
            this.buttonGuardarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuardarUsuario.Location = new System.Drawing.Point(19, 232);
            this.buttonGuardarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardarUsuario.Name = "buttonGuardarUsuario";
            this.buttonGuardarUsuario.Size = new System.Drawing.Size(108, 32);
            this.buttonGuardarUsuario.TabIndex = 25;
            this.buttonGuardarUsuario.Text = "Guardar NombreUsuario";
            this.buttonGuardarUsuario.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarUsuarario
            // 
            this.buttonEliminarUsuarario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEliminarUsuarario.Location = new System.Drawing.Point(173, 236);
            this.buttonEliminarUsuarario.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEliminarUsuarario.Name = "buttonEliminarUsuarario";
            this.buttonEliminarUsuarario.Size = new System.Drawing.Size(94, 32);
            this.buttonEliminarUsuarario.TabIndex = 25;
            this.buttonEliminarUsuarario.Text = "Eliminar NombreUsuario";
            this.buttonEliminarUsuarario.UseVisualStyleBackColor = true;
            // 
            // Form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(847, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPermisosDe);
            this.Controls.Add(this.grupBoxUsuarios);
            this.Controls.Add(this.treeViewPermisos);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form_Usuarios";
            this.Text = "Gestion Usuarios";
            this.Load += new System.EventHandler(this.FormPermisos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupBoxUsuarios.ResumeLayout(false);
            this.grupBoxUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewPermisos;
        private System.Windows.Forms.Button buttonGuardarPermisos;
        private System.Windows.Forms.Label labelPermisosDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGuardarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfigurar;
        private System.Windows.Forms.GroupBox grupBoxUsuarios;
        private System.Windows.Forms.Button buttonEliminarUsuarario;
    }
}