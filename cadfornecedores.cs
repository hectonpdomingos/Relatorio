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
    public partial class cadfornecedores : Form
    {
        public cadfornecedores()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        void limparcampos()
        {

            cnpj.Text = "";
            razaosocial.Text = "";
            nomefantasia.Text = "";
            inscricaoestadual.Text = "";
            inscricaomunicipal.Text = "";
            endereco.Text = "";
            complemento.Text = "";
            cep.Text = "";
            bairro.Text = "";
            cidade.Text = "";
            uf.Text = "";
            telefone.Text = "";
            ddd.Text = "";
            data.Text = "";

        }

        void modificar()
        {

            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;");

            //open the connection

            if (msqlConnection.State != System.Data.ConnectionState.Open)

                msqlConnection.Open();

            //define the command reference


            MySql.Data.MySqlClient.MySqlCommand msqlcommand = new MySql.Data.MySqlClient.MySqlCommand();

            //define the connection used by the command object

            msqlcommand.Connection = msqlConnection;

            //define the command text

            msqlcommand.CommandText = "UPDATE cadfornecedor SET razaosocial=@razaosocial, nomefantasia=@nomefantasia, inscricaoestadual=@inscricaoestadual, inscricaomunicipal=@inscricaomunicipal, endereco=@endereco, complemento=@complemento, cep=@cep,  bairro=@bairro, cidade=@cidade, uf=@uf, telefone=@telefone, ddd=@ddd, data=@data WHERE cnpj=@cnpj;";

            //add values provided by user
            msqlcommand.Parameters.AddWithValue("@cnpj", cnpj.Text);
            msqlcommand.Parameters.AddWithValue("@razaosocial", razaosocial.Text);
            msqlcommand.Parameters.AddWithValue("@nomefantasia", nomefantasia.Text);
            msqlcommand.Parameters.AddWithValue("@inscricaoestadual", inscricaoestadual.Text);
            msqlcommand.Parameters.AddWithValue("@inscricaomunicipal", inscricaomunicipal.Text);
            msqlcommand.Parameters.AddWithValue("@endereco", endereco.Text);
            msqlcommand.Parameters.AddWithValue("@complemento", complemento.Text);
            msqlcommand.Parameters.AddWithValue("@cep", cep.Text);
            msqlcommand.Parameters.AddWithValue("@bairro", bairro.Text);
            msqlcommand.Parameters.AddWithValue("@cidade", cidade.Text);
            msqlcommand.Parameters.AddWithValue("@uf", uf.Text);
            msqlcommand.Parameters.AddWithValue("@telefone", telefone.Text);
            msqlcommand.Parameters.AddWithValue("@ddd", ddd.Text);
            msqlcommand.Parameters.AddWithValue("@data", data.Text);
            msqlcommand.ExecuteNonQuery();

            //close the connection

            msqlConnection.Close();

            //empty the text boxes


            MessageBox.Show("Informação Alterada!!");


        }


        void campos()
        {
            string constring = "Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;";
            string query = "select * from cadfornecedor where cnpj = '" + cnpj.Text + "' ";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string SRazaosocial = myReader.GetString("razaosocial");
                    string SNomefantasia = myReader.GetString("nomefantasia");
                    string SInscricaoestadual = myReader.GetString("inscricaoestadual");
                    string SInscricaomunicipal = myReader.GetString("inscricaomunicipal");
                    string SEndereco = myReader.GetString("endereco");
                    string SComplemento = myReader.GetString("complemento");
                    string SCep = myReader.GetString("cep");
                    string SBairro = myReader.GetString("bairro");
                    string SCidade = myReader.GetString("cidade");
                    string SUf = myReader.GetString("uf");
                    string STelefone = myReader.GetString("telefone");
                    string SDdd = myReader.GetString("ddd");
                    string SData = myReader.GetString("data");
                                      
                    razaosocial.Text = SRazaosocial;
                    nomefantasia.Text = SNomefantasia;
                    inscricaoestadual.Text = SInscricaoestadual;
                    inscricaomunicipal.Text = SInscricaomunicipal;
                    endereco.Text = SEndereco;
                    complemento.Text = SComplemento;
                    cep.Text = SCep;
                    bairro.Text = SBairro;
                    cidade.Text = SCidade;
                    uf.Text = SUf;
                    telefone.Text = STelefone;
                    ddd.Text = SDdd;
                    data.Text = SData;




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }






        private void cadfornecedores_Load(object sender, EventArgs e)
        {
            //PREENCHENDO O COMBOBOXUF unidade federativa
            uf.Items.Add("AC");
            uf.Items.Add("AL");
            uf.Items.Add("AP");
            uf.Items.Add("AM");
            uf.Items.Add("BA");
            uf.Items.Add("CE");
            uf.Items.Add("DF");
            uf.Items.Add("ES");
            uf.Items.Add("GO");
            uf.Items.Add("MA");
            uf.Items.Add("MT");
            uf.Items.Add("MS");
            uf.Items.Add("MG");
            uf.Items.Add("PA");
            uf.Items.Add("PB");
            uf.Items.Add("PR");
            uf.Items.Add("PE");
            uf.Items.Add("PI");
            uf.Items.Add("RJ");
            uf.Items.Add("RN");
            uf.Items.Add("RS");
            uf.Items.Add("RO");
            uf.Items.Add("RR");
            uf.Items.Add("SC");
            uf.Items.Add("SP");
            uf.Items.Add("SE");
            uf.Items.Add("TO");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

 msqlcommand.CommandText = "insert into cadfornecedor(cnpj, razaosocial, nomefantasia, inscricaoestadual, inscricaomunicipal, endereco, complemento, cep, bairro, cidade, uf, telefone, ddd, data) values(@cnpj, @razaosocial, @nomefantasia, @inscricaoestadual, @inscricaomunicipal, @endereco, @complemento, @cep, @bairro, @cidade, @uf, @telefone, @ddd, @data);";
            //Adicionando valores definidos pelo usuario

            msqlcommand.Parameters.AddWithValue("@cnpj", cnpj.Text);
            msqlcommand.Parameters.AddWithValue("@razaosocial", razaosocial.Text);
            msqlcommand.Parameters.AddWithValue("@nomefantasia", nomefantasia.Text);
            msqlcommand.Parameters.AddWithValue("@inscricaoestadual", inscricaoestadual.Text);
            msqlcommand.Parameters.AddWithValue("@inscricaomunicipal", inscricaomunicipal.Text);
            msqlcommand.Parameters.AddWithValue("@endereco", endereco.Text);
            msqlcommand.Parameters.AddWithValue("@complemento", complemento.Text);
            msqlcommand.Parameters.AddWithValue("@cep", cep.Text);
            msqlcommand.Parameters.AddWithValue("@bairro", bairro.Text);
            msqlcommand.Parameters.AddWithValue("@cidade", cidade.Text);
            msqlcommand.Parameters.AddWithValue("@uf", uf.Text);
            msqlcommand.Parameters.AddWithValue("@telefone", telefone.Text);
            msqlcommand.Parameters.AddWithValue("@ddd", ddd.Text);
            msqlcommand.Parameters.AddWithValue("@data", data.Text);
            msqlcommand.ExecuteNonQuery();

            //FECHANDO A CONEXÃO

            msqlConnection.Close();
            MessageBox.Show("OK");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modcadempresa modificarcadastroempresa = new  modcadempresa();
            modificarcadastroempresa.Show();
        }

       

        private void cnpj_TextChanged_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cnpj_TextChanged(object sender, KeyPressEventArgs e)
        {
            
        }
          private void KeyChar(object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == 13)
            {

                this.campos();

            }
        }

          private void button3_Click(object sender, EventArgs e)
          {
              limparcampos();
          }

          private void button4_Click(object sender, EventArgs e)
          {
              modificar();
          }
        }
    }