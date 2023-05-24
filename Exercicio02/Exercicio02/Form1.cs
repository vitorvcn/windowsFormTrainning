using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpando os valores
            txtLado.Text = "";
            lblResultado.Text = "0";

            //Colocando o foco no componente do text box do lado
            txtLado.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Fechar o formulário
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarar as variáreis
            int lado;
            int area;

            //Capturando os valores de entrada
            lado = Convert.ToInt32(txtLado.Text);

            //Processamento

            area = lado * lado;

            //Saída
            lblResultado.Text = Convert.ToString(area);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
