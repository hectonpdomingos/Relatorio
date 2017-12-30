namespace Relatorio
{
    partial class testando
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.relatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet6 = new Relatorio.agendaDataSet6();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSetcadcliente = new Relatorio.agendaDataSetcadcliente();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new Relatorio.DataSet1();
            this.relatorioTableAdapter = new Relatorio.agendaDataSet6TableAdapters.relatorioTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.agendaDataSet7 = new Relatorio.agendaDataSet7();
            this.relatorioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioTableAdapter1 = new Relatorio.agendaDataSet7TableAdapters.relatorioTableAdapter();
            this.agendaDataSet8 = new Relatorio.agendaDataSet8();
            this.relatorioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioTableAdapter2 = new Relatorio.agendaDataSet8TableAdapters.relatorioTableAdapter();
            this.agendaDataSet9 = new Relatorio.agendaDataSet9();
            this.relatorioBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioTableAdapter3 = new Relatorio.agendaDataSet9TableAdapters.relatorioTableAdapter();
            this.relatorioBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioTableAdapter4 = new Relatorio.DataSet1TableAdapters.relatorioTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.agendaDataSetcadcliente1 = new Relatorio.agendaDataSetcadcliente();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteTableAdapter = new Relatorio.agendaDataSetcadclienteTableAdapters.clienteTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetcadcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetcadcliente1)).BeginInit();
            this.SuspendLayout();
            // 
            // relatorioBindingSource
            // 
            this.relatorioBindingSource.DataMember = "relatorio";
            this.relatorioBindingSource.DataSource = this.agendaDataSet6;
            // 
            // agendaDataSet6
            // 
            this.agendaDataSet6.DataSetName = "agendaDataSet6";
            this.agendaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.agendaDataSetcadcliente;
            // 
            // agendaDataSetcadcliente
            // 
            this.agendaDataSetcadcliente.DataSetName = "agendaDataSetcadcliente";
            this.agendaDataSetcadcliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 89);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioTableAdapter
            // 
            this.relatorioTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.relatorioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Relatorio.Report18.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(513, 132);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(184, 70);
            this.reportViewer1.TabIndex = 3;
            // 
            // agendaDataSet7
            // 
            this.agendaDataSet7.DataSetName = "agendaDataSet7";
            this.agendaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioBindingSource1
            // 
            this.relatorioBindingSource1.DataMember = "relatorio";
            this.relatorioBindingSource1.DataSource = this.agendaDataSet7;
            // 
            // relatorioTableAdapter1
            // 
            this.relatorioTableAdapter1.ClearBeforeFill = true;
            // 
            // agendaDataSet8
            // 
            this.agendaDataSet8.DataSetName = "agendaDataSet8";
            this.agendaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioBindingSource2
            // 
            this.relatorioBindingSource2.DataMember = "relatorio";
            this.relatorioBindingSource2.DataSource = this.agendaDataSet8;
            // 
            // relatorioTableAdapter2
            // 
            this.relatorioTableAdapter2.ClearBeforeFill = true;
            // 
            // agendaDataSet9
            // 
            this.agendaDataSet9.DataSetName = "agendaDataSet9";
            this.agendaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioBindingSource3
            // 
            this.relatorioBindingSource3.DataMember = "relatorio";
            this.relatorioBindingSource3.DataSource = this.agendaDataSet9;
            // 
            // relatorioTableAdapter3
            // 
            this.relatorioTableAdapter3.ClearBeforeFill = true;
            // 
            // relatorioBindingSource4
            // 
            this.relatorioBindingSource4.DataMember = "relatorio";
            this.relatorioBindingSource4.DataSource = this.dataSet1;
            // 
            // relatorioTableAdapter4
            // 
            this.relatorioTableAdapter4.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.relatorioBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Relatorio.Report19.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(297, 132);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowToolBar = false;
            this.reportViewer2.Size = new System.Drawing.Size(151, 62);
            this.reportViewer2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1049, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(787, 60);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Mensal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(790, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1021, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // agendaDataSetcadcliente1
            // 
            this.agendaDataSetcadcliente1.DataSetName = "agendaDataSetcadcliente";
            this.agendaDataSetcadcliente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1167, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(66, 147);
            this.listBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(440, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyChar);
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.clienteBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Relatorio.testederelatorio.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(52, 219);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(1028, 246);
            this.reportViewer3.TabIndex = 12;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(863, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "CONNECTIAR VIA CLASS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // testando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 467);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "testando";
            this.Text = "TESTANDO SQL";
            this.Load += new System.EventHandler(this.start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetcadcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetcadcliente1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private agendaDataSet6 agendaDataSet6;
        private System.Windows.Forms.BindingSource relatorioBindingSource;
        private agendaDataSet6TableAdapters.relatorioTableAdapter relatorioTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private agendaDataSet7 agendaDataSet7;
        private System.Windows.Forms.BindingSource relatorioBindingSource1;
        private agendaDataSet7TableAdapters.relatorioTableAdapter relatorioTableAdapter1;
        private agendaDataSet8 agendaDataSet8;
        private System.Windows.Forms.BindingSource relatorioBindingSource2;
        private agendaDataSet8TableAdapters.relatorioTableAdapter relatorioTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private agendaDataSet9 agendaDataSet9;
        private System.Windows.Forms.BindingSource relatorioBindingSource3;
        private agendaDataSet9TableAdapters.relatorioTableAdapter relatorioTableAdapter3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource relatorioBindingSource4;
        private DataSet1TableAdapters.relatorioTableAdapter relatorioTableAdapter4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private agendaDataSetcadcliente agendaDataSetcadcliente1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private agendaDataSetcadcliente agendaDataSetcadcliente;
        private agendaDataSetcadclienteTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}