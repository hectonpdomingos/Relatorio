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
    public partial class visualizar : Form
    {
        MySqlConnection con;
        MySqlDataAdapter adap;
        DataSet ds;

        public visualizar()
        {
            InitializeComponent();
        }

        private void visualizar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaDataSet5.relatorio' table. You can move, or remove it, as needed.
            this.relatorioTableAdapter2.Fill(this.agendaDataSet5.relatorio);


            MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("Server=127.0.0.1;Port=3306;Database=agenda;Uid=root;password=12domlei;");
            if (msqlConnection.State != System.Data.ConnectionState.Open)

                msqlConnection.Open();

            adap = new MySqlDataAdapter("SELECT os AS `OS`, nome AS `Nome`, telefone AS `Telefone`, endereco AS `Endereço`, equipamento AS `Equipamento`, acessorios AS `Acessorios`, servico AS `Servico`, valor AS `Valor` FROM relatorio", msqlConnection);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Dados");
            //dataGridView1.DataSource = ds.Tables[0];
            msqlConnection.Close();

            //this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
                {
                    string myConnection = "Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei  ;";
                    MySqlConnection myConn = new MySqlConnection(myConnection);
                    MySqlCommand SelectCommand = new MySqlCommand("select * from usuarios where user_name='" + this.username_txt.Text + "' and password='" + this.password_txt.Text + "' ;", myConn);
                    MySqlDataReader myReader;
                    myConn.Open();
                    myReader = SelectCommand.ExecuteReader();
                    int count = 0;
                    while (myReader.Read())
                {
                    count = count +1;
                }
                    if (count == 1)
                                {
                                    MessageBox.Show("Username and Password is correct");
                                    cadcliente vercadcliente = new cadcliente();
                                        vercadcliente.Show();
                                    
                        
                                }
                    else if (count > 1) 
                                {
                                    MessageBox.Show("Duplicate Username and Password");
                                }
                    else
                                    MessageBox.Show("Username and Password is not Corret...please try again");
                                    myConn.Close();
                                 }
                                    catch (Exception ex)
                                    {
                                    MessageBox.Show(ex.Message);
                                    }

                 }       
       
    }

    }
