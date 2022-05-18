using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace PAtividade9
{
    public partial class FrmExercicio5 : Form
    {
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void btnCalcMedia_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[4,3];
            double[] media = new double[4];
            string auxiliarNotas = "";

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    auxiliarNotas = Interaction.InputBox($"Digite o valor da {j+1}º nota", "Entrada de Dados");

                    if(Double.TryParse(auxiliarNotas, out notas[i,j]) && notas[i,j] <= 10)
                    {
                        media[i] += notas[i, j];
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido");
                        j -= 1;
                    }
                }

                media[i] /= 3;
                
            }

            auxiliarNotas = "";

            for(int i = 0; i < media.Length; i++)
            {
                auxiliarNotas = auxiliarNotas + $"Aluno {i+1}: média = " + media[i].ToString("N2") + "\n";
            }

            MessageBox.Show(auxiliarNotas);
        }
    }
}
