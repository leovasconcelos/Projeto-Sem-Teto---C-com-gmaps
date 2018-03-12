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
    public partial class frmCadRepublica : Form
    {
        public frmCadRepublica()
        {
            InitializeComponent();
        }
        int operacao = 0;
        private void inicial()
        {
            gbxDados.Enabled = false;
            gbxRepublica.Enabled = true;
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void frmCadRepublica_Load(object sender, EventArgs e)
        {
            inicial();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            operacao = 1;
            gbxDados.Enabled = true;
            gbxRepublica.Enabled = false;
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = 2;
            gbxDados.Enabled = true;
            gbxRepublica.Enabled = false;
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            gbxDados.Enabled = true;
            gbxRepublica.Enabled = false;
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicial();
        }
    }
}
