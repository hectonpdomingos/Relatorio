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
    public partial class cadcliente : Form
    {
        public cadcliente()
        {
            InitializeComponent();
        }

        // COMEÇO DA MODIIFCAÇÃO

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

            msqlcommand.CommandText = "UPDATE cliente SET nome=@nome, endereco=@endereco, referencia=@referencia, cidade=@cidade, uf=@comboBoxUF, telefone=@telefone, celular=@celular,  email=@email, data=@dateTimePicker1 WHERE cpf=@cpf;";

            //add values provided by user
            msqlcommand.Parameters.AddWithValue("@cpf", cpf.Text);
            msqlcommand.Parameters.AddWithValue("@nome", nome.Text);
            msqlcommand.Parameters.AddWithValue("@endereco", endereco.Text);
            msqlcommand.Parameters.AddWithValue("@referencia", referencia.Text);
            msqlcommand.Parameters.AddWithValue("@cidade", cidade.Text);
            msqlcommand.Parameters.AddWithValue("@comboBoxUF", comboBoxUF.Text); 
            msqlcommand.Parameters.AddWithValue("@telefone", telefone.Text);
            msqlcommand.Parameters.AddWithValue("@celular", celular.Text);
            msqlcommand.Parameters.AddWithValue("@email", email.Text);
            msqlcommand.Parameters.AddWithValue("@dateTimePicker1", dateTimePicker1.Text);
            msqlcommand.ExecuteNonQuery();

            //close the connection

            msqlConnection.Close();

            //empty the text boxes


            MessageBox.Show("Informação Alterada!!");


        }


//  FIM DA MODIFICAÇÃO 

        
        void limpar()
        {
            cpf.Text = "";
            nome.Text = "";
            endereco.Text = "";
            dateTimePicker1.Text = "";
            telefone.Text = "";
            celular.Text = "";
            comboBoxUF.Text = "";
            referencia.Text = "";
            email.Text = "";
            cidade.Text = "";
        }

        void campos()
        {
            string constring = "Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;";
            string query = "select * from cliente where cpf = '" + cpf.Text + "' ";

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
                    string sUf = myReader.GetString("uf");
                    string sReferencia = myReader.GetString("referencia");
                    string sEmail = myReader.GetString("email");
                    string sCidade = myReader.GetString("cidade");
                    nome.Text = sNome;
                    endereco.Text = sEndereco;
                    dateTimePicker1.Text = sData;
                    telefone.Text = sTelefone;
                    celular.Text = sCelular;
                    comboBoxUF.Text = sUf;
                    referencia.Text = sReferencia;
                    email.Text = sEmail;
                    cidade.Text = sCidade;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }




        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadcliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaDataSetcadcliente.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.agendaDataSetcadcliente.cliente);

     



            //PREENCHENDO O COMBOBOXUF unidade federativa
            comboBoxUF.Items.Add("AC");
            comboBoxUF.Items.Add("AL");
            comboBoxUF.Items.Add("AP");
            comboBoxUF.Items.Add("AM");
            comboBoxUF.Items.Add("BA");
            comboBoxUF.Items.Add("CE");
            comboBoxUF.Items.Add("DF");
            comboBoxUF.Items.Add("ES");
            comboBoxUF.Items.Add("GO");
            comboBoxUF.Items.Add("MA");
            comboBoxUF.Items.Add("MT");
            comboBoxUF.Items.Add("MS");
            comboBoxUF.Items.Add("MG");
            comboBoxUF.Items.Add("PA");
            comboBoxUF.Items.Add("PB");
            comboBoxUF.Items.Add("PR");
            comboBoxUF.Items.Add("PE");
            comboBoxUF.Items.Add("PI");
            comboBoxUF.Items.Add("RJ");
            comboBoxUF.Items.Add("RN");
            comboBoxUF.Items.Add("RS");
            comboBoxUF.Items.Add("RO");
            comboBoxUF.Items.Add("RR");
            comboBoxUF.Items.Add("SC");
            comboBoxUF.Items.Add("SP");
            comboBoxUF.Items.Add("SE");
            comboBoxUF.Items.Add("TO");
            this.reportViewer1.RefreshReport();
        }

        private void buttoncadcliente_Click(object sender, EventArgs e)
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

            msqlcommand.CommandText = "insert into cliente(nome, endereco,  referencia, cidade, uf, cpf, telefone, celular, data) values(@nome, @endereco, @referencia, @cidade, @uf, @cpf, @telefone, @celular, @data);";

            //Adicionando valores definidos pelo usuario


            msqlcommand.Parameters.AddWithValue("@nome", nome.Text);
            msqlcommand.Parameters.AddWithValue("@endereco", endereco.Text);
            msqlcommand.Parameters.AddWithValue("@referencia", referencia.Text);
            msqlcommand.Parameters.AddWithValue("@cidade", cidade.Text);
            msqlcommand.Parameters.AddWithValue("@uf", comboBoxUF.Text);
            msqlcommand.Parameters.AddWithValue("@cpf", cpf.Text);
            msqlcommand.Parameters.AddWithValue("@telefone", telefone.Text);
            msqlcommand.Parameters.AddWithValue("@celular", celular.Text);
            msqlcommand.Parameters.AddWithValue("@data", dateTimePicker1.Text);

            msqlcommand.ExecuteNonQuery();

            //FECHANDO A CONEXÃO

            msqlConnection.Close();
        }

        private void comboBoxUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void buttonexcluircliente_Click(object sender, EventArgs e)
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

            msqlcommand.CommandText = "DELETE from cliente where idcliente=@idclienteeexcluir;";

            //add values provided by user

            msqlcommand.Parameters.AddWithValue("@idclienteeexcluir", idclienteeexcluir.Text);
            msqlcommand.ExecuteNonQuery();

            //close the connection

            msqlConnection.Close();

            //empty the text boxes

        
            MessageBox.Show("Informação Alterada!");
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void keyChar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                campos();
            }
                
        }

    }
}
