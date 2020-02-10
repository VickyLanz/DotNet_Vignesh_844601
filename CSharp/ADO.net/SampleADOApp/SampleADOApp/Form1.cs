using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleADOApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Morning all .Have a great day",
                "Greetings of the day");
            if ((txtFirst.Text == "") || (txtSecond.Text == ""))
            {
                MessageBox.Show("Fields are mandatory");
            }
            else
            {

                double n1, n2;
                n1 = double.Parse(txtFirst.Text);
                n2 = double.Parse(txtFirst.Text);
                double result = 0;
                if(rdbAdd.Checked)
                {
                    result = (n1 + n2);
                    lblSolution.Text = "Sum :" + result;
                }
                else if (rdbSub.Checked)
                {
                    result = (n1 - n2);
                    lblSolution.Text = "Difference :" + result;
                }
               else if (rdbMultiply.Checked)
                {
                    result = (n1 * n2);
                    lblSolution.Text = "Product :" + result;
                }
               else if (rdbDivide.Checked)
                {
                    result = (n1 / n2);
                    lblSolution.Text = "Quotient :" + result;
                }
               else
                {
                    lblSolution.Text="Enter your Choice First";
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
