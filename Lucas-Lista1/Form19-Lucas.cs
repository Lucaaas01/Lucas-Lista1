using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucas_Lista1
{
    public partial class Form19_Lucas : Form
    {
        public Form19_Lucas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form19_Lucas_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int A, S, O, AC;
            string R;
            A = Convert.ToInt32(textBox1.Text); 
            S = Convert.ToInt32(textBox2.Text);
            O = Convert.ToInt32(textBox3.Text);

            AC = 2000 + A;

            label8.Text = A.ToString();
            label9.Text = S.ToString();
            label10.Text = O.ToString();
            
            R = "Ano: "+ AC+"\nSemestre: "+S+"°";
            label12.Text = R.ToString();
         }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido ,", "Erro",
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
            textBox3.Clear();
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label12.Text = "";
        }
    }
}
