using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Double LadoA, LadoB, LadoC;

            if (Double.TryParse(txtLadoA.Text, out LadoA) &&
                Double.TryParse(txtLadoB.Text, out LadoB) &&
                Double.TryParse(txtLadoC.Text, out LadoC))
            {
                if (LadoA < (LadoB + LadoC) && LadoA > Math.Abs(LadoB - LadoC) &&
                    LadoB < (LadoA + LadoC) && LadoB > Math.Abs(LadoA - LadoC) &&
                    LadoC < (LadoA + LadoB) && LadoC > Math.Abs(LadoA - LadoB))
                {
                    if (LadoA == LadoB && LadoB == LadoC)
                    {
                        MessageBox.Show("É um triângulo do tipo equilátero!");
                    }
                    else
                    if (LadoA != LadoB && LadoB != LadoC)
                    {
                        MessageBox.Show("É um triângulo do tipo escaleno!");
                    }
                    else
                    if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
                    {
                        MessageBox.Show("É um triângulo do tipo isósceles!");
                    }
                }
                else
                {
                    MessageBox.Show("Não atende aos requisitos para ser um triângulo.");
                }
            }
            else
            {
                MessageBox.Show("Valor inválido! Insira apenas números.");
            }

            
        }
    }
}
