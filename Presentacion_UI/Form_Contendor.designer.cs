namespace Presentacion_UI
{
    partial class Form_Contenedor
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Contenedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Hallazgo = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerarHallazgo = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionHallazgo = new System.Windows.Forms.ToolStripMenuItem();
            this.Entrega = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerarEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.Administracion = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.BackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.ABMCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.Bitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.Login = new System.Windows.Forms.ToolStripMenuItem();
            this.CambiarContrasena = new System.Windows.Forms.ToolStripMenuItem();
            this.customTitleBar1 = new Seguridad.CustomTitleBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Hallazgo,
            this.Entrega,
            this.Administracion,
            this.Login,
            this.CambiarContrasena});
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1416, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Hallazgo
            // 
            this.Hallazgo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerarHallazgo,
            this.GestionHallazgo});
            this.Hallazgo.Name = "Hallazgo";
            this.Hallazgo.Size = new System.Drawing.Size(163, 28);
            this.Hallazgo.Text = "Menú Hallazgo";
            // 
            // GenerarHallazgo
            // 
            this.GenerarHallazgo.Name = "GenerarHallazgo";
            this.GenerarHallazgo.Size = new System.Drawing.Size(224, 28);
            this.GenerarHallazgo.Text = "Generar";
            this.GenerarHallazgo.Click += new System.EventHandler(this.CrearHallazgo_Click);
            // 
            // GestionHallazgo
            // 
            this.GestionHallazgo.Name = "GestionHallazgo";
            this.GestionHallazgo.Size = new System.Drawing.Size(224, 28);
            this.GestionHallazgo.Text = "Gestión";
            this.GestionHallazgo.Click += new System.EventHandler(this.GestionHallazgo_Click);
            // 
            // Entrega
            // 
            this.Entrega.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerarEntrega,
            this.GestionEntrega});
            this.Entrega.Name = "Entrega";
            this.Entrega.Size = new System.Drawing.Size(151, 28);
            this.Entrega.Text = "Menú Entrega";
            // 
            // GenerarEntrega
            // 
            this.GenerarEntrega.Name = "GenerarEntrega";
            this.GenerarEntrega.Size = new System.Drawing.Size(224, 28);
            this.GenerarEntrega.Text = "Generar";
            this.GenerarEntrega.Click += new System.EventHandler(this.GenerarEntrega_Click);
            // 
            // GestionEntrega
            // 
            this.GestionEntrega.Name = "GestionEntrega";
            this.GestionEntrega.Size = new System.Drawing.Size(224, 28);
            this.GestionEntrega.Text = "Gestión";
            this.GestionEntrega.Click += new System.EventHandler(this.GestionEntrega_Click);
            // 
            // Administracion
            // 
            this.Administracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reporte,
            this.BackUp,
            this.GestionUsuarios,
            this.GestionPermisos,
            this.ABMCategorias,
            this.Bitacora});
            this.Administracion.Name = "Administracion";
            this.Administracion.Size = new System.Drawing.Size(219, 28);
            this.Administracion.Text = "Menú Administración";
            // 
            // Reporte
            // 
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(249, 28);
            this.Reporte.Text = "Reporte";
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // BackUp
            // 
            this.BackUp.Name = "BackUp";
            this.BackUp.Size = new System.Drawing.Size(249, 28);
            this.BackUp.Text = "Back Up";
            this.BackUp.Click += new System.EventHandler(this.BackUp_Click);
            // 
            // GestionUsuarios
            // 
            this.GestionUsuarios.Name = "GestionUsuarios";
            this.GestionUsuarios.Size = new System.Drawing.Size(249, 28);
            this.GestionUsuarios.Text = "Gestion Usuarios";
            this.GestionUsuarios.Click += new System.EventHandler(this.GestionUsuarios_Click);
            // 
            // GestionPermisos
            // 
            this.GestionPermisos.Name = "GestionPermisos";
            this.GestionPermisos.Size = new System.Drawing.Size(249, 28);
            this.GestionPermisos.Text = "Gestion Permisos";
            this.GestionPermisos.Click += new System.EventHandler(this.GestionPermisos_Click);
            // 
            // ABMCategorias
            // 
            this.ABMCategorias.Name = "ABMCategorias";
            this.ABMCategorias.Size = new System.Drawing.Size(249, 28);
            this.ABMCategorias.Text = "ABM Categorias";
            // 
            // Bitacora
            // 
            this.Bitacora.Name = "Bitacora";
            this.Bitacora.Size = new System.Drawing.Size(249, 28);
            this.Bitacora.Text = "Bitacora";
            this.Bitacora.Click += new System.EventHandler(this.bitacora_Click);
            // 
            // Login
            // 
            this.Login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(142, 28);
            this.Login.Text = "Iniciar sesión";
            this.Login.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Login.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // CambiarContrasena
            // 
            this.CambiarContrasena.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CambiarContrasena.Name = "CambiarContrasena";
            this.CambiarContrasena.Size = new System.Drawing.Size(219, 28);
            this.CambiarContrasena.Text = "Cambiar Contraseña";
            this.CambiarContrasena.Click += new System.EventHandler(this.CambiarContrasena_Click);
            // 
            // customTitleBar1
            // 
            this.customTitleBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customTitleBar1.CloseButtonVisible = true;
            this.customTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTitleBar1.Icon = ((System.Drawing.Image)(resources.GetObject("customTitleBar1.Icon")));
            this.customTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.customTitleBar1.Margin = new System.Windows.Forms.Padding(4);
            this.customTitleBar1.MaximizeButtonVisible = true;
            this.customTitleBar1.MinimizeButtonVisible = true;
            this.customTitleBar1.Name = "customTitleBar1";
            this.customTitleBar1.Size = new System.Drawing.Size(1416, 36);
            this.customTitleBar1.TabIndex = 3;
            this.customTitleBar1.Title = "SIGEHA";
            // 
            // Form_Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1416, 550);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.customTitleBar1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGEHA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Contenedor_FormClosing);
            this.Load += new System.EventHandler(this.Form_Contenedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Hallazgo;
        private System.Windows.Forms.ToolStripMenuItem Entrega;
        private System.Windows.Forms.ToolStripMenuItem Login;
        private System.Windows.Forms.ToolStripMenuItem GenerarHallazgo;
        private System.Windows.Forms.ToolStripMenuItem GestionHallazgo;
        private System.Windows.Forms.ToolStripMenuItem GenerarEntrega;
        private System.Windows.Forms.ToolStripMenuItem GestionEntrega;
        private System.Windows.Forms.ToolStripMenuItem Administracion;
        private System.Windows.Forms.ToolStripMenuItem Reporte;
        private System.Windows.Forms.ToolStripMenuItem BackUp;
        private System.Windows.Forms.ToolStripMenuItem GestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem GestionPermisos;
        private System.Windows.Forms.ToolStripMenuItem ABMCategorias;
        private System.Windows.Forms.ToolStripMenuItem CambiarContrasena;
        private System.Windows.Forms.ToolStripMenuItem Bitacora;
        private Seguridad.CustomTitleBar customTitleBar1;
    }

    
}

