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
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalculoFaturamento_Click(object sender, EventArgs e)
        {
            string auxiliarQtde = "";
            string auxiliarValor = "";
            int[] qtdeProduto = new int[10];
            double[] valorProduto = new double[10];
            double[] valorTotal = new double[10];
            double faturamentoTotal = 0;
            int j = 0;

            for(int i = 0; i < 10; i++)
            {
                auxiliarQtde = Interaction.InputBox("Digite a QUANTIDADE vendida da " +(i+1) + "º mercadoria.", "Entrada de Dados.");

                //================== Validação da Quantidade de Produtos =============
                if (!int.TryParse(auxiliarQtde, out qtdeProduto[i]))
                {
                    MessageBox.Show("Valor inválido!");
                    i--;
                }
                else
                {

                    j += 1; 
                    while (j > 0)
                    {
                        auxiliarValor = Interaction.InputBox("Digite o VALOR unitário da " + (i + 1) + "º mercadoria.", "Entrada de Dados.");

                        //============== Validação do Valor do Produto =================
                        if (!double.TryParse(auxiliarValor, out valorProduto[i]))
                        {
                            MessageBox.Show("Valor inválido!");
                            j += 1;
                        }

                        j -= 1;
                    }
                }

                valorTotal[i] = qtdeProduto[i] * valorProduto[i];
                faturamentoTotal += valorTotal[i];

                rchtxtQuantidade.Text += (i+1) + "º   -   " +qtdeProduto[i] + "\n";
                rchtxtValorUnitario.Text += "R$       " + valorProduto[i].ToString("N2") + "\n";
                rchtxtValorTotal.Text += "R$       " + valorTotal[i].ToString("N2") + "\n";
            }

            txtFaturamentoTotal.Text = "R$     " +faturamentoTotal.ToString("N2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rchtxtQuantidade.Clear();
            rchtxtValorTotal.Clear();
            rchtxtValorUnitario.Clear();
            txtFaturamentoTotal.Clear();
        }
    }
}
