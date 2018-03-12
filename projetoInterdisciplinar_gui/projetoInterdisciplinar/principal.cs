using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Globalization;
using System.Xml;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Collections;


namespace projetoInterdisciplinar
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        List<Ponto> pontos = new List<Ponto>();
        List<Republica> republicas = new List<Republica>();

        private int nRep()
        {
            int i=0;

            conexao conexao = new conexao();
            conexao.conectar();
            MySqlCommand cmd = new MySqlCommand("select count(id_republica) from republica", conexao.bdConn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
            if (dr.Read())
            {
                i = Convert.ToInt32( dr[0]);
            }
            conexao.desconectar();
            return i ;
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
        }

        GMarkerGoogle currentMarker;

        private void principal_Load(object sender, EventArgs e)
        {
            Mapa.DragButton = MouseButtons.Right;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = GMapProviders.GoogleMap;
            Mapa.MinZoom = 13;
            Mapa.MaxZoom = 24;
            Mapa.Zoom = 13;
            Mapa.AutoScroll = true;
            //Mapa.Position = new PointLatLng(-22.994077, -47.4930781);
            Mapa.SetPositionByKeywords("Capivari");
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            carregarPontos();

            txtLat.Visible = false;
            txtLng.Visible = false;
        }

        public void CarregaPontoOnibus()
        {
            conexao conexao = new conexao();
            try
             {

            conexao.conectar();
            MySqlCommand cmd = new MySqlCommand("select onibus.numero_onibus, onibus.descricao_onibus,lugar.latitude_lugar, lugar.longitude_lugar, lugar_onibus.horario, lugar_onibus.dia from lugar, lugar_onibus, onibus where lugar_onibus.id_lugar = lugar.id_lugar AND lugar_onibus.numero_onibus = onibus.numero_onibus", conexao.bdConn);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);


            while (dr.Read())
            {

                pontos.Add(new Ponto(Convert.ToInt32(dr[0]), dr[1].ToString(), (dr[2]).ToString(), (dr[3]).ToString(), (dr[4]).ToString(), dr[5].ToString()));

            }

            }
            catch (Exception ex)
            {
             MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
            }
            finally
            {
            conexao.desconectar();
            }
        }

        public void carregaPontosRep()
        {
            conexao conexao = new conexao();
            try
            {

                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("select * from infoRepublica", conexao.bdConn);
                MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
            
                while (dr.Read())
                {


                    republicas.Add(new Republica(Convert.ToInt32(dr[0]), dr[1].ToString(), (dr[2]).ToString(), (dr[3]).ToString(), Convert.ToInt32(dr[4]), dr[5].ToString(), dr[6].ToString()));


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
            }

            finally
            {
                conexao.desconectar();
            }

        }

        public void carregarPontos()
        {
            carregaPontosRep();
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            
                int n = republicas.Count();
                int i = 0;
            

                GMarkerGoogle[] marcadoresRep = new GMarkerGoogle[n]; 

                while (i < n)
                {
                    txtLat.Text = republicas[i].Latitude;
                    txtLng.Text = republicas[i].Longitude;

                    double latitude = Convert.ToDouble(txtLat.Text.Replace(".", "."));
                    double longitude = Convert.ToDouble(txtLng.Text.Replace(".", "."));

                MessageBox.Show(latitude.ToString()+ "\n" +longitude.ToString());

                if (republicas[i].Tipo == "Masculina")
                    {
                        marcadoresRep[i] = new GMarkerGoogle(new PointLatLng(longitude, latitude), new Bitmap("C:\\Users\\Antonio\\Desktop\\projetoInterdisciplinar_gui\\projetoInterdisciplinar\\icons\\Republica-Masculina.png"));
                       
                    }

                    if (republicas[i].Tipo == "Feminina")
                    {
                        marcadoresRep[i] = new GMarkerGoogle(new PointLatLng(latitude, longitude), new Bitmap("C:\\Users\\Antonio\\Desktop\\projetoInterdisciplinar_gui\\projetoInterdisciplinar\\icons\\Republica-Feminina.png"));
                       
                    }

                    if (republicas[i].Tipo == "Mista")
                    {
                        marcadoresRep[i] = new GMarkerGoogle(new PointLatLng(latitude, longitude), new Bitmap("C:\\Users\\Antonio\\Desktop\\projetoInterdisciplinar_gui\\projetoInterdisciplinar\\icons\\Republica-Mista.png"));
                        
                    }

                markersOverlay.Markers.Add(marcadoresRep[i]);
                marcadoresRep[i].ToolTipText = ("--REPÚBLICA--\n"+republicas[i].Nome + " \n\nVagas Disponíveis: " + republicas[i].Vagas + "\nTipo: " + republicas[i].Tipo + "\n\nAluno Responsável: " + republicas[i].AlunoResponsavel);
                Mapa.Overlays.Add(markersOverlay);
                i++;
            }


            CarregaPontoOnibus();

            int c = pontos.Count();
            int g = 0;
            
            GMarkerGoogle[] marcadoresPnt = new GMarkerGoogle[c];


            while ( g < c)
            {
                txtLat.Text = pontos[g].Latitude;
                txtLng.Text = pontos[g].Longitude;

                double latitude = Convert.ToDouble(txtLat.Text.Replace(".", "."));
                double longitude = Convert.ToDouble(txtLng.Text.Replace(".", "."));
    
                if(pontos[g].Turno == "M - T - N")
                {
                    marcadoresPnt[g] = new GMarkerGoogle(new PointLatLng(latitude, longitude), new Bitmap("C:\\Users\\Antonio\\Desktop\\projetoInterdisciplinar_gui\\projetoInterdisciplinar\\icons\\bus-M-T-N.png"));
                    
                }

                if (pontos[g].Turno == "T")
                {
                    marcadoresPnt[g] = new GMarkerGoogle(new PointLatLng(latitude, longitude), new Bitmap("C:\\Users\\Antonio\\Desktop\\projetoInterdisciplinar_gui\\projetoInterdisciplinar\\icons\\bus-Tarde.png"));
                    
                }

                if(pontos[g].Turno == "M - N")
                {
                    marcadoresPnt[g] = new GMarkerGoogle(new PointLatLng(latitude, longitude), new Bitmap("C:\\Users\\Antonio\\Desktop\\projetoInterdisciplinar_gui\\projetoInterdisciplinar\\icons\\bus-M-N.png"));
                    
                }

                markersOverlay.Markers.Add(marcadoresPnt[g]);
                Mapa.Overlays.Add(markersOverlay);
                marcadoresPnt[g].ToolTip = new GMapRoundedToolTip(marcadoresPnt[g]);
                marcadoresPnt[g].ToolTipText = ("--Ponto de Onibus--\n" + pontos[g].DescricaoOnibus + "\n\nNúmero Onibus: " + pontos[g].NumeroOnibus + "\nTurno: " + pontos[g].Turno + "\nHorário: " + pontos[g].Horario);
                g++;
                
            } 
          


        }

        private void escolherVagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssociar asocia = new frmAssociar();
            asocia.ShowDialog();
        }

        private void escolherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssociar aso = new frmAssociar();
            aso.ShowDialog();
        }
    }
}
