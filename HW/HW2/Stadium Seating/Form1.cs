using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        double a, b, c, total;

        private void button2_Click(object sender, EventArgs e)
        {
            txtClassA.Text = "";
            txtClassB.Text = "";
            txtClassC.Text = "";

            lblClassA.Text = "";
            lblClassB.Text = "";
            lblClassC.Text = "";
            lblTotal.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtClassA.Text) * 15;
            b = Convert.ToDouble(txtClassB.Text) * 12;
            c = Convert.ToDouble(txtClassC.Text) * 9;
            total = a + b + c;

            lblClassA.Text = (a.ToString("c2"));

            lblClassB.Text = (b.ToString("c2"));
            lblClassC.Text = (c.ToString("c2"));
            lblTotal.Text = (total.ToString("c2"));
        }
    }
}
