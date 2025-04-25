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
    public partial class Form6_Lucas : Form
    {
        public Form6_Lucas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r, h, p, v;
            try {
            p = 3.14159;
            r = Convert.ToDouble(textBox1.Text);
            h = Convert.ToDouble(textBox2.Text);
            v = p * r * r * h;
            label5.Text = v.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, Digite os números", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }

        private void Form6_Lucas_Load(object sender, EventArgs e)
        {

        }
    }
}
