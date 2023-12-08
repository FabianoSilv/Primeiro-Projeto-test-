namespace Primeiro_Projeto
{
    partial class ListarFilmes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbNomeFilme = new System.Windows.Forms.Label();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.lbGenero = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.Lst_View = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.picView = new System.Windows.Forms.PictureBox();
            this.cms_AlterarImagem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.procurarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.rtbRetornoSinopse = new System.Windows.Forms.RichTextBox();
            this.cms_AlterarSinopse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarSinopseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRetornoCarac = new System.Windows.Forms.TextBox();
            this.txtReturnName = new System.Windows.Forms.TextBox();
            this.ofd_AlterarImagem = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.cms_AlterarImagem.SuspendLayout();
            this.gbDetalhes.SuspendLayout();
            this.cms_AlterarSinopse.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o metodo de pesquisa";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(113, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Genero";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nome";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbNomeFilme
            // 
            this.lbNomeFilme.AutoSize = true;
            this.lbNomeFilme.Location = new System.Drawing.Point(309, 14);
            this.lbNomeFilme.Name = "lbNomeFilme";
            this.lbNomeFilme.Size = new System.Drawing.Size(140, 16);
            this.lbNomeFilme.TabIndex = 1;
            this.lbNomeFilme.Text = "Digite o nome do filme";
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(312, 51);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(213, 22);
            this.txtNomeFilme.TabIndex = 2;
            // 
            // btnPesquisarNome
            // 
            this.btnPesquisarNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarNome.Location = new System.Drawing.Point(544, 49);
            this.btnPesquisarNome.Name = "btnPesquisarNome";
            this.btnPesquisarNome.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarNome.TabIndex = 4;
            this.btnPesquisarNome.Text = "Pesquisar";
            this.btnPesquisarNome.UseVisualStyleBackColor = true;
            this.btnPesquisarNome.Click += new System.EventHandler(this.btnPesquisarNome_Click);
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(309, 15);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(125, 16);
            this.lbGenero.TabIndex = 4;
            this.lbGenero.Text = "Selecione o genero";
            this.lbGenero.Visible = false;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Drama",
            "Ação",
            "Comédia",
            "Terror",
            "Romance",
            "Outro"});
            this.cbGenero.Location = new System.Drawing.Point(312, 49);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(213, 24);
            this.cbGenero.TabIndex = 3;
            this.cbGenero.Visible = false;
            // 
            // Lst_View
            // 
            this.Lst_View.AllowColumnReorder = true;
            this.Lst_View.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lst_View.ContextMenuStrip = this.contextMenuStrip1;
            this.Lst_View.FullRowSelect = true;
            this.Lst_View.GridLines = true;
            this.Lst_View.HideSelection = false;
            this.Lst_View.Location = new System.Drawing.Point(12, 91);
            this.Lst_View.Name = "Lst_View";
            this.Lst_View.Size = new System.Drawing.Size(800, 151);
            this.Lst_View.TabIndex = 5;
            this.Lst_View.UseCompatibleStateImageBehavior = false;
            this.Lst_View.View = System.Windows.Forms.View.Details;
            this.Lst_View.SelectedIndexChanged += new System.EventHandler(this.Lst_View_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Excluir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 28);
            // 
            // Excluir
            // 
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(121, 24);
            this.Excluir.Text = "Excluir";
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // picView
            // 
            this.picView.ContextMenuStrip = this.cms_AlterarImagem;
            this.picView.Location = new System.Drawing.Point(6, 30);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(200, 160);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picView.TabIndex = 6;
            this.picView.TabStop = false;
            // 
            // cms_AlterarImagem
            // 
            this.cms_AlterarImagem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_AlterarImagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procurarImagemToolStripMenuItem});
            this.cms_AlterarImagem.Name = "contextMenuStrip2";
            this.cms_AlterarImagem.Size = new System.Drawing.Size(211, 56);
            // 
            // procurarImagemToolStripMenuItem
            // 
            this.procurarImagemToolStripMenuItem.Name = "procurarImagemToolStripMenuItem";
            this.procurarImagemToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.procurarImagemToolStripMenuItem.Text = "Procurar Imagem";
            this.procurarImagemToolStripMenuItem.Click += new System.EventHandler(this.procurarImagemToolStripMenuItem_Click);
            // 
            // gbDetalhes
            // 
            this.gbDetalhes.Controls.Add(this.rtbRetornoSinopse);
            this.gbDetalhes.Controls.Add(this.txtRetornoCarac);
            this.gbDetalhes.Controls.Add(this.txtReturnName);
            this.gbDetalhes.Controls.Add(this.picView);
            this.gbDetalhes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDetalhes.Location = new System.Drawing.Point(0, 253);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(819, 199);
            this.gbDetalhes.TabIndex = 7;
            this.gbDetalhes.TabStop = false;
            this.gbDetalhes.Text = "Detalhes";
            // 
            // rtbRetornoSinopse
            // 
            this.rtbRetornoSinopse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtbRetornoSinopse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRetornoSinopse.ContextMenuStrip = this.cms_AlterarSinopse;
            this.rtbRetornoSinopse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRetornoSinopse.Location = new System.Drawing.Point(231, 103);
            this.rtbRetornoSinopse.Name = "rtbRetornoSinopse";
            this.rtbRetornoSinopse.ReadOnly = true;
            this.rtbRetornoSinopse.Size = new System.Drawing.Size(528, 90);
            this.rtbRetornoSinopse.TabIndex = 14;
            this.rtbRetornoSinopse.Text = "";
            this.rtbRetornoSinopse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbRetornoSinopse_MouseClick);
            this.rtbRetornoSinopse.MouseLeave += new System.EventHandler(this.rtbRetornoSinopse_MouseLeave);
            // 
            // cms_AlterarSinopse
            // 
            this.cms_AlterarSinopse.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_AlterarSinopse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSinopseToolStripMenuItem});
            this.cms_AlterarSinopse.Name = "cms_AlterarSinopse";
            this.cms_AlterarSinopse.Size = new System.Drawing.Size(180, 28);
            // 
            // alterarSinopseToolStripMenuItem
            // 
            this.alterarSinopseToolStripMenuItem.Name = "alterarSinopseToolStripMenuItem";
            this.alterarSinopseToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.alterarSinopseToolStripMenuItem.Text = "Alterar Sinopse";
            // 
            // txtRetornoCarac
            // 
            this.txtRetornoCarac.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRetornoCarac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRetornoCarac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetornoCarac.Location = new System.Drawing.Point(231, 71);
            this.txtRetornoCarac.Name = "txtRetornoCarac";
            this.txtRetornoCarac.ReadOnly = true;
            this.txtRetornoCarac.Size = new System.Drawing.Size(490, 19);
            this.txtRetornoCarac.TabIndex = 13;
            // 
            // txtReturnName
            // 
            this.txtReturnName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtReturnName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReturnName.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtReturnName.Location = new System.Drawing.Point(231, 34);
            this.txtReturnName.Name = "txtReturnName";
            this.txtReturnName.ReadOnly = true;
            this.txtReturnName.Size = new System.Drawing.Size(476, 31);
            this.txtReturnName.TabIndex = 7;
            // 
            // ofd_AlterarImagem
            // 
            this.ofd_AlterarImagem.FileName = "AlterarImagem";
            // 
            // ListarFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 452);
            this.Controls.Add(this.gbDetalhes);
            this.Controls.Add(this.Lst_View);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.btnPesquisarNome);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.lbNomeFilme);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ListarFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListarFilmes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.cms_AlterarImagem.ResumeLayout(false);
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            this.cms_AlterarSinopse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lbNomeFilme;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.Button btnPesquisarNome;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ListView Lst_View;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Excluir;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.GroupBox gbDetalhes;
        private System.Windows.Forms.TextBox txtReturnName;
        private System.Windows.Forms.TextBox txtRetornoCarac;
        private System.Windows.Forms.RichTextBox rtbRetornoSinopse;
        private System.Windows.Forms.ContextMenuStrip cms_AlterarImagem;
        private System.Windows.Forms.ToolStripMenuItem procurarImagemToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_AlterarSinopse;
        private System.Windows.Forms.ToolStripMenuItem alterarSinopseToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd_AlterarImagem;
    }
}