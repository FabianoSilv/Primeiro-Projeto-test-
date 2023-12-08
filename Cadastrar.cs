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
    public partial class Cadastrar : Form
    {
        DataBase novo = new DataBase();

        private int Escolha = 1;
        public Cadastrar(int escolha)
        {
            Escolha = escolha;
            InitializeComponent();
        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtSenha.Text.Equals("") && !txtEmail.Text.Equals(""))
                {

                    if (Escolha == 1 && !mtb_CPF.Text.Equals("") && !mtb_Telefone.Text.Equals(""))
                    {
                        //    novo.Nome = txtNome.Text;
                        //    novo.Cpf = mtb_CPF.Text;
                        //    novo.Telefone = mtb_Telefone.Text;
                        //    novo.Email = txtEmail.Text;
                        //    novo.Senha = txtSenha.Text;
                        //    novo.NivelCliente = Escolha.ToString();

                        //    //novo.CadastrarCliente();
                        //    this.Close();
                    }
                    else if (Escolha == 2)
                    {

                        //novo.email = txtEmail.Text;
                        //novo.NomeFuncionario = txtNome.Text;
                        //novo.SenhaFuncionario = txtSenha.Text;
                        //novo.nivelfunc = Escolha.ToString();

                        //novo.CadastrarFuncionario();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Obrigatório preencher TODOS os CAMPOS", "Atenção!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Obrigatório preencher TODOS os CAMPOS", "Atenção!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
