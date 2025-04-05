using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numberf, numbers;
            double top, fark, carp, bolum;
            numberf = Convert.ToDouble(textBox1.Text);
            numbers = Convert.ToDouble(textBox2.Text);
            top = numberf + numbers;
            fark = numberf - numbers;
            carp = numberf * numbers;
            bolum = numberf / numbers;
            
            label7.Text = top.ToString();
            label8.Text = fark.ToString();
            label9.Text = carp.ToString();
            label10.Text = bolum.ToString();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
