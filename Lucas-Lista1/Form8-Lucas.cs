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
    public partial class Form8_Lucas : Form
    {
        public Form8_Lucas()
        {
            InitializeComponent();
        }

        private void Form8_Lucas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Va, Vb;
            try { 
            Va = Convert.ToDouble(textBox1.Text);
            Vb = Convert.ToDouble(textBox2.Text);

            label6.Text = Va.ToString();
            label7.Text = Vb.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label6.Text = "";
            label7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
