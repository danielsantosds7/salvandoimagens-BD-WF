namespace SalvandoImagens_BD_SQLServer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStringConexaoBD = new System.Windows.Forms.TextBox();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnRetornarImagemBD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoImagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoImagem = new System.Windows.Forms.TextBox();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.btnSalvarImagemBD = new System.Windows.Forms.Button();
            this.gdvImagens = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "String de Conexão com o SQL Server";
            // 
            // txtStringConexaoBD
            // 
            this.txtStringConexaoBD.Location = new System.Drawing.Point(36, 69);
            this.txtStringConexaoBD.Multiline = true;
            this.txtStringConexaoBD.Name = "txtStringConexaoBD";
            this.txtStringConexaoBD.Size = new System.Drawing.Size(611, 82);
            this.txtStringConexaoBD.TabIndex = 1;
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(653, 69);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(113, 82);
            this.btnAtivar.TabIndex = 2;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(36, 177);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(382, 410);
            this.picImagem.TabIndex = 3;
            this.picImagem.TabStop = false;
            // 
            // btnRetornarImagemBD
            // 
            this.btnRetornarImagemBD.Enabled = false;
            this.btnRetornarImagemBD.Location = new System.Drawing.Point(425, 177);
            this.btnRetornarImagemBD.Name = "btnRetornarImagemBD";
            this.btnRetornarImagemBD.Size = new System.Drawing.Size(341, 60);
            this.btnRetornarImagemBD.TabIndex = 4;
            this.btnRetornarImagemBD.Text = "Obter Imagem do Banco de Dados";
            this.btnRetornarImagemBD.UseVisualStyleBackColor = true;
            this.btnRetornarImagemBD.Click += new System.EventHandler(this.btnRetornarImagemBD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código da Imagem";
            // 
            // txtCodigoImagem
            // 
            this.txtCodigoImagem.Location = new System.Drawing.Point(425, 302);
            this.txtCodigoImagem.Name = "txtCodigoImagem";
            this.txtCodigoImagem.Size = new System.Drawing.Size(341, 26);
            this.txtCodigoImagem.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição da Imagem";
            // 
            // txtDescricaoImagem
            // 
            this.txtDescricaoImagem.Location = new System.Drawing.Point(425, 385);
            this.txtDescricaoImagem.Multiline = true;
            this.txtDescricaoImagem.Name = "txtDescricaoImagem";
            this.txtDescricaoImagem.Size = new System.Drawing.Size(341, 202);
            this.txtDescricaoImagem.TabIndex = 8;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Enabled = false;
            this.btnCarregarImagem.Location = new System.Drawing.Point(36, 593);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(382, 60);
            this.btnCarregarImagem.TabIndex = 9;
            this.btnCarregarImagem.Text = "Carregar Imagem";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // btnSalvarImagemBD
            // 
            this.btnSalvarImagemBD.Location = new System.Drawing.Point(428, 593);
            this.btnSalvarImagemBD.Name = "btnSalvarImagemBD";
            this.btnSalvarImagemBD.Size = new System.Drawing.Size(338, 60);
            this.btnSalvarImagemBD.TabIndex = 10;
            this.btnSalvarImagemBD.Text = "Salvar Imagem no Banco de Dados";
            this.btnSalvarImagemBD.UseVisualStyleBackColor = true;
            this.btnSalvarImagemBD.Click += new System.EventHandler(this.btnSalvarImagemBD_Click);
            // 
            // gdvImagens
            // 
            this.gdvImagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvImagens.Location = new System.Drawing.Point(36, 681);
            this.gdvImagens.Name = "gdvImagens";
            this.gdvImagens.RowHeadersWidth = 62;
            this.gdvImagens.RowTemplate.Height = 28;
            this.gdvImagens.Size = new System.Drawing.Size(730, 276);
            this.gdvImagens.TabIndex = 11;
            this.gdvImagens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvImagens_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 980);
            this.Controls.Add(this.gdvImagens);
            this.Controls.Add(this.btnSalvarImagemBD);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.txtDescricaoImagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRetornarImagemBD);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.txtStringConexaoBD);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvImagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStringConexaoBD;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btnRetornarImagemBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoImagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoImagem;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Button btnSalvarImagemBD;
        private System.Windows.Forms.DataGridView gdvImagens;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

