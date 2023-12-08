using Primeiro_Projeto.Model;
using Primeiro_Projeto.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Primeiro_Projeto
{
    public partial class NovoUsuarioSenha : Form
    {
        DataBase novoUsuarioSenha = new DataBase();
        private int Id;
        // private string Email;
        // private int Escolha = 1;
        public NovoUsuarioSenha(int id) //int escolha
        {
            Id = id;
            // Email = email;
            //  Escolha = escolha;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha1.Text == txtSenha2.Text && !txtSenha1.Text.Equals("") && !txtUsuario.Text.Equals(""))
                {
                    Pessoa enviar = new Pessoa();

                    enviar.id = Id;
                    enviar.nome = txtUsuario.Text;
                    enviar.senha = txtSenha1.Text;

                    novoUsuarioSenha.AtualizarPessoa(enviar);

                    MessageBox.Show("Usuario e Senha atualizados com sucesso", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    //if (Escolha == 1)
                    //{
                    //    novoUsuarioSenha.Nome = txtUsuario.Text;
                    //    novoUsuarioSenha.Senha = txtSenha1.Text;
                    //    novoUsuarioSenha.Email = Email;
                    //    novoUsuarioSenha.AtualizarCliente();
                    //    this.Close();
                    //}
                    //else if (Escolha == 2)
                    //{

                    //    novoUsuarioSenha.NomeFuncionario = txtUsuario.Text;
                    //    novoUsuarioSenha.SenhaFuncionario = txtSenha1.Text;
                    //    novoUsuarioSenha.email = Email;
                    //    novoUsuarioSenha.AtualizarFuncionario();
                    //    this.Close();
                    //}
                }
                else if (txtSenha1.Text != txtSenha2.Text)
                {
                    MessageBox.Show("Os campos \n``Nova Senha´´ e ``Repetir Nova Senha´´ \ndevem ser iguais!", "Atenção!",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Atenção!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
