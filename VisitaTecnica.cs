using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Relatorio
{
    public partial class VisitaTecnica : Form
    {
        public VisitaTecnica()
        {
            InitializeComponent();
        }

        private void VisitaTecnica_Load(object sender, EventArgs e)
        {

        }

        // Atualizar dados

        void modificar()
        {
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;");

            //server remoto
           // MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("Server=hectonpdomingos.ddns.net;Port=3306;Database=agenda;Uid=root;password=12domlei;");

            //open the connection

            if (msqlConnection.State != System.Data.ConnectionState.Open)

                msqlConnection.Open();

            //define the command reference


            MySql.Data.MySqlClient.MySqlCommand msqlcommand = new MySql.Data.MySqlClient.MySqlCommand();

            //define the connection used by the command object

            msqlcommand.Connection = msqlConnection;

            //define the command text

            msqlcommand.CommandText = "UPDATE visitatecnica SET nome=@nome, endereco=@endereco, referencia=@referencia, problema=@problema, cidade=@cidade, telefone=@telefone, celular=@celular,  observacao=@observacao, data=@data WHERE nome=@nome;";

            //add values provided by user
      
            msqlcommand.Parameters.AddWithValue("@nome", nome.Text);
            msqlcommand.Parameters.AddWithValue("@endereco", endereco.Text);
            msqlcommand.Parameters.AddWithValue("@referencia", referencia.Text);
            msqlcommand.Parameters.AddWithValue("@cidade", cidade.Text);
            msqlcommand.Parameters.AddWithValue("@data", data.Text);
            msqlcommand.Parameters.AddWithValue("@telefone", telefone.Text);
            msqlcommand.Parameters.AddWithValue("@celular", celular.Text);
            msqlcommand.Parameters.AddWithValue("@problema", problema.Text);
            msqlcommand.Parameters.AddWithValue("@observacao", observacao.Text);
            msqlcommand.ExecuteNonQuery();

            //close the connection

            msqlConnection.Close();

            //empty the text boxes


            MessageBox.Show("Informação Alterada!!");


        }




        // fim do atualizar dados




        //Limpar campos

        void limparcampos()
        {
            nome.Text = "";
            endereco.Text = "";
            data.Text = "";
            telefone.Text = "";
            celular.Text = "";
            observacao.Text = "";
            cidade.Text = "";
            problema.Text = "";
            referencia.Text = "";


        }



        //Funcao de consulta keypress

        void campos()
        {
            string constring = "Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;";
            //server remoto
            //string constring = "Server=hectonpdomingos.ddns.net;Port=3306;Database=agenda;Uid=root;password=12domlei;";
            string query = "select * from visitatecnica where nome = '" + nome.Text + "' ";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string sNome = myReader.GetString("nome");
                    string sEndereco = myReader.GetString("endereco");
                    string sData = myReader.GetString("data");
                    string sTelefone = myReader.GetString("telefone");
                    string sCelular = myReader.GetString("celular");
                    string sObservacao = myReader.GetString("observacao");
                    string sCidade = myReader.GetString("cidade");
                    string sProblema = myReader.GetString("problema");
                    string sReferencia = myReader.GetString("referencia");
                    nome.Text = sNome;
                    endereco.Text = sEndereco;
                    data.Text = sData;
                    telefone.Text = sTelefone;
                    celular.Text = sCelular;
                    observacao.Text = sObservacao;
                    cidade.Text = sCidade;
                    problema.Text = sProblema;
                    referencia.Text = sReferencia;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

 // fim da consulta



        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;");

                //Abrindo a conexão

                if (msqlConnection.State != System.Data.ConnectionState.Open)

                    msqlConnection.Open();

                //definindo a referencia do comando

                MySql.Data.MySqlClient.MySqlCommand msqlcommand = new MySql.Data.MySqlClient.MySqlCommand();

                //Definindo a conexao usada pelo objeto do comando

                msqlcommand.Connection = msqlConnection;

                //definindo o comando texto

                msqlcommand.CommandText = "insert into visitatecnica(nome, endereco, cidade, data, telefone, celular, referencia, observacao, problema) values(@nome, @endereco, @cidade, @data, @telefone, @celular, @referencia, @observacao, @problema);";

                //Adicionando valores definidos pelo usuario


                msqlcommand.Parameters.AddWithValue("@nome", nome.Text);

                msqlcommand.Parameters.AddWithValue("@endereco", endereco.Text);

                msqlcommand.Parameters.AddWithValue("@cidade", cidade.Text);

                msqlcommand.Parameters.AddWithValue("@problema", problema.Text);

                msqlcommand.Parameters.AddWithValue("@data", data.Text);

                msqlcommand.Parameters.AddWithValue("@telefone", telefone.Text);

                msqlcommand.Parameters.AddWithValue("@celular", celular.Text);

                msqlcommand.Parameters.AddWithValue("@referencia", referencia.Text);

                msqlcommand.Parameters.AddWithValue("@observacao", observacao.Text);

                
                msqlcommand.ExecuteNonQuery();

                //FECHANDO A CONEXÃO

                msqlConnection.Close();
                MessageBox.Show("Visita Técnica cadastrada com sucesso!");
            }

        private void KeyChar(object sender, KeyEventArgs e)
        {

        }

        private void KeyChar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                campos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limparcampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modificar();
        }
        }
    }

