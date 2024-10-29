using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal hoursworked, hourlyPayRate, grossPay;
            const decimal BASE_HOUR = 40m;
            const decimal OVERTIME_RATE = 1.5m;

            try 
            {
                hoursworked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                if (hoursworked > BASE_HOUR)
                {
                    grossPay = (BASE_HOUR * hourlyPayRate) +
                        ((hoursworked - BASE_HOUR) * hourlyPayRate * OVERTIME_RATE);
                }
                else
                {
                    grossPay = hoursworked * hourlyPayRate;
                }

                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            { 
                //Display an error message.
                MessageBox.Show(ex.Message); 
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
