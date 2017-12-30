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
using System.Drawing.Imaging;


namespace Relatorio
{
    public partial class TesteImagem : Form
   { 
        public TesteImagem()
        {

            InitializeComponent();
            
        }




        private void TesteImagem_Load(object sender, EventArgs e)
        {

        }

        private void button1AdcionarImagem_Click(object sender, EventArgs e)
        {
            
             if ( openFileDialog1.ShowDialog() == DialogResult.OK)
{

//exibir a imagem no formulário
string nomeArquivo = openFileDialog1.FileName;
Bitmap bmp = new Bitmap(nomeArquivo);
pictureBox1.Image = bmp;

MemoryStream ms = new MemoryStream();

bmp.Save(ms, ImageFormat.Bmp);
byte[] foto = ms.ToArray();
              

//Salvar imagem no banco de dados

MySql.Data.MySqlClient.MySqlConnection msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;");
if (msqlConnection.State != System.Data.ConnectionState.Open)
msqlConnection.Open();
MySql.Data.MySqlClient.MySqlCommand msqlcommand = new MySql.Data.MySqlClient.MySqlCommand();
msqlcommand.Connection = msqlConnection;

msqlcommand.CommandText = "insert into Cliente_Foto (idCliente, Foto) values (idCliente, @Foto);";

MySqlParameter paramFoto = new MySqlParameter("@foto", MySqlDbType.Binary);
                 
paramFoto.Value = foto;
msqlcommand.Parameters.Add(paramFoto);

msqlcommand.ExecuteNonQuery();
msqlConnection.Close();
}
           

        }

        private void button2ListarImagens_Click(object sender, EventArgs e)
        {
           
            
MySqlConnection conexao = new MySqlConnection("Server=192.168.79.130;Port=3306;Database=agenda;Uid=root;password=12domlei;");
MySqlCommand comandomsql = new MySqlCommand();
comandomsql.Connection = conexao;

conexao.Open();        
comandomsql.CommandText = "select Foto from Cliente_Foto where idCliente=3;";
MySqlDataReader reader = comandomsql.ExecuteReader();
            
Image imagem = null;
            
if (reader.Read())
{
    byte[] foto = (byte[])reader["Foto"];
    MemoryStream adap = new MemoryStream(foto);
    imagem = Image.FromStream(adap);
    pictureBox1.Image = imagem;
}

conexao.Close();
}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }

       

    }
