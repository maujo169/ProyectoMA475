namespace ProyectoMA475
{
    partial class FRM_Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.min_pic = new System.Windows.Forms.PictureBox();
            this.close_pic = new System.Windows.Forms.PictureBox();
            this.panelOperaciones = new System.Windows.Forms.Panel();
            this.panelExpansion = new System.Windows.Forms.Panel();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.nudMayor = new System.Windows.Forms.NumericUpDown();
            this.nudMenor = new System.Windows.Forms.NumericUpDown();
            this.btnEcualizar = new System.Windows.Forms.Button();
            this.btnGrises = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.panelArchivo = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelhisto = new System.Windows.Forms.Panel();
            this.chartAzul = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.chartVerde = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.chartRojo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.chartGrises = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.imgPic = new System.Windows.Forms.PictureBox();
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pic)).BeginInit();
            this.panelOperaciones.SuspendLayout();
            this.panelExpansion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMayor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenor)).BeginInit();
            this.panelArchivo.SuspendLayout();
            this.panelhisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.AutoScroll = true;
            this.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelOpciones.Controls.Add(this.label1);
            this.PanelOpciones.Controls.Add(this.min_pic);
            this.PanelOpciones.Controls.Add(this.close_pic);
            this.PanelOpciones.Controls.Add(this.panelOperaciones);
            this.PanelOpciones.Controls.Add(this.btn2);
            this.PanelOpciones.Controls.Add(this.panelArchivo);
            this.PanelOpciones.Controls.Add(this.btn1);
            this.PanelOpciones.Location = new System.Drawing.Point(0, 0);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Padding = new System.Windows.Forms.Padding(0, 180, 0, 0);
            this.PanelOpciones.Size = new System.Drawing.Size(220, 592);
            this.PanelOpciones.TabIndex = 2;
            this.PanelOpciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelOpciones_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 75);
            this.label1.TabIndex = 18;
            this.label1.Text = "Expansión y \r\necualización de \r\nhistogramas";
            // 
            // min_pic
            // 
            this.min_pic.Image = global::ProyectoMA475.Properties.Resources.min_icon;
            this.min_pic.Location = new System.Drawing.Point(41, 11);
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
            this.close_pic.Location = new System.Drawing.Point(16, 11);
            this.close_pic.Name = "close_pic";
            this.close_pic.Size = new System.Drawing.Size(18, 18);
            this.close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_pic.TabIndex = 6;
            this.close_pic.TabStop = false;
            this.close_pic.Click += new System.EventHandler(this.close_pic_Click);
            // 
            // panelOperaciones
            // 
            this.panelOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelOperaciones.Controls.Add(this.panelExpansion);
            this.panelOperaciones.Controls.Add(this.btnEcualizar);
            this.panelOperaciones.Controls.Add(this.btnGrises);
            this.panelOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOperaciones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOperaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.panelOperaciones.Location = new System.Drawing.Point(0, 299);
            this.panelOperaciones.Name = "panelOperaciones";
            this.panelOperaciones.Size = new System.Drawing.Size(220, 166);
            this.panelOperaciones.TabIndex = 14;
            // 
            // panelExpansion
            // 
            this.panelExpansion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelExpansion.Controls.Add(this.btnExpandir);
            this.panelExpansion.Controls.Add(this.nudMayor);
            this.panelExpansion.Controls.Add(this.nudMenor);
            this.panelExpansion.Location = new System.Drawing.Point(3, 71);
            this.panelExpansion.Name = "panelExpansion";
            this.panelExpansion.Size = new System.Drawing.Size(214, 88);
            this.panelExpansion.TabIndex = 7;
            // 
            // btnExpandir
            // 
            this.btnExpandir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExpandir.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExpandir.FlatAppearance.BorderSize = 0;
            this.btnExpandir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnExpandir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandir.ForeColor = System.Drawing.Color.White;
            this.btnExpandir.Location = new System.Drawing.Point(3, 43);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(208, 33);
            this.btnExpandir.TabIndex = 0;
            this.btnExpandir.Text = "Expandir";
            this.btnExpandir.UseVisualStyleBackColor = false;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // nudMayor
            // 
            this.nudMayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.nudMayor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMayor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMayor.ForeColor = System.Drawing.SystemColors.Window;
            this.nudMayor.Location = new System.Drawing.Point(116, 14);
            this.nudMayor.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMayor.Name = "nudMayor";
            this.nudMayor.Size = new System.Drawing.Size(50, 19);
            this.nudMayor.TabIndex = 2;
            // 
            // nudMenor
            // 
            this.nudMenor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.nudMenor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMenor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMenor.ForeColor = System.Drawing.SystemColors.Window;
            this.nudMenor.Location = new System.Drawing.Point(48, 14);
            this.nudMenor.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMenor.Name = "nudMenor";
            this.nudMenor.Size = new System.Drawing.Size(50, 19);
            this.nudMenor.TabIndex = 1;
            // 
            // btnEcualizar
            // 
            this.btnEcualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEcualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEcualizar.FlatAppearance.BorderSize = 0;
            this.btnEcualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnEcualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnEcualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcualizar.Location = new System.Drawing.Point(-1, 35);
            this.btnEcualizar.Name = "btnEcualizar";
            this.btnEcualizar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEcualizar.Size = new System.Drawing.Size(220, 30);
            this.btnEcualizar.TabIndex = 10;
            this.btnEcualizar.Text = "Ecualizar";
            this.btnEcualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEcualizar.UseVisualStyleBackColor = false;
            this.btnEcualizar.Click += new System.EventHandler(this.btnEcualizar_Click);
            // 
            // btnGrises
            // 
            this.btnGrises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnGrises.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGrises.FlatAppearance.BorderSize = 0;
            this.btnGrises.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnGrises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnGrises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrises.Location = new System.Drawing.Point(-1, -1);
            this.btnGrises.Name = "btnGrises";
            this.btnGrises.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGrises.Size = new System.Drawing.Size(220, 30);
            this.btnGrises.TabIndex = 8;
            this.btnGrises.Text = "Escala de grises";
            this.btnGrises.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrises.UseVisualStyleBackColor = false;
            this.btnGrises.Click += new System.EventHandler(this.btnGrises_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(0, 257);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn2.Size = new System.Drawing.Size(220, 42);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "Operaciones";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // panelArchivo
            // 
            this.panelArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelArchivo.Controls.Add(this.btnOpen);
            this.panelArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArchivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelArchivo.ForeColor = System.Drawing.SystemColors.Control;
            this.panelArchivo.Location = new System.Drawing.Point(0, 222);
            this.panelArchivo.Name = "panelArchivo";
            this.panelArchivo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panelArchivo.Size = new System.Drawing.Size(220, 35);
            this.panelArchivo.TabIndex = 12;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(-1, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnOpen.Size = new System.Drawing.Size(220, 30);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Abrir imagen";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(0, 180);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn1.Size = new System.Drawing.Size(220, 42);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "Archivo";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imagenes PNG|*.png";
            // 
            // panelhisto
            // 
            this.panelhisto.AutoScroll = true;
            this.panelhisto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelhisto.Controls.Add(this.chartAzul);
            this.panelhisto.Controls.Add(this.label5);
            this.panelhisto.Controls.Add(this.chartVerde);
            this.panelhisto.Controls.Add(this.label4);
            this.panelhisto.Controls.Add(this.chartRojo);
            this.panelhisto.Controls.Add(this.label3);
            this.panelhisto.Controls.Add(this.chartGrises);
            this.panelhisto.Controls.Add(this.label2);
            this.panelhisto.Location = new System.Drawing.Point(768, -1);
            this.panelhisto.Name = "panelhisto";
            this.panelhisto.Padding = new System.Windows.Forms.Padding(0, 180, 0, 0);
            this.panelhisto.Size = new System.Drawing.Size(259, 593);
            this.panelhisto.TabIndex = 6;
            // 
            // chartAzul
            // 
            this.chartAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            chartArea1.Name = "ChartArea1";
            this.chartAzul.ChartAreas.Add(chartArea1);
            this.chartAzul.Location = new System.Drawing.Point(12, 452);
            this.chartAzul.Name = "chartAzul";
            this.chartAzul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartAzul.Series.Add(series1);
            this.chartAzul.Size = new System.Drawing.Size(230, 100);
            this.chartAzul.TabIndex = 25;
            this.chartAzul.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(14, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Azul";
            // 
            // chartVerde
            // 
            this.chartVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            chartArea2.Name = "ChartArea1";
            this.chartVerde.ChartAreas.Add(chartArea2);
            this.chartVerde.Location = new System.Drawing.Point(12, 315);
            this.chartVerde.Name = "chartVerde";
            this.chartVerde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartVerde.Series.Add(series2);
            this.chartVerde.Size = new System.Drawing.Size(230, 100);
            this.chartVerde.TabIndex = 23;
            this.chartVerde.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(14, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Verde";
            // 
            // chartRojo
            // 
            this.chartRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            chartArea3.Name = "ChartArea1";
            this.chartRojo.ChartAreas.Add(chartArea3);
            this.chartRojo.Location = new System.Drawing.Point(12, 180);
            this.chartRojo.Name = "chartRojo";
            this.chartRojo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chartRojo.Series.Add(series3);
            this.chartRojo.Size = new System.Drawing.Size(230, 100);
            this.chartRojo.TabIndex = 21;
            this.chartRojo.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rojo";
            // 
            // chartGrises
            // 
            this.chartGrises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            chartArea4.Name = "ChartArea1";
            this.chartGrises.ChartAreas.Add(chartArea4);
            this.chartGrises.Location = new System.Drawing.Point(12, 41);
            this.chartGrises.Name = "chartGrises";
            this.chartGrises.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series4.Name = "Series1";
            this.chartGrises.Series.Add(series4);
            this.chartGrises.Size = new System.Drawing.Size(230, 100);
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
            // imgPic
            // 
            this.imgPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPic.Location = new System.Drawing.Point(250, 70);
            this.imgPic.Name = "imgPic";
            this.imgPic.Size = new System.Drawing.Size(487, 446);
            this.imgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPic.TabIndex = 2;
            this.imgPic.TabStop = false;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1028, 592);
            this.Controls.Add(this.imgPic);
            this.Controls.Add(this.panelhisto);
            this.Controls.Add(this.PanelOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProyectoMA475";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_Main_MouseDown);
            this.PanelOpciones.ResumeLayout(false);
            this.PanelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pic)).EndInit();
            this.panelOperaciones.ResumeLayout(false);
            this.panelExpansion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMayor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenor)).EndInit();
            this.panelArchivo.ResumeLayout(false);
            this.panelhisto.ResumeLayout(false);
            this.panelhisto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.Panel panelOperaciones;
        private System.Windows.Forms.Button btnEcualizar;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Panel panelArchivo;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox min_pic;
        private System.Windows.Forms.PictureBox close_pic;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panelhisto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrises;
        private System.Windows.Forms.Button btnGrises;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAzul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVerde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRojo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelExpansion;
        private System.Windows.Forms.NumericUpDown nudMayor;
        private System.Windows.Forms.NumericUpDown nudMenor;
        private System.Windows.Forms.Button btnExpandir;
        private System.Windows.Forms.PictureBox imgPic;
        private System.Windows.Forms.Label label1;
    }
}