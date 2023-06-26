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
            this.buttonGuardarUsuario = new System.Windows.Forms.Button();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfigurar = new System.Windows.Forms.Button();
            this.grupBoxUsuarios = new System.Windows.Forms.GroupBox();
            this.buttonEliminarUsuarario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grupBoxUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Location = new System.Drawing.Point(1555, 93);
            this.treeViewPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(671, 603);
            this.treeViewPermisos.TabIndex = 0;
            // 
            // buttonGuardarPermisos
            // 
            this.buttonGuardarPermisos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuardarPermisos.Location = new System.Drawing.Point(53, 563);
            this.buttonGuardarPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarPermisos.Name = "buttonGuardarPermisos";
            this.buttonGuardarPermisos.Size = new System.Drawing.Size(285, 76);
            this.buttonGuardarPermisos.TabIndex = 1;
            this.buttonGuardarPermisos.Text = "Guardar Permisos";
            this.buttonGuardarPermisos.UseVisualStyleBackColor = true;
            // 
            // labelPermisosDe
            // 
            this.labelPermisosDe.AutoSize = true;
            this.labelPermisosDe.Location = new System.Drawing.Point(1813, 43);
            this.labelPermisosDe.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelPermisosDe.Name = "labelPermisosDe";
            this.labelPermisosDe.Size = new System.Drawing.Size(186, 32);
            this.labelPermisosDe.TabIndex = 3;
            this.labelPermisosDe.Text = "Permisos de: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 32);
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
            this.groupBox1.Location = new System.Drawing.Point(32, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(723, 663);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de NombreUsuario";
            // 
            // buttonGuardarUsuario
            // 
            this.buttonGuardarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuardarUsuario.Location = new System.Drawing.Point(51, 553);
            this.buttonGuardarUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonGuardarUsuario.Name = "buttonGuardarUsuario";
            this.buttonGuardarUsuario.Size = new System.Drawing.Size(288, 76);
            this.buttonGuardarUsuario.TabIndex = 25;
            this.buttonGuardarUsuario.Text = "Generar Usuario";
            this.buttonGuardarUsuario.UseVisualStyleBackColor = true;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Enabled = false;
            this.textBoxContraseña.Location = new System.Drawing.Point(51, 413);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(479, 38);
            this.textBoxContraseña.TabIndex = 31;
            this.textBoxContraseña.Text = "PAPA1234";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 374);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 32);
            this.label7.TabIndex = 30;
            this.label7.Text = "Contraseña";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(51, 186);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(479, 38);
            this.textBoxDNI.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "DNI";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(51, 293);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(479, 38);
            this.textBoxUsuario.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "NombreUsuario";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(51, 93);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(479, 38);
            this.textBoxNombre.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rol";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(53, 324);
            this.comboBoxRoles.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(513, 39);
            this.comboBoxRoles.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(51, 386);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 76);
            this.button3.TabIndex = 24;
            this.button3.Text = "Asignar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(53, 91);
            this.comboBoxUsuarios.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(513, 39);
            this.comboBoxUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // buttonConfigurar
            // 
            this.buttonConfigurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfigurar.Location = new System.Drawing.Point(53, 148);
            this.buttonConfigurar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonConfigurar.Name = "buttonConfigurar";
            this.buttonConfigurar.Size = new System.Drawing.Size(176, 76);
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
            this.grupBoxUsuarios.Location = new System.Drawing.Point(781, 62);
            this.grupBoxUsuarios.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grupBoxUsuarios.Name = "grupBoxUsuarios";
            this.grupBoxUsuarios.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grupBoxUsuarios.Size = new System.Drawing.Size(723, 663);
            this.grupBoxUsuarios.TabIndex = 2;
            this.grupBoxUsuarios.TabStop = false;
            this.grupBoxUsuarios.Text = "Gestion";
            // 
            // buttonEliminarUsuarario
            // 
            this.buttonEliminarUsuarario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEliminarUsuarario.Location = new System.Drawing.Point(461, 563);
            this.buttonEliminarUsuarario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarUsuarario.Name = "buttonEliminarUsuarario";
            this.buttonEliminarUsuarario.Size = new System.Drawing.Size(251, 76);
            this.buttonEliminarUsuarario.TabIndex = 25;
            this.buttonEliminarUsuarario.Text = "Eliminar Usuario";
            this.buttonEliminarUsuarario.UseVisualStyleBackColor = true;
            // 
            // Form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2259, 746);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPermisosDe);
            this.Controls.Add(this.grupBoxUsuarios);
            this.Controls.Add(this.treeViewPermisos);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Usuarios";
            this.Text = "Gestion Usuarios";
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