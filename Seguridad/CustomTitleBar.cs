using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad
{
    public partial class CustomTitleBar : UserControl
    {
        private Button closeButton;
        private Button minimizeButton;
        private Button maximizeButton;
        private PictureBox iconPictureBox;
        private Label titleLabel;

        public CustomTitleBar()
        {
            this.Size = new Size(800, 30);
            this.Dock = DockStyle.Top;

            iconPictureBox = new PictureBox();
            iconPictureBox.Image = Properties.Resources.Logo_PSA1;
            iconPictureBox.Size = new Size(25, 25);
            iconPictureBox.Left = 5;
            iconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            titleLabel = new Label();
            titleLabel.Text = "Login";
            titleLabel.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            titleLabel.AutoSize = false;
            titleLabel.Size = new Size(150, 30);
            titleLabel.Left = iconPictureBox.Right + 10;
            titleLabel.Top = 5;  // Asegúrate de que titleLabel esté dentro de la vista
            titleLabel.ForeColor = Color.White;

            closeButton = new Button();
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Image = Properties.Resources.cerrar;
            closeButton.Size = new Size(30, 30);
            closeButton.BackColor = Color.Transparent;
            closeButton.Click += (sender, e) => this.ParentForm.Close();

            maximizeButton = new Button();
            maximizeButton.FlatStyle = FlatStyle.Flat;
            maximizeButton.FlatAppearance.BorderSize = 0;
            maximizeButton.Image = Properties.Resources.maximizar;
            maximizeButton.Size = new Size(30, 30);
            maximizeButton.BackColor = Color.Transparent;
            maximizeButton.Click += (sender, e) =>
            {
                if (this.ParentForm.WindowState == FormWindowState.Maximized)
                {
                    this.ParentForm.WindowState = FormWindowState.Normal;
                    maximizeButton.Image = Properties.Resources.maximizar;
                }
                else if (this.ParentForm.WindowState == FormWindowState.Normal)
                {
                    this.ParentForm.WindowState = FormWindowState.Maximized;
                    maximizeButton.Image = Properties.Resources.maximizar_tamano;
                }
                else if (this.ParentForm.WindowState == FormWindowState.Minimized)
                {
                    this.ParentForm.WindowState = FormWindowState.Normal;
                    maximizeButton.Image = Properties.Resources.maximizar;
                }
            };



            minimizeButton = new Button();
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.Image = Properties.Resources.minimizar;
            minimizeButton.Size = new Size(30, 30);
            minimizeButton.BackColor = Color.Transparent;
            minimizeButton.Click += (sender, e) => this.ParentForm.WindowState = FormWindowState.Minimized;
            
            this.Controls.Add(iconPictureBox);
            this.Controls.Add(closeButton);
            this.Controls.Add(maximizeButton);
            this.Controls.Add(minimizeButton);
            this.Controls.Add(titleLabel);
            this.Resize += CustomTitleBar_Resize;
        }

       
        public bool MinimizeButtonVisible
        {
            get { return minimizeButton.Visible; }
            set
            {
                minimizeButton.Visible = value;
                AdjustButtonPositions();
            }
        }

        public bool MaximizeButtonVisible
        {
            get { return maximizeButton.Visible; }
            set
            {
                maximizeButton.Visible = value;
                AdjustButtonPositions();
            }
        }

        public bool CloseButtonVisible
        {
            get { return closeButton.Visible; }
            set
            {
                closeButton.Visible = value;
                AdjustButtonPositions();
            }
        }

        private void AdjustButtonPositions()
        {
            int offset = this.Width - 5;

            if (CloseButtonVisible)
            {
                closeButton.Left = offset - closeButton.Width;
                offset = closeButton.Left - 5;
            }

            if (MaximizeButtonVisible)
            {
                maximizeButton.Left = offset - maximizeButton.Width;
                offset = maximizeButton.Left - 5;
            }

            if (MinimizeButtonVisible)
            {
                minimizeButton.Left = offset - minimizeButton.Width;
                offset = minimizeButton.Left - 5;
            }
        }

        private void CustomTitleBar_Resize(object sender, EventArgs e)
        {
            AdjustButtonPositions();
        }


        public Image Icon
        {
            get { return iconPictureBox.Image; }
            set { iconPictureBox.Image = value; }
        }

        public string Title
        {
            get { return titleLabel.Text; }
            set { titleLabel.Text = value; }
        }
    }

}
