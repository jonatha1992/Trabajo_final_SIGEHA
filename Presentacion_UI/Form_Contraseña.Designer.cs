namespace Presentacion_UI
{
    partial class Form_Contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Contraseña));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword2 = new Presentacion_UI.TextBoxPassword();
            this.textBoxPassword1 = new Presentacion_UI.TextBoxPassword();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.ButtonGuardar = new Seguridad.RJButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre Completo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonGuardar);
            this.groupBox1.Controls.Add(this.textBoxPassword2);
            this.groupBox1.Controls.Add(this.textBoxPassword1);
            this.groupBox1.Controls.Add(this.textBoxUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDNI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 327);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuario";
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword2.Location = new System.Drawing.Point(51, 228);
            this.textBoxPassword2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(213, 37);
            this.textBoxPassword2.TabIndex = 34;
            this.textBoxPassword2.Texto = "";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword1.Location = new System.Drawing.Point(51, 171);
            this.textBoxPassword1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(215, 31);
            this.textBoxPassword1.TabIndex = 33;
            this.textBoxPassword1.Texto = "";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Enabled = false;
            this.textBoxUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(54, 81);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(196, 21);
            this.textBoxUsuario.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 28;
            this.label6.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Repetir Contraseña";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Enabled = false;
            this.textBoxDNI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.Location = new System.Drawing.Point(54, 36);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(196, 21);
            this.textBoxDNI.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 14);
            this.label7.TabIndex = 30;
            this.label7.Text = "Contraseña";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(54, 125);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(196, 21);
            this.textBoxNombre.TabIndex = 25;
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonGuardar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonGuardar.BorderRadius = 20;
            this.ButtonGuardar.BorderSize = 0;
            this.ButtonGuardar.FlatAppearance.BorderSize = 0;
            this.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGuardar.ForeColor = System.Drawing.Color.White;
            this.ButtonGuardar.Location = new System.Drawing.Point(38, 278);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(226, 40);
            this.ButtonGuardar.TabIndex = 35;
            this.ButtonGuardar.Text = "Cambiar Contraseña";
            this.ButtonGuardar.TextColor = System.Drawing.Color.White;
            this.ButtonGuardar.UseVisualStyleBackColor = false;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // Form_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(336, 351);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "Form_Contraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contraseña";
            this.Load += new System.EventHandler(this.FormPermisos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label3;
        private TextBoxPassword textBoxPassword2;
        private TextBoxPassword textBoxPassword1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Seguridad.RJButton ButtonGuardar;
    }
}