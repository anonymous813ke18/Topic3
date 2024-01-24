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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Boolean addCount = false, subCount = false, mulCount = false, divCount = false;
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
                if (addCount == false)
                {
                    total = num1 + num2;
                    subCount = false; mulCount = false; divCount = false; addCount = true;
                }
                else
                {
                    MessageBox.Show("Cannot perform 2 additions in a row.");
                }
            }
            else if (subtraction.Checked == true)
            {
                if (subCount == false)
                {
                    total = num1 - num2;
                    addCount = false; mulCount = false; divCount = false; subCount = true;
                }
                else
                {
                    MessageBox.Show("Cannot perform 2 subtractions in a row.");
                }
            }
            else if (multiplication.Checked == true)
            {
                if (mulCount == false)
                {
                    total = num1 * num2;
                    addCount = false; subCount = false; divCount = false; mulCount = true;
                }
                else
                {
                    MessageBox.Show("Cannot perform 2 multiplicaitons in a row.");
                }
            }
            else if (division.Checked == true)
            {
                if (divCount == false)
                {
                    total = num1 / num2;
                    addCount = false; subCount = false; mulCount = false; divCount = true;
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
