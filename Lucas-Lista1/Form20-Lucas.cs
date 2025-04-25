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
    public partial class Form20_Lucas : Form
    {
        public Form20_Lucas()
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
            textBox2.Clear();
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string nome, sobreNome, NjS;
            nome = Convert.ToString(textBox1.Text);
            sobreNome = Convert.ToString(textBox2.Text);

            NjS = string.Concat("Olá ", nome , " " , sobreNome);
            label5.Text = NjS.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válido ,", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form20_Lucas_Load(object sender, EventArgs e)
        {

        }
    }
}
