using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetoInterdisciplinar
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void msACadastro_Click(object sender, EventArgs e)
        {
            frmCadAluno aluno = new frmCadAluno();
            aluno.ShowDialog();
        }

        private void msRCadastro_Click(object sender, EventArgs e)
        {
            frmCadRepublica rep = new frmCadRepublica();
            rep.ShowDialog();
        }

        private void cadastraVagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicionarVagas advaga = new frmAdicionarVagas();
            advaga.ShowDialog();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void escolherVagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssociar asocia = new frmAssociar();
            asocia.ShowDialog();
        }
    }
}
