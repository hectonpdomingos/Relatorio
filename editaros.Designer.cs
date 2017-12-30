namespace Relatorio
{
    partial class editaros
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
            this.alteracao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.os = new System.Windows.Forms.TextBox();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new Relatorio.DataSet1();
            this.relatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioTableAdapter = new Relatorio.DataSet1TableAdapters.relatorioTableAdapter();
            this.agendaDataSet11_ordem_de_servico = new Relatorio.agendaDataSet11_ordem_de_servico();
            this.agendaDataSet11ordemdeservicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet11_ordem_de_servico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet11ordemdeservicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alteracao
            // 
            this.alteracao.Location = new System.Drawing.Point(329, 57);
            this.alteracao.Name = "alteracao";
            this.alteracao.Size = new System.Drawing.Size(319, 20);
            this.alteracao.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Altere a informação desejada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Campo para alteração";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // os
            // 
            this.os.Location = new System.Drawing.Point(38, 59);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(100, 20);
            this.os.TabIndex = 9;
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(163, 57);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(151, 21);
            this.comboBoxCampo.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_editar_ordem_de_servico";
            reportDataSource1.Value = this.agendaDataSet11ordemdeservicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Relatorio.Report24.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 153);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1042, 246);
            this.reportViewer1.TabIndex = 14;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioBindingSource
            // 
            this.relatorioBindingSource.DataMember = "relatorio";
            this.relatorioBindingSource.DataSource = this.DataSet1;
            // 
            // relatorioTableAdapter
            // 
            this.relatorioTableAdapter.ClearBeforeFill = true;
            // 
            // agendaDataSet11_ordem_de_servico
            // 
            this.agendaDataSet11_ordem_de_servico.DataSetName = "agendaDataSet11_ordem_de_servico";
            this.agendaDataSet11_ordem_de_servico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaDataSet11ordemdeservicoBindingSource
            // 
            this.agendaDataSet11ordemdeservicoBindingSource.DataSource = this.agendaDataSet11_ordem_de_servico;
            this.agendaDataSet11ordemdeservicoBindingSource.Position = 0;
            this.agendaDataSet11ordemdeservicoBindingSource.CurrentChanged += new System.EventHandler(this.agendaDataSet11ordemdeservicoBindingSource_CurrentChanged);
            // 
            // editaros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 423);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.alteracao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.os);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.button1);
            this.Name = "editaros";
            this.Text = "Editar Ordem de Serviço";
            this.Load += new System.EventHandler(this.editaros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet11_ordem_de_servico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet11ordemdeservicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alteracao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox os;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource relatorioBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.relatorioTableAdapter relatorioTableAdapter;
        private agendaDataSet11_ordem_de_servico agendaDataSet11_ordem_de_servico;
        private System.Windows.Forms.BindingSource agendaDataSet11ordemdeservicoBindingSource;
    }
}