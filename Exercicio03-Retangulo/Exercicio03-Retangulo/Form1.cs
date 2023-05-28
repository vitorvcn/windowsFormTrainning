using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio03_Retangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //terminar programa
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //limpar parametos
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            lblResultado.Text = "0";

            //foco no text box A
            txtLadoA.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaração de váriavel
            int ladoA;
            int ladoB;
            int resultado;

            //capturar valores
            ladoA = Convert.ToInt32(txtLadoA.Text);
            ladoB = Convert.ToInt32(txtLadoB.Text);

            //processamento
            resultado = ladoA * ladoB;

            //saída
            lblResultado.Text = resultado.ToString();

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
