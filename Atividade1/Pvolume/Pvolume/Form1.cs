using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*-----------------------------Validação do Raio------------------------------*/
        private void textBox1_Validated(object sender, EventArgs e)
        {
            double raio;

            if (!Double.TryParse(textBox1.Text, out raio)) //tryParse é a propriedade de conversão de texto para Double / out => envia para varial de saída
            {
                MessageBox.Show("Valor raio inválido!");
                //textBox1.Focus();       //Manda o foco novamente para o textBox
            }
            else
                if (raio <= 0)
            {
                MessageBox.Show("O raio deve ser maior que zero!");
                //textBox1.Focus();
            }
        }

        /*-----------------------------Validação da Altura---------------------------*/
        private void textBox2_Validated(object sender, EventArgs e)
        {
            double altura;

            if (!Double.TryParse(textBox2.Text, out altura))
            {
                MessageBox.Show("Altura inválida!");
                //textBox2.Focus();
            }
            else
                if (altura <= 0)
            {
                MessageBox.Show("Altura deve ser maior do que zero!");
                //textBox2.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();        //finaliza a aplicação
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio;

            if (!Double.TryParse(textBox1.Text, out raio)) //tryParse é a propriedade de conversão de texto para Double / out => envia para varial de saída
            {
                MessageBox.Show("Valor raio inválido!");
                textBox1.Focus();       //Manda o foco novamente para o textBox
            }
            else
                if (raio <= 0)
            {
                MessageBox.Show("O raio deve ser maior que zero!");
                textBox1.Focus();
            }
            else
            {
                double altura;
                if (!Double.TryParse(textBox2.Text, out altura))
                {
                    MessageBox.Show("Altura inválida!");
                    textBox2.Focus();
                }
                else
                    if (altura <= 0)
                {
                    MessageBox.Show("Altura deve ser maior do que zero!");
                    textBox2.Focus();
                }
                else
                {
                    //fazer calculo
                    // Volume = Pi * raio * raio * altura

                    double volume;

                    volume = Math.PI * Math.Pow(raio, 2) * altura;      //Conta

                    textBox3.Text = volume.ToString("N2");   //Conversão do volume que ta 'double' --> 'string' 
                }                                            //para exibir valor no TextBox3. / ('N2') é o num de casas decimais
            }
        }
    }
}