namespace Relatorio
{
    partial class visualizar
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
            this.relatorioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet5 = new Relatorio.agendaDataSet5();
            this.relatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet2 = new Relatorio.agendaDataSet2();
            this.relatorioTableAdapter = new Relatorio.agendaDataSet2TableAdapters.relatorioTableAdapter();
            this.DataSet1 = new Relatorio.DataSet1();
            this.tableAdapterManager1 = new Relatorio.agendaDataSetTableAdapters.TableAdapterManager();
            this.relatorioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioTableAdapter1 = new Relatorio.DataSet1TableAdapters.relatorioTableAdapter();
            this.relatorioTableAdapter2 = new Relatorio.agendaDataSet5TableAdapters.relatorioTableAdapter();
            this.agendaDataSetcadcliente = new Relatorio.agendaDataSetcadcliente();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Relatorio.agendaDataSetcadclienteTableAdapters.clienteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetcadcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // relatorioBindingSource2
            // 
            this.relatorioBindingSource2.DataMember = "relatorio";
            this.relatorioBindingSource2.DataSource = this.agendaDataSet5;
            // 
            // agendaDataSet5
            // 
            this.agendaDataSet5.DataSetName = "agendaDataSet5";
            this.agendaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioBindingSource
            // 
            this.relatorioBindingSource.DataMember = "relatorio";
            this.relatorioBindingSource.DataSource = this.agendaDataSet2;
            // 
            // agendaDataSet2
            // 
            this.agendaDataSet2.DataSetName = "agendaDataSet2";
            this.agendaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioTableAdapter
            // 
            this.relatorioTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.relatorioTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Relatorio.agendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // relatorioBindingSource1
            // 
            this.relatorioBindingSource1.DataMember = "relatorio";
            this.relatorioBindingSource1.DataSource = this.DataSet1;
            // 
            // relatorioTableAdapter1
            // 
            this.relatorioTableAdapter1.ClearBeforeFill = true;
            // 
            // relatorioTableAdapter2
            // 
            this.relatorioTableAdapter2.ClearBeforeFill = true;
            // 
            // agendaDataSetcadcliente
            // 
            this.agendaDataSetcadcliente.DataSetName = "agendaDataSetcadcliente";
            this.agendaDataSetcadcliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.agendaDataSetcadcliente;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Acessar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.fabricantesToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(146, 70);
            this.contextMenuStrip2.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDown = this.contextMenuStrip1;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // fabricantesToolStripMenuItem
            // 
            this.fabricantesToolStripMenuItem.Name = "fabricantesToolStripMenuItem";
            this.fabricantesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fabricantesToolStripMenuItem.Text = "Fabricantes";
            this.fabricantesToolStripMenuItem.Click += new System.EventHandler(this.fabricantesToolStripMenuItem_Click);
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(82, 107);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(100, 20);
            this.username_txt.TabIndex = 7;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(82, 149);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(100, 20);
            this.password_txt.TabIndex = 8;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha";
            // 
            // visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.button1);
            this.Name = "visualizar";
            this.Text = "visualizar";
            this.Load += new System.EventHandler(this.visualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetcadcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private agendaDataSet2 agendaDataSet2;
        private System.Windows.Forms.BindingSource relatorioBindingSource;
        private agendaDataSet2TableAdapters.relatorioTableAdapter relatorioTableAdapter;
        private DataSet1 DataSet1;
        private agendaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource relatorioBindingSource1;
        private DataSet1TableAdapters.relatorioTableAdapter relatorioTableAdapter1;
        private agendaDataSet5 agendaDataSet5;
        private System.Windows.Forms.BindingSource relatorioBindingSource2;
        private agendaDataSet5TableAdapters.relatorioTableAdapter relatorioTableAdapter2;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private agendaDataSetcadcliente agendaDataSetcadcliente;
        private agendaDataSetcadclienteTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricantesToolStripMenuItem;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;


    }
}