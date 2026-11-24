using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculeter
{
    public partial class Form1 : Form
    {
        double num1, num2, result;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out num2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num1) &&
            double.TryParse(textBox2.Text, out num2))
            {
                result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
            textBox1.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           double.TryParse(textBox1.Text, out num1);
        }
    }
}
