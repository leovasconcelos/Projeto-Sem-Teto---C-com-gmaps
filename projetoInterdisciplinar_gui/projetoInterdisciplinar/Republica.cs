using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetoInterdisciplinar
{
    class Republica
    {
        private string nome;
        private string lat;
        private string lng;
        private int vagas;
        private string tipo;
        private int id;
        private string aluno;

        public Republica(int id, string nome, string lat, string lng, int vagas, string tipo, string aluno)
        {
            this.id = id;
            this.nome = nome;
            this.lat = lat;
            this.lng = lng;
            this.vagas = vagas;
            this.tipo = tipo;
            this.aluno = aluno;
        }



        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Latitude
        {
            get { return lat; }
            set { lat = value; }
        }

        public string Longitude
        {
            get { return lng; }
            set { lng = value; }
        }

        public int Vagas
        {
            get { return vagas; }
            set { vagas = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string AlunoResponsavel
        {
            get { return aluno; }
            set { aluno = value; }
        }
    }
}
