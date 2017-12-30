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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }


        
        // TERMINO DO CODIGO DE INSERIR
        private void acessorios_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FUNÇÃO PARA CHAMAR O REPORT VIEWER DO FORM VISUALIZAR
            visualizar visualizacao = new visualizar();
            visualizacao.Show();


        }

        private void buttonImprimirRelatorio_Click(object sender, EventArgs e)
        {

            testando teste = new testando();
            teste.Show();

            //imprimirrelatorio2 imprimir = new imprimirrelatorio2();
            //imprimir.Show();

        }


        //Menu do comboboxmenu para opções avançadas
  

        //private void tabPage2_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void tabPage1_Click(object sender, EventArgs e)
        //{

        //}

        //private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{

        //}

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadcliente menucadcliente = new cadcliente();
            menucadcliente.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadfornecedores cadastrodefornecedores = new cadfornecedores();
            cadastrodefornecedores.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cados cadastrodeordemdeservico = new cados();
            cadastrodeordemdeservico.Show();
        }

        private void manutençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editaros manutencaodeos = new editaros();
            manutencaodeos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void visitaTécnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitaTecnica Formvisitatecnica = new VisitaTecnica();
            Formvisitatecnica.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TesteImagem fromimagem = new TesteImagem();
            fromimagem.Show();
        }

        

    }
}
