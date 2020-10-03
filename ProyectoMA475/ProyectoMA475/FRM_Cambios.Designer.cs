namespace ProyectoMA475
{
    partial class FRM_Cambios
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Cambios));
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.min_pic = new System.Windows.Forms.PictureBox();
            this.close_pic = new System.Windows.Forms.PictureBox();
            this.panelhisto = new System.Windows.Forms.Panel();
            this.chartGrises = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pic)).BeginInit();
            this.panelhisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.AutoScroll = true;
            this.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelOpciones.Controls.Add(this.label1);
            this.PanelOpciones.Controls.Add(this.min_pic);
            this.PanelOpciones.Controls.Add(this.close_pic);
            this.PanelOpciones.Location = new System.Drawing.Point(0, 0);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Padding = new System.Windows.Forms.Padding(0, 180, 0, 0);
            this.PanelOpciones.Size = new System.Drawing.Size(800, 35);
            this.PanelOpciones.TabIndex = 3;
            this.PanelOpciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelOpciones_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(72, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Imagen - Histograma";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // min_pic
            // 
            this.min_pic.Image = global::ProyectoMA475.Properties.Resources.min_icon;
            this.min_pic.Location = new System.Drawing.Point(41, 8);
            this.min_pic.Name = "min_pic";
            this.min_pic.Size = new System.Drawing.Size(18, 18);
            this.min_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min_pic.TabIndex = 17;
            this.min_pic.TabStop = false;
            this.min_pic.Click += new System.EventHandler(this.min_pic_Click);
            // 
            // close_pic
            // 
            this.close_pic.Image = global::ProyectoMA475.Properties.Resources.close_icon;
            this.close_pic.Location = new System.Drawing.Point(16, 8);
            this.close_pic.Name = "close_pic";
            this.close_pic.Size = new System.Drawing.Size(18, 18);
            this.close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_pic.TabIndex = 6;
            this.close_pic.TabStop = false;
            this.close_pic.Click += new System.EventHandler(this.close_pic_Click);
            // 
            // panelhisto
            // 
            this.panelhisto.AutoScroll = true;
            this.panelhisto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelhisto.Controls.Add(this.chartGrises);
            this.panelhisto.Controls.Add(this.label2);
            this.panelhisto.Location = new System.Drawing.Point(469, 35);
            this.panelhisto.Name = "panelhisto";
            this.panelhisto.Padding = new System.Windows.Forms.Padding(0, 180, 0, 0);
            this.panelhisto.Size = new System.Drawing.Size(331, 420);
            this.panelhisto.TabIndex = 7;
            // 
            // chartGrises
            // 
            this.chartGrises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            chartArea1.Name = "ChartArea1";
            this.chartGrises.ChartAreas.Add(chartArea1);
            this.chartGrises.Location = new System.Drawing.Point(12, 41);
            this.chartGrises.Name = "chartGrises";
            this.chartGrises.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series1.Name = "Series1";
            this.chartGrises.Series.Add(series1);
            this.chartGrises.Size = new System.Drawing.Size(307, 140);
            this.chartGrises.TabIndex = 19;
            this.chartGrises.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Grises";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imagenes PNG|*.png";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(77, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Cambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelhisto);
            this.Controls.Add(this.PanelOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Cambios";
            this.Text = "Imagen - Histograma";
            this.Load += new System.EventHandler(this.FRM_Cambios_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_Cambios_MouseDown);
            this.PanelOpciones.ResumeLayout(false);
            this.PanelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pic)).EndInit();
            this.panelhisto.ResumeLayout(false);
            this.panelhisto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox min_pic;
        private System.Windows.Forms.PictureBox close_pic;
        private System.Windows.Forms.Panel panelhisto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrises;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}