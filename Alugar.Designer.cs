namespace Primeiro_Projeto
{
    partial class Alugar
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
            this.btn_Alugar = new System.Windows.Forms.Button();
            this.picView = new System.Windows.Forms.PictureBox();
            this.lbl_NomeFilme = new System.Windows.Forms.Label();
            this.lbl_Duracao = new System.Windows.Forms.Label();
            this.lbl_Ano = new System.Windows.Forms.Label();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.lbl_IdCliente = new System.Windows.Forms.Label();
            this.lbl_NomeCliente = new System.Windows.Forms.Label();
            this.lbl_Classificacao = new System.Windows.Forms.Label();
            this.lbl_IdFilme = new System.Windows.Forms.Label();
            this.rtb_sinopse = new System.Windows.Forms.RichTextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Fila = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Alugar
            // 
            this.btn_Alugar.Location = new System.Drawing.Point(12, 215);
            this.btn_Alugar.Name = "btn_Alugar";
            this.btn_Alugar.Size = new System.Drawing.Size(93, 33);
            this.btn_Alugar.TabIndex = 1;
            this.btn_Alugar.Text = "Alugar";
            this.btn_Alugar.UseVisualStyleBackColor = true;
            this.btn_Alugar.Click += new System.EventHandler(this.btn_Alugar_Click);
            // 
            // picView
            // 
            this.picView.Location = new System.Drawing.Point(12, 12);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(177, 173);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picView.TabIndex = 0;
            this.picView.TabStop = false;
            // 
            // lbl_NomeFilme
            // 
            this.lbl_NomeFilme.AutoSize = true;
            this.lbl_NomeFilme.Font = new System.Drawing.Font("Sylfaen", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeFilme.Location = new System.Drawing.Point(195, 9);
            this.lbl_NomeFilme.Name = "lbl_NomeFilme";
            this.lbl_NomeFilme.Size = new System.Drawing.Size(161, 36);
            this.lbl_NomeFilme.TabIndex = 2;
            this.lbl_NomeFilme.Text = "NomeFilme";
            // 
            // lbl_Duracao
            // 
            this.lbl_Duracao.AutoSize = true;
            this.lbl_Duracao.Location = new System.Drawing.Point(314, 55);
            this.lbl_Duracao.Name = "lbl_Duracao";
            this.lbl_Duracao.Size = new System.Drawing.Size(59, 16);
            this.lbl_Duracao.TabIndex = 3;
            this.lbl_Duracao.Text = "Duração";
            // 
            // lbl_Ano
            // 
            this.lbl_Ano.AutoSize = true;
            this.lbl_Ano.Location = new System.Drawing.Point(195, 55);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(31, 16);
            this.lbl_Ano.TabIndex = 4;
            this.lbl_Ano.Text = "Ano";
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Location = new System.Drawing.Point(395, 55);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(52, 16);
            this.lbl_Genero.TabIndex = 6;
            this.lbl_Genero.Text = "Genero";
            // 
            // lbl_IdCliente
            // 
            this.lbl_IdCliente.AutoSize = true;
            this.lbl_IdCliente.Location = new System.Drawing.Point(718, 124);
            this.lbl_IdCliente.Name = "lbl_IdCliente";
            this.lbl_IdCliente.Size = new System.Drawing.Size(59, 16);
            this.lbl_IdCliente.TabIndex = 7;
            this.lbl_IdCliente.Text = "IdCliente";
            // 
            // lbl_NomeCliente
            // 
            this.lbl_NomeCliente.AutoSize = true;
            this.lbl_NomeCliente.Location = new System.Drawing.Point(678, 43);
            this.lbl_NomeCliente.Name = "lbl_NomeCliente";
            this.lbl_NomeCliente.Size = new System.Drawing.Size(85, 16);
            this.lbl_NomeCliente.TabIndex = 8;
            this.lbl_NomeCliente.Text = "NomeCliente";
            // 
            // lbl_Classificacao
            // 
            this.lbl_Classificacao.AutoSize = true;
            this.lbl_Classificacao.Location = new System.Drawing.Point(249, 55);
            this.lbl_Classificacao.Name = "lbl_Classificacao";
            this.lbl_Classificacao.Size = new System.Drawing.Size(27, 16);
            this.lbl_Classificacao.TabIndex = 9;
            this.lbl_Classificacao.Text = "Cla";
            // 
            // lbl_IdFilme
            // 
            this.lbl_IdFilme.AutoSize = true;
            this.lbl_IdFilme.Location = new System.Drawing.Point(718, 84);
            this.lbl_IdFilme.Name = "lbl_IdFilme";
            this.lbl_IdFilme.Size = new System.Drawing.Size(56, 16);
            this.lbl_IdFilme.TabIndex = 10;
            this.lbl_IdFilme.Text = "ID Filme";
            // 
            // rtb_sinopse
            // 
            this.rtb_sinopse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_sinopse.Location = new System.Drawing.Point(198, 84);
            this.rtb_sinopse.Name = "rtb_sinopse";
            this.rtb_sinopse.ReadOnly = true;
            this.rtb_sinopse.Size = new System.Drawing.Size(388, 101);
            this.rtb_sinopse.TabIndex = 11;
            this.rtb_sinopse.Text = "";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(111, 215);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(88, 33);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total na fila:";
            // 
            // lbl_Fila
            // 
            this.lbl_Fila.AutoSize = true;
            this.lbl_Fila.Location = new System.Drawing.Point(337, 215);
            this.lbl_Fila.Name = "lbl_Fila";
            this.lbl_Fila.Size = new System.Drawing.Size(14, 16);
            this.lbl_Fila.TabIndex = 17;
            this.lbl_Fila.Text = "0";
            // 
            // Alugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 258);
            this.Controls.Add(this.lbl_Fila);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.rtb_sinopse);
            this.Controls.Add(this.lbl_IdFilme);
            this.Controls.Add(this.lbl_Classificacao);
            this.Controls.Add(this.lbl_NomeCliente);
            this.Controls.Add(this.lbl_IdCliente);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.lbl_Ano);
            this.Controls.Add(this.lbl_Duracao);
            this.Controls.Add(this.lbl_NomeFilme);
            this.Controls.Add(this.btn_Alugar);
            this.Controls.Add(this.picView);
            this.Name = "Alugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alugar";
            this.Load += new System.EventHandler(this.Alugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.Button btn_Alugar;
        private System.Windows.Forms.Label lbl_Duracao;
        private System.Windows.Forms.Label lbl_Ano;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Label lbl_IdCliente;
        private System.Windows.Forms.Label lbl_NomeCliente;
        private System.Windows.Forms.Label lbl_Classificacao;
        private System.Windows.Forms.Label lbl_IdFilme;
        private System.Windows.Forms.RichTextBox rtb_sinopse;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_Fila;
        public System.Windows.Forms.Label lbl_NomeFilme;
    }
}