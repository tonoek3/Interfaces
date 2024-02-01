using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeLed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            try
            {
                //enviar codigoa al arduino
                //serial.println("$On");
                //serialPort1.WriteLine("$On");
                labelLed.BackColor = Color.Lime;
                labelLed.Text = "ON";
                buttonApagar.Enabled = true;
                buttonEncender.Enabled = false;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                buttonApagar.Enabled = false;
                serialPort1.PortName = "COM6";
                serialPort1.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Orale joto");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            try
            {
                //enviar codigoa al arduino
                //serial.println("$On");
                //serialPort1.WriteLine("$OFF");
                labelLed.BackColor = Color.Red;
                labelLed.Text = "OFF";
                buttonApagar.Enabled = false;
                buttonEncender.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
