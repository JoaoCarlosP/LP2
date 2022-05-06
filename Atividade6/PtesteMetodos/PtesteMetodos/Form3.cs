using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PtesteMetodos
{
    public partial class formExercicio3 : Form
    {
        public formExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();

            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (posicao >= 0) // a busca do indexof inicia em 0
            {   
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);


                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();

            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray(); // jogo a string para um array
            Array.Reverse(arr); //Invertendo o Array

            s = "";  //Limpa a variavel

            foreach (char c in arr) //Procuro o tipo 'char' no array 'arr'
            {
                s = s + c.ToString();
            }

            txtPalavra2.Text = s;
        }
    }
}
