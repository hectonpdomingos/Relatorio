using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace Relatorio
{
    class conexao
    {
       MySqlConnection msqlConnection = new MySqlConnection("Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;");
        public static MySqlConnection mysqlConnection = null;
        public static MySqlConnection obterConexao()
        {
            mysqlConnection = new MySqlConnection(mysqlConnection.ConnectionString);
            // a conexão foi feita com sucesso?
      try{
        // abre a conexão e a devolve ao chamador do método
        mysqlConnection.Open();
      }
      catch(MySqlException){
        mysqlConnection = null;
        // ops! o que aconteceu?
        // uma boa idéia aqui é gravar a exceção em um arquivo de log
      }

      return mysqlConnection;
    
        }

        public static void fecharConexao()
        {
            if (mysqlConnection != null)
            {
                mysqlConnection.Close();
            }
        }
    }
}