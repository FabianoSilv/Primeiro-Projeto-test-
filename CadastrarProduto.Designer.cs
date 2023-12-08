namespace Primeiro_Projeto
{
    partial class CadastrarProduto
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
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtSinopse = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.mskAno = new System.Windows.Forms.MaskedTextBox();
            this.mskDuracao = new System.Windows.Forms.MaskedTextBox();
            this.cbClassificao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picCapa = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Filme";
            // 
            // txtFilme
            // 
            this.txtFilme.Location = new System.Drawing.Point(16, 32);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(225, 22);
            this.txtFilme.TabIndex = 1;
            this.txtFilme.TextChanged += new System.EventHandler(this.txtFilme_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sinopse";
            // 
            // rtxtSinopse
            // 
            this.rtxtSinopse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtSinopse.Location = new System.Drawing.Point(304, 105);
            this.rtxtSinopse.Name = "rtxtSinopse";
            this.rtxtSinopse.Size = new System.Drawing.Size(408, 159);
            this.rtxtSinopse.TabIndex = 6;
            this.rtxtSinopse.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Classificação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Duração";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Drama",
            "Ação",
            "Comédia",
            "Terror",
            "Romance",
            "Outro"});
            this.cbTipo.Location = new System.Drawing.Point(581, 34);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 24);
            this.cbTipo.TabIndex = 5;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(578, 13);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(52, 16);
            this.Tipo.TabIndex = 9;
            this.Tipo.Text = "Genero";
            // 
            // mskAno
            // 
            this.mskAno.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskAno.HidePromptOnLeave = true;
            this.mskAno.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskAno.Location = new System.Drawing.Point(266, 32);
            this.mskAno.Mask = "0000";
            this.mskAno.Name = "mskAno";
            this.mskAno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskAno.Size = new System.Drawing.Size(49, 22);
            this.mskAno.TabIndex = 2;
            this.mskAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskAno.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskAno.ValidatingType = typeof(System.DateTime);
            // 
            // mskDuracao
            // 
            this.mskDuracao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskDuracao.HidePromptOnLeave = true;
            this.mskDuracao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskDuracao.Location = new System.Drawing.Point(342, 32);
            this.mskDuracao.Mask = "900";
            this.mskDuracao.Name = "mskDuracao";
            this.mskDuracao.PromptChar = ' ';
            this.mskDuracao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskDuracao.Size = new System.Drawing.Size(48, 22);
            this.mskDuracao.TabIndex = 3;
            this.mskDuracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDuracao.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbClassificao
            // 
            this.cbClassificao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassificao.FormattingEnabled = true;
            this.cbClassificao.Items.AddRange(new object[] {
            "Livre",
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.cbClassificao.Location = new System.Drawing.Point(440, 34);
            this.cbClassificao.Name = "cbClassificao";
            this.cbClassificao.Size = new System.Drawing.Size(121, 24);
            this.cbClassificao.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Capa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "min";
            // 
            // picCapa
            // 
            this.picCapa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCapa.Location = new System.Drawing.Point(16, 105);
            this.picCapa.Name = "picCapa";
            this.picCapa.Size = new System.Drawing.Size(200, 160);
            this.picCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapa.TabIndex = 15;
            this.picCapa.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(304, 280);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(408, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar Filme";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(16, 280);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(200, 23);
            this.btnImagem.TabIndex = 7;
            this.btnImagem.Text = "Procurar Imagem";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg| PNG (*.pgn)|*.png| JPEG (*.jpeg)|*.jpeg";
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 315);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.picCapa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbClassificao);
            this.Controls.Add(this.mskDuracao);
            this.Controls.Add(this.mskAno);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtSinopse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilme);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarProduto";
            this.Text = "CadastrarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtSinopse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.MaskedTextBox mskAno;
        private System.Windows.Forms.MaskedTextBox mskDuracao;
        private System.Windows.Forms.ComboBox cbClassificao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picCapa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}