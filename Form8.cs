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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text), num2 = int.Parse(textBox2.Text), num3 = int.Parse(textBox3.Text);
            if (num1 < 0 || num1 > 100)
            {
                MessageBox.Show("Enter a valid num1ber (0 - 100)");
                textBox1.Text = "";
                return;
            }
            if (num2 < 0 || num2 > 100)
            {
                MessageBox.Show("Enter a valid num1ber (0 - 100)");
                textBox2.Text = "";
                return;
            }
            if (num3 < 0 || num3 > 100)
            {
                MessageBox.Show("Enter a valid num1ber (0 - 100)");
                textBox3.Text = "";
                return;
            }
            if (num1 > 70)
            {
                textBox1.Text = "A";
            }
            else if (num1 > 60 && num1 <= 70)
            {
                textBox1.Text = "B";
            }
            else if (num1 > 50 && num1 <= 60)
            {
                textBox1.Text = "C";
            }
            else if (num1 > 40 && num1 <= 50)
            {
                textBox1.Text = "D";
            }
            else if (num1 > 30 && num1 <= 40)
            {
                textBox1.Text = "E";
            }
            else
            {
                textBox1.Text = "F";
            }

            if (num2 > 70)
            {
                textBox2.Text = "A";
            }
            else if (num2 > 60 && num2 <= 70)
            {
                textBox2.Text = "B";
            }
            else if (num2 > 50 && num2 <= 60)
            {
                textBox2.Text = "C";
            }
            else if (num2 > 40 && num2 <= 50)
            {
                textBox2.Text = "D";
            }
            else if (num2 > 30 && num2 <= 40)
            {
                textBox2.Text = "E";
            }
            else
            {
                textBox2.Text = "F";
            }

            if (num3 > 70)
            {
                textBox3.Text = "A";
            }
            else if (num3 > 60 && num3 <= 70)
            {
                textBox3.Text = "B";
            }
            else if (num3 > 50 && num3 <= 60)
            {
                textBox3.Text = "C";
            }
            else if (num3 > 40 && num3 <= 50)
            {
                textBox3.Text = "D";
            }
            else if (num3 > 30 && num3 <= 40)
            {
                textBox3.Text = "E";
            }
            else
            {
                textBox3.Text = "F";
            }

            if (num1 > num2) 
            { 
                if (num1 > num3)
                {
                    MessageBox.Show("The highest grade is " + textBox1.Text);
                }
                else
                {
                    MessageBox.Show("The highest grade is " + textBox3.Text);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    MessageBox.Show("The highest grade is " + textBox2.Text);
                }
                else
                {
                    MessageBox.Show("The highest grade is " + textBox3.Text);
                }
            }
        }
    }
}
