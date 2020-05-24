using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            userControl31.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            userControl41.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            userControl51.BringToFront();
        }
    }
}
