using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace projetoInterdisciplinar
{
    public partial class frmCadRepublica : Form
    {
        public frmCadRepublica()
        {
            InitializeComponent();
        }

        int operacao = 0;
        public int idRep = 0;
        string lat, lng;
        int idLugar = 0;

        private void inicial()
        {
            gbxDados.Enabled = false;
            gbxRepublica.Enabled = true;
            btnAdicionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;

            gbxMapa.Visible = false;
            gbxMapa.Enabled = false;

            txtIdLugar.Visible = false;
            txtId.Text = "";
            txtNome.Text = "";
            txtAlunoResponsavel.Text = "";
            txtTipo.Text = "";
            txtUf.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtCapacidade.Text = "";
            txtVagas.Text = "";
            txtDescricao.Text = "";
            txtaluguel.Text = "";
        }

        

        private void frmCadRepublica_Load(object sender, EventArgs e)
        {
            inicial();
            carregaListBox(lstRepublica);
            carregaComboBox();


            txtNome.MaxLength = 40;
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtUf.CharacterCasing = CharacterCasing.Upper;
            txtUf.MaxLength = 2;
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.MaxLength = 20;
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.MaxLength = 20;
            txtRua.CharacterCasing = CharacterCasing.Upper;
            txtRua.MaxLength = 40;
            txtComplemento.CharacterCasing = CharacterCasing.Upper;
            txtComplemento.MaxLength = 30;
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
            txtDescricao.MaxLength = 200;


        }

        private void id()
        {
            conexao conexao = new conexao();
            conexao.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT max(id_republica)+1 FROM republica", conexao.bdConn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
            if (dr.Read())
            {
                txtId.Text = dr[0].ToString();

            }
        }

        private void numero(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void carregaComboBox()
        {
            txtAlunoResponsavel.Items.Clear();

            conexao conexao = new conexao();
            MySqlCommand cmd;
            try
            {

                conexao.conectar();
                cmd = new MySqlCommand("SELECT  * FROM aluno WHERE status_aluno=0 ", conexao.bdConn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                string texto;
                while (dr.Read())
                {
                    texto = dr["nome_aluno"].ToString();
                    texto = texto + "\t" + dr["id_aluno"].ToString();
                    txtAlunoResponsavel.Items.Add(texto);
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

        public void carregaListBox(ListBox lst)
        {
            
            lst.Items.Clear();
            idRep = 0;
            conexao conexao = new conexao();
            MySqlCommand cmd;
            try
            {

                conexao.conectar();
                cmd = new MySqlCommand("select * from republica where status_republica = 1 ", conexao.bdConn);
                
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                string texto;
                while (dr.Read())
                {
                    texto = dr["id_republica"].ToString();
                    texto = texto + "\t" + dr["nome_republica"].ToString();
                    texto = texto + "\t" + dr["alunoResponsavel_republica"].ToString();
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

        private void exibeDados(int id, string nome)
        {
            conexao conexao = new conexao();
            conexao.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM REPUBLICA WHERE id_republica=? AND nome_republica=?", conexao.bdConn);
            cmd.Parameters.AddWithValue("@id_republica", id);
            cmd.Parameters.AddWithValue("@nome_republica", nome);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (dr.Read())
            {
                txtId.Text = dr["id_republica"].ToString();
                txtAlunoResponsavel.Text = dr["alunoResponsavel_republica"].ToString();
                txtNome.Text = dr["nome_republica"].ToString();
                txtUf.Text = dr["uf_republica"].ToString();
                txtRua.Text = dr["rua_republica"].ToString();
                txtTipo.Text = dr["tipo_republica"].ToString();
                txtBairro.Text = dr["bairro_republica"].ToString();
                txtCidade.Text = dr["cidade_republica"].ToString();
                txtNumero.Text = dr["numero_republica"].ToString();
                txtComplemento.Text = dr["complemento_republica"].ToString();
                txtCapacidade.Text = dr["capacidade_republica"].ToString();
                txtVagas.Text = dr["vagas_republica"].ToString();
                txtDescricao.Text = dr["descricao_republica"].ToString();
                txtaluguel.Text = dr["preco_republica"].ToString();
                txtIdLugar.Text = dr["lugar_id_lugar"].ToString();
            }

            dr.Close();
            conexao.desconectar();

        }


        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] campo = lstRepublica.Text.Split(Convert.ToChar("\t"));
                exibeDados(Convert.ToInt32(campo[0]), campo[1]);

            }catch(Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
            }

            gbxDados.Enabled = false;

            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            operacao = 1;
            txtVagas.Text = "";
            txtId.Enabled = false;
            txtId.Text = (idRep+1).ToString();
            txtVagas.Enabled = false;
            gbxDados.Enabled = true;
            gbxRepublica.Enabled = false;
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            id();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = 2;

            txtUf.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            txtRua.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;

            btnAddLocation.Enabled = false;
            txtVagas.Enabled = false;
            gbxDados.Enabled = true;
            gbxRepublica.Enabled = false;
            btnAdicionar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            txtId.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult iResposta = MessageBox.Show("Deseja excluir esta Republica?", "Confirma Exclusao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iResposta.ToString() == "Yes")
            {
                conexao conexao = new conexao();
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("call deletarRepublica(?);", conexao.bdConn);
                cmd.Parameters.AddWithValue("@id_republica", txtId.Text);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                conexao.desconectar();

                carregaListBox(lstRepublica);

                inicial();

            }
            else
            {
                carregaListBox(lstRepublica);

                inicial();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conexao conexao = new conexao();
            conexao.conectar();
            MySqlCommand cmd;


            if (operacao == 1)
            {

                {
                    try
                    {

                            string[] campo = txtAlunoResponsavel.Text.Split(Convert.ToChar("\t"));
                            cmd = new MySqlCommand("call criaRep(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", conexao.bdConn);
                            cmd.Parameters.AddWithValue("@lat", lat);
                            cmd.Parameters.AddWithValue("@lon", lng);
                                if (txtId.Text != "")
                                {
                                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                                 }
                                 else
                                 {
                                     cmd.Parameters.AddWithValue("@id",0);
                                 }
                        
                            cmd.Parameters.AddWithValue("@al", campo[0].ToString());
                            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@uf", txtUf.Text);
                            cmd.Parameters.AddWithValue("@rua", txtRua.Text);
                            cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                            cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                            cmd.Parameters.AddWithValue("@compl", txtComplemento.Text);
                            cmd.Parameters.AddWithValue("@cap", txtCapacidade.Text);
                            cmd.Parameters.AddWithValue("@descrb", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("@preco", txtaluguel.Text);                           
                            cmd.Parameters.AddWithValue("@idlu", Convert.ToInt32( campo[1]));
                            cmd.ExecuteReader(CommandBehavior.SingleRow);

                            DialogResult iResposta;
                            iResposta = MessageBox.Show("Deseja Continuar a Incluir?", "Confirma Nova Inclusao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (iResposta.ToString() == "Yes")
                            {
                                txtId.Text = "";
                                txtNome.Text = "";
                                txtAlunoResponsavel.Text = "";
                                txtTipo.Text = "";
                                txtUf.Text = "";
                                txtCidade.Text = "";
                                txtBairro.Text = "";
                                txtRua.Text = "";
                                txtNumero.Text = "";
                                txtComplemento.Text = "";
                                txtCapacidade.Text = "";
                                txtVagas.Text = "";
                                txtDescricao.Text = "";
                                txtaluguel.Text = "";

                                operacao = 1;
                                gbxDados.Enabled = true;
                                gbxRepublica.Enabled = false;
                                btnAdicionar.Enabled = false;
                                btnCancelar.Enabled = true;
                                btnEditar.Enabled = false;
                                btnExcluir.Enabled = false;
                                btnSalvar.Enabled = true;
                                carregaListBox(lstRepublica);
                            }
                            else
                            {
                                inicial();
                            carregaListBox(lstRepublica);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else if (operacao == 2)
            {
                try
                {
                    cmd = new MySqlCommand("UPDATE (republica) SET   alunoResponsavel_republica=?, nome_republica=?, uf_republica=?, rua_republica=?, tipo_republica=?, bairro_republica=?, cidade_republica=?, numero_republica=?, complemento_republica=?, capacidade_republica=?, vagas_republica=?, descricao_republica=?,preco_republica=? WHERE id_republica=?", conexao.bdConn);

                    cmd.Parameters.AddWithValue("@alunoResponsavel_republica", txtAlunoResponsavel.Text);
                    cmd.Parameters.AddWithValue("@nome_republica", txtNome.Text);
                    cmd.Parameters.AddWithValue("@uf_republica", txtUf.Text);
                    cmd.Parameters.AddWithValue("@rua_republica", txtRua.Text);
                    cmd.Parameters.AddWithValue("@tipo_republica", txtTipo.Text);
                    cmd.Parameters.AddWithValue("@bairro_republica", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@cidade_republica", txtId.Text);
                    cmd.Parameters.AddWithValue("@numero_republica", txtNome.Text);
                    cmd.Parameters.AddWithValue("@complemento_republica", txtComplemento.Text);
                    cmd.Parameters.AddWithValue("@capacidade_republica", txtCapacidade.Text);
                    cmd.Parameters.AddWithValue("@vagas_republica", txtVagas.Text);
                    cmd.Parameters.AddWithValue("@descricao_republica", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@preco_republica", txtDescricao.Text);

                    cmd.Parameters.AddWithValue("@id_republica", txtId.Text);

                    cmd.ExecuteReader(CommandBehavior.SingleRow);

                    inicial();
                    carregaListBox(lstRepublica);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
                    //MessageBox.Show(ex.ToString());
                }

            }
                    inicial();
        }
            

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicial();
        }

        public static void buscaListBoxAluno(ListBox lst, string busca)
        {
            lst.Items.Clear();
            conexao conexao = new conexao();
            try
            {
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("SELECT id_republica,nome_republica,alunoResponsavel_republica FROM republica WHERE alunoResponsavel_republica LIKE ? ", conexao.bdConn);
                cmd.Parameters.AddWithValue("@alunoResponsavel_republica", busca + "%");
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

        public static void buscaListBoxRep(ListBox lst, string busca)
        {
            lst.Items.Clear();
            conexao conexao = new conexao();
            try
            {
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("SELECT id_republica,nome_republica,alunoResponsavel_republica FROM republica WHERE nome_republica LIKE ? ", conexao.bdConn);
                cmd.Parameters.AddWithValue("@nome_republica", busca + "%");
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

        private void txtAlunoBusca_TextChanged(object sender, EventArgs e)
        {
            string texto;
            if (txtAlunoBusca.Text == "")
            {
                carregaListBox(lstRepublica);
            }
            else
            {
                texto = txtAlunoBusca.Text;
                buscaListBoxAluno(lstRepublica, texto);
            }
        }

        private void txtRepublicaBusca_TextChanged(object sender, EventArgs e)
        {
            string texto;
            if (txtRepublicaBusca.Text == "")
            {
                carregaListBox(lstRepublica);
            }
            else
            {
                texto = txtRepublicaBusca.Text;
                buscaListBoxRep(lstRepublica, texto);
            }
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            
            if (txtRua.Text == "" && txtNumero.Text =="" && txtCidade.Text=="" )
            {
                MessageBox.Show("preencher cidade e/ou numero e/ou rua", "campos vazio");
            }
            else
            {

                try
                {
                    gbxMapa.Visible = true;
                    gbxMapa.Enabled = true;
                    gbxMapa.BringToFront();

                    Mapa2.DragButton = MouseButtons.Left;
                    Mapa2.CanDragMap = true;
                    Mapa2.MapProvider = GMapProviders.GoogleMap;               
                    Mapa2.MinZoom = 13;
                    Mapa2.MaxZoom = 24;
                    Mapa2.Zoom = 17;
                    Mapa2.AutoScroll = true;
                    //Mapa2.SetPositionByKeywords("Rua Lino Marino Petena 270, Capivari");
                    Mapa2.SetPositionByKeywords(txtRua.Text + " " + txtNumero.Text + ", " + txtCidade.Text);


                    GMapOverlay markersOverlay = new GMapOverlay("markers");
                    GMarkerGoogle currentMarker = new GMarkerGoogle(Mapa2.Position, GMarkerGoogleType.red_dot);
                    markersOverlay.Markers.Add(currentMarker);
                    Mapa2.Overlays.Add(markersOverlay);

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
                }
                

            }

        }


        private void btnConfirma_Click(object sender, EventArgs e)
        {
            gbxMapa.Visible = false;
            gbxMapa.Enabled = false;
            gbxMapa.SendToBack();


            lat = Mapa2.Position.Lat.ToString();
            lng = Mapa2.Position.Lng.ToString();


            //Mapa2.Refresh();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {        

            List<Placemark> plc = null;
            var st = GMapProviders.GoogleMap.GetPlacemarks(Mapa2.Position, out plc);

            if (st == GeoCoderStatusCode.G_GEO_SUCCESS && plc != null)
            {
                foreach (var pl in plc)
                {
                    if (!string.IsNullOrEmpty(pl.PostalCodeNumber))
                    {
                        MessageBox.Show(pl.Address + ", PostalCodeNumber: " + pl.PostalCodeNumber);
                    }
                  
                }

                DialogResult res = MessageBox.Show("Informações estão corretas do ponto?", "Confirma!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.No)
                {
                    MessageBox.Show("Confira informações do formulário", "Check!");
                    gbxMapa.Visible = false;
                    gbxMapa.Enabled = false;
                    gbxMapa.SendToBack();
                    
                }
                else
                {
                    lat = Mapa2.Position.Lat.ToString();
                    lng = Mapa2.Position.Lng.ToString();
                }
            }
       
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            Mapa2.DragButton = MouseButtons.Left;
            Mapa2.CanDragMap = true;
            Mapa2.MapProvider = GMapProviders.GoogleMap;
          
        }

        private void txtAlunoResponsavel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }

    
}
