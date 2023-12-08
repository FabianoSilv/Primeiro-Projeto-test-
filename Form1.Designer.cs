namespace Primeiro_Projeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNOVA = new System.Windows.Forms.TextBox();
            this.txtNOVO = new System.Windows.Forms.TextBox();
            this.NOVA = new System.Windows.Forms.Label();
            this.NOVO = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.txtNOVO);
            this.groupBox1.Controls.Add(this.NOVA);
            this.groupBox1.Controls.Add(this.NOVO);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnCadastar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.S);
            this.groupBox1.Controls.Add(this.U);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de Login";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(218, 81);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(245, 22);
            this.txtemail.TabIndex = 14;
            this.txtemail.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Digite seu E-Mail";
            this.label1.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(375, 178);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirma";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNOVA
            // 
            this.txtNOVA.Location = new System.Drawing.Point(91, 240);
            this.txtNOVA.Name = "txtNOVA";
            this.txtNOVA.Size = new System.Drawing.Size(245, 22);
            this.txtNOVA.TabIndex = 11;
            this.txtNOVA.Visible = false;
            // 
            // txtNOVO
            // 
            this.txtNOVO.Location = new System.Drawing.Point(79, 200);
            this.txtNOVO.Name = "txtNOVO";
            this.txtNOVO.Size = new System.Drawing.Size(245, 22);
            this.txtNOVO.TabIndex = 10;
            this.txtNOVO.Visible = false;
            // 
            // NOVA
            // 
            this.NOVA.AutoSize = true;
            this.NOVA.Location = new System.Drawing.Point(237, 181);
            this.NOVA.Name = "NOVA";
            this.NOVA.Size = new System.Drawing.Size(87, 16);
            this.NOVA.TabIndex = 9;
            this.NOVA.Text = "NOVA Senha";
            this.NOVA.Visible = false;
            // 
            // NOVO
            // 
            this.NOVO.AutoSize = true;
            this.NOVO.Location = new System.Drawing.Point(237, 155);
            this.NOVO.Name = "NOVO";
            this.NOVO.Size = new System.Drawing.Size(96, 16);
            this.NOVO.TabIndex = 8;
            this.NOVO.Text = "NOVO Usuario";
            this.NOVO.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(94, 115);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(114, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar Senha";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastar
            // 
            this.btnCadastar.Location = new System.Drawing.Point(0, 115);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(88, 23);
            this.btnCadastar.TabIndex = 5;
            this.btnCadastar.Text = "Cadastrar";
            this.btnCadastar.UseVisualStyleBackColor = true;
            this.btnCadastar.Click += new System.EventHandler(this.btnCadastar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtSenha
            // 
            this.txtSenha.AcceptsReturn = true;
            this.txtSenha.Location = new System.Drawing.Point(-17, 81);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(245, 22);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsReturn = true;
            this.txtUsuario.AccessibleDescription = "";
            this.txtUsuario.AccessibleName = "";
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.Location = new System.Drawing.Point(0, 37);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(245, 22);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Tag = "";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(6, 62);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(46, 16);
            this.S.TabIndex = 1;
            this.S.Text = "Senha";
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.Location = new System.Drawing.Point(3, 18);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(54, 16);
            this.U.TabIndex = 0;
            this.U.Text = "Usuario";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(387, 220);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 255);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNOVA);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISGEN - Sistema de Gestão";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label U;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Button btnCadastar;
        private System.Windows.Forms.Label NOVA;
        private System.Windows.Forms.Label NOVO;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNOVA;
        private System.Windows.Forms.TextBox txtNOVO;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

