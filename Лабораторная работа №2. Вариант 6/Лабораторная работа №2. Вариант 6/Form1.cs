using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__2.Вариант_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1,655e-2";
            textBox2.Text = "-2,75";
            textBox3.Text = "0,15";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X=" + x.ToString();

            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y=" + y.ToString();

            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z=" + z.ToString();

            double b = Math.Sqrt(10 * (Math.Pow(x, 1.3) + Math.Pow(x, y + 2))) * (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y));
            textBox4.Text += Environment.NewLine + "Результат B=" + b.ToString();
        }
    }
}
