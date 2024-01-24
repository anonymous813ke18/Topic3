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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int addCount = 0, subCount = 0, mulCount = 0, divCount = 0;
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
            if (num1 > num2)
            {
                label1.Text = "Latgest Number = " + num1;
            }
            else
            {
                label1.Text = "Largest Number = " + num2;
            }
            if (addition.Checked == true)
            {
                addCount = addCount + 1;
                if (addCount < 2)
                {
                    total = num1 + num2;
                    subCount = 0; mulCount = 0; divCount = 0;
                }
                else
                {
                    MessageBox.Show("Cannot perform 2 additions in a row.");
                }
            }
            else if (subtraction.Checked == true)
            {
                subCount++;
                if (subCount < 2)
                {
                    total = num1 - num2;
                    addCount = 0; mulCount = 0; divCount = 0;
                }
                else
                {
                    MessageBox.Show("Cannot perform 2 subtractions in a row.");
                }
            }
            else if (multiplication.Checked == true)
            {
                mulCount++;
                if (mulCount < 2)
                {
                    total = num1 * num2;
                    addCount = 0; subCount = 0; divCount = 0;
                }
                else
                {
                    MessageBox.Show("Cannot perform 2 multiplicaitons in a row.");
                }
            }
            else if (division.Checked == true)
            {
                divCount++;
                if (divCount < 2)
                {
                    total = num1 / num2;
                    addCount = 0; subCount = 0; mulCount = 0;
                }
                else
                {
                    MessageBox.Show("Cannot perform 2 divisions in a row.");
                }
            }
            else
            {
                MessageBox.Show("Select a radio button");
            }
            MessageBox.Show("Result =" + total);
        }
    }
}
