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
    public partial class Form11_Lucas : Form
    {
        double n, r;
        public Form11_Lucas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            n = Convert.ToDouble(textBox1.Text);
            r = n * n * n;
            label6.Text = r.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label5.Text = "";
            label6.Text = "";
        }

        private void Form11_Lucas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            n = Convert.ToDouble(textBox1.Text);
            r = n * n;
            label5.Text = r.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
