using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace Relatorio
{
    public partial class cados : Form
    {
        public cados()
        {
            InitializeComponent();
           
        }

        private void cados_Load(object sender, EventArgs e)
        {


        }

        void limparcampos()
        {
            os.Text = "";
            nome.Text ="";
            endereco.Text = "";
            defeito.Text = "";
            data.Text = "";
            telefone.Text = "";
            equipamento.Text = "";
            acessorios.Text = "";
            servico.Text = "";
            valor.Text = "";

        }


        void campos()
        {
            string constring = "Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;";
            string query = "select * from relatorio where os = '" + os.Text + "' ";

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
                    string sDefeito = myReader.GetString("defeito");
                    string sData= myReader.GetString("data");
                    string sTelefone = myReader.GetString("telefone");
                    string sEquipamento = myReader.GetString("equipamento");
                    string sAcessorios = myReader.GetString("acessorios");
                    string sServico= myReader.GetString("servico");
                    string sValor = myReader.GetString("valor");
                    nome.Text = sNome;
                    endereco.Text = sEndereco;
                    defeito.Text = sDefeito;
                    data.Text = sData;
                    telefone.Text = sTelefone;
                    equipamento.Text = sEquipamento;
                    acessorios.Text = sAcessorios;
                    servico.Text = sServico;
                    valor.Text = sValor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void button2_Click(object sender, EventArgs e)
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

            msqlcommand.CommandText = "insert into relatorio(nome, os, endereco, defeito, data, telefone, equipamento, acessorios, servico, valor) values(@nome, @os, @endereco, @defeito, @data, @telefone, @equipamento, @acessorios, @servico, @valor);";

            //Adicionando valores definidos pelo usuario



            msqlcommand.Parameters.AddWithValue("@os", os.Text);

            msqlcommand.Parameters.AddWithValue("@nome", nome.Text);

            msqlcommand.Parameters.AddWithValue("@endereco", endereco.Text);

            msqlcommand.Parameters.AddWithValue("@defeito", defeito.Text);

            msqlcommand.Parameters.AddWithValue("@data", data.Text);

            msqlcommand.Parameters.AddWithValue("@telefone", telefone.Text);

            msqlcommand.Parameters.AddWithValue("@equipamento", equipamento.Text);

            msqlcommand.Parameters.AddWithValue("@acessorios", acessorios.Text);

            msqlcommand.Parameters.AddWithValue("@servico", servico.Text);

            msqlcommand.Parameters.AddWithValue("@valor", Convert.ToDecimal(valor.Text));
            msqlcommand.ExecuteNonQuery();

            //FECHANDO A CONEXÃO

            msqlConnection.Close();
            MessageBox.Show("OK");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void comboBox1OrdemServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KeyChar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                this.campos();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparcampos();
        }

        private void os_TextChanged(object sender, EventArgs e)
        {

        }
     

        
        }

    }
