namespace ControlDeLed
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
            this.labelLed = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.LED1 = new System.Windows.Forms.GroupBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.LED1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLed
            // 
            this.labelLed.AutoSize = true;
            this.labelLed.BackColor = System.Drawing.Color.Red;
            this.labelLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLed.Location = new System.Drawing.Point(112, 91);
            this.labelLed.Name = "labelLed";
            this.labelLed.Size = new System.Drawing.Size(102, 46);
            this.labelLed.TabIndex = 0;
            this.labelLed.Text = "OFF";
            this.labelLed.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncender.Location = new System.Drawing.Point(26, 196);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(115, 44);
            this.buttonEncender.TabIndex = 1;
            this.buttonEncender.Text = "Encender";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // LED1
            // 
            this.LED1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LED1.Controls.Add(this.buttonApagar);
            this.LED1.Controls.Add(this.labelLed);
            this.LED1.Controls.Add(this.buttonEncender);
            this.LED1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LED1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LED1.Location = new System.Drawing.Point(106, 50);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(340, 285);
            this.LED1.TabIndex = 2;
            this.LED1.TabStop = false;
            this.LED1.Text = "LED1";
            // 
            // buttonApagar
            // 
            this.buttonApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.Location = new System.Drawing.Point(193, 196);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(115, 44);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 386);
            this.Controls.Add(this.LED1);
            this.Name = "Form1";
            this.Text = "Control de led";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LED1.ResumeLayout(false);
            this.LED1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLed;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.GroupBox LED1;
        private System.Windows.Forms.Button buttonApagar;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

