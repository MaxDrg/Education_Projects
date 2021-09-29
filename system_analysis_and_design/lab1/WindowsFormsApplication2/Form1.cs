using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            double x1, x2;

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox5.Text);

            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d > 0)
            {
                x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                textBox3.Text = Math.Round(x1, 3).ToString();
                textBox4.Text = Math.Round(x2, 3).ToString();
            }
            if (d == 0)
            {
                x1 = -(b / (2 * a));
                textBox3.Text = Math.Round(x1, 3).ToString();
                textBox4.Text = Math.Round(x1, 3).ToString();
            }
            if (d < 0)
            {
                label6.Text = "Dicriminant negative!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
