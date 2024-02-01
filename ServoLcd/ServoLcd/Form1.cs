using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ServoLcd
{   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DesabilitarComponentes();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                //ComboBoxPuerto
                string[] ports = SerialPort.GetPortNames();
                ComboBoxPuerto.DataSource = ports;

                // ComboBoxBaud
                string[] rates = { "9600", "38400", "57600" };
                ComboBoxBaudrate.DataSource = rates;
                labelBaudrate.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void LedA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (LedA.Checked)
                {
                    // activar led A
                    ImagenA.Image = Properties.Resources.Led_on;
                }
                else
                {
                    ImagenA.Image = Properties.Resources.led_off;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void LedB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (LedB.Checked)
                {
                    // activar led B
                    ImagenB.Image = Properties.Resources.Led_on;
                }
                else
                {
                    ImagenB.Image = Properties.Resources.led_off;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void LedC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (LedC.Checked)
                {
                    // activar led C
                    ImagenC.Image = Properties.Resources.Led_on;
                }
                else
                {
                    ImagenC.Image = Properties.Resources.led_off;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private async void buttonSerialConect_Click(object sender, EventArgs e)
        {
            HabilitarComponentes();
            buttonSerialConect.Enabled = false;
            progressBar1.Value = 100;
            if (progressBar1.Value == 100)
            {
                await Task.Delay(1000); // se esperara un segundo perro
                buttonSerialConect.Text = "Conectado";
            }

        }

        private void buttonSerialRefresh_Click(object sender, EventArgs e)
        {
            DesabilitarComponentes();
            buttonSerialConect.Text = "Conectar";
            buttonSerialConect.Enabled = true;
            ComboBoxPuerto.Text = "";
            ComboBoxBaudrate.Text = "";
            progressBar1.Value = 0;
            
        }

        private void buttonPrintLCD_Click(object sender, EventArgs e)
        {
            buttonPrintLCD.Dock = DockStyle.Fill;
            // mandarle el print ok joto?
            string l1 = textBox1.Text;
            //string l2 = textBox2.Text;
            textBox2.Text = l1;
        }

        private void buttonBorrarLCD_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }

        



        private void DesabilitarComponentes()
        {
            // Desactivar CheckBox
            LedA.Enabled = false;
            LedB.Enabled = false;
            LedC.Enabled = false;

            // Desactivar LCD
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            buttonPrintLCD.Enabled = false; 
            buttonBorrarLCD.Enabled = false;

            // Desactivar Control Servo
            trackBarMotor.Enabled = false;

        }
        private void HabilitarComponentes()
        {
            // Desactivar CheckBox
            LedA.Enabled = true;
            LedB.Enabled = true;
            LedC.Enabled = true;

            // Desactivar LCD
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            buttonPrintLCD.Enabled = true;
            buttonBorrarLCD.Enabled = true;

            // Desactivar Control Servo
            trackBarMotor.Enabled = true;

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }  
}
