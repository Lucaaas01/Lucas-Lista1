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
    public partial class Form4_Lucas : Form
    {
        public Form4_Lucas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c1, f1;
            try
            {
                c1 = Convert.ToDouble(textBox1.Text);
                f1 = (9 * c1 + 160) / 5;
                label3.Text = f1.ToString("F2");
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
            label3.Text = "";
        }

        private void Form4_Lucas_Load(object sender, EventArgs e)
        {

        }
    }
    }
