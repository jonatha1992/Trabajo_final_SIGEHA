using Seguridad;

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
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.treeViewPermisos = new System.Windows.Forms.TreeView();
            this.groupBoxPermisos = new System.Windows.Forms.GroupBox();
            this.ButtonDesasignarRol = new Seguridad.RJButton();
            this.ButtonAsignar = new Seguridad.RJButton();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rjButton1 = new Seguridad.RJButton();
            this.rjButton2 = new Seguridad.RJButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDatosUsuario = new System.Windows.Forms.GroupBox();
            this.ButtonGuardar = new Seguridad.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.groupBoxDestino = new System.Windows.Forms.GroupBox();
            this.RadioButtonUnidad = new Seguridad.RJRadioButton();
            this.rjButtonDesasignarDestino = new Seguridad.RJButton();
            this.radiobuttonUrsa = new Seguridad.RJRadioButton();
            this.rjButtonAsignarDestino = new Seguridad.RJButton();
            this.textBoxPassword4 = new Seguridad.TextBoxPassword();
            this.textBoxPassword2 = new Seguridad.TextBoxPassword();
            this.textBoxPassword3 = new Seguridad.TextBoxPassword();
            this.textBoxPassword1 = new Seguridad.TextBoxPassword();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.customTitleBar1 = new Seguridad.CustomTitleBar();
            this.ButtonEliminarUsuario = new Seguridad.RJButton();
            this.ButtonGenerarUsuario = new Seguridad.RJButton();
            this.ButtonConfiguracion = new Seguridad.RJButton();
            this.groupBoxPermisos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDatosUsuario.SuspendLayout();
            this.groupBoxDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsuarios.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(35, 55);
            this.comboBoxUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(189, 23);
            this.comboBoxUsuarios.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre Completo";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(38, 80);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(227, 23);
            this.textBoxNombre.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(38, 36);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(227, 23);
            this.textBoxUsuario.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "DNI";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDNI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.Location = new System.Drawing.Point(38, 124);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(227, 23);
            this.textBoxDNI.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Contraseña";
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Location = new System.Drawing.Point(311, 65);
            this.treeViewPermisos.Margin = new System.Windows.Forms.Padding(1);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(332, 466);
            this.treeViewPermisos.TabIndex = 0;
            this.treeViewPermisos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPermisos_AfterSelect);
            // 
            // groupBoxPermisos
            // 
            this.groupBoxPermisos.Controls.Add(this.ButtonDesasignarRol);
            this.groupBoxPermisos.Controls.Add(this.ButtonAsignar);
            this.groupBoxPermisos.Controls.Add(this.comboBoxRoles);
            this.groupBoxPermisos.Controls.Add(this.label5);
            this.groupBoxPermisos.Controls.Add(this.groupBox1);
            this.groupBoxPermisos.ForeColor = System.Drawing.Color.White;
            this.groupBoxPermisos.Location = new System.Drawing.Point(21, 255);
            this.groupBoxPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPermisos.Name = "groupBoxPermisos";
            this.groupBoxPermisos.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPermisos.Size = new System.Drawing.Size(267, 117);
            this.groupBoxPermisos.TabIndex = 31;
            this.groupBoxPermisos.TabStop = false;
            this.groupBoxPermisos.Text = "Permisos";
            // 
            // ButtonDesasignarRol
            // 
            this.ButtonDesasignarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ButtonDesasignarRol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ButtonDesasignarRol.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonDesasignarRol.BorderRadius = 20;
            this.ButtonDesasignarRol.BorderSize = 0;
            this.ButtonDesasignarRol.FlatAppearance.BorderSize = 0;
            this.ButtonDesasignarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDesasignarRol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDesasignarRol.ForeColor = System.Drawing.Color.Black;
            this.ButtonDesasignarRol.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDesasignarRol.Image")));
            this.ButtonDesasignarRol.Location = new System.Drawing.Point(140, 78);
            this.ButtonDesasignarRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonDesasignarRol.Name = "ButtonDesasignarRol";
            this.ButtonDesasignarRol.Size = new System.Drawing.Size(109, 28);
            this.ButtonDesasignarRol.TabIndex = 42;
            this.ButtonDesasignarRol.Text = "Desasignar";
            this.ButtonDesasignarRol.TextColor = System.Drawing.Color.Black;
            this.ButtonDesasignarRol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDesasignarRol.UseVisualStyleBackColor = false;
            this.ButtonDesasignarRol.Click += new System.EventHandler(this.buttonDesagsinarRol_Click);
            // 
            // ButtonAsignar
            // 
            this.ButtonAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.ButtonAsignar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.ButtonAsignar.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonAsignar.BorderRadius = 20;
            this.ButtonAsignar.BorderSize = 0;
            this.ButtonAsignar.FlatAppearance.BorderSize = 0;
            this.ButtonAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAsignar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAsignar.ForeColor = System.Drawing.Color.Black;
            this.ButtonAsignar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAsignar.Image")));
            this.ButtonAsignar.Location = new System.Drawing.Point(22, 78);
            this.ButtonAsignar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAsignar.Name = "ButtonAsignar";
            this.ButtonAsignar.Size = new System.Drawing.Size(90, 28);
            this.ButtonAsignar.TabIndex = 41;
            this.ButtonAsignar.Text = "Asignar";
            this.ButtonAsignar.TextColor = System.Drawing.Color.Black;
            this.ButtonAsignar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAsignar.UseVisualStyleBackColor = false;
            this.ButtonAsignar.Click += new System.EventHandler(this.buttonAsignarRol_Click);
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.BackColor = System.Drawing.Color.Silver;
            this.comboBoxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(20, 41);
            this.comboBoxRoles.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(227, 23);
            this.comboBoxRoles.TabIndex = 30;
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Roles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rjButton1);
            this.groupBox1.Controls.Add(this.rjButton2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 117);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.rjButton1.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.Location = new System.Drawing.Point(140, 78);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(109, 28);
            this.rjButton1.TabIndex = 42;
            this.rjButton1.Text = "Desasignar";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.buttonDesagsinarRol_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.rjButton2.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Image = ((System.Drawing.Image)(resources.GetObject("rjButton2.Image")));
            this.rjButton2.Location = new System.Drawing.Point(22, 78);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(90, 28);
            this.rjButton2.TabIndex = 41;
            this.rjButton2.Text = "  Asignar";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.buttonAsignarRol_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Silver;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 41);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 23);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Roles";
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestino.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(22, 57);
            this.comboBoxDestino.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(227, 23);
            this.comboBoxDestino.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Repetir Contraseña";
            // 
            // groupBoxDatosUsuario
            // 
            this.groupBoxDatosUsuario.Controls.Add(this.ButtonGuardar);
            this.groupBoxDatosUsuario.Controls.Add(this.label8);
            this.groupBoxDatosUsuario.Controls.Add(this.labelDestino);
            this.groupBoxDatosUsuario.Controls.Add(this.groupBoxDestino);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxPassword4);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxPassword2);
            this.groupBoxDatosUsuario.Controls.Add(this.label1);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxPassword3);
            this.groupBoxDatosUsuario.Controls.Add(this.groupBoxPermisos);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxPassword1);
            this.groupBoxDatosUsuario.Controls.Add(this.treeViewPermisos);
            this.groupBoxDatosUsuario.Controls.Add(this.textBox3);
            this.groupBoxDatosUsuario.Controls.Add(this.label7);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxDNI);
            this.groupBoxDatosUsuario.Controls.Add(this.textBox2);
            this.groupBoxDatosUsuario.Controls.Add(this.label6);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxUsuario);
            this.groupBoxDatosUsuario.Controls.Add(this.textBox1);
            this.groupBoxDatosUsuario.Controls.Add(this.label3);
            this.groupBoxDatosUsuario.Controls.Add(this.textBoxNombre);
            this.groupBoxDatosUsuario.Controls.Add(this.label4);
            this.groupBoxDatosUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxDatosUsuario.Location = new System.Drawing.Point(17, 82);
            this.groupBoxDatosUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDatosUsuario.Name = "groupBoxDatosUsuario";
            this.groupBoxDatosUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDatosUsuario.Size = new System.Drawing.Size(665, 564);
            this.groupBoxDatosUsuario.TabIndex = 25;
            this.groupBoxDatosUsuario.TabStop = false;
            this.groupBoxDatosUsuario.Text = "Datos de Usuario";
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ButtonGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ButtonGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonGuardar.BorderRadius = 20;
            this.ButtonGuardar.BorderSize = 0;
            this.ButtonGuardar.FlatAppearance.BorderSize = 0;
            this.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGuardar.ForeColor = System.Drawing.Color.White;
            this.ButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGuardar.Image")));
            this.ButtonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGuardar.Location = new System.Drawing.Point(74, 520);
            this.ButtonGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(133, 38);
            this.ButtonGuardar.TabIndex = 39;
            this.ButtonGuardar.Text = "Guardar Usuario";
            this.ButtonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonGuardar.TextColor = System.Drawing.Color.White;
            this.ButtonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonGuardar.UseVisualStyleBackColor = false;
            this.ButtonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Destino: ";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestino.Location = new System.Drawing.Point(452, 26);
            this.labelDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(0, 16);
            this.labelDestino.TabIndex = 39;
            // 
            // groupBoxDestino
            // 
            this.groupBoxDestino.Controls.Add(this.RadioButtonUnidad);
            this.groupBoxDestino.Controls.Add(this.rjButtonDesasignarDestino);
            this.groupBoxDestino.Controls.Add(this.radiobuttonUrsa);
            this.groupBoxDestino.Controls.Add(this.rjButtonAsignarDestino);
            this.groupBoxDestino.Controls.Add(this.comboBoxDestino);
            this.groupBoxDestino.ForeColor = System.Drawing.Color.White;
            this.groupBoxDestino.Location = new System.Drawing.Point(21, 380);
            this.groupBoxDestino.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDestino.Name = "groupBoxDestino";
            this.groupBoxDestino.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDestino.Size = new System.Drawing.Size(267, 132);
            this.groupBoxDestino.TabIndex = 32;
            this.groupBoxDestino.TabStop = false;
            this.groupBoxDestino.Text = "Destino";
            // 
            // RadioButtonUnidad
            // 
            this.RadioButtonUnidad.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonUnidad.CheckedColor = System.Drawing.Color.SteelBlue;
            this.RadioButtonUnidad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonUnidad.Location = new System.Drawing.Point(159, 23);
            this.RadioButtonUnidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButtonUnidad.MinimumSize = new System.Drawing.Size(0, 22);
            this.RadioButtonUnidad.Name = "RadioButtonUnidad";
            this.RadioButtonUnidad.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.RadioButtonUnidad.Size = new System.Drawing.Size(68, 22);
            this.RadioButtonUnidad.TabIndex = 40;
            this.RadioButtonUnidad.TabStop = true;
            this.RadioButtonUnidad.Text = "Unidad";
            this.RadioButtonUnidad.UnCheckedColor = System.Drawing.Color.White;
            this.RadioButtonUnidad.UseVisualStyleBackColor = false;
            this.RadioButtonUnidad.CheckedChanged += new System.EventHandler(this.rbtnUnidad_CheckedChanged);
            // 
            // rjButtonDesasignarDestino
            // 
            this.rjButtonDesasignarDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.rjButtonDesasignarDestino.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.rjButtonDesasignarDestino.BorderColor = System.Drawing.Color.Transparent;
            this.rjButtonDesasignarDestino.BorderRadius = 20;
            this.rjButtonDesasignarDestino.BorderSize = 0;
            this.rjButtonDesasignarDestino.FlatAppearance.BorderSize = 0;
            this.rjButtonDesasignarDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonDesasignarDestino.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonDesasignarDestino.ForeColor = System.Drawing.Color.Black;
            this.rjButtonDesasignarDestino.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonDesasignarDestino.Image")));
            this.rjButtonDesasignarDestino.Location = new System.Drawing.Point(140, 93);
            this.rjButtonDesasignarDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButtonDesasignarDestino.Name = "rjButtonDesasignarDestino";
            this.rjButtonDesasignarDestino.Size = new System.Drawing.Size(109, 28);
            this.rjButtonDesasignarDestino.TabIndex = 43;
            this.rjButtonDesasignarDestino.Text = "Desasignar";
            this.rjButtonDesasignarDestino.TextColor = System.Drawing.Color.Black;
            this.rjButtonDesasignarDestino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButtonDesasignarDestino.UseVisualStyleBackColor = false;
            this.rjButtonDesasignarDestino.Click += new System.EventHandler(this.buttonDesagniarDestino_Click);
            // 
            // radiobuttonUrsa
            // 
            this.radiobuttonUrsa.BackColor = System.Drawing.Color.Transparent;
            this.radiobuttonUrsa.CheckedColor = System.Drawing.Color.SteelBlue;
            this.radiobuttonUrsa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonUrsa.Location = new System.Drawing.Point(22, 23);
            this.radiobuttonUrsa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radiobuttonUrsa.MinimumSize = new System.Drawing.Size(0, 22);
            this.radiobuttonUrsa.Name = "radiobuttonUrsa";
            this.radiobuttonUrsa.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.radiobuttonUrsa.Size = new System.Drawing.Size(61, 22);
            this.radiobuttonUrsa.TabIndex = 39;
            this.radiobuttonUrsa.TabStop = true;
            this.radiobuttonUrsa.Text = "Ursa";
            this.radiobuttonUrsa.UnCheckedColor = System.Drawing.Color.White;
            this.radiobuttonUrsa.UseVisualStyleBackColor = false;
            this.radiobuttonUrsa.CheckedChanged += new System.EventHandler(this.rbtnUrsa_CheckedChanged);
            // 
            // rjButtonAsignarDestino
            // 
            this.rjButtonAsignarDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.rjButtonAsignarDestino.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.rjButtonAsignarDestino.BorderColor = System.Drawing.Color.Transparent;
            this.rjButtonAsignarDestino.BorderRadius = 20;
            this.rjButtonAsignarDestino.BorderSize = 0;
            this.rjButtonAsignarDestino.FlatAppearance.BorderSize = 0;
            this.rjButtonAsignarDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonAsignarDestino.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonAsignarDestino.ForeColor = System.Drawing.Color.Black;
            this.rjButtonAsignarDestino.Image = ((System.Drawing.Image)(resources.GetObject("rjButtonAsignarDestino.Image")));
            this.rjButtonAsignarDestino.Location = new System.Drawing.Point(20, 94);
            this.rjButtonAsignarDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButtonAsignarDestino.Name = "rjButtonAsignarDestino";
            this.rjButtonAsignarDestino.Size = new System.Drawing.Size(90, 28);
            this.rjButtonAsignarDestino.TabIndex = 43;
            this.rjButtonAsignarDestino.Text = "Asignar";
            this.rjButtonAsignarDestino.TextColor = System.Drawing.Color.Black;
            this.rjButtonAsignarDestino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButtonAsignarDestino.UseVisualStyleBackColor = false;
            this.rjButtonAsignarDestino.Click += new System.EventHandler(this.buttonAsignarDestino_Click);
            // 
            // textBoxPassword4
            // 
            this.textBoxPassword4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword4.Location = new System.Drawing.Point(37, 219);
            this.textBoxPassword4.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.textBoxPassword4.Name = "textBoxPassword4";
            this.textBoxPassword4.Size = new System.Drawing.Size(265, 32);
            this.textBoxPassword4.TabIndex = 29;
            this.textBoxPassword4.Texto = "";
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword2.Location = new System.Drawing.Point(37, 219);
            this.textBoxPassword2.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(227, 28);
            this.textBoxPassword2.TabIndex = 29;
            this.textBoxPassword2.Texto = "";
            // 
            // textBoxPassword3
            // 
            this.textBoxPassword3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword3.Location = new System.Drawing.Point(38, 166);
            this.textBoxPassword3.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.textBoxPassword3.Name = "textBoxPassword3";
            this.textBoxPassword3.Size = new System.Drawing.Size(265, 35);
            this.textBoxPassword3.TabIndex = 28;
            this.textBoxPassword3.Texto = "";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword1.Location = new System.Drawing.Point(38, 166);
            this.textBoxPassword1.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(227, 30);
            this.textBoxPassword1.TabIndex = 28;
            this.textBoxPassword1.Texto = "";
            // 
            // textBox3
            // 
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(38, 124);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 21);
            this.textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(38, 36);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 21);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(38, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 21);
            this.textBox1.TabIndex = 25;
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.BackColor = System.Drawing.Color.SlateGray;
            this.customTitleBar1.CloseButtonVisible = true;
            this.customTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTitleBar1.Icon = ((System.Drawing.Image)(resources.GetObject("customTitleBar1.Icon")));
            this.customTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.customTitleBar1.MaximizeButtonVisible = true;
            this.customTitleBar1.MinimizeButtonVisible = true;
            this.customTitleBar1.Name = "customTitleBar1";
            this.customTitleBar1.Size = new System.Drawing.Size(695, 29);
            this.customTitleBar1.TabIndex = 44;
            this.customTitleBar1.Title = "Gestión Usuarios";
            // 
            // ButtonEliminarUsuario
            // 
            this.ButtonEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ButtonEliminarUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ButtonEliminarUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonEliminarUsuario.BorderRadius = 20;
            this.ButtonEliminarUsuario.BorderSize = 0;
            this.ButtonEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.ButtonEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEliminarUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.ButtonEliminarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEliminarUsuario.Image")));
            this.ButtonEliminarUsuario.Location = new System.Drawing.Point(513, 43);
            this.ButtonEliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonEliminarUsuario.Name = "ButtonEliminarUsuario";
            this.ButtonEliminarUsuario.Size = new System.Drawing.Size(105, 35);
            this.ButtonEliminarUsuario.TabIndex = 43;
            this.ButtonEliminarUsuario.Text = "Eliminar";
            this.ButtonEliminarUsuario.TextColor = System.Drawing.Color.White;
            this.ButtonEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonEliminarUsuario.UseVisualStyleBackColor = false;
            this.ButtonEliminarUsuario.Visible = false;
            this.ButtonEliminarUsuario.Click += new System.EventHandler(this.buttonEliminarUsuario_Click);
            // 
            // ButtonGenerarUsuario
            // 
            this.ButtonGenerarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ButtonGenerarUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ButtonGenerarUsuario.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonGenerarUsuario.BorderRadius = 20;
            this.ButtonGenerarUsuario.BorderSize = 0;
            this.ButtonGenerarUsuario.FlatAppearance.BorderSize = 0;
            this.ButtonGenerarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGenerarUsuario.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ButtonGenerarUsuario.ForeColor = System.Drawing.Color.White;
            this.ButtonGenerarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGenerarUsuario.Image")));
            this.ButtonGenerarUsuario.Location = new System.Drawing.Point(378, 43);
            this.ButtonGenerarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonGenerarUsuario.Name = "ButtonGenerarUsuario";
            this.ButtonGenerarUsuario.Size = new System.Drawing.Size(105, 35);
            this.ButtonGenerarUsuario.TabIndex = 38;
            this.ButtonGenerarUsuario.Text = "Nuevo";
            this.ButtonGenerarUsuario.TextColor = System.Drawing.Color.White;
            this.ButtonGenerarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonGenerarUsuario.UseVisualStyleBackColor = false;
            this.ButtonGenerarUsuario.Click += new System.EventHandler(this.ButtonGenerarUsuario_Click);
            // 
            // ButtonConfiguracion
            // 
            this.ButtonConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ButtonConfiguracion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ButtonConfiguracion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonConfiguracion.BorderRadius = 20;
            this.ButtonConfiguracion.BorderSize = 0;
            this.ButtonConfiguracion.FlatAppearance.BorderSize = 0;
            this.ButtonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfiguracion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfiguracion.ForeColor = System.Drawing.Color.White;
            this.ButtonConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("ButtonConfiguracion.Image")));
            this.ButtonConfiguracion.Location = new System.Drawing.Point(242, 43);
            this.ButtonConfiguracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonConfiguracion.Name = "ButtonConfiguracion";
            this.ButtonConfiguracion.Size = new System.Drawing.Size(105, 35);
            this.ButtonConfiguracion.TabIndex = 37;
            this.ButtonConfiguracion.Text = "Configurar";
            this.ButtonConfiguracion.TextColor = System.Drawing.Color.White;
            this.ButtonConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonConfiguracion.UseVisualStyleBackColor = false;
            this.ButtonConfiguracion.Click += new System.EventHandler(this.ButtonConfiguracion_Click);
            // 
            // Form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(695, 651);
            this.Controls.Add(this.customTitleBar1);
            this.Controls.Add(this.ButtonEliminarUsuario);
            this.Controls.Add(this.ButtonGenerarUsuario);
            this.Controls.Add(this.ButtonConfiguracion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxUsuarios);
            this.Controls.Add(this.groupBoxDatosUsuario);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "Form_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Usuarios";
            this.Load += new System.EventHandler(this.FormPermisos_Load);
            this.groupBoxPermisos.ResumeLayout(false);
            this.groupBoxPermisos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDatosUsuario.ResumeLayout(false);
            this.groupBoxDatosUsuario.PerformLayout();
            this.groupBoxDestino.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private TextBoxPassword textBoxPassword2;
        private System.Windows.Forms.GroupBox groupBoxDatosUsuario;
        private System.Windows.Forms.GroupBox groupBoxDestino;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label label8;
        private Seguridad.RJButton ButtonConfiguracion;
        private Seguridad.RJButton ButtonGenerarUsuario;
        private Seguridad.RJRadioButton radiobuttonUrsa;
        private Seguridad.RJRadioButton RadioButtonUnidad;
        private Seguridad.RJButton ButtonAsignar;
        private Seguridad.RJButton ButtonDesasignarRol;
        private Seguridad.RJButton rjButtonAsignarDestino;
        private Seguridad.RJButton rjButtonDesasignarDestino;
        private Seguridad.RJButton ButtonGuardar;
        private Seguridad.RJButton ButtonEliminarUsuario;
        private TextBoxPassword textBoxPassword4;
        private System.Windows.Forms.GroupBox groupBox1;
        private RJButton rjButton1;
        private RJButton rjButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private TextBoxPassword textBoxPassword3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private CustomTitleBar customTitleBar1;
    }
}