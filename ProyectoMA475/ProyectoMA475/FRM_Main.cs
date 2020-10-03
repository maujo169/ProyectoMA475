using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace ProyectoMA475
{
    /*
             * ------------------------------------------------------------ TO DO ------------------------------------------------------------ *
             *
             *------------------------------------------------ Proceso de abrir archivo ------------------------------------------------ *
             * Abrir una imagen primero
             * Primero copiamos la ruta de la imagen
             * Esta imagen que se ha abierto se le asigna al Bitmap inicial
             * Se establece el ancho y alto de la imagen
             * Se hace una copia del bitmap inicial al final
             * Finalmente se le asigna al pictureBox el bitmap final
             *
             *
             *
             * ------------------------------------------------ Mostrar el histograma del archivo abierto ------------------------------------------------ *
             * Al abrir el archivo se debe verificar si esta en escala de grises o a color
             * Si esta a color se calculan los histogramas para cada color y se muestran las graficas RGB
             * Si esta en escala de grises se muestra solo la grafica de GRISES
             *
             *
             *
             * ------------------------------------------------ Proceso de ecualizacion de histograma ------------------------------------------------ *
             * Si la imagen esta a color se lleva a escala de grises
             * Si la imagen ya esta en escala de grises, entonces se calcula el histograma
             * Una vez calculado el histograma se procede a ecualizar a imagen
             *
             *
             *
             * SIEMPRE QUE SE HAGA UN CAMBIO EN LA IMAGEN SE DEBE LIMPIAR, CALCULAR Y MOSTRAR HISTOGRAMA
    */

    public partial class FRM_Main : Form
    {

        private Bitmap bit, bitOriginal;
        //private Bitmap bitOriginal;
        private string path = "";
        private int[,] histograma = new int[3, 256];
        private ImageProcessor imgProc = new ImageProcessor();

        public FRM_Main()
        {
            InitializeComponent();
            InicializarPaneles();
            InicializarGraficas();
        }

        #region Basicos

        private void InicializarPaneles()
        {
            panelArchivo.Visible = false;
            panelOperaciones.Visible = false;
        } 
        private void EsconderSubMenu()
        {
            if (panelArchivo.Visible == true)
                panelArchivo.Visible = false;
            if (panelOperaciones.Visible == true)
                panelOperaciones.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void InicializarGraficas()
        {
            chartGrises.BackColor = Color.FromArgb(80, 80, 80); // Inicializa la grafica del histograma con color GRIS
            chartRojo.BackColor = Color.FromArgb(255, 70, 70); // Inicializa la grafica del histograma con color ROJO
            chartVerde.BackColor = Color.FromArgb(33, 163, 102); // Inicializa la grafica del histograma con color VERDE
            chartAzul.BackColor = Color.FromArgb(33, 102, 163); // Inicializa la grafica del histograma con color AZUL

            chartGrises.ChartAreas[0].BackColor = Color.FromArgb(80, 80, 80);
            chartRojo.ChartAreas[0].BackColor = Color.FromArgb(255, 70, 70);
            chartVerde.ChartAreas[0].BackColor = Color.FromArgb(33, 163, 102);
            chartAzul.ChartAreas[0].BackColor = Color.FromArgb(33, 102, 163);

            chartGrises.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(80, 80, 80);
            chartRojo.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(255, 70, 70);
            chartVerde.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(33, 163, 102);
            chartAzul.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(33, 102, 163);

            chartGrises.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartRojo.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartVerde.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartAzul.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chartGrises.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartRojo.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartVerde.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartAzul.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void PanelOpciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelArchivo); 
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelOperaciones);
        }
        private void close_pic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void min_pic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FRM_Main_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


        public bool VerificarImagen()
        {
            int cantPixeles = 0;

            for (int x = 0; x < bit.Width; x++)
                for (int y = 0; y < bit.Height; y++)
                {
                    int R = bit.GetPixel(x, y).R, G = bit.GetPixel(x, y).G, B = bit.GetPixel(x, y).B;
                    if (R == G && G == B)
                        cantPixeles++;
                    else
                        cantPixeles--;
                }

            if (cantPixeles == bit.Width * bit.Height)
                // Imagen en escala de grises
                return true;
            else
                // Imagen a color
                return false;
        }
        private void MostrarHistogramas(int op)
        {
            if (bit != null)
            {
                chartGrises.Series["Series1"].Points.Clear();
                chartGrises.Series["Series1"].Color = Color.White;
                chartRojo.Series["Series1"].Points.Clear();
                chartRojo.Series["Series1"].Color = Color.White;
                chartVerde.Series["Series1"].Points.Clear();
                chartVerde.Series["Series1"].Color = Color.White;
                chartAzul.Series["Series1"].Points.Clear();
                chartAzul.Series["Series1"].Color = Color.White;

                for (int i = 0; i < 256; i++)
                {
                    if (op == 0)
                    {
                        chartGrises.Visible = true;

                        label2.Visible = true;

                        chartGrises.Series["Series1"].Points.AddXY(i + 1, histograma[0, i]);

                        chartRojo.Visible = false;
                        chartVerde.Visible = false;
                        chartAzul.Visible = false;

                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                    }
                    if (op == 1)
                    {
                        chartRojo.Visible = true;
                        chartVerde.Visible = true;
                        chartAzul.Visible = true;

                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;

                        chartRojo.Series["Series1"].Points.AddXY(i + 1, histograma[0, i]);
                        chartVerde.Series["Series1"].Points.AddXY(i + 1, histograma[1, i]);
                        chartAzul.Series["Series1"].Points.AddXY(i + 1, histograma[2, i]);

                        chartGrises.Visible = false;

                        label2.Visible = false;
                    }
                }
            }
        }
        
        #region PanelArchivos

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                if (path.Contains(".png") || path.Contains(".jpg") || path.Contains(".jpeg"))
                {
                    bitOriginal = new Bitmap(path);
                    bit = new Bitmap(path);

                    imgProc.SetBitmap(bit);

                    histograma = imgProc.LimpiarHistograma();
                            
                    if (VerificarImagen())
                    {
                        histograma = imgProc.CalcularHistograma(0);
                        MostrarHistogramas(0);
                    }
                    else
                    {
                        histograma = imgProc.CalcularHistograma(1);
                        MostrarHistogramas(1);
                    }

                    imgPic.Image = bit;
                }
                else
                    MessageBox.Show("Este archivo no es una imagen: " + path);
            }
        }

        #endregion

        #region PanelOperaciones
        private void btnGrises_Click(object sender, EventArgs e)
        {
            // Aqui convertimos a escala de grises
            if (bit != null)
            {
                bitOriginal = new Bitmap(path);
                bit = new Bitmap(path);

                imgProc.SetBitmap(bit);
                histograma = imgProc.LimpiarHistograma();
                bit = imgProc.ConversionEscalaDeGrises();

                FRM_Cambios frm = new FRM_Cambios(bit);
                frm.Show();

            }
            else
                MessageBox.Show("Hey! Carga una imagen");
        }
        private void btnEcualizar_Click(object sender, EventArgs e)
        {
            // Aqui se debe ecualizar y dar una vista del histograma
            if (bit != null)
            {
                histograma = imgProc.LimpiarHistograma();
                imgProc.SetBitmap(bit);
                
                var n = imgProc.ConversionEscalaDeGrises();

                imgProc.SetBitmap(n);
                histograma = imgProc.CalcularHistograma(0);
                
                bit = imgProc.EcualizarHistograma();

                FRM_Cambios frm = new FRM_Cambios(bit);
                frm.Show();
            }
            else
                MessageBox.Show("Hey! Carga una imagen");
        }
        private void btnExpandir_Click(object sender, EventArgs e)
        {
            // Aqui se debe abrir un form que permite editar el rango de expansion y dar una vista del histograma
            if (bit != null)
            {
                if(nudMayor.Value != 0)
                    if(nudMenor.Value < nudMayor.Value)
                    {
                        histograma = imgProc.LimpiarHistograma(); // Se limpia el histograma ya que al abrir la imagen el histograma ya esta calculado
                        bit = imgProc.ConversionEscalaDeGrises(); // Para ecualizar primero pasamos la imagen a escala de grises
                        imgProc.SetBitmap(bit);
                        histograma = imgProc.CalcularHistograma(0); // Calculamos el histograma de la imagen en escala de grises
                        
                        // Busqueda de menor nivel de gris en el histograma 
                        float mayor = 0, menor = 0;
                        for(float i = 0; i < 256; i++)
                            if(histograma[0, Convert.ToInt32(i)] != 0) { menor = i; break; }
                        for (float i = 0; i < 256; i++)
                            if (histograma[0, Convert.ToInt32(i)] != 0) { mayor = i; }

                        if ((float)nudMayor.Value >= mayor && (float)nudMenor.Value <= menor)
                        {
                            bit = imgProc.ExpansionHistograma(menor, mayor, (float)nudMenor.Value, (float)nudMayor.Value);
                            FRM_Cambios frm = new FRM_Cambios(bit);
                            frm.Show();
                        }
                        else
                            MessageBox.Show("El valor minimo de intensidad en el histograma es '" + menor + "' y el maximo es '" + mayor + "'");
                        
                    }
                    else
                        MessageBox.Show("El valor de la izquierda debe ser menor al de la derecha");
                else
                    MessageBox.Show("No se especifican valores");

            }
            else
                MessageBox.Show("Hey! Carga una imagen");
        }
        #endregion
    }
}
