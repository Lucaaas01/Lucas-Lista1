using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucas_Lista1
{
    public partial class Form3_Lucas : Form
    {
        double ht, vh, pd, sb, sl, td;

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ht = Convert.ToDouble(textBox1.Text);
                vh = Convert.ToDouble(textBox2.Text);
                sb = ht * vh;
                label5.Text = sb.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido para horas trabalhadas, valor da hora e percentual de desconto,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = " ";
            label7.Text = " ";
            label10.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sl = sb - td;
                label10.Text = sl.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido para horas trabalhadas, valor da hora e percentual de desconto,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pd = Convert.ToDouble(textBox3.Text);
                td = (pd / 100) * sb;
                label7.Text = td.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido para horas trabalhadas, valor da hora e percentual de desconto,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form3_Lucas()
        {
            InitializeComponent();
        }

        private void Form3_Lucas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
