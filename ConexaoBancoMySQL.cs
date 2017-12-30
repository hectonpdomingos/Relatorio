using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace Relatorio
{
    class ConexaoBancoMySQL
    {
        private static MySqlConnection objConexao = null;

        // string mysql acessa o banco do servidor de hospedagem
        private String stringconnection1 = MySqlConnection msqlConnection = new MySqlConnection("Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;");
        public static MySqlConnection mysqlConnection = null;
        //string mysql rodando na maquina do desenvolvedor.
        private String stringconnection2 = ("Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=;");

             public void tentarAbrirConexaoLocal()
        {
            objConexao = new MySqlConnection();
            objConexao.ConnectionString = stringconnection1;
            objConexao.Open();
        }

        public void tentarAbrirConexaoRemota()
        {
            objConexao = new MySqlConnection();
            objConexao.ConnectionString = stringconnection2;
            objConexao.Open();
        }

        public ConexaoBancoMySQL()
        {
            try
            {
                tentarAbrirConexaoRemota();
            }
            catch
            {
                try
                {
                    tentarAbrirConexaoLocal();
                }
                catch
                {

                   
                }
            }

        }

        public static MySqlConnection getConexao()
        {
            new ConexaoBancoMySQL();
            return objConexao;
        }
        public static void fecharConexao()
        {
            objConexao.Close();
        }
    }
}