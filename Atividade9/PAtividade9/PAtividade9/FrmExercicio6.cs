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
    public partial class FrmExercicio6 : Form
    {
        public FrmExercicio6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[3];
            string auxiliarNome = "";
            int qtde = 0;
            double teste = 0; ;

            for(int i=0; i < 3; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite o {i+1}º nome completo: ", "Entrada de Dados");

                if (nomes[i] == "")     //Verifica se o campo está vazio!
                {
                    MessageBox.Show("A caixa de entrada de dados deve ser preenchida");
                    i--;
                }
                else
                    if (double.TryParse(nomes[i], out teste))   //Verifica se digitou um número
                {
                    MessageBox.Show("Valor inválido!");
                    i--;
                }
                else
                {
                    auxiliarNome = nomes[i].Replace(" ", "");
                    qtde = auxiliarNome.Length;
                    lstbxLista.Items.Add($"Aluno {i+1}: {nomes[i]} tem {qtde} caracteres \n");
                }
                
            }
            
        }
    }
}
