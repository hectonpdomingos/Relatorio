using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorio
{
    public partial class editaros : Form
    {
        public editaros()
        {
            InitializeComponent();
            //comboBoxCampo.Items.Add("cnpj");
            comboBoxCampo.Items.Add("nome");
            comboBoxCampo.Items.Add("endereco");
            comboBoxCampo.Items.Add("equipamento");
            comboBoxCampo.Items.Add("acessorios");
            comboBoxCampo.Items.Add("defeito");
            comboBoxCampo.Items.Add("servico");
            comboBoxCampo.Items.Add("valor");
            
        }

        private void editaros_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void agendaDataSet11ordemdeservicoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
