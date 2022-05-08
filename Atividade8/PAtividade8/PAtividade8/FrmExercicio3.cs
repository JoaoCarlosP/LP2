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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string frase = txtFrase.Text.Replace(" ", "").ToUpper(),
                auxiliar = "";
            char[] fraseInversa = frase.ToCharArray();

            Array.Reverse(fraseInversa);

            foreach (char c in fraseInversa)
            {
                auxiliar = auxiliar + c.ToString();
            }

            lblResposta.Visible = true;

            if (string.Compare(frase, auxiliar) == 0)
                lblResposta.Text = "A frase " + txtFrase.Text + " é um palindromo!";
            else
                lblResposta.Text = "A frase/palavra: " + txtFrase.Text + "NÃO é um palindromo!";

        }
    }
}