using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucas_Lista1
{
    public partial class Form9_Lucas : Form
    {
        double a, b, c, d;

        private void button2_Click(object sender, EventArgs e)
        {
            double rm1, rm2, rm3, rm4, rm5, rm6;
            try { 
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            d = Convert.ToDouble(textBox4.Text);

            rm1 = a * b;
            label20.Text = rm1.ToString();

            rm2 = a * c;
            label23.Text = rm2.ToString();

            rm3 = a * d;
            label21.Text = rm3.ToString();

            rm4 = b * c;
            label25.Text = rm4.ToString();

            rm5 = b * d;
            label22.Text = rm5.ToString();

            rm6 = c * d;
            label24.Text = rm6.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido para horas trabalhadas, valor da hora e percentual de desconto,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public Form9_Lucas()
        {
            InitializeComponent();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label23.Text = "";
            label21.Text = "";
            label25.Text = "";
            label22.Text = "";
            label24.Text = "";

        }

        private void Form9_Lucas_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rs1, rs2, rs3, rs4, rs5, rs6;
            try { 
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            d = Convert.ToDouble(textBox4.Text);

            rs1 = a + b;
            label14.Text = rs1.ToString();

            rs2 = a + c;
            label15.Text = rs2.ToString();

            rs3 = a + d;
            label16.Text = rs3.ToString();   

            rs4 = b + c;
            label17.Text = rs4.ToString();

            rs5 = b + d;
            label18.Text = rs5.ToString();   

            rs6 = c + d;
            label19.Text = rs6.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
