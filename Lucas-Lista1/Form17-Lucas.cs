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
    public partial class Form17_Lucas : Form
    {
        public Form17_Lucas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
            double sb, sl;
            sb = Convert.ToDouble(textBox1.Text);

            sl = sb - (sb * 10 / 100);
            sl = sl - (sl * 5 / 100);

            label4.Text = sl.ToString("F2");
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
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form17_Lucas_Load(object sender, EventArgs e)
        {

        }
    }
}
