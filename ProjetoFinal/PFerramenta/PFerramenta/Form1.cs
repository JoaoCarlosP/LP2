using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;              //Infomra qual o banco de dados usado
using System.Data.SqlClient;        // "    "   "   "   "   "   "   "

namespace PFerramenta
{
    public partial class Form1 : Form
    {
       //Criada a variável conexao que se conecta com o banco
        public static SqlConnection conexao;    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {   //irá realizar a conexão de acordo com a string da máquina -- ADICIONAR DUAS BARRAS INVERTIDAS'\\' NO LUGAR DA '/'
                conexao = new SqlConnection("Data Source=DESKTOP-2H7S31R\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");

                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros =/" + ex.Message);
            }
        }

        private void cadastroFerramentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmFerramenta"];
            if (fc != null)
                fc.Close();

            frmFerramenta objFrm = new frmFerramenta();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["sobre"];
            if (fc != null)
                fc.Close();

            sobre objFrm = new sobre();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }
    }
}
