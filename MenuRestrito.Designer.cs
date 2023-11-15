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
            this.cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarEmCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizarTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTodasAsJanelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CadastrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.janelasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrar,
            this.CadastrarCliente});
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // cadastrar
            // 
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(236, 26);
            this.cadastrar.Text = "Cadastrar Funcionario";
            this.cadastrar.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.listarToolStripMenuItem.Text = "Listar";
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
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
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
            // CadastrarCliente
            // 
            this.CadastrarCliente.Name = "CadastrarCliente";
            this.CadastrarCliente.Size = new System.Drawing.Size(236, 26);
            this.CadastrarCliente.Text = "Cadastrar Cliente";
            this.CadastrarCliente.Click += new System.EventHandler(this.CadastrarCliente_Click);
            // 
            // MenuRestrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 615);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuRestrito";
            this.Text = "MenuRestrito";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrar;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarEmCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem minimizarTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTodasAsJanelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CadastrarCliente;
    }
}