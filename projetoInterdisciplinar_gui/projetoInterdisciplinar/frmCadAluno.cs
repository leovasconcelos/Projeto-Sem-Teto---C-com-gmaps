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
        public int idAluno, operacao = 0;



        private void inicial()
        {
            gbxDados.Enabled = false;
            gbxAlunos.Enabled = true;
            btnAdiconar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;

            txtId.Text = "";
            txtNome.Text = "";
            txtProntuario.Text = "";
            txtCurso.Text = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
            txtTelefone.Text = "";


        }

        private void frmCadAluno_Load(object sender, EventArgs e)
        {
            inicial();
            carregaListBox(lstAlunos);

            txtNome.MaxLength = 40;
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtProntuario.MaxLength = 7;
            txtCurso.MaxLength = 30;
            txtCurso.CharacterCasing = CharacterCasing.Upper;
            txtEmail.MaxLength = 50;
            txtEmail.CharacterCasing = CharacterCasing.Upper;
            txtCelular.MaxLength = 15;
            txtTelefone.MaxLength = 15;

        }

        private void id()
        {
            conexao conexao = new conexao();
            conexao.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT max(id_aluno)+1 FROM ALUNO", conexao.bdConn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
            if (dr.Read())
            {
                txtId.Text = dr[0].ToString();
            }
        }

        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            operacao = 1;
            txtId.Enabled = false;
            txtId.Text = (idAluno + 1).ToString();
            btnAdiconar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            gbxAlunos.Enabled = false;
            gbxDados.Enabled = true;

            id();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicial();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conexao conexao = new conexao();
            conexao.conectar();
            MySqlCommand cmd;
            if (operacao == 1)
            {
                try
                {
                    cmd = new MySqlCommand("INSERT INTO ALUNO VALUES(?,?,?,?,?,?,?,?)", conexao.bdConn);
                    cmd.Parameters.AddWithValue("@ID_ALUNO", txtId.Text);
                    cmd.Parameters.AddWithValue("@NOME_ALUNO", txtNome.Text);
                    cmd.Parameters.AddWithValue("@PRONTUARIO_ALUNO", txtProntuario.Text);
                    cmd.Parameters.AddWithValue("@EMAIL_ALUNO", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@CELULAR_ALUNO", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@TELEFONE_ALUNO", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@CURSO_ALUNO", txtCurso.Text);
                    cmd.Parameters.AddWithValue("@status_aluno", 0);

                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                    DialogResult iResposta;
                    iResposta = MessageBox.Show("Deseja Continuar a Incluir?", "Confirma Nova Inclusao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iResposta.ToString() == "Yes")
                    {
                        txtId.Text = "";
                        txtNome.Text = "";
                        txtProntuario.Text = "";
                        txtCurso.Text = "";
                        txtEmail.Text = "";
                        txtCelular.Text = "";
                        txtTelefone.Text = "";

                        btnAdiconar.Enabled = false;
                        btnCancelar.Enabled = true;
                        btnEditar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnSalvar.Enabled = true;
                        gbxAlunos.Enabled = false;
                        gbxDados.Enabled = true;
                        carregaListBox(lstAlunos);

                    }
                    else
                    {
                        inicial();
                        carregaListBox(lstAlunos);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
                }
            }
            else if (operacao == 2)
            {
                cmd = new MySqlCommand("UPDATE (ALUNO) SET  NOME_ALUNO=?, PRONTUARIO_ALUNO=?, EMAIL_ALUNO=?, CELULAR_ALUNO=?, TELEFONE_ALUNO=?, CURSO_ALUNO=? WHERE ID_ALUNO=?", conexao.bdConn);
                cmd.Parameters.AddWithValue("@NOME_ALUNO", txtNome.Text);
                cmd.Parameters.AddWithValue("@PRONTUARIO_ALUNO", txtProntuario.Text);
                cmd.Parameters.AddWithValue("@EMAIL_ALUNO", txtEmail.Text);
                cmd.Parameters.AddWithValue("@CELULAR_ALUNO", txtCelular.Text);
                cmd.Parameters.AddWithValue("@TELEFONE_ALUNO", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@CURSO_ALUNO", txtCurso.Text);
                cmd.Parameters.AddWithValue("@ID_ALUNO", txtId.Text);
                cmd.ExecuteReader(CommandBehavior.SingleRow);

                inicial();
                carregaListBox(lstAlunos);

            }
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

        public void carregaListBox(ListBox lst)
        {
            lst.Items.Clear();
            idAluno = 0;
            conexao conexao = new conexao();
            try
            {

                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM ALUNO  where status_aluno <> 2", conexao.bdConn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                string texto;
                while (dr.Read())
                {
                    texto = dr[0].ToString();
                    texto = texto + "\t" + dr[1].ToString();
                    lst.Items.Add(texto);
                    
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

        private void exibeDados(int prontuario, string nome)
        {
            conexao conexao = new conexao();
            conexao.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ALUNO WHERE NOME_ALUNO=? AND id_aluno=?", conexao.bdConn);
            cmd.Parameters.AddWithValue("@NOME_ALUNO", nome);
            cmd.Parameters.AddWithValue("@id_aluno", prontuario);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (dr.Read())
            {
                txtId.Text = Convert.ToString(dr[("ID_ALUNO")]);
                txtNome.Text = Convert.ToString(dr[("NOME_ALUNO")]);
                txtProntuario.Text = Convert.ToString(dr[("PRONTUARIO_ALUNO")]);
                txtCurso.Text = Convert.ToString(dr[("CURSO_ALUNO")]);
                txtEmail.Text = Convert.ToString(dr[("EMAIL_ALUNO")]);
                txtCelular.Text = Convert.ToString(dr[("CELULAR_ALUNO")]);
                txtTelefone.Text = Convert.ToString(dr[("TELEFONE_ALUNO")]);


            }

            dr.Close();
            conexao.desconectar();

        }

        private void lstAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] campo = lstAlunos.Text.Split(Convert.ToChar("\t"));
                exibeDados(Convert.ToInt32( campo[0]),campo[1]);

                btnAdiconar.Enabled = false;

                btnAdiconar.Enabled = false;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
            }
            catch
            {

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult iResposta = MessageBox.Show("Deseja excluir este aluno?", "Confirma Exclusao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (iResposta == DialogResult.Yes)
            {
                try
                {
                    conexao conexao = new conexao();
                    conexao.conectar();
                    MySqlCommand cmd = new MySqlCommand("call deletarAluno(?)", conexao.bdConn);
                    cmd.Parameters.AddWithValue("@id_aluno", txtId.Text);
                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                    conexao.desconectar();

                    carregaListBox(lstAlunos);

                    inicial();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");

                }


            }
            else
            {
                carregaListBox(lstAlunos);

                inicial();
            }



        }

        public static void buscaListBox(ListBox lst, string busca)
        {
            lst.Items.Clear();
            conexao conexao = new conexao();
            try
            {
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("SELECT NOME_ALUNO,PRONTUARIO_ALUNO FROM ALUNO WHERE NOME_ALUNO LIKE ? ", conexao.bdConn);
                cmd.Parameters.AddWithValue("@NOME_ALUNO", busca + "%");
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                string texto;
                while (dr.Read())
                {
                    texto = dr[0].ToString();
                    texto = texto + "\t" + dr[1].ToString();
                    lst.Items.Add(texto);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Ocorreu o seguinte erro: " + e.Message, "ERRO");

            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                    if (txtTelefone.Text.Length == 0)
                    {
                        txtTelefone.Text = "(";
                        txtTelefone.SelectionStart = txtTelefone.Text.Length;
                    }
                    if (txtTelefone.Text.Length == 3 && e.ToString() != "Back")
                    {
                        txtTelefone.Text = txtTelefone.Text + ")";
                        txtTelefone.SelectionStart = txtTelefone.Text.Length;
                    }
                    if (txtTelefone.Text.Length == 8 && e.ToString() != "Back")
                    {
                        txtTelefone.Text = txtTelefone.Text + "-";
                        txtTelefone.SelectionStart = txtTelefone.Text.Length;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                    if (txtCelular.Text.Length == 0)
                    {
                        txtCelular.Text = "(";
                        txtCelular.SelectionStart = txtCelular.Text.Length;
                    }
                    if (txtCelular.Text.Length == 3 && e.ToString() != "Back")
                    {
                        txtCelular.Text = txtCelular.Text + ")";
                        txtCelular.SelectionStart = txtCelular.Text.Length;
                    }
                    if (txtCelular.Text.Length == 8 && e.ToString() != "Back")
                    {
                        txtCelular.Text = txtCelular.Text + "-";
                        txtCelular.SelectionStart = txtCelular.Text.Length;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            string texto;
            if (txtBusca.Text == "")
            {
                carregaListBox(lstAlunos);
            }
            else
            {
                texto = txtBusca.Text;

                buscaListBox(lstAlunos, texto);
            }
        }




    }
}

