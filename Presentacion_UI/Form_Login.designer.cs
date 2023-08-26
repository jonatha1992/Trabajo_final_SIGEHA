using Seguridad;

namespace Presentacion_UI
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.customTitleBar1 = new Seguridad.CustomTitleBar();
            this.ButtonSalir = new Seguridad.RJButton();
            this.ButtonIngresar = new Seguridad.RJButton();
            this.TextBoxPassword1 = new Seguridad.TextBoxPassword();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(194, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(222, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(296, 60);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(177, 27);
            this.textBoxUsuario.TabIndex = 12;
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.BackColor = System.Drawing.Color.SlateGray;
            this.customTitleBar1.CloseButtonVisible = true;
            this.customTitleBar1.Color_Borde = System.Drawing.Color.SteelBlue;
            this.customTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTitleBar1.Icon = null;
            this.customTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.customTitleBar1.MaximizeButtonVisible = true;
            this.customTitleBar1.MinimizeButtonVisible = true;
            this.customTitleBar1.Name = "customTitleBar1";
            this.customTitleBar1.Size = new System.Drawing.Size(535, 25);
            this.customTitleBar1.TabIndex = 20;
            this.customTitleBar1.Title = "Login";
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.ButtonSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.ButtonSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonSalir.BorderRadius = 20;
            this.ButtonSalir.BorderSize = 0;
            this.ButtonSalir.FlatAppearance.BorderSize = 0;
            this.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalir.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalir.ForeColor = System.Drawing.Color.White;
            this.ButtonSalir.Location = new System.Drawing.Point(382, 138);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(91, 40);
            this.ButtonSalir.TabIndex = 19;
            this.ButtonSalir.Text = "Salir";
            this.ButtonSalir.TextColor = System.Drawing.Color.White;
            this.ButtonSalir.UseVisualStyleBackColor = false;
            this.ButtonSalir.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // ButtonIngresar
            // 
            this.ButtonIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.ButtonIngresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.ButtonIngresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonIngresar.BorderRadius = 20;
            this.ButtonIngresar.BorderSize = 0;
            this.ButtonIngresar.FlatAppearance.BorderSize = 0;
            this.ButtonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonIngresar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonIngresar.ForeColor = System.Drawing.Color.White;
            this.ButtonIngresar.Location = new System.Drawing.Point(243, 138);
            this.ButtonIngresar.Name = "ButtonIngresar";
            this.ButtonIngresar.Size = new System.Drawing.Size(91, 40);
            this.ButtonIngresar.TabIndex = 18;
            this.ButtonIngresar.Text = "Ingresar";
            this.ButtonIngresar.TextColor = System.Drawing.Color.White;
            this.ButtonIngresar.UseVisualStyleBackColor = false;
            this.ButtonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // TextBoxPassword1
            // 
            this.TextBoxPassword1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxPassword1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword1.Location = new System.Drawing.Point(291, 90);
            this.TextBoxPassword1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPassword1.Name = "TextBoxPassword1";
            this.TextBoxPassword1.Size = new System.Drawing.Size(226, 43);
            this.TextBoxPassword1.TabIndex = 17;
            this.TextBoxPassword1.Texto = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion_UI.Properties.Resources.Logo_PSA;
            this.pictureBox1.Location = new System.Drawing.Point(44, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(535, 201);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customTitleBar1);
            this.Controls.Add(this.ButtonSalir);
            this.Controls.Add(this.ButtonIngresar);
            this.Controls.Add(this.TextBoxPassword1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsuario);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private TextBoxPassword TextBoxPassword1;
        private RJButton ButtonIngresar;
        private RJButton ButtonSalir;
        private CustomTitleBar customTitleBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}