using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        double A = 0; //A = salário

        private void cbxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //==================== Verificação e atribuição do salario por cargo ===================

            if (cbxCargo.SelectedIndex == 0)
                A = 2000;
            else if (cbxCargo.SelectedIndex == 1)
                A = 3500;
            else if (cbxCargo.SelectedIndex == 2)
                A = 4500;
            else if (cbxCargo.SelectedIndex == 3)
                A = 2300;
            else if (cbxCargo.SelectedIndex == 4)
                A = 3800;
            else if (cbxCargo.SelectedIndex == 5)
                A = 5000;
            else if (cbxCargo.SelectedIndex == 6)
                A = 1500;

            txtSalario.Text = "R$ " + A.ToString();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            double nomeFuncionario,
                matricula,
                salarioBruto,
                gratificacao = 0;

            int B, C, D,
                producao = 0;

            //============================= Validação dos valores inseridos =================================

            if (double.TryParse(txtNome.Text, out nomeFuncionario))
            {
                MessageBox.Show("A caixa de nome só aceita caracteres alfabéticos!");
                txtNome.Focus();
            }
            else
                if (!double.TryParse(txtMatricula.Text, out matricula) ||
                    !int.TryParse(txtProdução.Text, out producao))
                    MessageBox.Show("Valor inválido! Possíveis erros:\n" +
                        "- Numero de matricula inválida.\n" +
                        "- Número da produção inválida.");
            else 
                if (txtNome.Text == string.Empty || txtMatricula.Text == string.Empty || txtProdução.Text == string.Empty)
                    MessageBox.Show("Não pode haver caixas de texto vazias!");

            if (txtGratificacao.Text == "")
                txtGratificacao.Text = "0";

            gratificacao = Convert.ToDouble(txtGratificacao.Text);

            B = (producao >= 100 ? 1 : 0);
            C = (producao >= 120 ? 1 : 0);
            D = (producao >= 150 ? 1 : 0);

            salarioBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

            if (salarioBruto > 7000 && producao >= 150 && gratificacao > 0)
                salarioBruto = salarioBruto + 0;
            else
                if (salarioBruto > 7000 && producao < 150)
                    salarioBruto = 7000;
             
            lblResposta.Text = "Salário Bruto: R$ " + salarioBruto;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMatricula.Clear();
            txtGratificacao.Clear();
            txtProdução.Clear();
            cbxCargo.Text = null;
            txtSalario.Clear();
        }
    }
}
