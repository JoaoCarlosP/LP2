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
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnValorH_Click(object sender, EventArgs e)
        {
            int N = 0;
            double H = 0;

            lblResposta.Text = "";

            if (!int.TryParse(txtNumeroInserido.Text, out N))
            {
                MessageBox.Show("O caracter inserido deve ser um número!");
                txtNumeroInserido.Focus();
            }
            else
                if(N <= 0)
            {
                MessageBox.Show("O número inserido deve ser maior que 0 (zero)!");
                txtNumeroInserido.Focus();
            }
            else
            {
                for(double i = 1; i <= N; i++)
                {
                    H += 1 / i;
                }

                lblResposta.Text = "Resposta: A soma de 1/1, 1/2... 1/N é: " + H;
                lblResposta.Visible = true;
            }
        }
    }
}
