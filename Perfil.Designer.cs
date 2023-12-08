namespace Primeiro_Projeto
{
    partial class Perfil
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lstview_Resumo = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Alterar);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_Telefone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_CPF);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do cliente";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(7, 143);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(132, 23);
            this.btn_Alterar.TabIndex = 7;
            this.btn_Alterar.Text = "Alterar Dados";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Location = new System.Drawing.Point(7, 105);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(168, 15);
            this.txt_email.TabIndex = 6;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Telefone.Location = new System.Drawing.Point(203, 105);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.ReadOnly = true;
            this.txt_Telefone.Size = new System.Drawing.Size(132, 15);
            this.txt_Telefone.TabIndex = 5;
            // 
            // txt_CPF
            // 
            this.txt_CPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CPF.Location = new System.Drawing.Point(203, 48);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.ReadOnly = true;
            this.txt_CPF.Size = new System.Drawing.Size(132, 15);
            this.txt_CPF.TabIndex = 3;
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nome.Location = new System.Drawing.Point(7, 49);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.ReadOnly = true;
            this.txt_Nome.Size = new System.Drawing.Size(168, 15);
            this.txt_Nome.TabIndex = 2;
            // 
            // lstview_Resumo
            // 
            this.lstview_Resumo.FullRowSelect = true;
            this.lstview_Resumo.GridLines = true;
            this.lstview_Resumo.HideSelection = false;
            this.lstview_Resumo.Location = new System.Drawing.Point(12, 198);
            this.lstview_Resumo.Name = "lstview_Resumo";
            this.lstview_Resumo.Size = new System.Drawing.Size(372, 163);
            this.lstview_Resumo.TabIndex = 6;
            this.lstview_Resumo.UseCompatibleStateImageBehavior = false;
            this.lstview_Resumo.View = System.Windows.Forms.View.Details;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 373);
            this.Controls.Add(this.lstview_Resumo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_CPF;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.ListView lstview_Resumo;
    }
}