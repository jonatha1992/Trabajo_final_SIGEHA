namespace Seguridad
{
    partial class TextBoxPassword
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1raContrasena = new System.Windows.Forms.PictureBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1raContrasena)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1raContrasena
            // 
            this.pictureBox1raContrasena.Image = global::Seguridad.Properties.Resources.icons_no_visible_16;
            this.pictureBox1raContrasena.Location = new System.Drawing.Point(164, 9);
            this.pictureBox1raContrasena.Name = "pictureBox1raContrasena";
            this.pictureBox1raContrasena.Size = new System.Drawing.Size(18, 19);
            this.pictureBox1raContrasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1raContrasena.TabIndex = 37;
            this.pictureBox1raContrasena.TabStop = false;
            this.pictureBox1raContrasena.Click += new System.EventHandler(this.pictureBox1raContrasena_Click);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(3, 5);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(152, 25);
            this.textBoxContraseña.TabIndex = 38;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            // 
            // TextBoxPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.pictureBox1raContrasena);
            this.Name = "TextBoxPassword";
            this.Size = new System.Drawing.Size(195, 34);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1raContrasena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1raContrasena;
        private System.Windows.Forms.TextBox textBoxContraseña;
    }
}
