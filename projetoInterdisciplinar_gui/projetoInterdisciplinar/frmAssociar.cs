using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projetoInterdisciplinar
{
    public partial class frmAssociar : Form
    {
        public frmAssociar()
        {
            InitializeComponent();

        }

        int teste = 0;
        int recebe = 0;

        private void inicial()
        {
            AlunosSemRep(lstAluno);
            repComVaga(lstVaga);

            gbxRep.Enabled = true;
            txtAluno.Enabled = false;
            txtRepublica.Enabled = false;

            btnAssociar.Enabled = false;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            groupBox2.Enabled = true;
            txtNomeRep.Text = "";
            txtAlunoResp.Text = "";
            txtCapacidade.Text = "";
            txtVagas.Text = "";
            txtTipo.Text = "";
            txtAluguel.Text = "";
            txtDescricao.Text = "";
            txtRepublica.Text = "";
            txtAluno.Text = "";
            teste = 0;
        }

        private void frmAssociar_Load(object sender, EventArgs e)
        {
            inicial();
            AlunosSemRep(lstAluno);
            repComVaga(lstVaga);

            inicial();
        }

        public static void repComVaga(ListBox lst)
        {
            lst.Items.Clear();
            conexao conexao = new conexao();
            MySqlCommand cmd;
            try
            {
                conexao.conectar();
                cmd = new MySqlCommand("SELECT  * FROM republica WHERE VAGAS_REPUBLICA>0 and status_republica<>2", conexao.bdConn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                string texto;
                while (dr.Read())
                {
                    texto = dr["id_republica"].ToString();
                    texto = texto + "\t" + dr["nome_republica"].ToString();
                    texto = texto + "\t Vagas:" + dr["vagas_republica"].ToString();

                    lst.Items.Add(texto);
                }
                dr.Close();
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

        public static void repTodas(ListBox lst)
        {
            lst.Items.Clear();
            conexao conexao = new conexao();
            MySqlCommand cmd;
            try
            {
                conexao.conectar();
                cmd = new MySqlCommand("SELECT  * FROM republica WHERE status_republica<>2 ", conexao.bdConn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                string texto;
                while (dr.Read())
                {
                    texto = dr["id_republica"].ToString();
                    texto = texto + "\t" + dr["nome_republica"].ToString();
                    texto = texto + "\t Vagas:" + dr["vagas_republica"].ToString();

                    lst.Items.Add(texto);
                }
                dr.Close();
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

        public static void AlunosSemRep(ListBox lst)
        {
            lst.Items.Clear();
            conexao conexao = new conexao();
            try
            {
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("SELECT ID_ALUNO, NOME_ALUNO FROM ALUNO WHERE status_aluno = 0 ", conexao.bdConn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                string texto;
                while (dr.Read())
                {
                    texto = dr[0].ToString();
                    texto = texto + "\t" + dr[1].ToString();
                    lst.Items.Add(texto);
                }
                dr.Close();
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

        public static void AlunosComRep(ListBox lst)
        {
            lst.Items.Clear();
            conexao conexao = new conexao();
            try
            {
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("SELECT ID_ALUNO, NOME_ALUNO FROM ALUNO WHERE status_aluno = 1 ", conexao.bdConn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                string texto;
                while (dr.Read())
                {
                    texto = dr[0].ToString();
                    texto = texto + "\t" + dr[1].ToString();
                    lst.Items.Add(texto);
                }
                dr.Close();
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

        private void exibeDadosRep(int id)
        {
                conexao conexao = new conexao();
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM REPUBLICA WHERE id_republica=?", conexao.bdConn);
                cmd.Parameters.AddWithValue("@id_republica", id);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    txtNomeRep.Text = dr["NOME_REPUBLICA"].ToString();
                    txtAlunoResp.Text = dr["alunoResponsavel_republica"].ToString();
                    txtCapacidade.Text = dr["CAPACIDADE_REPUBLICA"].ToString();
                    txtVagas.Text = dr["VAGAS_REPUBLICA"].ToString();
                    txtTipo.Text = dr["TIPO_REPUBLICA"].ToString();
                    txtAluguel.Text = dr["preco_republica"].ToString();
                    txtDescricao.Text = dr["descricao_republica"].ToString();
                    txtRepublica.Text = dr["id_republica"].ToString();
                }
                dr.Close();
                conexao.desconectar();           
        }

        private void exibeDadosRepDoAluno(int id)
        {
            lstVaga.Items.Clear();
            try
            {
                conexao conexao = new conexao();
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM REPUBLICA WHERE id_republica in(select republica_id_republica from relacao where status ='ATIVO' and aluno_id_aluno = ?) )", conexao.bdConn);
                cmd.Parameters.AddWithValue("@id_republica", id);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    lstVaga.Items.Add(dr["id_republica"].ToString() + "\t" + dr["NOME_REPUBLICA"].ToString());
                    txtNomeRep.Text = dr["NOME_REPUBLICA"].ToString();
                    txtAlunoResp.Text = dr["NOME_ALUNO"].ToString();
                    txtCapacidade.Text = dr["CAPACIDADE_REPUBLICA"].ToString();
                    txtVagas.Text = dr["VAGAS_REPUBLICA"].ToString();
                    txtTipo.Text = dr["TIPO_REPUBLICA"].ToString();
                    txtAluguel.Text = dr["preco_republica"].ToString();
                    txtDescricao.Text = dr["descricao_republica"].ToString();
                    txtRepublica.Text = dr["id_republica"].ToString();
                }
                dr.Close();
                conexao.desconectar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");

            }

        }

        private void lstVaga_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] campo = lstVaga.Text.Split(Convert.ToChar("\t"));
                exibeDadosRep(Convert.ToInt32(campo[0]));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");

            }
        }

        private void lstAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string[] campo = lstAluno.Text.Split(Convert.ToChar("\t"));

            if (teste == 1)
            {
                //exibeDadosRepDoAluno(Convert.ToInt32( campo[0]));
                txtAluno.Text = campo[0];
                //lstVaga.Enabled = false;
            }
            else
            {
                txtAluno.Text = campo[0];
            }
            
            
        }

        private void btnAssociar_Click(object sender, EventArgs e)
        {
            conexao conexao = new conexao();
            conexao.conectar();
            MySqlCommand cmd;

            try
            {

                cmd = new MySqlCommand("call inseriRelacao(?,?)", conexao.bdConn);
                cmd.Parameters.AddWithValue("@aluno_id_aluno", txtAluno.Text);
                cmd.Parameters.AddWithValue("@republica_id_republica", txtRepublica.Text);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
            }
            finally
            {
                conexao.desconectar();
                inicial();
            }   
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtAluno.Text == "" && txtRepublica.Text == "")
            {

            }
            else
            {
                conexao conexao = new conexao();
                conexao.conectar();
                MySqlCommand cmd;

                try
                {

                    cmd = new MySqlCommand("call desfazRelaçao(?,?)", conexao.bdConn);
                    cmd.Parameters.AddWithValue("@aluno_id_aluno", txtAluno.Text);
                    cmd.Parameters.AddWithValue("@republica_id_republica", txtRepublica.Text);

                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
                }
                finally
                {
                    conexao.desconectar();
                    inicial();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicial();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            btnAssociar.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            teste = 1;

            repTodas(lstVaga);
            AlunosComRep(lstAluno);

        }



        private void txtAluno_TextChanged(object sender, EventArgs e)
        {
            if (txtAluno.Text != "" && txtRepublica.Text != "" && teste == 0)
            {
                btnAssociar.Enabled = true;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {

            }
        }

        private void txtRepublica_TextChanged(object sender, EventArgs e)
        {
            if (txtAluno.Text != "" && txtRepublica.Text != "" && teste == 0)
            {
                btnAssociar.Enabled = true;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {

            }
        }


    }
}
