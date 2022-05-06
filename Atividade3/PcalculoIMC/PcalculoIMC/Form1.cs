using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalculo_Click(object sender, EventArgs e)
        {
            Double peso, altura, IMC;

            if (Double.TryParse(txtPeso.Text, out peso) &&
                Double.TryParse(txtAltura.Text, out altura))
            {
                IMC = peso / Math.Pow(altura, 2);
                IMC = Math.Round(IMC, 1);

                txtIMC.Text = IMC.ToString();

                if (IMC < 18.5)
                {
                    MessageBox.Show("Classificação: Magreza.");
                }
                else
                if (IMC < 25)
                {
                    MessageBox.Show("Classificação: Normal.");
                }
                else
                if (IMC < 30)
                {
                    MessageBox.Show("Classificação: Sobrepeso.");
                }
                else
                if (IMC < 40)
                {
                    MessageBox.Show("Classificação: Obesidade.");
                }
                else
                if (IMC >= 40)
                {
                    MessageBox.Show("Classificação: Obsidade grave.");
                }
            }
            else
            {
                MessageBox.Show("Valor inválido! Insira apenas números.");
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
