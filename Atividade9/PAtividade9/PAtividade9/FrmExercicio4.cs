using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PAtividade9
{
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            string auxiliar = "";

            List<string> listaNomes = new List<string>(new string[] {"Ana", "André", "Débora", "Fátima", "João",
                    "Janete", "Otávio", "Marcelo","Pedro", "Thais"});

            listaNomes.Remove("Otávio");

            foreach(string a in listaNomes)
            {
                auxiliar = auxiliar + a + "\n";
            }

            MessageBox.Show(auxiliar);







        }
    }
}
