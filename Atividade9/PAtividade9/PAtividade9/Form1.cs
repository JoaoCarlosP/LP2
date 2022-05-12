using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio1"];
            if (fc != null)
                fc.Close();

            frmExercicio1 objFrm = new frmExercicio1();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio2"];
            if (fc != null)
                fc.Close();

            FrmExercicio2 objFrm = new FrmExercicio2();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio3"];
            if (fc != null)
                fc.Close();

            FrmExercicio3 objFrm = new FrmExercicio3();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio4"];
            if (fc != null)
                fc.Close();

            FrmExercicio4 objFrm = new FrmExercicio4();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmExercicio5"];
            if (fc != null)
                fc.Close();

            FrmExercicio5 objFrm = new FrmExercicio5();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
