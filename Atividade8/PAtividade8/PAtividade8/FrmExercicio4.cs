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

        private void cbxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //==================== Verificação e atribuição do salario por cargo ===================

            double A = 0; //A = salário

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
                matricula;

            int B, C, D,
                producao = 0;

            //============================= Validação dos valores inseridos =================================

            if (double.TryParse(txtNome.Text, out nomeFuncionario))
            {
                MessageBox.Show("A caixa de nome só aceita caracteres alfabéticos!");
                txtNome.Focus();
            }
            else if (!double.TryParse(txtMatricula.Text, out matricula) ||
                !int.TryParse(txtProdução.Text, out producao))
                MessageBox.Show("Valor inválido! Possíveis erros:\n" +
                    "- Numero de matricula inválida.\n" +
                    "- Número da produção inválida.");
            else if (txtNome.Text == string.Empty || txtMatricula.Text == string.Empty || txtProdução.Text == string.Empty)
                MessageBox.Show("Não pode haver caixas de texto vazias!");

            B = (producao >= 100 ? 1 : 0);
            C = (producao >= 120 ? 1 : 0);
            D = (producao >= 150 ? 1 : 0);
        }

        
    }
}
