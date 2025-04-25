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
    public partial class Form10_Lucas : Form
    {
        public Form10_Lucas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, a, l, v;
            try{
            c = Convert.ToDouble(textBox1.Text);
            a = Convert.ToDouble(textBox2.Text);
            l = Convert.ToDouble(textBox3.Text);

            v = c * a * l;
            label6.Text = v.ToString();
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
            textBox3.Clear();
            label6.Text = "";
        }

        private void Form10_Lucas_Load(object sender, EventArgs e)
        {

        }
    }
}
