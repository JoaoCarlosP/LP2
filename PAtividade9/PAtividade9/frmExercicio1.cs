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

namespace PAtividade9
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string auxiliar;
            int[] vetor = new int[20];

            for (var x = 0; x < 20; x++)
            {
                auxiliar = Interaction.InputBox("Digite o número da posição: " +(x+1), "Entrada de Dados");
                if(!int.TryParse(auxiliar, out vetor[x]))
                {
                    MessageBox.Show("Valor inválido!");
                    x -= 1;
                }
            }
            Array.Reverse(vetor);
            auxiliar = "";

            foreach (int numero in vetor)
                auxiliar = auxiliar + "\n" + numero;

            MessageBox.Show(auxiliar);
        }
    }
}
