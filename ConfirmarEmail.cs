using Primeiro_Projeto.Model;
using Primeiro_Projeto.Model_s;
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
    public partial class ConfirmarEmail : Form
    {
        DataBase confirmandoEmail = new DataBase();
        private int Id;
        //private string Nome;
        //private string Senha;
        private string Email;
        // private int Escolha = 1;
        public ConfirmarEmail() // (int escolha)
        {
            // Escolha = escolha;
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
                if (!txtEmail.Text.Equals(""))
                {
                    Pessoa enviar = new Pessoa();
                    enviar.email = txtEmail.Text;

                    List<Pessoa> retorno = confirmandoEmail.ValidarLoginEmail(enviar);

                    foreach (var item in retorno)
                    {
                        Id = item.id;
                        Email = item.email;
                    }


                    //    if (Escolha == 1)
                    //    {
                    //        confirmandoEmail.Email = txtEmail.Text;
                    //        List<Cliente> retorno = confirmandoEmail.ValidarLoginCliente();
                    //        foreach (var item in retorno)
                    //        {
                    //            Nome = item.Nome;
                    //            Senha = item.Senha;
                    //            Email = item.Email;
                    //        }
                    //    }
                    //    else if (Escolha == 2)
                    //    {
                    //        confirmandoEmail.email = txtEmail.Text;
                    //        List<Funcionario> retorno = confirmandoEmail.ValidarLoginFuncionario();
                    //        foreach (var item in retorno)
                    //        {
                    //            Nome = item.nome;
                    //            Senha = item.senha;
                    //            Email = item.email;
                    //        }
                    //    }
                    if (Email == txtEmail.Text)
                    {
                        NovoUsuarioSenha novo = new NovoUsuarioSenha(Id);
                        novo.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("E-mail não cadastrado!!", "Atenção!",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("O email não pode estar vazio!!", "Atenção!",
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
