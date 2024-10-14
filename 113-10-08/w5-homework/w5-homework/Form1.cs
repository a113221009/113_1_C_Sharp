using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w5_homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ptb_8_Diamonds_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8_Diamonds";
        }

        private void ptb_2_Clubs_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2_Clubs";
        }

        private void ptb_King_Clubs_Click(object sender, EventArgs e)
        {
            textBox1.Text = "King_Clubs";
        }

        private void ptb_Ace_Spades_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ace_Spades";
        }

        private void ptb_Joker_Black_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Joker_Black";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
