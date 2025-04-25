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
    public partial class Form13 : Form
    {
        double a, b, rqA, rqB, s;

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            s = rqA + rqB;
            label9.Text = s.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            b = Convert.ToDouble(textBox2.Text);
            rqB = b*b; 
            label8.Text = rqB.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form13()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            a = Convert.ToDouble(textBox1.Text);
            rqA = a * a;
            label7.Text = rqA.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
