namespace Primeiro_Projeto
{
    partial class FilmeClientes
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
            this.dgv_filme = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Pesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_filme
            // 
            this.dgv_filme.AllowUserToAddRows = false;
            this.dgv_filme.AllowUserToDeleteRows = false;
            this.dgv_filme.AllowUserToResizeColumns = false;
            this.dgv_filme.AllowUserToResizeRows = false;
            this.dgv_filme.CausesValidation = false;
            this.dgv_filme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_filme.Location = new System.Drawing.Point(0, 33);
            this.dgv_filme.MultiSelect = false;
            this.dgv_filme.Name = "dgv_filme";
            this.dgv_filme.ReadOnly = true;
            this.dgv_filme.RowHeadersWidth = 51;
            this.dgv_filme.RowTemplate.Height = 24;
            this.dgv_filme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_filme.Size = new System.Drawing.Size(1131, 504);
            this.dgv_filme.TabIndex = 0;
            this.dgv_filme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_filme_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Location = new System.Drawing.Point(351, 5);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(100, 22);
            this.txt_Pesquisa.TabIndex = 2;
            // 
            // FilmeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 573);
            this.Controls.Add(this.txt_Pesquisa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_filme);
            this.Name = "FilmeClientes";
            this.Text = "FilmeClientes";
            this.Load += new System.EventHandler(this.FilmeClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_filme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_filme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Pesquisa;
    }
}