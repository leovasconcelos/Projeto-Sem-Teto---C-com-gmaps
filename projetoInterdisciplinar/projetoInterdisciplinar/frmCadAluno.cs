using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace projetoInterdisciplinar
{
    public partial class frmCadAluno : Form
    {
        public frmCadAluno()
        {
            InitializeComponent();
        }
        public int operacao = 0;

        private void inicial()
        {
            gbxDados.Enabled = false;
            gbxAlunos.Enabled = true;
            btnAdiconar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void frmCadAluno_Load(object sender, EventArgs e)
        {
            inicial();
            carregaListBox(lstAlunos);

        }

        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            operacao = 1;

            btnAdiconar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            gbxAlunos.Enabled = false;
            gbxDados.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicial();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            inicial();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = 2;

            btnAdiconar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            gbxAlunos.Enabled = false;
            gbxDados.Enabled = true;


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

       
        public static void carregaListBox(ListBox lst)
        {
            conexao conexao = new conexao();
            try
            {
                
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("SELECT NOME_ALUNO FROM ALUNO",conexao.bdConn);
                MySqlDataReader dr =  cmd.ExecuteReader(CommandBehavior.Default);
                while (dr.Read())
                {
                    lst.Items.Add(dr["NOME_ALUNO"]);
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
            finally
            {
                conexao.desconectar();
            }

        }

    }
}
