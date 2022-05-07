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
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        

        private void btnQtdeEspacoBranco_Click(object sender, EventArgs e)
        {
            string frase = rchtxtFrase.Text.Trim();
            int qtdeEspaco = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (Char.IsWhiteSpace(frase[i]))
                    qtdeEspaco += 1;
            }
            MessageBox.Show("Quantidade de espaços em branco é: " +qtdeEspaco);
        }

        private void btnQtdeLetraR_Click(object sender, EventArgs e)
        {
            string frase = rchtxtFrase.Text.ToUpper().Trim();
            int qtdeLetraR = 0;

            foreach(char caracter in frase)
            {
                if (caracter == 'R')
                    qtdeLetraR += 1;
            }
            MessageBox.Show("Quantidade de letras 'R's é: " + qtdeLetraR);
        }

        private void btnQtdeDePar_Click(object sender, EventArgs e)
        {
            string frase = rchtxtFrase.Text.ToUpper().Replace(" ", "");
            char caracter = ' ';
            int i = 0;
            int qtdeCharRepetido = 0;

            while(i < frase.Length)
            {
                if (frase[i] == caracter)
                    qtdeCharRepetido += 1;

                caracter = frase[i];
                i++;
            }
            MessageBox.Show("Quantidade de caracteres repetidos é: " + qtdeCharRepetido);
        }

 
    }
}
