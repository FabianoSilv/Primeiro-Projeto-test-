namespace Primeiro_Projeto
{
    partial class Cadastrar
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
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.lb_CPF = new System.Windows.Forms.Label();
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(29, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(32, 89);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 22);
            this.txtSenha.TabIndex = 3;
            // 
            // btnCadastar
            // 
            this.btnCadastar.Location = new System.Drawing.Point(32, 136);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(100, 23);
            this.btnCadastar.TabIndex = 4;
            this.btnCadastar.Text = "Cadastrar";
            this.btnCadastar.UseVisualStyleBackColor = true;
            this.btnCadastar.Click += new System.EventHandler(this.btnCadastar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // lb_Telefone
            // 
            this.lb_Telefone.AutoSize = true;
            this.lb_Telefone.Location = new System.Drawing.Point(154, 13);
            this.lb_Telefone.Name = "lb_Telefone";
            this.lb_Telefone.Size = new System.Drawing.Size(61, 16);
            this.lb_Telefone.TabIndex = 7;
            this.lb_Telefone.Text = "Telefone";
            // 
            // lb_CPF
            // 
            this.lb_CPF.AutoSize = true;
            this.lb_CPF.Location = new System.Drawing.Point(282, 13);
            this.lb_CPF.Name = "lb_CPF";
            this.lb_CPF.Size = new System.Drawing.Size(33, 16);
            this.lb_CPF.TabIndex = 8;
            this.lb_CPF.Text = "CPF";
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtb_Telefone.Location = new System.Drawing.Point(157, 31);
            this.mtb_Telefone.Mask = "(99) 0000-0000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(100, 22);
            this.mtb_Telefone.TabIndex = 9;
            this.mtb_Telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtb_CPF
            // 
            this.mtb_CPF.Location = new System.Drawing.Point(285, 31);
            this.mtb_CPF.Mask = "000,000,000-00";
            this.mtb_CPF.Name = "mtb_CPF";
            this.mtb_CPF.Size = new System.Drawing.Size(100, 22);
            this.mtb_CPF.TabIndex = 10;
            this.mtb_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(157, 136);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 23);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 179);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.mtb_CPF);
            this.Controls.Add(this.mtb_Telefone);
            this.Controls.Add(this.lb_CPF);
            this.Controls.Add(this.lb_Telefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCadastar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCadastar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.MaskedTextBox mtb_Telefone;
        public System.Windows.Forms.MaskedTextBox mtb_CPF;
        public System.Windows.Forms.Label lb_Telefone;
        public System.Windows.Forms.Label lb_CPF;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}