﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TWENTYFIVE_CENTS_VALUE = 0.25m;
        const decimal TEN_CENTS_VALUE = 0.1m;
        const decimal FIFTY_CENTS_VALUE = 0.5m;

        private decimal total = 0m;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //total = total + 0.05m;
            total += FIVE_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TWENTYFIVE_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total = 0m;
            totalLabel.Text = total.ToString("c");
    }
    }
}
