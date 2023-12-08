namespace Primeiro_Projeto
{
    partial class MenuRestrito
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFilmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFilmesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarEmCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizarTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTodasAsJanelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNivelAcesso = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImagemLogin = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.listarFilmesToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrarProduto,
            this.CadastrarCliente,
            this.perfilToolStripMenuItem});
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // CadastrarProduto
            // 
            this.CadastrarProduto.Name = "CadastrarProduto";
            this.CadastrarProduto.Size = new System.Drawing.Size(256, 26);
            this.CadastrarProduto.Text = "Cadastrar Produtos";
            this.CadastrarProduto.Click += new System.EventHandler(this.CadastrarProduto_Click);
            // 
            // CadastrarCliente
            // 
            this.CadastrarCliente.Name = "CadastrarCliente";
            this.CadastrarCliente.Size = new System.Drawing.Size(256, 26);
            this.CadastrarCliente.Text = "Cadastrar/Alterar Cliente";
            this.CadastrarCliente.Click += new System.EventHandler(this.CadastrarCliente_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.perfilToolStripMenuItem.Text = "Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // listarFilmesToolStripMenuItem
            // 
            this.listarFilmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarFilmesToolStripMenuItem1,
            this.filmesToolStripMenuItem});
            this.listarFilmesToolStripMenuItem.Name = "listarFilmesToolStripMenuItem";
            this.listarFilmesToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.listarFilmesToolStripMenuItem.Text = "Listar Filmes";
            // 
            // listarFilmesToolStripMenuItem1
            // 
            this.listarFilmesToolStripMenuItem1.Name = "listarFilmesToolStripMenuItem1";
            this.listarFilmesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.listarFilmesToolStripMenuItem1.Text = "Listar/Alterar Filmes";
            this.listarFilmesToolStripMenuItem1.Click += new System.EventHandler(this.listarFilmesToolStripMenuItem1_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizarEmCascataToolStripMenuItem,
            this.organizarNaHorizontalToolStripMenuItem,
            this.organizarNaVerticalToolStripMenuItem,
            this.toolStripSeparator1,
            this.minimizarTodasToolStripMenuItem,
            this.fecharTodasAsJanelasToolStripMenuItem,
            this.toolStripSeparator2});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // organizarEmCascataToolStripMenuItem
            // 
            this.organizarEmCascataToolStripMenuItem.Name = "organizarEmCascataToolStripMenuItem";
            this.organizarEmCascataToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.organizarEmCascataToolStripMenuItem.Text = "Organizar em cascata";
            this.organizarEmCascataToolStripMenuItem.Click += new System.EventHandler(this.organizarEmCascataToolStripMenuItem_Click);
            // 
            // organizarNaHorizontalToolStripMenuItem
            // 
            this.organizarNaHorizontalToolStripMenuItem.Name = "organizarNaHorizontalToolStripMenuItem";
            this.organizarNaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.organizarNaHorizontalToolStripMenuItem.Text = "Organizar na horizontal";
            this.organizarNaHorizontalToolStripMenuItem.Click += new System.EventHandler(this.organizarNaHorizontalToolStripMenuItem_Click);
            // 
            // organizarNaVerticalToolStripMenuItem
            // 
            this.organizarNaVerticalToolStripMenuItem.Name = "organizarNaVerticalToolStripMenuItem";
            this.organizarNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.organizarNaVerticalToolStripMenuItem.Text = "Organizar na vertical";
            this.organizarNaVerticalToolStripMenuItem.Click += new System.EventHandler(this.organizarNaVerticalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(265, 6);
            // 
            // minimizarTodasToolStripMenuItem
            // 
            this.minimizarTodasToolStripMenuItem.Name = "minimizarTodasToolStripMenuItem";
            this.minimizarTodasToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.minimizarTodasToolStripMenuItem.Text = "Minimizar todas as Janelas";
            this.minimizarTodasToolStripMenuItem.Click += new System.EventHandler(this.minimizarTodasToolStripMenuItem_Click);
            // 
            // fecharTodasAsJanelasToolStripMenuItem
            // 
            this.fecharTodasAsJanelasToolStripMenuItem.Name = "fecharTodasAsJanelasToolStripMenuItem";
            this.fecharTodasAsJanelasToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.fecharTodasAsJanelasToolStripMenuItem.Text = "Fechar todas as Janelas";
            this.fecharTodasAsJanelasToolStripMenuItem.Click += new System.EventHandler(this.fecharTodasAsJanelasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(265, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem1,
            this.logOffToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(129, 26);
            this.loginToolStripMenuItem1.Text = "Login";
            this.loginToolStripMenuItem1.Click += new System.EventHandler(this.loginToolStripMenuItem1_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.logOffToolStripMenuItem.Text = "Logff";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lbNivelAcesso);
            this.panel1.Controls.Add(this.cpf);
            this.panel1.Controls.Add(this.lbNomeUsuario);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.pbImagemLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 41);
            this.panel1.TabIndex = 2;
            // 
            // lbNivelAcesso
            // 
            this.lbNivelAcesso.AutoSize = true;
            this.lbNivelAcesso.Location = new System.Drawing.Point(231, 11);
            this.lbNivelAcesso.Name = "lbNivelAcesso";
            this.lbNivelAcesso.Size = new System.Drawing.Size(89, 16);
            this.lbNivelAcesso.TabIndex = 4;
            this.lbNivelAcesso.Text = "complemento";
            this.lbNivelAcesso.Visible = false;
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(200, 11);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(25, 16);
            this.cpf.TabIndex = 3;
            this.cpf.Text = "cpf";
            this.cpf.Visible = false;
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Location = new System.Drawing.Point(96, 11);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(16, 16);
            this.lbNomeUsuario.TabIndex = 2;
            this.lbNomeUsuario.Text = "...";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(43, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 16);
            this.label.TabIndex = 1;
            this.label.Text = "Usuário:";
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.filmesToolStripMenuItem.Text = "Filmes";
            this.filmesToolStripMenuItem.Click += new System.EventHandler(this.filmesToolStripMenuItem_Click);
            // 
            // pbImagemLogin
            // 
            this.pbImagemLogin.Image = global::Primeiro_Projeto.Properties.Resources.led_vermelho;
            this.pbImagemLogin.Location = new System.Drawing.Point(3, 3);
            this.pbImagemLogin.Name = "pbImagemLogin";
            this.pbImagemLogin.Size = new System.Drawing.Size(33, 33);
            this.pbImagemLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemLogin.TabIndex = 0;
            this.pbImagemLogin.TabStop = false;
            // 
            // MenuRestrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuRestrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuRestrito";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarEmCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem minimizarTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTodasAsJanelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CadastrarCliente;
        private System.Windows.Forms.ToolStripMenuItem listarFilmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFilmesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.PictureBox pbImagemLogin;
        public System.Windows.Forms.Label lbNomeUsuario;
        public System.Windows.Forms.Label lbNivelAcesso;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        public System.Windows.Forms.Label cpf;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
    }
}