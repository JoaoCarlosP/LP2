using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;     //globais

        public Form1()
        {
            InitializeComponent();
        }

        /*----------------------Botão para fazer SOMA--------------------*/
        private void buttonSoma_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out numero1) &&
                Double.TryParse(textBox2.Text, out numero2))
            {

                resultado = numero1 + numero2;

                textBox3.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Valor inserido deve ser um número!");
            }
        }


        /*------------------Botão para fazer SUBTRAÇÃO------------------*/
        private void buttonSubt_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out numero1) &&
                Double.TryParse(textBox2.Text, out numero2))
            {

                resultado = numero1 - numero2;

                textBox3.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Valor inserido deve ser um número!");
            }
        }

        /*------------------Botão para fazer MULTIPLICAÇÃO------------------*/
        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out numero1) &&
            Double.TryParse(textBox2.Text, out numero2))
            {

                resultado = numero1 * numero2;

                textBox3.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Valor inserido deve ser um número!");
            }
        }

        /*---------------------Botão para fazer DIVISÃO-------------------*/
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBox1.Text, out numero1) &&
               !Double.TryParse(textBox2.Text, out numero2))
            {
                MessageBox.Show("Valor inserido deve ser um número!");
            }
            
            else
                if (numero2 == 0)
                {
                    MessageBox.Show("Valor inserido deve ser maior que zero!");
                    textBox2.Focus();
                }
            else
            {
                resultado = numero1 / numero2;

                textBox3.Text = resultado.ToString();
            }
        }

        /*--------------------Botão para LIMPAR os valores---------------*/
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            textBox1.Focus();
        }

        /*--------------------Botão para SAIR do programa-----------------*/
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }






    }
}
