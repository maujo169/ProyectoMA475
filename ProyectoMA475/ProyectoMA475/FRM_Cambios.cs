using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoMA475
{
    public partial class FRM_Cambios : Form
    {
        ImageProcessor imgProc = new ImageProcessor();
        private int[,] histograma = new int[3, 256];
        Bitmap bit;

        public FRM_Cambios(Bitmap bmp)
        {
            InitializeComponent();

            bit = bmp;
            imgProc.SetBitmap(bit);
            histograma = imgProc.CalcularHistograma(0);
            MostrarHistograma();

            pictureBox1.Image = bit;            
        }

        private void MostrarHistograma()
        {
            chartGrises.Series["Series1"].Points.Clear();
            chartGrises.Series["Series1"].Color = Color.White;

            for (int i = 0; i < 256; i++)
            {
                    chartGrises.Visible = true;
                    chartGrises.Series["Series1"].Points.AddXY(i + 1, histograma[0, i]);
            }

            chartGrises.BackColor = Color.FromArgb(80, 80, 80); // Inicializa la grafica del histograma con color GRIS
            chartGrises.ChartAreas[0].BackColor = Color.FromArgb(80, 80, 80);
            chartGrises.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(80, 80, 80);
            chartGrises.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartGrises.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void FRM_Cambios_Load(object sender, EventArgs e)
        {

        }
        private void PanelOpciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FRM_Cambios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void close_pic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void min_pic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
