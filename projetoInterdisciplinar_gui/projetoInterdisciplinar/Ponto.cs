using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetoInterdisciplinar
{
    class Ponto
    {
        private int numeroOnibus;
        private string lat;
        private string lng;
        private string horario;
        private string turno;
        private string descricao;

        public Ponto(int numeroOnibus, string descricao,string lat, string lng, string horario, string turno)
        {
            this.numeroOnibus = numeroOnibus;
            this.lat = lat;
            this.lng = lng;
            this.horario = horario;
            this.turno = turno;
            this.descricao = descricao;
        }

        public string DescricaoOnibus
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int NumeroOnibus
        {
            get { return numeroOnibus; }
            set { numeroOnibus = value; }
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

        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
    }
}
