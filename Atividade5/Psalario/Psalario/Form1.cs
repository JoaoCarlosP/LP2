using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }


        private void frmSalario_Load(object sender, EventArgs e)
        {
           cbxNumFilhos.SelectedIndex = 0;
        }

        //========================= Verificação do Nome do Funcionário ================================
        private void txtNomeFunc_Validated(object sender, EventArgs e)
        {
            Double nomeFuncionario;

            if (Double.TryParse(txtNomeFunc.Text, out nomeFuncionario))
            {
                MessageBox.Show("O nome do funcionário não pode ser um número!");
                Focus();
            }

            if (txtNomeFunc.Text == string.Empty)
            {
                MessageBox.Show("Nome do funcionário deve ser preenchido");
                Focus();
            }
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            Double salarioBruto = 0;
            Double aliquotaINSS = 0;
            Double aliquotaIRRF = 0;
            Double salarioFamilia = 0;
            Double valorINSS = 0;
            Double valorIRRF = 0;

            if (!Double.TryParse(txtSalarioBruto.Text, out salarioBruto))
                MessageBox.Show("Salário Bruto deve ser um valor numérico!");
            else
                if (salarioBruto <= 0)
                    MessageBox.Show("Salário bruto deve ser maior que R$ 0,00");
            else
            {
                //=============== Verificação da Aliquota do INSS =========================
                if (salarioBruto <= 800.47)
                    aliquotaINSS = 0.0765;
                else
                    if (salarioBruto <= 1050)
                    aliquotaINSS = 0.0865;
                else
                    if (salarioBruto <= 1400.77)
                    aliquotaINSS = 0.09;
                else
                    if (salarioBruto <= 2081.56)
                    aliquotaINSS = 0.11;
                else
                {
                    aliquotaINSS = 308.17;
                }

                //============= Verificação da Aliquota do IRFF =============================
                if (salarioBruto <= 1257.12)
                {
                    txtDescontoIrrf.Text = "R$ 0,00 (isento)";
                    txtAliquotaIrrf.Text = "-";                }
                else
                    if (salarioBruto <= 2512.08)
                    aliquotaIRRF = 0.15;
                else
                    aliquotaIRRF = 0.275;

                //============ Atribuição de valores ao salário familia =====================
                if (salarioBruto <= 435.52)
                    salarioFamilia = 22.33;
                else
                    if (salarioBruto <= 654.61)
                        salarioFamilia = 15.74;
                else
                    txtSalarioFamilia.Text = "-";

            }

            //------------------Calculo do desconto do INSS-------------------------

            if (salarioBruto <= 2081.56)
            {
                valorINSS = salarioBruto * aliquotaINSS;

                txtDescontoInss.Text = "R$ " + valorINSS.ToString("N2");
                txtAliquotaInss.Text = (aliquotaINSS * 100).ToString("N2") + "%";
            }
            else
            {
                valorINSS = 308.17;
                txtDescontoInss.Text = "R$ 308,17 (teto)";
                txtAliquotaInss.Text = "-";
            }


            //------------------Calculo do desconto do IRRF-------------------------

            if (salarioBruto > 1257.12)
            {
                valorIRRF = salarioBruto * aliquotaIRRF;

                txtDescontoIrrf.Text = "R$ " + valorIRRF.ToString("N2");
                txtAliquotaIrrf.Text = (aliquotaIRRF * 100).ToString("N2") + "%";
            }

            //------------------Calculo do salário familia--------------------------

            if (salarioBruto <= 654.61)
            { 
                salarioFamilia = double.Parse(cbxNumFilhos.Text) * salarioFamilia;

                txtSalarioFamilia.Text = "R$ " + salarioFamilia.ToString("N2");

            }

            //------------------Calculo do salário líquido-------------------------

            txtSalarioLiquido.Text = (salarioBruto - valorINSS - valorIRRF + salarioFamilia).ToString("N2");

            //------------------verificação da informações-------------------------

            string estadoCivil;
            string sexo;

            //Verificar estado civil
            if (ckbxCasado.Checked)
                estadoCivil = "casado";
            else
                estadoCivil = "solteiro";

            //Verificar sexo
            if (rbtnFeminino.Checked)
                sexo = "feminino";
            else
                sexo = "masculino";

            

            lblInformacao.Text = txtNomeFunc.Text + " é do sexo " + sexo + ", " + estadoCivil + " e tem " + cbxNumFilhos.SelectedIndex + " filho(s)." +
                                        "\nSeu salário líquido de R$ " + txtSalarioLiquido.Text;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFunc.Clear();
            txtSalarioBruto.Clear();
            txtAliquotaInss.Clear();
            txtAliquotaIrrf.Clear();
            txtDescontoInss.Clear();
            txtDescontoIrrf.Clear();
            txtSalarioFamilia.Clear();
            txtSalarioLiquido.Clear();

            cbxNumFilhos.SelectedIndex = 0;

            ckbxCasado.CheckState = CheckState.Unchecked;

            rbtnFeminino.Checked = true;
        }
    }
}
