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
    public partial class Form1 : Form
    {
        DataBase validando = new DataBase();
        private string nome;
        private string senha;
        private int? id_funcionario = null;
        private string Email = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deu certo!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela1();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!txtUsuario.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    //validando.NomeFuncionario = txtUsuario.Text;
                    //validando.SenhaFuncionario = txtSenha.Text;
                    //int validado = 0;
                    //validando.validador = validado;
                    //List<Funcionario> retorno = validando.ValidarLoginFuncionario();
                    //foreach (var item in retorno)
                    //{
                    //    nome = item.nome;
                    //    senha = item.senha;
                    //}
                }
                if (txtUsuario.Text == nome && txtSenha.Text == senha)
                {
                   // var MenuRestrito = new MenuRestrito();
                    //this.Visible = false;
                    //MenuRestrito.ShowDialog();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Usario ou senha incorreto!",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                    txtUsuario.Focus();
                    txtSenha.Text = "";

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.LightBlue;

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.White;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.LightBlue;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 8 && tecla != 32)
            {
                e.Handled = true;
                MessageBox.Show("Somente letras e numeros!",
                                "Eita!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);


            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 8)
            {
                e.Handled = true;
                MessageBox.Show("Somente letras e numeros sem espaço!",
                                "Eita!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);


            }
        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            Tela1();

            //Cadastrar cadastro = new Cadastrar();

           // cadastro.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            Tela2();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtemail.Text.Equals(""))
                {

                    //validando.email = txtemail.Text;
                    //List<Funcionario> retorno = validando.ValidarLoginFuncionario();
                    //foreach (var item in retorno)
                    //{
                    //    nome = item.nome;
                    //    senha = item.senha;
                    //    Email = item.email;
                    //}
                    if (Email == txtemail.Text)
                    {
                        Tela3();
                    }
                    else
                    {
                        MessageBox.Show("EMAIL NÃO cadastrado!!", "Atenção!",
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

        private void Tela1()
        {
            txtNOVA.Visible = false;
            txtNOVO.Visible = false;
            btnConfirmar.Visible = false;
            NOVA.Visible = false;
            NOVO.Visible = false;
            label1.Visible = false;
            txtemail.Visible = false;
            btnAtualizar.Visible = false;
            btnAlterar.Visible = true;
            U.Visible = true;
            S.Visible = true;
            txtUsuario.Visible = true;
            txtSenha.Visible = true;
            button1.Visible = true;
        }
        private void Tela2()
        {
            btnConfirmar.Visible = true;
            txtemail.Visible = true;
            label1.Visible = true;

            btnAlterar.Visible = true;

            U.Visible = false;
            S.Visible = false;

            txtUsuario.Visible = false;
            txtSenha.Visible = false;
            button1.Visible = false;
            btnAtualizar.Visible = false;
        }
        private void Tela3()
        {
            txtNOVA.Visible = true;
            txtNOVO.Visible = true;
            btnAtualizar.Visible = true;
            NOVA.Visible = true;
            NOVO.Visible = true;
            btnConfirmar.Visible = false;

            btnAlterar.Visible = false;
            label1.Visible = false;
            txtemail.Visible = false;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                

                if(txtNOVA.Text != senha && !txtNOVA.Text.Equals("") && !txtNOVO.Text.Equals("")) 
                {

                    //validando.NomeFuncionario = txtNOVO.Text;
                    //validando.SenhaFuncionario = txtNOVA.Text;

                    //validando.AtualizarFuncionario();
                    //Tela1();

                }
                else
                {
                    MessageBox.Show("Os campos não podem estar vazios. \n\nNova senha não pode ser igual a anterior!", "Atenção!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
