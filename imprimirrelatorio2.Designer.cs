namespace Relatorio
{
    partial class imprimirrelatorio2
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
            this.relatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet4 = new Relatorio.agendaDataSet4();
            this.agendaDataSet1 = new Relatorio.agendaDataSet();
            this.relatorioTableAdapter = new Relatorio.agendaDataSet4TableAdapters.relatorioTableAdapter();
            this.agendaDataSet5 = new Relatorio.agendaDataSet5();
            this.agendaDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSetImprimirRelatorio = new Relatorio.agendaDataSetImprimirRelatorio();
            this.agendaDataSetImprimirRelatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetImprimirRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetImprimirRelatorioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // relatorioBindingSource
            // 
            this.relatorioBindingSource.DataMember = "relatorio";
            this.relatorioBindingSource.DataSource = this.agendaDataSet4;
            // 
            // agendaDataSet4
            // 
            this.agendaDataSet4.DataSetName = "agendaDataSet4";
            this.agendaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaDataSet1
            // 
            this.agendaDataSet1.DataSetName = "agendaDataSet";
            this.agendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioTableAdapter
            // 
            this.relatorioTableAdapter.ClearBeforeFill = true;
            // 
            // agendaDataSet5
            // 
            this.agendaDataSet5.DataSetName = "agendaDataSet5";
            this.agendaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaDataSet5BindingSource
            // 
            this.agendaDataSet5BindingSource.DataSource = this.agendaDataSet5;
            this.agendaDataSet5BindingSource.Position = 0;
            // 
            // agendaDataSet4BindingSource
            // 
            this.agendaDataSet4BindingSource.DataSource = this.agendaDataSet4;
            this.agendaDataSet4BindingSource.Position = 0;
            // 
            // agendaDataSetImprimirRelatorio
            // 
            this.agendaDataSetImprimirRelatorio.DataSetName = "agendaDataSetImprimirRelatorio";
            this.agendaDataSetImprimirRelatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaDataSetImprimirRelatorioBindingSource
            // 
            this.agendaDataSetImprimirRelatorioBindingSource.DataSource = this.agendaDataSetImprimirRelatorio;
            this.agendaDataSetImprimirRelatorioBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetImprimirRelatorio";
            reportDataSource1.Value = this.agendaDataSetImprimirRelatorioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Relatorio.Report12.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1290, 441);
            this.reportViewer1.TabIndex = 0;
            // 
            // imprimirrelatorio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 441);
            this.Controls.Add(this.reportViewer1);
            this.Name = "imprimirrelatorio2";
            this.Text = "Relatótio Mensal - Hecton P.Domingos";
            this.Load += new System.EventHandler(this.imprimirrelatorio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetImprimirRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetImprimirRelatorioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private agendaDataSet agendaDataSet1;
        private System.Windows.Forms.BindingSource relatorioBindingSource;
        private agendaDataSet4 agendaDataSet4;
        private agendaDataSet4TableAdapters.relatorioTableAdapter relatorioTableAdapter;
        private System.Windows.Forms.BindingSource agendaDataSet5BindingSource;
        private agendaDataSet5 agendaDataSet5;
        private System.Windows.Forms.BindingSource agendaDataSet4BindingSource;
        private agendaDataSetImprimirRelatorio agendaDataSetImprimirRelatorio;
        private System.Windows.Forms.BindingSource agendaDataSetImprimirRelatorioBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}