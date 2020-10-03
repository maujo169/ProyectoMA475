using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProyectoMA475
{
    public partial class Caratula : Form
    {
        public Caratula()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Main frm = new FRM_Main();
            frm.ShowDialog();
            this.Show();
        }

        private void Caratula_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Basicos

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        // PRESENTACION
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 130, 130);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 130, 130);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 130, 130);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 70, 70);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 70, 70);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 70, 70);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panelPresentacion.Visible = true;
            panelManual.Visible = false;
            panel1.Width = 330;
            panel2.Width = 100;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panelPresentacion.Visible = true;
            panelManual.Visible = false;
            panel1.Width = 330;
            panel2.Width = 100;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panelPresentacion.Visible = true;
            panelManual.Visible = false;
            panel1.Width = 330;
            panel2.Width = 100;
        }

        // MANUAL
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(90, 186, 141);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(90, 186, 141);
        }
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            // Solo funciona cuando el ancho del panel es 250
            panel2.BackColor = Color.FromArgb(90, 186, 141);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(33, 163, 102);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(33, 163, 102);
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            // Solo funciona cuando el ancho del panel es 250
            panel2.BackColor = Color.FromArgb(33, 163, 102);
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            panelPresentacion.Visible = false;
            panelManual.Visible = true;
            panel2.Width = 330;
            panel1.Width = 100;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            panelPresentacion.Visible = false;
            panelManual.Visible = true;
            panel2.Width = 330;
            panel1.Width = 100;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            panelPresentacion.Visible = false;
            panelManual.Visible = true;
            panel2.Width = 330;
            panel1.Width = 100;
        }

        // SALIR
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(70, 127, 178);
        }
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(70, 127, 178);
        }
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(33, 102, 163);
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(33, 102, 163);
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        #endregion

    }
}
