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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            if (num < 0 || num > 100) 
            {
                MessageBox.Show("Enter a valid number (0 - 100)");
                textBox1.Text = "";
                return;
            }
            if (num > 70) 
            {
                MessageBox.Show("You got an A Grade.");
            }
            else if (num > 60 &&  num <= 70)
            {
                MessageBox.Show("You got a B Grade");
            }
            else if (num > 50 && num <= 60)
            {
                MessageBox.Show("You got a C Grade");
            }
            else if (num > 40 && num <= 50)
            {
                MessageBox.Show("You got a D Grade");
            }
            else if (num > 30 && num <= 40)
            {
                MessageBox.Show("You got an E Grade");
            }
            else
            {
                MessageBox.Show("You got a F Grade");
            }
        }
    }
}
