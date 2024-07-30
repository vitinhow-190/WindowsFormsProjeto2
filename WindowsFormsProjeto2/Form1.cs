using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProjeto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Entrada de dados

            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);

            //processamento

            int resultado = n1 + n2;

            //Saida de dados

            lblResultado.Text = resultado.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpar as caixas de texto através da função clear

            textBox1.Clear();
            textBox2.Clear();

            //Move o texto Zero para a label

            lblResultado.Text = "0";

            //Move o cursor para o textBox

            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação

            Close();
        }
    }
}
