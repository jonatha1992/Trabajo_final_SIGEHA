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
            this.Entrega = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrearHallazgo = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionHallazgo = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaYModificacionEntregaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Administracion = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.Informe = new System.Windows.Forms.ToolStripMenuItem();
            this.backUp = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.ABMCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Hallazgo,
            this.Entrega,
            this.Administracion,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2864, 50);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Hallazgo
            // 
            this.Hallazgo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearHallazgo,
            this.GestionHallazgo});
            this.Hallazgo.Name = "Hallazgo";
            this.Hallazgo.Size = new System.Drawing.Size(173, 42);
            this.Hallazgo.Text = "Hallazgo";
            this.Hallazgo.Click += new System.EventHandler(this.hallazgoToolStripMenuItem_Click);
            // 
            // Entrega
            // 
            this.Entrega.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearEntrega,
            this.bajaYModificacionEntregaToolStripMenuItem1});
            this.Entrega.Name = "Entrega";
            this.Entrega.Size = new System.Drawing.Size(161, 42);
            this.Entrega.Text = "Entrega";
            this.Entrega.Click += new System.EventHandler(this.entregaToolStripMenuItem1_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(128, 42);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Presentacion_UI.Properties.Resources.Logo_PSA;
            this.pictureBox1.Location = new System.Drawing.Point(964, 187);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 857);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2864, 1226);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CrearHallazgo
            // 
            this.CrearHallazgo.Name = "CrearHallazgo";
            this.CrearHallazgo.Size = new System.Drawing.Size(432, 48);
            this.CrearHallazgo.Text = "Crear Hallazgo";
            this.CrearHallazgo.Click += new System.EventHandler(this.CrearHallazgo_Click);
            // 
            // GestionHallazgo
            // 
            this.GestionHallazgo.Name = "GestionHallazgo";
            this.GestionHallazgo.Size = new System.Drawing.Size(432, 48);
            this.GestionHallazgo.Text = "Gestion Hallazgo";
            // 
            // CrearEntrega
            // 
            this.CrearEntrega.Name = "CrearEntrega";
            this.CrearEntrega.Size = new System.Drawing.Size(604, 48);
            this.CrearEntrega.Text = "Crear Entrega";
            // 
            // bajaYModificacionEntregaToolStripMenuItem1
            // 
            this.bajaYModificacionEntregaToolStripMenuItem1.Name = "bajaYModificacionEntregaToolStripMenuItem1";
            this.bajaYModificacionEntregaToolStripMenuItem1.Size = new System.Drawing.Size(604, 48);
            this.bajaYModificacionEntregaToolStripMenuItem1.Text = "Baja y Modificacion Entrega";
            // 
            // Administracion
            // 
            this.Administracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reporte,
            this.Informe,
            this.backUp,
            this.GestionUsuarios,
            this.GestionPermisos,
            this.ABMCategorias});
            this.Administracion.Name = "Administracion";
            this.Administracion.Size = new System.Drawing.Size(276, 42);
            this.Administracion.Text = "Administracion";
            // 
            // Reporte
            // 
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(444, 48);
            this.Reporte.Text = "Reporte Excel";
            // 
            // Informe
            // 
            this.Informe.Name = "Informe";
            this.Informe.Size = new System.Drawing.Size(444, 48);
            this.Informe.Text = "Informe";
            // 
            // backUp
            // 
            this.backUp.Name = "backUp";
            this.backUp.Size = new System.Drawing.Size(444, 48);
            this.backUp.Text = "Back Up";
            // 
            // GestionUsuarios
            // 
            this.GestionUsuarios.Name = "GestionUsuarios";
            this.GestionUsuarios.Size = new System.Drawing.Size(444, 48);
            this.GestionUsuarios.Text = "Gestion Usuarios";
            // 
            // GestionPermisos
            // 
            this.GestionPermisos.Name = "GestionPermisos";
            this.GestionPermisos.Size = new System.Drawing.Size(444, 48);
            this.GestionPermisos.Text = "Gestion Permisos";
            // 
            // ABMCategorias
            // 
            this.ABMCategorias.Name = "ABMCategorias";
            this.ABMCategorias.Size = new System.Drawing.Size(444, 48);
            this.ABMCategorias.Text = "ABM Categorias";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1204);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2864, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form_Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(2864, 1276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.Name = "Form_Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGEHA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Contenedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Hallazgo;
        private System.Windows.Forms.ToolStripMenuItem Entrega;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem CrearHallazgo;
        private System.Windows.Forms.ToolStripMenuItem GestionHallazgo;
        private System.Windows.Forms.ToolStripMenuItem CrearEntrega;
        private System.Windows.Forms.ToolStripMenuItem bajaYModificacionEntregaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Administracion;
        private System.Windows.Forms.ToolStripMenuItem Reporte;
        private System.Windows.Forms.ToolStripMenuItem Informe;
        private System.Windows.Forms.ToolStripMenuItem backUp;
        private System.Windows.Forms.ToolStripMenuItem GestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem GestionPermisos;
        private System.Windows.Forms.ToolStripMenuItem ABMCategorias;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }

    
}

