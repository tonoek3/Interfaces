namespace ServoLcd
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LedC = new System.Windows.Forms.CheckBox();
            this.LedB = new System.Windows.Forms.CheckBox();
            this.LedA = new System.Windows.Forms.CheckBox();
            this.ImagenC = new System.Windows.Forms.PictureBox();
            this.ImagenB = new System.Windows.Forms.PictureBox();
            this.ImagenA = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSerialRefresh = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonSerialConect = new System.Windows.Forms.Button();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.ComboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.LabelPuerto = new System.Windows.Forms.Label();
            this.ComboBoxPuerto = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarMotor = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonBorrarLCD = new System.Windows.Forms.Button();
            this.buttonPrintLCD = new System.Windows.Forms.Button();
            this.Linea2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Linea1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMotor)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LedC);
            this.groupBox1.Controls.Add(this.LedB);
            this.groupBox1.Controls.Add(this.LedA);
            this.groupBox1.Controls.Add(this.ImagenC);
            this.groupBox1.Controls.Add(this.ImagenB);
            this.groupBox1.Controls.Add(this.ImagenA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(82, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control LEDS";
            // 
            // LedC
            // 
            this.LedC.AutoSize = true;
            this.LedC.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedC.Location = new System.Drawing.Point(311, 143);
            this.LedC.Name = "LedC";
            this.LedC.Size = new System.Drawing.Size(77, 25);
            this.LedC.TabIndex = 7;
            this.LedC.Text = "Led C";
            this.LedC.UseVisualStyleBackColor = true;
            this.LedC.CheckedChanged += new System.EventHandler(this.LedC_CheckedChanged);
            // 
            // LedB
            // 
            this.LedB.AutoSize = true;
            this.LedB.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedB.Location = new System.Drawing.Point(180, 143);
            this.LedB.Name = "LedB";
            this.LedB.Size = new System.Drawing.Size(77, 25);
            this.LedB.TabIndex = 6;
            this.LedB.Text = "Led B";
            this.LedB.UseVisualStyleBackColor = true;
            this.LedB.CheckedChanged += new System.EventHandler(this.LedB_CheckedChanged);
            // 
            // LedA
            // 
            this.LedA.AutoSize = true;
            this.LedA.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedA.Location = new System.Drawing.Point(44, 143);
            this.LedA.Name = "LedA";
            this.LedA.Size = new System.Drawing.Size(78, 25);
            this.LedA.TabIndex = 5;
            this.LedA.Text = "Led A";
            this.LedA.UseVisualStyleBackColor = true;
            this.LedA.CheckedChanged += new System.EventHandler(this.LedA_CheckedChanged);
            // 
            // ImagenC
            // 
            this.ImagenC.Image = global::ServoLcd.Properties.Resources.led_off;
            this.ImagenC.Location = new System.Drawing.Point(311, 59);
            this.ImagenC.Name = "ImagenC";
            this.ImagenC.Size = new System.Drawing.Size(40, 43);
            this.ImagenC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenC.TabIndex = 4;
            this.ImagenC.TabStop = false;
            // 
            // ImagenB
            // 
            this.ImagenB.Image = global::ServoLcd.Properties.Resources.led_off;
            this.ImagenB.Location = new System.Drawing.Point(180, 59);
            this.ImagenB.Name = "ImagenB";
            this.ImagenB.Size = new System.Drawing.Size(40, 43);
            this.ImagenB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenB.TabIndex = 3;
            this.ImagenB.TabStop = false;
            // 
            // ImagenA
            // 
            this.ImagenA.Image = global::ServoLcd.Properties.Resources.led_off;
            this.ImagenA.Location = new System.Drawing.Point(44, 59);
            this.ImagenA.Name = "ImagenA";
            this.ImagenA.Size = new System.Drawing.Size(40, 43);
            this.ImagenA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenA.TabIndex = 2;
            this.ImagenA.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSerialRefresh);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.buttonSerialConect);
            this.groupBox2.Controls.Add(this.labelBaudrate);
            this.groupBox2.Controls.Add(this.ComboBoxBaudrate);
            this.groupBox2.Controls.Add(this.LabelPuerto);
            this.groupBox2.Controls.Add(this.ComboBoxPuerto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(45, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conexion Seria";
            // 
            // buttonSerialRefresh
            // 
            this.buttonSerialRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSerialRefresh.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerialRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSerialRefresh.Location = new System.Drawing.Point(303, 113);
            this.buttonSerialRefresh.Name = "buttonSerialRefresh";
            this.buttonSerialRefresh.Size = new System.Drawing.Size(153, 44);
            this.buttonSerialRefresh.TabIndex = 6;
            this.buttonSerialRefresh.Text = "Refrescar";
            this.buttonSerialRefresh.UseVisualStyleBackColor = false;
            this.buttonSerialRefresh.Click += new System.EventHandler(this.buttonSerialRefresh_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(303, 175);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(153, 21);
            this.progressBar1.TabIndex = 5;
            // 
            // buttonSerialConect
            // 
            this.buttonSerialConect.BackColor = System.Drawing.Color.Yellow;
            this.buttonSerialConect.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerialConect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSerialConect.Location = new System.Drawing.Point(303, 47);
            this.buttonSerialConect.Name = "buttonSerialConect";
            this.buttonSerialConect.Size = new System.Drawing.Size(153, 44);
            this.buttonSerialConect.TabIndex = 4;
            this.buttonSerialConect.Text = "Conectar";
            this.buttonSerialConect.UseVisualStyleBackColor = false;
            this.buttonSerialConect.Click += new System.EventHandler(this.buttonSerialConect_Click);
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaudrate.Location = new System.Drawing.Point(26, 143);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(98, 26);
            this.labelBaudrate.TabIndex = 3;
            this.labelBaudrate.Text = "Baudrate";
            // 
            // ComboBoxBaudrate
            // 
            this.ComboBoxBaudrate.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBaudrate.FormattingEnabled = true;
            this.ComboBoxBaudrate.Items.AddRange(new object[] {
            "1200\t",
            "1500",
            "1800",
            "2100",
            "2400"});
            this.ComboBoxBaudrate.Location = new System.Drawing.Point(162, 140);
            this.ComboBoxBaudrate.Name = "ComboBoxBaudrate";
            this.ComboBoxBaudrate.Size = new System.Drawing.Size(101, 34);
            this.ComboBoxBaudrate.TabIndex = 2;
            // 
            // LabelPuerto
            // 
            this.LabelPuerto.AutoSize = true;
            this.LabelPuerto.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPuerto.Location = new System.Drawing.Point(26, 73);
            this.LabelPuerto.Name = "LabelPuerto";
            this.LabelPuerto.Size = new System.Drawing.Size(75, 26);
            this.LabelPuerto.TabIndex = 1;
            this.LabelPuerto.Text = "Puerto";
            // 
            // ComboBoxPuerto
            // 
            this.ComboBoxPuerto.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPuerto.FormattingEnabled = true;
            this.ComboBoxPuerto.Items.AddRange(new object[] {
            "COM6",
            "COM7",
            "COM8"});
            this.ComboBoxPuerto.Location = new System.Drawing.Point(162, 70);
            this.ComboBoxPuerto.Name = "ComboBoxPuerto";
            this.ComboBoxPuerto.Size = new System.Drawing.Size(101, 34);
            this.ComboBoxPuerto.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.trackBarMotor);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(565, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 227);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Servo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "1200 RPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "0 RPM";
            // 
            // trackBarMotor
            // 
            this.trackBarMotor.Location = new System.Drawing.Point(52, 111);
            this.trackBarMotor.Name = "trackBarMotor";
            this.trackBarMotor.Size = new System.Drawing.Size(422, 69);
            this.trackBarMotor.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonBorrarLCD);
            this.groupBox4.Controls.Add(this.buttonPrintLCD);
            this.groupBox4.Controls.Add(this.Linea2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.Linea1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(565, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(530, 242);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control LCD";
            // 
            // buttonBorrarLCD
            // 
            this.buttonBorrarLCD.BackColor = System.Drawing.Color.Gray;
            this.buttonBorrarLCD.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarLCD.ForeColor = System.Drawing.Color.Black;
            this.buttonBorrarLCD.Location = new System.Drawing.Point(340, 147);
            this.buttonBorrarLCD.Name = "buttonBorrarLCD";
            this.buttonBorrarLCD.Size = new System.Drawing.Size(134, 48);
            this.buttonBorrarLCD.TabIndex = 5;
            this.buttonBorrarLCD.Text = "Borrar";
            this.buttonBorrarLCD.UseVisualStyleBackColor = false;
            this.buttonBorrarLCD.Click += new System.EventHandler(this.buttonBorrarLCD_Click);
            // 
            // buttonPrintLCD
            // 
            this.buttonPrintLCD.BackColor = System.Drawing.Color.Yellow;
            this.buttonPrintLCD.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintLCD.ForeColor = System.Drawing.Color.Black;
            this.buttonPrintLCD.Location = new System.Drawing.Point(340, 75);
            this.buttonPrintLCD.Name = "buttonPrintLCD";
            this.buttonPrintLCD.Size = new System.Drawing.Size(134, 48);
            this.buttonPrintLCD.TabIndex = 4;
            this.buttonPrintLCD.Text = "Imprimir";
            this.buttonPrintLCD.UseVisualStyleBackColor = false;
            this.buttonPrintLCD.Click += new System.EventHandler(this.buttonPrintLCD_Click);
            // 
            // Linea2
            // 
            this.Linea2.AutoSize = true;
            this.Linea2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Linea2.Location = new System.Drawing.Point(54, 135);
            this.Linea2.Name = "Linea2";
            this.Linea2.Size = new System.Drawing.Size(74, 26);
            this.Linea2.TabIndex = 3;
            this.Linea2.Text = "Linea2";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Location = new System.Drawing.Point(41, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 48);
            this.textBox2.TabIndex = 2;
            // 
            // Linea1
            // 
            this.Linea1.AutoSize = true;
            this.Linea1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Linea1.Location = new System.Drawing.Point(53, 44);
            this.Linea1.Name = "Linea1";
            this.Linea1.Size = new System.Drawing.Size(74, 26);
            this.Linea1.TabIndex = 1;
            this.Linea1.Text = "Linea1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(40, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 48);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1146, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMotor)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox ImagenA;
        private System.Windows.Forms.CheckBox LedA;
        private System.Windows.Forms.PictureBox ImagenC;
        private System.Windows.Forms.PictureBox ImagenB;
        private System.Windows.Forms.CheckBox LedC;
        private System.Windows.Forms.CheckBox LedB;
        private System.Windows.Forms.Label Linea2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Linea1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.ComboBox ComboBoxBaudrate;
        private System.Windows.Forms.Label LabelPuerto;
        private System.Windows.Forms.ComboBox ComboBoxPuerto;
        private System.Windows.Forms.Button buttonPrintLCD;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonSerialConect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarMotor;
        private System.Windows.Forms.Button buttonSerialRefresh;
        private System.Windows.Forms.Button buttonBorrarLCD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

