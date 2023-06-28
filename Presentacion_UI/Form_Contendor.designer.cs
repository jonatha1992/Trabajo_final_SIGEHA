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
            this.CrearHallazgo = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionHallazgo = new System.Windows.Forms.ToolStripMenuItem();
            this.Entrega = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.Administracion = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.Informe = new System.Windows.Forms.ToolStripMenuItem();
            this.BackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.ABMCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Hallazgo,
            this.Entrega,
            this.Administracion,
            this.LoginToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1227, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Hallazgo
            // 
            this.Hallazgo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearHallazgo,
            this.GestionHallazgo});
            this.Hallazgo.Name = "Hallazgo";
            this.Hallazgo.Size = new System.Drawing.Size(81, 22);
            this.Hallazgo.Text = "Hallazgo";
            this.Hallazgo.Click += new System.EventHandler(this.hallazgoToolStripMenuItem_Click);
            // 
            // CrearHallazgo
            // 
            this.CrearHallazgo.Name = "CrearHallazgo";
            this.CrearHallazgo.Size = new System.Drawing.Size(197, 22);
            this.CrearHallazgo.Text = "Crear Hallazgo";
            this.CrearHallazgo.Click += new System.EventHandler(this.CrearHallazgo_Click);
            // 
            // GestionHallazgo
            // 
            this.GestionHallazgo.Name = "GestionHallazgo";
            this.GestionHallazgo.Size = new System.Drawing.Size(197, 22);
            this.GestionHallazgo.Text = "Gestion Hallazgo";
            // 
            // Entrega
            // 
            this.Entrega.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearEntrega,
            this.GestionEntrega});
            this.Entrega.Name = "Entrega";
            this.Entrega.Size = new System.Drawing.Size(76, 22);
            this.Entrega.Text = "Entrega";
            this.Entrega.Click += new System.EventHandler(this.entregaToolStripMenuItem1_Click);
            // 
            // CrearEntrega
            // 
            this.CrearEntrega.Name = "CrearEntrega";
            this.CrearEntrega.Size = new System.Drawing.Size(192, 22);
            this.CrearEntrega.Text = "Crear Entrega";
            // 
            // GestionEntrega
            // 
            this.GestionEntrega.Name = "GestionEntrega";
            this.GestionEntrega.Size = new System.Drawing.Size(192, 22);
            this.GestionEntrega.Text = "Gestion Entrega";
            // 
            // Administracion
            // 
            this.Administracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reporte,
            this.Informe,
            this.BackUp,
            this.GestionUsuarios,
            this.GestionPermisos,
            this.ABMCategorias});
            this.Administracion.Name = "Administracion";
            this.Administracion.Size = new System.Drawing.Size(124, 22);
            this.Administracion.Text = "Administracion";
            // 
            // Reporte
            // 
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(202, 22);
            this.Reporte.Text = "Reporte Excel";
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // Informe
            // 
            this.Informe.Name = "Informe";
            this.Informe.Size = new System.Drawing.Size(202, 22);
            this.Informe.Text = "Informe";
            // 
            // BackUp
            // 
            this.BackUp.Name = "BackUp";
            this.BackUp.Size = new System.Drawing.Size(202, 22);
            this.BackUp.Text = "Back Up";
            // 
            // GestionUsuarios
            // 
            this.GestionUsuarios.Name = "GestionUsuarios";
            this.GestionUsuarios.Size = new System.Drawing.Size(202, 22);
            this.GestionUsuarios.Text = "Gestion Usuarios";
            this.GestionUsuarios.Click += new System.EventHandler(this.GestionUsuarios_Click);
            // 
            // GestionPermisos
            // 
            this.GestionPermisos.Name = "GestionPermisos";
            this.GestionPermisos.Size = new System.Drawing.Size(202, 22);
            this.GestionPermisos.Text = "Gestion Permisos";
            this.GestionPermisos.Click += new System.EventHandler(this.GestionPermisos_Click);
            // 
            // ABMCategorias
            // 
            this.ABMCategorias.Name = "ABMCategorias";
            this.ABMCategorias.Size = new System.Drawing.Size(202, 22);
            this.ABMCategorias.Text = "ABM Categorias";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.LoginToolStripMenuItem.Text = "Iniciar sesión";
            this.LoginToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.LoginToolStripMenuItem.Visible = true;
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuracion";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // Form_Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1227, 473);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGEHA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Contenedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Hallazgo;
        private System.Windows.Forms.ToolStripMenuItem Entrega;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CrearHallazgo;
        private System.Windows.Forms.ToolStripMenuItem GestionHallazgo;
        private System.Windows.Forms.ToolStripMenuItem CrearEntrega;
        private System.Windows.Forms.ToolStripMenuItem GestionEntrega;
        private System.Windows.Forms.ToolStripMenuItem Administracion;
        private System.Windows.Forms.ToolStripMenuItem Reporte;
        private System.Windows.Forms.ToolStripMenuItem Informe;
        private System.Windows.Forms.ToolStripMenuItem BackUp;
        private System.Windows.Forms.ToolStripMenuItem GestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem GestionPermisos;
        private System.Windows.Forms.ToolStripMenuItem ABMCategorias;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
    }

    
}

