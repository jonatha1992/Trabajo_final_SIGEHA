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
            this.label8 = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.buttonEliminarUsuario = new System.Windows.Forms.Button();
            this.groupBoxDestino = new System.Windows.Forms.GroupBox();
            this.buttonDesagniarUnidad = new System.Windows.Forms.Button();
            this.textBoxPassword2 = new Presentacion_UI.TextBoxPassword();
            this.textBoxPassword1 = new Presentacion_UI.TextBoxPassword();
            this.rjButton1 = new Seguridad.RJButton();
            this.groupBoxPermisos.SuspendLayout();
            this.groupBoxDatosUsuario.SuspendLayout();
            this.groupBoxDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuardarUsuario
            // 
            this.buttonGuardarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuardarUsuario.Location = new System.Drawing.Point(421, 24);
            this.buttonGuardarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarUsuario.Name = "buttonGuardarUsuario";
            this.buttonGuardarUsuario.Size = new System.Drawing.Size(112, 45);
            this.buttonGuardarUsuario.TabIndex = 25;
            this.buttonGuardarUsuario.Text = "Nuevo Usuario";
            this.buttonGuardarUsuario.UseVisualStyleBackColor = true;
            this.buttonGuardarUsuario.Click += new System.EventHandler(this.buttonGenerarUsuario_Click);
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(40, 31);
            this.comboBoxUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(215, 23);
            this.comboBoxUsuarios.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 36;
            this.label2.Text = "Usuarios";
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSeleccionar.Location = new System.Drawing.Point(287, 24);
            this.buttonSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(117, 45);
            this.buttonSeleccionar.TabIndex = 31;
            this.buttonSeleccionar.Text = "Configurar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre Completo";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(24, 89);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(259, 23);
            this.textBoxNombre.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(24, 41);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(259, 23);
            this.textBoxUsuario.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 28;
            this.label6.Text = "DNI";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDNI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.Location = new System.Drawing.Point(24, 131);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(259, 23);
            this.textBoxDNI.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 14);
            this.label7.TabIndex = 30;
            this.label7.Text = "Contraseña";
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Location = new System.Drawing.Point(355, 41);
            this.treeViewPermisos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(379, 500);
            this.treeViewPermisos.TabIndex = 0;
            this.treeViewPermisos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPermisos_AfterSelect);
            // 
            // groupBoxPermisos
            // 
            this.groupBoxPermisos.Controls.Add(this.buttonDesagsinarRol);
            this.groupBoxPermisos.Controls.Add(this.buttonAsignarRol);
            this.groupBoxPermisos.Controls.Add(this.comboBoxRoles);
            this.groupBoxPermisos.Controls.Add(this.label5);
            this.groupBoxPermisos.ForeColor = System.Drawing.Color.White;
            this.groupBoxPermisos.Location = new System.Drawing.Point(24, 276);
            this.groupBoxPermisos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxPermisos.Name = "groupBoxPermisos";
            this.groupBoxPermisos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxPermisos.Size = new System.Drawing.Size(305, 124);
            this.groupBoxPermisos.TabIndex = 31;
            this.groupBoxPermisos.TabStop = false;
            this.groupBoxPermisos.Text = "Permisos";
            // 
            // buttonDesagsinarRol
            // 
            this.buttonDesagsinarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.buttonDesagsinarRol.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesagsinarRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDesagsinarRol.Location = new System.Drawing.Point(173, 70);
            this.buttonDesagsinarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDesagsinarRol.Name = "buttonDesagsinarRol";
            this.buttonDesagsinarRol.Size = new System.Drawing.Size(109, 34);
            this.buttonDesagsinarRol.TabIndex = 25;
            this.buttonDesagsinarRol.Text = "Desagsinar";
            this.buttonDesagsinarRol.UseVisualStyleBackColor = false;
            this.buttonDesagsinarRol.Visible = false;
            this.buttonDesagsinarRol.Click += new System.EventHandler(this.buttonDesagsinarRol_Click);
            // 
            // buttonAsignarRol
            // 
            this.buttonAsignarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.buttonAsignarRol.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignarRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAsignarRol.Location = new System.Drawing.Point(21, 70);
            this.buttonAsignarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAsignarRol.Name = "buttonAsignarRol";
            this.buttonAsignarRol.Size = new System.Drawing.Size(88, 34);
            this.buttonAsignarRol.TabIndex = 24;
            this.buttonAsignarRol.Text = "Asignar";
            this.buttonAsignarRol.UseVisualStyleBackColor = false;
            this.buttonAsignarRol.Click += new System.EventHandler(this.buttonAsignarRol_Click);
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(23, 42);
            this.comboBoxRoles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(259, 23);
            this.comboBoxRoles.TabIndex = 30;
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Roles";
            // 
            // buttonAsignarDestino
            // 
            this.buttonAsignarDestino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignarDestino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAsignarDestino.Location = new System.Drawing.Point(24, 88);
            this.buttonAsignarDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAsignarDestino.Name = "buttonAsignarDestino";
            this.buttonAsignarDestino.Size = new System.Drawing.Size(88, 34);
            this.buttonAsignarDestino.TabIndex = 28;
            this.buttonAsignarDestino.Text = "Asignar";
            this.buttonAsignarDestino.UseVisualStyleBackColor = true;
            this.buttonAsignarDestino.Click += new System.EventHandler(this.buttonAsignarDestino_Click);
            // 
            // rbtnUrsa
            // 
            this.rbtnUrsa.AutoSize = true;
            this.rbtnUrsa.Checked = true;
            this.rbtnUrsa.Location = new System.Drawing.Point(27, 27);
            this.rbtnUrsa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnUrsa.Name = "rbtnUrsa";
            this.rbtnUrsa.Size = new System.Drawing.Size(53, 18);
            this.rbtnUrsa.TabIndex = 29;
            this.rbtnUrsa.TabStop = true;
            this.rbtnUrsa.Text = "Ursa";
            this.rbtnUrsa.UseVisualStyleBackColor = true;
            this.rbtnUrsa.CheckedChanged += new System.EventHandler(this.rbtnUrsa_CheckedChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(25, 54);
            this.comboBoxDestino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(259, 23);
            this.comboBoxDestino.TabIndex = 31;
            // 
            // rbtnUnidad
            // 
            this.rbtnUnidad.AutoSize = true;
            this.rbtnUnidad.Location = new System.Drawing.Point(173, 27);
            this.rbtnUnidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnUnidad.Name = "rbtnUnidad";
            this.rbtnUnidad.Size = new System.Drawing.Size(67, 18);
            this.rbtnUnidad.TabIndex = 30;
            this.rbtnUnidad.Text = "Unidad";
            this.rbtnUnidad.UseVisualStyleBackColor = true;
            this.rbtnUnidad.CheckedChanged += new System.EventHandler(this.rbtnUnidad_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "Contraseña";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGuardar.Location = new System.Drawing.Point(47, 552);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(95, 34);
            this.buttonGuardar.TabIndex = 37;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // groupBoxDatosUsuario
            // 
            this.groupBoxDatosUsuario.Controls.Add(this.label8);
            this.groupBoxDatosUsuario.Controls.Add(this.labelDestino);
            this.groupBoxDatosUsuario.Controls.Add(this.buttonEliminarUsuario);
            this.groupBoxDatosUsuario.Controls.Add(this.groupBoxDestino);
            this.groupBoxDatosUsuario.Controls.Add(this.buttonGuardar);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxPassword2);
            this.groupBoxDatosUsuario.Controls.Add(this.label1);
            this.groupBoxDatosUsuario.Controls.Add(this.groupBoxPermisos);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxPassword1);
            this.groupBoxDatosUsuario.Controls.Add(this.treeViewPermisos);
            this.groupBoxDatosUsuario.Controls.Add(this.label7);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxDNI);
            this.groupBoxDatosUsuario.Controls.Add(this.label6);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxUsuario);
            this.groupBoxDatosUsuario.Controls.Add(this.label3);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxNombre);
            this.groupBoxDatosUsuario.Controls.Add(this.label4);
            this.groupBoxDatosUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxDatosUsuario.Location = new System.Drawing.Point(16, 74);
            this.groupBoxDatosUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDatosUsuario.Name = "groupBoxDatosUsuario";
            this.groupBoxDatosUsuario.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDatosUsuario.Size = new System.Drawing.Size(760, 597);
            this.groupBoxDatosUsuario.TabIndex = 25;
            this.groupBoxDatosUsuario.TabStop = false;
            this.groupBoxDatosUsuario.Text = "Datos de Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 14);
            this.label8.TabIndex = 40;
            this.label8.Text = "Destino: ";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Location = new System.Drawing.Point(525, 17);
            this.labelDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(0, 14);
            this.labelDestino.TabIndex = 39;
            // 
            // buttonEliminarUsuario
            // 
            this.buttonEliminarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEliminarUsuario.Location = new System.Drawing.Point(197, 552);
            this.buttonEliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            this.buttonEliminarUsuario.Size = new System.Drawing.Size(109, 34);
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
            this.groupBoxDestino.Location = new System.Drawing.Point(24, 404);
            this.groupBoxDestino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDestino.Name = "groupBoxDestino";
            this.groupBoxDestino.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDestino.Size = new System.Drawing.Size(305, 130);
            this.groupBoxDestino.TabIndex = 32;
            this.groupBoxDestino.TabStop = false;
            this.groupBoxDestino.Text = "Destino";
            // 
            // buttonDesagniarUnidad
            // 
            this.buttonDesagniarUnidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesagniarUnidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDesagniarUnidad.Location = new System.Drawing.Point(173, 90);
            this.buttonDesagniarUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDesagniarUnidad.Name = "buttonDesagniarUnidad";
            this.buttonDesagniarUnidad.Size = new System.Drawing.Size(109, 34);
            this.buttonDesagniarUnidad.TabIndex = 26;
            this.buttonDesagniarUnidad.Text = "Desagsinar";
            this.buttonDesagniarUnidad.UseVisualStyleBackColor = true;
            this.buttonDesagniarUnidad.Click += new System.EventHandler(this.buttonDesagniarUnidad_Click);
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword2.Location = new System.Drawing.Point(27, 235);
            this.textBoxPassword2.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(260, 40);
            this.textBoxPassword2.TabIndex = 29;
            this.textBoxPassword2.Texto = "";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword1.Location = new System.Drawing.Point(24, 179);
            this.textBoxPassword1.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(260, 34);
            this.textBoxPassword1.TabIndex = 28;
            this.textBoxPassword1.Texto = "";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(575, 24);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 37;
            this.rjButton1.Text = "Configurar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // Form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(792, 675);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxUsuarios);
            this.Controls.Add(this.groupBoxDatosUsuario);
            this.Controls.Add(this.buttonGuardarUsuario);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Button buttonDesagsinarRol;
        private System.Windows.Forms.Button buttonDesagniarUnidad;
        private System.Windows.Forms.Label label8;
        private Seguridad.RJButton rjButton1;
    }
}