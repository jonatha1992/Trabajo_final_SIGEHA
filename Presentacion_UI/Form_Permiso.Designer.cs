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
            this.treeViewPermisos = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Location = new System.Drawing.Point(38, 44);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(537, 510);
            this.treeViewPermisos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 112);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(410, 581);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(155, 112);
            this.button.TabIndex = 2;
            this.button.Text = "Desahacer";
            this.button.UseVisualStyleBackColor = true;
            // 
            // FormPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 934);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeViewPermisos);
            this.Name = "FormPermisos";
            this.Text = "Gestion Usuarios";
            this.Load += new System.EventHandler(this.FormPermisos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewPermisos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button;
    }
}