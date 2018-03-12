using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace projetoInterdisciplinar
{
    class conexao
    {

        public MySqlConnection bdConn = new MySqlConnection(" Persist Security Info=False;server=localhost;database=semteto;uid=root;server = localhost; database = semteto; uid = root; pwd = leo97cris10"); //MySQL 
        public void conectar()
        {
            bdConn.Open();      
        }
        public void desconectar()
        {
            bdConn.Close();
        }
        
    }
}
