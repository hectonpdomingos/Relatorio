namespace Relatorio
{
    partial class modcadempresa
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
            this.cadfornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSetcadfornecedor = new Relatorio.agendaDataSetcadfornecedor();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.idcadfornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alteracao = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cadfornecedorTableAdapter = new Relatorio.agendaDataSetcadfornecedorTableAdapters.cadfornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cadfornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetcadfornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // cadfornecedorBindingSource
            // 
            this.cadfornecedorBindingSource.DataMember = "cadfornecedor";
            this.cadfornecedorBindingSource.DataSource = this.agendaDataSetcadfornecedor;
            // 
            // agendaDataSetcadfornecedor
            // 
            this.agendaDataSetcadfornecedor.DataSetName = "agendaDataSetcadfornecedor";
            this.agendaDataSetcadfornecedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(164, 79);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(151, 21);
            this.comboBoxCampo.TabIndex = 1;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // idcadfornecedor
            // 
            this.idcadfornecedor.Location = new System.Drawing.Point(39, 81);
            this.idcadfornecedor.Name = "idcadfornecedor";
            this.idcadfornecedor.Size = new System.Drawing.Size(100, 20);
            this.idcadfornecedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Campo para alteração";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Altere a informação desejada";
            // 
            // alteracao
            // 
            this.alteracao.Location = new System.Drawing.Point(330, 79);
            this.alteracao.Name = "alteracao";
            this.alteracao.Size = new System.Drawing.Size(319, 20);
            this.alteracao.TabIndex = 6;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cadfornecedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Relatorio.Report15.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(39, 138);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(722, 258);
            this.reportViewer1.TabIndex = 7;
            // 
            // cadfornecedorTableAdapter
            // 
            this.cadfornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // modcadempresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 437);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.alteracao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idcadfornecedor);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.button1);
            this.Name = "modcadempresa";
            this.Text = "Modificar cadastro Fornecedores - Hecton P.Domingos";
            this.Load += new System.EventHandler(this.modcadempresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadfornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetcadfornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.TextBox idcadfornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alteracao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cadfornecedorBindingSource;
        private agendaDataSetcadfornecedor agendaDataSetcadfornecedor;
        private agendaDataSetcadfornecedorTableAdapters.cadfornecedorTableAdapter cadfornecedorTableAdapter;
    }
}