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
    public partial class Form5_Lucas : Form
    {
        public Form5_Lucas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f, c;
            try
            {
                f = Convert.ToDouble(textBox1.Text);
                c = (f - 32) * (5 / 9);
                label4.Text = c.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, Digite os números", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Lucas_Load(object sender, EventArgs e)
        {

        }
    }
}
