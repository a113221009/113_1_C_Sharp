using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal income;     //收入
            decimal taxRate;    //稅率
            

            //Step 1: 取得收入輸入值
            if (decimal.TryParse(txtIncome.Text, out income))
            {
                //Step 2: 根據收入設定稅率
                if (income <= 590000)
                    taxRate = 0.05m; // 5%
                else if (income <= 1330000)
                    taxRate = 590000 * 0.05m + (income - 590000) * 0.12m;
                else if (income <= 2660000)
                    taxRate = 590000 * 0.05m + 740000 * 0.12m + (income - 1330000) * 0.20m;
                else if (income <= 4980000)
                    taxRate = 590000 * 0.05m + 740000 * 0.12m + 1330000 * 0.20m + (income - 2660000) * 0.30m;
                else
                    taxRate = 590000 * 0.05m + 740000 * 0.12m + 1330000 * 0.20m + 2320000 * 0.30m + (income - 4980000) * 0.40m;

                //Step 3: 計算淨收入
                decimal netincome = income - taxRate;

                // Step 4: 顯示結果
                label1.Text = $"Tax : NT${taxRate:N2}\n Net Income: NT${netincome:N2}";


            }
            else
            {
                // 如果輸入無效，顯示錯誤訊息
                label1.Text = "請輸入有效的收入數字！";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
