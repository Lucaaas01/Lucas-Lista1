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
    public partial class Form18_Lucas : Form
    {
        public Form18_Lucas()
        {
            InitializeComponent();
        }

        private void Form18_Lucas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int dd, mm, aa, inv;

            dd = Convert.ToInt32(textBox1.Text);
            aa = Convert.ToInt32(textBox3.Text);
            mm = Convert.ToInt32(textBox2.Text);

            inv = (aa * 10000) + (mm * 100) + dd;
            label6.Text = inv.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido ,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            label6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
