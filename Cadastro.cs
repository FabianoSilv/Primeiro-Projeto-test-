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

namespace Primeiro_Projeto
{
    public partial class Cadastro : Form
    { DataBase cadastrar = new DataBase();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!txt_Nome.Text.Equals("") && !mtb_CPF.Text.Equals("") && !mtb_Telefone.Text.Equals("")
                   && !txt_Email.Text.Equals("") && !txt_Senha.Text.Equals(""))
                {
                    Pessoa enviar = new Pessoa();
                    
                    enviar.nome = txt_Nome.Text;
                    enviar.cpf = mtb_CPF.Text;
                    enviar.telefone = mtb_Telefone.Text;
                    enviar.email = txt_Email.Text;
                    enviar.senha = txt_Senha.Text;
                    enviar.acesso = "2";
                    enviar.complemento = "Funcionario";

                    cadastrar.CadastrarPessoa(enviar);

                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Obrigatorio preencher todos os campos!", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
