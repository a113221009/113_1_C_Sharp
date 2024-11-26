using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            //這裡是寫入名字的按鈕點擊事件處理程式
            try
            {
                StreamWriter outputfile;  //StreamWriter物件
                outputfile = File.AppendText(@"C:\\Users\\shu\\Desktop\friends.txt"); //開啟檔案
                outputfile.WriteLine(nameTextBox.Text); //寫入名字
                outputfile.Close();   //關閉檔案
                MessageBox.Show("名字已經寫入檔案。");  //顯示訊息
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
