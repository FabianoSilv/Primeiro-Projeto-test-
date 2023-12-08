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

namespace Primeiro_Projeto
{
    public partial class TelaLogin : Form
    {
        DataBase validando = new DataBase();
        public string nivelacesso;
        private string Usuario;
        private string Senha;
        private string complemento;
        private string cpf = "";

        MenuRestrito menurestrito;
        public TelaLogin(MenuRestrito f)
        {
            InitializeComponent();
            menurestrito = f;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastrar = new Cadastro();
            cadastrar.ShowDialog();

           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
          
            ConfirmarEmail confirmar = new ConfirmarEmail();
            confirmar.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!txtUsuario.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    Pessoa enviar = new Pessoa();
                    enviar.nome = txtUsuario.Text;
                    enviar.senha = txtSenha.Text;
                    validando.selectValidador = 1;

                    List<Pessoa> retorno = validando.ValidarLoginEmail(enviar);

                    foreach (var item in retorno)
                    {
                        cpf = item.cpf;
                        Usuario = item.nome;
                        Senha = item.senha;
                        nivelacesso = item.acesso;
                        complemento = item.complemento;
                    }

                    if (txtUsuario.Text == Usuario && txtSenha.Text == Senha)
                    {
                        menurestrito.lbNomeUsuario.Text = Usuario;
                        menurestrito.pbImagemLogin.Image = Properties.Resources.led_verde;
                        menurestrito.lbNivelAcesso.Text = complemento;
                        menurestrito.cpf.Text = cpf;
                        menurestrito.nivelAcesso = Convert.ToInt32(nivelacesso);
                        menurestrito.logado = true;
                      
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usario ou senha incorreto!", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Prencha todos os campos", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtUsuario.Focus();
                txtSenha.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_Funcionario_CheckedChanged(object sender, EventArgs e)
        {
            // escolha = 2;

        }

        private void rb_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            // escolha = 1;
        }
    }
}
