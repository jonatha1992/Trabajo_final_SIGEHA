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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Usuarios));
            this.buttonGuardarUsuario = new System.Windows.Forms.Button();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.treeViewPermisos = new System.Windows.Forms.TreeView();
            this.labelPermisosDe = new System.Windows.Forms.Label();
            this.groupBoxPermisos = new System.Windows.Forms.GroupBox();
            this.buttonDesagsinarRol = new System.Windows.Forms.Button();
            this.buttonAsignarRol = new System.Windows.Forms.Button();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAsignarDestino = new System.Windows.Forms.Button();
            this.rbtnUrsa = new System.Windows.Forms.RadioButton();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.rbtnUnidad = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBoxDatosUsuario = new System.Windows.Forms.GroupBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.buttonEliminarUsuario = new System.Windows.Forms.Button();
            this.groupBoxDestino = new System.Windows.Forms.GroupBox();
            this.buttonDesagniarUnidad = new System.Windows.Forms.Button();
            this.textBoxPassword2 = new Presentacion_UI.TextBoxPassword();
            this.textBoxPassword1 = new Presentacion_UI.TextBoxPassword();
            this.groupBoxPermisos.SuspendLayout();
            this.groupBoxDatosUsuario.SuspendLayout();
            this.groupBoxDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuardarUsuario
            // 
            this.buttonGuardarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuardarUsuario.Location = new System.Drawing.Point(307, 22);
            this.buttonGuardarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardarUsuario.Name = "buttonGuardarUsuario";
            this.buttonGuardarUsuario.Size = new System.Drawing.Size(75, 42);
            this.buttonGuardarUsuario.TabIndex = 25;
            this.buttonGuardarUsuario.Text = "Nuevo Usuario";
            this.buttonGuardarUsuario.UseVisualStyleBackColor = true;
            this.buttonGuardarUsuario.Click += new System.EventHandler(this.buttonGenerarUsuario_Click);
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(30, 29);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(162, 21);
            this.comboBoxUsuarios.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Usuarios";
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSeleccionar.Location = new System.Drawing.Point(215, 22);
            this.buttonSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(76, 42);
            this.buttonSeleccionar.TabIndex = 31;
            this.buttonSeleccionar.Text = "Configurar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre Completo";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(18, 83);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(195, 20);
            this.textBoxNombre.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(18, 38);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(195, 20);
            this.textBoxUsuario.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "DNI";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(18, 122);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(195, 20);
            this.textBoxDNI.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Contraseña";
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Location = new System.Drawing.Point(280, 39);
            this.treeViewPermisos.Margin = new System.Windows.Forms.Padding(1);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(239, 464);
            this.treeViewPermisos.TabIndex = 0;
            this.treeViewPermisos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPermisos_AfterSelect);
            // 
            // labelPermisosDe
            // 
            this.labelPermisosDe.AutoSize = true;
            this.labelPermisosDe.Location = new System.Drawing.Point(350, 16);
            this.labelPermisosDe.Name = "labelPermisosDe";
            this.labelPermisosDe.Size = new System.Drawing.Size(70, 13);
            this.labelPermisosDe.TabIndex = 3;
            this.labelPermisosDe.Text = "Permisos de: ";
            // 
            // groupBoxPermisos
            // 
            this.groupBoxPermisos.Controls.Add(this.buttonDesagsinarRol);
            this.groupBoxPermisos.Controls.Add(this.buttonAsignarRol);
            this.groupBoxPermisos.Controls.Add(this.comboBoxRoles);
            this.groupBoxPermisos.Controls.Add(this.label5);
            this.groupBoxPermisos.ForeColor = System.Drawing.Color.White;
            this.groupBoxPermisos.Location = new System.Drawing.Point(18, 258);
            this.groupBoxPermisos.Name = "groupBoxPermisos";
            this.groupBoxPermisos.Size = new System.Drawing.Size(229, 115);
            this.groupBoxPermisos.TabIndex = 31;
            this.groupBoxPermisos.TabStop = false;
            this.groupBoxPermisos.Text = "Permisos";
            // 
            // buttonDesagsinarRol
            // 
            this.buttonDesagsinarRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDesagsinarRol.Location = new System.Drawing.Point(140, 65);
            this.buttonDesagsinarRol.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDesagsinarRol.Name = "buttonDesagsinarRol";
            this.buttonDesagsinarRol.Size = new System.Drawing.Size(72, 32);
            this.buttonDesagsinarRol.TabIndex = 25;
            this.buttonDesagsinarRol.Text = "Desagsinar";
            this.buttonDesagsinarRol.UseVisualStyleBackColor = true;
            this.buttonDesagsinarRol.Visible = false;
            this.buttonDesagsinarRol.Click += new System.EventHandler(this.buttonDesagsinarRol_Click);
            // 
            // buttonAsignarRol
            // 
            this.buttonAsignarRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAsignarRol.Location = new System.Drawing.Point(16, 65);
            this.buttonAsignarRol.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAsignarRol.Name = "buttonAsignarRol";
            this.buttonAsignarRol.Size = new System.Drawing.Size(66, 32);
            this.buttonAsignarRol.TabIndex = 24;
            this.buttonAsignarRol.Text = "Asignar";
            this.buttonAsignarRol.UseVisualStyleBackColor = true;
            this.buttonAsignarRol.Click += new System.EventHandler(this.buttonAsignarRol_Click);
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(17, 39);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(195, 21);
            this.comboBoxRoles.TabIndex = 30;
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Roles";
            // 
            // buttonAsignarDestino
            // 
            this.buttonAsignarDestino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAsignarDestino.Location = new System.Drawing.Point(18, 82);
            this.buttonAsignarDestino.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAsignarDestino.Name = "buttonAsignarDestino";
            this.buttonAsignarDestino.Size = new System.Drawing.Size(66, 32);
            this.buttonAsignarDestino.TabIndex = 28;
            this.buttonAsignarDestino.Text = "Asignar";
            this.buttonAsignarDestino.UseVisualStyleBackColor = true;
            this.buttonAsignarDestino.Click += new System.EventHandler(this.buttonAsignarDestino_Click);
            // 
            // rbtnUrsa
            // 
            this.rbtnUrsa.AutoSize = true;
            this.rbtnUrsa.Checked = true;
            this.rbtnUrsa.Location = new System.Drawing.Point(20, 25);
            this.rbtnUrsa.Name = "rbtnUrsa";
            this.rbtnUrsa.Size = new System.Drawing.Size(47, 17);
            this.rbtnUrsa.TabIndex = 29;
            this.rbtnUrsa.TabStop = true;
            this.rbtnUrsa.Text = "Ursa";
            this.rbtnUrsa.UseVisualStyleBackColor = true;
            this.rbtnUrsa.CheckedChanged += new System.EventHandler(this.rbtnUrsa_CheckedChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(19, 50);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(195, 21);
            this.comboBoxDestino.TabIndex = 31;
            // 
            // rbtnUnidad
            // 
            this.rbtnUnidad.AutoSize = true;
            this.rbtnUnidad.Location = new System.Drawing.Point(130, 25);
            this.rbtnUnidad.Name = "rbtnUnidad";
            this.rbtnUnidad.Size = new System.Drawing.Size(59, 17);
            this.rbtnUnidad.TabIndex = 30;
            this.rbtnUnidad.Text = "Unidad";
            this.rbtnUnidad.UseVisualStyleBackColor = true;
            this.rbtnUnidad.CheckedChanged += new System.EventHandler(this.rbtnUnidad_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Contraseña";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuardar.Location = new System.Drawing.Point(24, 513);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(56, 32);
            this.buttonGuardar.TabIndex = 37;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // groupBoxDatosUsuario
            // 
            this.groupBoxDatosUsuario.Controls.Add(this.labelUsuario);
            this.groupBoxDatosUsuario.Controls.Add(this.buttonEliminarUsuario);
            this.groupBoxDatosUsuario.Controls.Add(this.groupBoxDestino);
            this.groupBoxDatosUsuario.Controls.Add(this.buttonGuardar);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxPassword2);
            this.groupBoxDatosUsuario.Controls.Add(this.label1);
            this.groupBoxDatosUsuario.Controls.Add(this.groupBoxPermisos);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxPassword1);
            this.groupBoxDatosUsuario.Controls.Add(this.labelPermisosDe);
            this.groupBoxDatosUsuario.Controls.Add(this.treeViewPermisos);
            this.groupBoxDatosUsuario.Controls.Add(this.label7);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxDNI);
            this.groupBoxDatosUsuario.Controls.Add(this.label6);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxUsuario);
            this.groupBoxDatosUsuario.Controls.Add(this.label3);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxNombre);
            this.groupBoxDatosUsuario.Controls.Add(this.label4);
            this.groupBoxDatosUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxDatosUsuario.Location = new System.Drawing.Point(12, 69);
            this.groupBoxDatosUsuario.Name = "groupBoxDatosUsuario";
            this.groupBoxDatosUsuario.Size = new System.Drawing.Size(539, 554);
            this.groupBoxDatosUsuario.TabIndex = 25;
            this.groupBoxDatosUsuario.TabStop = false;
            this.groupBoxDatosUsuario.Text = "Datos de Usuario";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(415, 16);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(0, 13);
            this.labelUsuario.TabIndex = 39;
            // 
            // buttonEliminarUsuario
            // 
            this.buttonEliminarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEliminarUsuario.Location = new System.Drawing.Point(176, 513);
            this.buttonEliminarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            this.buttonEliminarUsuario.Size = new System.Drawing.Size(54, 32);
            this.buttonEliminarUsuario.TabIndex = 38;
            this.buttonEliminarUsuario.Text = "Eliminar";
            this.buttonEliminarUsuario.UseVisualStyleBackColor = true;
            this.buttonEliminarUsuario.Click += new System.EventHandler(this.buttonEliminarUsuario_Click);
            // 
            // groupBoxDestino
            // 
            this.groupBoxDestino.Controls.Add(this.buttonDesagniarUnidad);
            this.groupBoxDestino.Controls.Add(this.rbtnUnidad);
            this.groupBoxDestino.Controls.Add(this.comboBoxDestino);
            this.groupBoxDestino.Controls.Add(this.buttonAsignarDestino);
            this.groupBoxDestino.Controls.Add(this.rbtnUrsa);
            this.groupBoxDestino.ForeColor = System.Drawing.Color.White;
            this.groupBoxDestino.Location = new System.Drawing.Point(18, 379);
            this.groupBoxDestino.Name = "groupBoxDestino";
            this.groupBoxDestino.Size = new System.Drawing.Size(229, 121);
            this.groupBoxDestino.TabIndex = 32;
            this.groupBoxDestino.TabStop = false;
            this.groupBoxDestino.Text = "Destino";
            this.groupBoxDestino.Visible = false;
            // 
            // buttonDesagniarUnidad
            // 
            this.buttonDesagniarUnidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDesagniarUnidad.Location = new System.Drawing.Point(140, 84);
            this.buttonDesagniarUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDesagniarUnidad.Name = "buttonDesagniarUnidad";
            this.buttonDesagniarUnidad.Size = new System.Drawing.Size(72, 32);
            this.buttonDesagniarUnidad.TabIndex = 26;
            this.buttonDesagniarUnidad.Text = "Desagsinar";
            this.buttonDesagniarUnidad.UseVisualStyleBackColor = true;
            this.buttonDesagniarUnidad.Click += new System.EventHandler(this.buttonDesagniarUnidad_Click);
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword2.Location = new System.Drawing.Point(20, 218);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(195, 37);
            this.textBoxPassword2.TabIndex = 29;
            this.textBoxPassword2.Texto = "";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword1.Location = new System.Drawing.Point(18, 166);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(195, 32);
            this.textBoxPassword1.TabIndex = 28;
            this.textBoxPassword1.Texto = "";
            // 
            // Form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(575, 635);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxUsuarios);
            this.Controls.Add(this.groupBoxDatosUsuario);
            this.Controls.Add(this.buttonGuardarUsuario);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "Form_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Usuarios";
            this.Load += new System.EventHandler(this.FormPermisos_Load);
            this.groupBoxPermisos.ResumeLayout(false);
            this.groupBoxPermisos.PerformLayout();
            this.groupBoxDatosUsuario.ResumeLayout(false);
            this.groupBoxDatosUsuario.PerformLayout();
            this.groupBoxDestino.ResumeLayout(false);
            this.groupBoxDestino.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGuardarUsuario;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TreeView treeViewPermisos;
        private System.Windows.Forms.Label labelPermisosDe;
        private TextBoxPassword textBoxPassword1;
        private System.Windows.Forms.GroupBox groupBoxPermisos;
        private System.Windows.Forms.RadioButton rbtnUnidad;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.RadioButton rbtnUrsa;
        private System.Windows.Forms.Button buttonAsignarDestino;
        private System.Windows.Forms.Button buttonAsignarRol;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private TextBoxPassword textBoxPassword2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.GroupBox groupBoxDatosUsuario;
        private System.Windows.Forms.GroupBox groupBoxDestino;
        private System.Windows.Forms.Button buttonEliminarUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button buttonDesagsinarRol;
        private System.Windows.Forms.Button buttonDesagniarUnidad;
    }
}