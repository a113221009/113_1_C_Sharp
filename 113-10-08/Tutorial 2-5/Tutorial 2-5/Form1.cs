using System.Runtime.CompilerServices;

namespace Tutorial_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //顯示撲克牌背面
        private void btnShowBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;  //設定visible屬性為假
            ptxFront.Visible = false;
        }
        //顯示撲克牌正面
        private void btnShowFront_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = false;
            ptxFront.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
