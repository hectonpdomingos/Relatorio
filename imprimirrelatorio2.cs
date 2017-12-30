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
    public partial class imprimirrelatorio2 : Form
    {
    //    MySqlConnection con;
    //    MySqlDataAdapter adap;
    //    DataSet ds;

        public imprimirrelatorio2()
        {
            InitializeComponent();
        }

        private void imprimirrelatorio2_Load(object sender, EventArgs e)
        {
            

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }


        }
    }

