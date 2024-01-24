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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter value in textbox.");
                return;
            }
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
