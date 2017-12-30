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
using MySql.Data.Common;
using MySql.Data.Types;


namespace Relatorio
{
    public partial class testando : Form
    {
        public testando()
        {
            InitializeComponent();
            Fillcombo();
            Totalmensal();
        }



       
        void Totalmensal()
        {
            

           // string input = total.Text.Trim();
            string conn = "Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;";
            MySqlConnection myconn = new MySqlConnection(conn);
            string sql = "select os from relatorio;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, myconn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
               
            {
                MessageBox.Show(" is not exist.", "Not Exists");
            }
            else
            {
                //total.Text = dt.Rows[5][5] + "";
                //listBox1.Text = dt.Rows[0][0] + "";
              
                    comboBox2.Items.Add(dt.Rows[0][0] + "");
              
            }


        }
        
        //criando uma funcao para dar um select em uma coluna do db e preencher o comboBox
       
        void Fillcombo()
        {
            string constring = "Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;";
            string query = "select * from cliente where nome = '" + comboBox1.Text + "' ";
            
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
                    comboBox1.Items.Add(sNome);
                   // textBox1.Text = sEndereco;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Fechando a funcao para dar um select em uma coluna do db e preencher o comboBox




        void campos()
        {
            string constring = "Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;";
            string query = "select * from cliente where nome = '" + textBox2.Text + "' ";

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
                    comboBox1.Items.Add(sNome);
                    textBox1.Text = sEndereco;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }


        private void start_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaDataSetcadcliente.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.agendaDataSetcadcliente.cliente);
            this.relatorioTableAdapter.Fill(this.agendaDataSet6.relatorio);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();

            this.reportViewer3.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            campos();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KeyChar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                this.campos();

            }

                  
        }

        private void button2_Click(object sender, EventArgs e)
        {


            ConexaoBancoMySQL.getConexao
            
            
            //// vamos obter a conexão com o banco de dados
            //MySqlConnection mysqlConnetion = conexao.obterConexao();

            //// a conexão foi efetuada com sucesso?
            //if (mysqlConnetion == null)
            //{
            //    MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
            //}
            //else
            //{
            //    MessageBox.Show("A conexão foi obtida com sucesso.");
            //}

            //// não precisamos mais da conexão? vamos fechá-la
            //conexao.fecharConexao();
        }
        //private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    if (e.KeyChar == 13)

        //        this.campos();

        //}
    }
}
