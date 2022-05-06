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
    public partial class formExercicio5 : Form
    {
        public formExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            int primeiroNumero;
            int segundoNumero;

            //====================== Verificação das caixas de texto ==============

            if(!int.TryParse(txtPrimeiroNum.Text, out primeiroNumero) ||
                !int.TryParse(txtSegundoNum.Text, out segundoNumero))
            {
                MessageBox.Show("A caixa de texto aceita apenas caracteres numéricos");
                txtPrimeiroNum.Focus();
            }
            else
                if(txtPrimeiroNum.Text == string.Empty || txtSegundoNum.Text == string.Empty)
                    MessageBox.Show("a caixa de texto não pode estar vazia!");
            else
                if(primeiroNumero > segundoNumero){
                    MessageBox.Show("O segundo número deve ser maior que o primeiro!");
                    txtSegundoNum.Focus();
            }
            else //=================== código ==============================
            {  
                Random random = new Random();
                int numeroSorteado = random.Next(primeiroNumero, segundoNumero);

                MessageBox.Show("Número sorteado: "+ numeroSorteado);
            }

        }
    }
}
