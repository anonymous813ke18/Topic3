using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            float total = 0.0f;
            if (addition.Checked == true)
            {
                total = num1 + num2;
            }
            else if (subtraction.Checked == true) 
            {
                total = num1 - num2;
            }
            else if (multiplication.Checked == true)
            {
                total = num1 * num2;
            }
            else if (division.Checked == true)
            {
                total = num1 / num2;
            }
            else
            {
                MessageBox.Show("Select a radio button");
            }
            MessageBox.Show("Result =" + total);
        }
    }
}
