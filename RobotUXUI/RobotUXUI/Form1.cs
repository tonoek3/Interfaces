using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotUXUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExpander_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnExpander.Visible = false;
            btnChico.Visible = true;
        }

        private void btnChico_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btnChico.Visible = false;
            btnExpander.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
