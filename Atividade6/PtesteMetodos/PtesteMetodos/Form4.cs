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
    public partial class formExercicio4 : Form
    {
        public formExercicio4()
        {
            InitializeComponent();
        }

        private void btnQtdeNumero_Click(object sender, EventArgs e)
        {
            string textoDigitado = rchtxtFrase.Text.Trim();
            int totalCaracter = textoDigitado.Length;
            int qtdeNumero = 0;

            for (var i = 0; i < totalCaracter; i++)
            {
                if (Char.IsNumber(textoDigitado[i]))
                    qtdeNumero += 1;
            }

            MessageBox.Show("O texto digitado tem " +qtdeNumero+ " número(s)");


        }

        private void btnQtdeAlfabetico_Click(object sender, EventArgs e)
        {
            string textoDigitado = rchtxtFrase.Text.Trim();
            int qtdeCaracter = 0;

            foreach(char caracter in textoDigitado)
            {
                if (Char.IsLetter(caracter))
                    qtdeCaracter += 1;
            }

            MessageBox.Show("O texto digitado tem " +qtdeCaracter+ " letra(s)");
        }

        private void btnPosicaoCaracterBranco_Click(object sender, EventArgs e)
        {
            string textoDigitado = rchtxtFrase.Text.Trim();
            int i = 0;
            int posicao = 0;
            
            while(i < textoDigitado.Length)
            {
                if(char.IsWhiteSpace(textoDigitado[i]))
                {
                    posicao = i;
                    break;
                }

                i += 1;
            }

            MessageBox.Show("A posição do espaço em branco é: " +posicao);
        }
    }
}
