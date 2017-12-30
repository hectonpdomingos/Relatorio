namespace Relatorio
{
    partial class TesteImagem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1AdcionarImagem = new System.Windows.Forms.Button();
            this.button2ListarImagens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1AdcionarImagem
            // 
            this.button1AdcionarImagem.Location = new System.Drawing.Point(36, 31);
            this.button1AdcionarImagem.Name = "button1AdcionarImagem";
            this.button1AdcionarImagem.Size = new System.Drawing.Size(126, 23);
            this.button1AdcionarImagem.TabIndex = 1;
            this.button1AdcionarImagem.Text = "Adcionar Imagem";
            this.button1AdcionarImagem.UseVisualStyleBackColor = true;
            this.button1AdcionarImagem.Click += new System.EventHandler(this.button1AdcionarImagem_Click);
            // 
            // button2ListarImagens
            // 
            this.button2ListarImagens.Location = new System.Drawing.Point(211, 31);
            this.button2ListarImagens.Name = "button2ListarImagens";
            this.button2ListarImagens.Size = new System.Drawing.Size(130, 23);
            this.button2ListarImagens.TabIndex = 2;
            this.button2ListarImagens.Text = "Listar Imagens";
            this.button2ListarImagens.UseVisualStyleBackColor = true;
            this.button2ListarImagens.Click += new System.EventHandler(this.button2ListarImagens_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição da Imagem";
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(39, 89);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(302, 20);
            this.descricao.TabIndex = 4;
            this.descricao.Text = " ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            this.openFileDialog1.InitialDirectory = "c:\\";
            // 
            // TesteImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 400);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2ListarImagens);
            this.Controls.Add(this.button1AdcionarImagem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TesteImagem";
            this.Text = "TesteImagem";
            this.Load += new System.EventHandler(this.TesteImagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1AdcionarImagem;
        private System.Windows.Forms.Button button2ListarImagens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}