namespace Relatorio
{
    partial class cadcliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadcliente));
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSetcadcliente = new Relatorio.agendaDataSetcadcliente();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.referencia = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.celular = new System.Windows.Forms.TextBox();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttoncadcliente = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteTableAdapter = new Relatorio.agendaDataSetcadclienteTableAdapters.clienteTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonexcluircliente = new System.Windows.Forms.Button();
            this.idclienteeexcluir = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetcadcliente)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço: / Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Referência:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(915, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cidade:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(171, 45);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(201, 20);
            this.nome.TabIndex = 8;
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(408, 45);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(235, 20);
            this.endereco.TabIndex = 9;
            // 
            // referencia
            // 
            this.referencia.Location = new System.Drawing.Point(667, 45);
            this.referencia.Name = "referencia";
            this.referencia.Size = new System.Drawing.Size(238, 20);
            this.referencia.TabIndex = 10;
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(918, 45);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(100, 20);
            this.cidade.TabIndex = 11;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(9, 44);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(129, 20);
            this.cpf.TabIndex = 12;
            this.cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyChar);
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(6, 100);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(100, 20);
            this.telefone.TabIndex = 13;
            // 
            // celular
            // 
            this.celular.Location = new System.Drawing.Point(132, 100);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(100, 20);
            this.celular.TabIndex = 14;
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Location = new System.Drawing.Point(1033, 44);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(49, 21);
            this.comboBoxUF.TabIndex = 17;
            this.comboBoxUF.SelectedIndexChanged += new System.EventHandler(this.comboBoxUF_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1030, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "UF:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(641, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // buttoncadcliente
            // 
            this.buttoncadcliente.Location = new System.Drawing.Point(966, 109);
            this.buttoncadcliente.Name = "buttoncadcliente";
            this.buttoncadcliente.Size = new System.Drawing.Size(117, 25);
            this.buttoncadcliente.TabIndex = 21;
            this.buttoncadcliente.Text = "Cadastrar";
            this.buttoncadcliente.UseVisualStyleBackColor = true;
            this.buttoncadcliente.Click += new System.EventHandler(this.buttoncadcliente_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.clienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Relatorio.Report16.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(99, 245);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1103, 195);
            this.reportViewer1.TabIndex = 22;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(99, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1103, 227);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.cpf);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttoncadcliente);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.celular);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.telefone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBoxUF);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.nome);
            this.tabPage1.Controls.Add(this.endereco);
            this.tabPage1.Controls.Add(this.referencia);
            this.tabPage1.Controls.Add(this.cidade);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1095, 201);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonexcluircliente);
            this.tabPage3.Controls.Add(this.idclienteeexcluir);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1095, 201);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Excluir";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // buttonexcluircliente
            // 
            this.buttonexcluircliente.Location = new System.Drawing.Point(162, 50);
            this.buttonexcluircliente.Name = "buttonexcluircliente";
            this.buttonexcluircliente.Size = new System.Drawing.Size(107, 24);
            this.buttonexcluircliente.TabIndex = 2;
            this.buttonexcluircliente.Text = "Excluir Cliente";
            this.buttonexcluircliente.UseVisualStyleBackColor = true;
            this.buttonexcluircliente.Click += new System.EventHandler(this.buttonexcluircliente_Click);
            // 
            // idclienteeexcluir
            // 
            this.idclienteeexcluir.Location = new System.Drawing.Point(32, 54);
            this.idclienteeexcluir.Name = "idclienteeexcluir";
            this.idclienteeexcluir.Size = new System.Drawing.Size(100, 20);
            this.idclienteeexcluir.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Idcliente";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(268, 100);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(190, 20);
            this.email.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "E-Mail:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(966, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(966, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cadcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 442);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadcliente";
            this.Text = "Manutenção de Cliente  - RelatórioOS - Hecton P.Domingos";
            this.Load += new System.EventHandler(this.cadcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetcadcliente)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.TextBox referencia;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.ComboBox comboBoxUF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttoncadcliente;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private agendaDataSetcadcliente agendaDataSetcadcliente;
        private agendaDataSetcadclienteTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox idclienteeexcluir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonexcluircliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox email;
    }
}