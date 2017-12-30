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
    ////public class modificar:
    
    ////{

    ////}

    

    public partial class modcadempresa : Form
    {
        public modcadempresa()
        {
            InitializeComponent();
        }

        private void modcadempresa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaDataSetcadfornecedor.cadfornecedor' table. You can move, or remove it, as needed.
            this.cadfornecedorTableAdapter.Fill(this.agendaDataSetcadfornecedor.cadfornecedor);

            this.reportViewer1.RefreshReport();

            //combobox campo para edicção de cadastro de cliente
            comboBoxCampo.Items.Add("cnpj");
            comboBoxCampo.Items.Add("razaosocial");
            comboBoxCampo.Items.Add("nomefantasia");
            comboBoxCampo.Items.Add("inscricaoestadual");
            comboBoxCampo.Items.Add("inscricaomunicipal");
            comboBoxCampo.Items.Add("endereco");
            comboBoxCampo.Items.Add("complemento");
            comboBoxCampo.Items.Add("cep");
            comboBoxCampo.Items.Add("bairro");
            comboBoxCampo.Items.Add("cidade");
            comboBoxCampo.Items.Add("uf");
            comboBoxCampo.Items.Add("telefone");
            comboBoxCampo.Items.Add("ddd");
           // comboBoxCampo.Items.Add("data");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // ALTERANDO O CAMPO CNPJ DO DB DA TABELA IDCADFORNECEDOR
            if (comboBoxCampo.Text == "cnpj")
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

                                msqlcommand.CommandText = "UPDATE cadfornecedor SET cnpj=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                                //add values provided by user

                                msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                                msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                                msqlcommand.ExecuteNonQuery();

                                //close the connection

                                msqlConnection.Close();

                                //empty the text boxes

                                alteracao.Text = null;

                                idcadfornecedor.Text = null;

                                MessageBox.Show("Informação Alterada!!");



            }

            // SEGUNDA OPÇÃO DO COMBOBOXCAMPO

            if (comboBoxCampo.Text == "razaosocial")
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

                msqlcommand.CommandText = "UPDATE cadfornecedor SET razaosocial=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                //add values provided by user

                msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                msqlcommand.ExecuteNonQuery();

                //close the connection

                msqlConnection.Close();

                //empty the text boxes

                alteracao.Text = null;

                idcadfornecedor.Text = null;

                MessageBox.Show("Informação Alterada!!");



            }
            //ALTERACAO DO TERCEIRO CAMPO DO COMBOBOXCAMPO

            if (comboBoxCampo.Text == "nomefantasia")
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

                msqlcommand.CommandText = "UPDATE cadfornecedor SET nomefantasia=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                //add values provided by user

                msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                msqlcommand.ExecuteNonQuery();

                //close the connection
                msqlConnection.Close();

                //empty the text boxes

                alteracao.Text = null;

                idcadfornecedor.Text = null;

                MessageBox.Show("Informação Alterada!!");
            }

                if (comboBoxCampo.Text == "inscricaoestadual")
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

                    msqlcommand.CommandText = "UPDATE cadfornecedor SET inscricaoestadual=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                    //add values provided by user

                    msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                    msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                    msqlcommand.ExecuteNonQuery();

                    //close the connection

                    msqlConnection.Close();

                    //empty the text boxes

                    alteracao.Text = null;

                    idcadfornecedor.Text = null;

                    MessageBox.Show("Informação Alterada!");



            }
            //ALTERACAO DO QUARTO CAMPO

                if (comboBoxCampo.Text == "inscricaomunicipal")
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

                    msqlcommand.CommandText = "UPDATE cadfornecedor SET inscricaomunicipal=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                    //add values provided by user

                    msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                    msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                    msqlcommand.ExecuteNonQuery();

                    //close the connection

                    msqlConnection.Close();

                    //empty the text boxes

                    alteracao.Text = null;

                    idcadfornecedor.Text = null;

                    MessageBox.Show("Informação Alterada!");



                }
            // ALTERACAO DO QUINTO CAMPO


                if (comboBoxCampo.Text == "endereco")
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

                    msqlcommand.CommandText = "UPDATE cadfornecedor SET endereco=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                    //add values provided by user

                    msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                    msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                    msqlcommand.ExecuteNonQuery();

                    //close the connection

                    msqlConnection.Close();

                    //empty the text boxes

                    alteracao.Text = null;

                    idcadfornecedor.Text = null;

                    MessageBox.Show("Informação Alterada!");



                }
            // ALTERACAO DO SEXTO CAMPO


                if (comboBoxCampo.Text == "complemento")
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

                    msqlcommand.CommandText = "UPDATE cadfornecedor SET complemento=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                    //add values provided by user

                    msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                    msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                    msqlcommand.ExecuteNonQuery();

                    //close the connection

                    msqlConnection.Close();

                    //empty the text boxes

                    alteracao.Text = null;

                    idcadfornecedor.Text = null;

                    MessageBox.Show("Informação Alterada!");



                }
            //ALTERANDO O SETIMO CAMPO
                if (comboBoxCampo.Text == "cep")
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

                    msqlcommand.CommandText = "UPDATE cadfornecedor SET cep=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                    //add values provided by user

                    msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                    msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                    msqlcommand.ExecuteNonQuery();

                    //close the connection

                    msqlConnection.Close();

                    //empty the text boxes

                    alteracao.Text = null;

                    idcadfornecedor.Text = null;

                    MessageBox.Show("Informação Alterada!");



                }
            // ALTERANDO O OITAVO CAMPO

                if (comboBoxCampo.Text == "bairro")
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

                    msqlcommand.CommandText = "UPDATE cadfornecedor SET bairro=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                    //add values provided by user

                    msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                    msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                    msqlcommand.ExecuteNonQuery();

                    //close the connection

                    msqlConnection.Close();

                    //empty the text boxes

                    alteracao.Text = null;

                    idcadfornecedor.Text = null;

                    MessageBox.Show("Informação Alterada!");



                }
            //ALTERANDO O NONO CAMPO


                if (comboBoxCampo.Text == "cidade")
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

                    msqlcommand.CommandText = "UPDATE cadfornecedor SET cidade=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                    //add values provided by user

                    msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                    msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                    msqlcommand.ExecuteNonQuery();

                    //close the connection

                    msqlConnection.Close();

                    //empty the text boxes

                    alteracao.Text = null;

                    idcadfornecedor.Text = null;

                    MessageBox.Show("Informação Alterada!");



                }
            //ALTERANDO O DECIMO CAMPO
                if (comboBoxCampo.Text == "uf")
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

                    msqlcommand.CommandText = "UPDATE cadfornecedor SET uf=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                    //add values provided by user

                    msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                    msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                    msqlcommand.ExecuteNonQuery();

                    //close the connection

                    msqlConnection.Close();

                    //empty the text boxes

                    alteracao.Text = null;

                    idcadfornecedor.Text = null;

                    MessageBox.Show("Informação Alterada!");



                }
            //ALTERANDO O DECIMO PRIMEIRO CAMPO
                if (comboBoxCampo.Text == "telefone")
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

                    msqlcommand.CommandText = "UPDATE cadfornecedor SET telefone=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                    //add values provided by user

                    msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                    msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                    msqlcommand.ExecuteNonQuery();

                    //close the connection

                    msqlConnection.Close();

                    //empty the text boxes

                    alteracao.Text = null;

                    idcadfornecedor.Text = null;

                    MessageBox.Show("Informação Alterada!");



                }
            //ALTERANDO O DECIMO SEGUNDO CAMPO
                if (comboBoxCampo.Text == "ddd")
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

                    msqlcommand.CommandText = "UPDATE cadfornecedor SET ddd=@alteracao WHERE idcadfornecedor=@idcadfornecedor;";

                    //add values provided by user

                    msqlcommand.Parameters.AddWithValue("@alteracao", alteracao.Text);
                    msqlcommand.Parameters.AddWithValue("@idcadfornecedor", idcadfornecedor.Text);
                    msqlcommand.ExecuteNonQuery();

                    //close the connection

                    msqlConnection.Close();

                    //empty the text boxes

                    alteracao.Text = null;

                    idcadfornecedor.Text = null;

                    MessageBox.Show("Informação Alterada!");



                }
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
