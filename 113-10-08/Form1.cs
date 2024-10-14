namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ptb_diamond8_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("Diamonds 8");
        }

        private void ptb_Club2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("Clubs 2");
        }

        private void ptb_ClubsKing_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("Clubs King");
        }

        private void ptb_SpadesA_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("Spades A");
        }

        private void ptb_Joker_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("Joker");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
