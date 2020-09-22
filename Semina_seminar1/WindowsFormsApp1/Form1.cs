using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Rational ReadRational(TextBox tb1, TextBox tb2)
        {
            int up = 1, down = 1;
            try
            {
                up = Convert.ToInt32(tb1.Text);
                down = Convert.ToInt32(tb2.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Введи число");
                return new Rational(0,0);
            }
            Rational x = new Rational(up,down);
            return x;
        }

        private void btplus_Click(object sender, EventArgs e)
        {           
            Rational z = ReadRational(textBox1,textBox2)+(ReadRational(textBox3,textBox4));
            textBox5.Text = z.Tostring(z);
        }

        private void btminus_Click(object sender, EventArgs e)
        {
            Rational z = ReadRational(textBox1, textBox2)-(ReadRational(textBox3, textBox4));
            textBox5.Text = z.Tostring(z);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void btumn_Click(object sender, EventArgs e)
        {
            Rational z = ReadRational(textBox1, textBox2)*(ReadRational(textBox3, textBox4));
            textBox5.Text = z.Tostring(z);
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            Rational z = ReadRational(textBox1, textBox2)/(ReadRational(textBox3, textBox4));
            textBox5.Text = z.Tostring(z);
        }
    }
}
