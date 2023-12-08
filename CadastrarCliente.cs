using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Primeiro_Projeto
{
    public partial class CadastrarCliente : Form
    {
        Pessoa enviar = new Pessoa();
        DataBase cliente = new DataBase();
        private int? Id_selecionada = null;
        private int validado = 0;
        public CadastrarCliente()
        {
            InitializeComponent();

            Lst_View.Columns.Add("Id", 30, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Nome", 70, HorizontalAlignment.Left);
            Lst_View.Columns.Add("CPF", 80, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Telefone", 80, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Email", 100, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Complemento", 70, HorizontalAlignment.Left);

            ListarContatos();
        }

        private void LimparCampos()
        {
            mskCPF.ReadOnly = false;
            txtNome.Text = string.Empty;
            mskCPF.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPesquisar.Text = string.Empty;
            Id_selecionada = null;
        }

        private void AdicionarItemListView(int coluna1, string coluna2, string coluna3,
                                           string coluna4, string coluna5, string coluna6)
        {
            ListViewItem item = new ListViewItem(coluna1.ToString());
            item.SubItems.Add(coluna2);
            item.SubItems.Add(coluna3);
            item.SubItems.Add(coluna4);
            item.SubItems.Add(coluna5);
            item.SubItems.Add(coluna6);
         
            Lst_View.Items.Add(item);
        }

        private void ListarContatos()
        {
            try
            {
                enviar.complemento = "Cliente";

                Lst_View.Items.Clear();
                List<Pessoa> listarCliente = cliente.ListarCliente(enviar);
                foreach (var item in listarCliente)
                {
                    AdicionarItemListView(item.id, item.nome, item.cpf, item.telefone, item.email, item.complemento);
                }
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id_selecionada == null && !txtNome.Text.Equals("") && !mskCPF.Text.Equals("")
                    && !mskTelefone.Text.Equals("") && !txtEmail.Text.Equals(""))
                {
                    enviar.nome = txtNome.Text;
                    enviar.cpf = mskCPF.Text;
                    enviar.telefone = mskTelefone.Text;
                    enviar.email = txtEmail.Text;
                    enviar.senha = "padrao";
                    enviar.acesso = "1";
                    enviar.complemento = "Cliente";

                    cliente.CadastrarPessoa(enviar);

                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    ListarContatos();
                }
                else if (Id_selecionada != null)
                {
                    LimparCampos();
                    MessageBox.Show("Todos os campos devem estar vazios para adicionar um contato!", "Atenção!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Obrigatório Nome, CPF, Telefone e E-Mail", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro" + ex.Number + "ocorreu" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPesquisar.Text.Equals(""))
                {
                    enviar.complemento = "Cliente";
                    cliente.pesquisa = txtPesquisar.Text;

                    Lst_View.Items.Clear();
                    List<Pessoa> pesquisarCliente = cliente.PesquisarPessoa(enviar);
                    foreach (var item in pesquisarCliente)
                    {
                        AdicionarItemListView(item.id, item.nome, item.cpf, item.telefone, item.email, item.complemento);
                    }
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Para a pesquisa ser mais precisa, digite " +
                                    "no campo indicado um Nome ou CPF", "Atenção",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarContatos();
                }
                //if (!txtPesquisar.Text.Equals(""))
                //{
                //    cliente.Pesquisa = txtPesquisar.Text;
                //    Lst_View.Items.Clear();

                //    List<Cliente> listPesquisa = cliente.PesquisarCliente();

                //    foreach (var item in listPesquisa)
                //    {
                //        AdicionarItemListView(item.Id, item.Nome, item.CPF.ToString(), item.Telefone, item.Email);
                //    }
                //    LimparCampos();
                //}
                //else
                //{
                //    ListarContatos();
                //    MessageBox.Show("Para uma pesquisa mais precisa, preencha com Nome ou CPF", "Atenção",
                //                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Lst_View_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionada = Lst_View.SelectedItems;

            foreach (ListViewItem item in itens_selecionada)
            {
                mskCPF.ReadOnly = true;
                Id_selecionada = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                mskCPF.Text = item.SubItems[2].Text;
                mskTelefone.Text = item.SubItems[3].Text;
                txtEmail.Text = item.SubItems[4].Text;
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id_selecionada != null)
                {
                    cliente.selectValidador = validado = 1;
                    enviar.id = Convert.ToInt32(Id_selecionada);
                    enviar.nome = txtNome.Text;
                    //cliente.Cpf_Pessoa = mskCPF.Text;
                    enviar.telefone = mskTelefone.Text;
                    enviar.email = txtEmail.Text;
                    //cliente.NivelCliente = "1";
                    cliente.AtualizarPessoa(enviar);

                    MessageBox.Show($"Cliente {txtNome.Text}, atualizado com sucesso!", "Conluido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    LimparCampos();
                    ListarContatos();
                }
                else
                {
                    MessageBox.Show("Selecione na lista o contato que deseja atualizar", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Lst_View_Click(object sender, EventArgs e)
        {

        }
        private void cmsExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Contato \n{txtNome.Text} \n{mskCPF.Text} \npara excluir", "ATENÇÃO",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DialogResult confirmarExcluir = MessageBox.Show($"Deseja excluir " +
                                                $"\n{txtNome.Text} \n{mskCPF.Text} \nEste processo é irreversivel!",
                                                "CUIDADO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (DialogResult.Yes == confirmarExcluir)
                {
                    enviar.id = Convert.ToInt32(Id_selecionada);
                    // cliente.Nome = txtNome.Text;
                    // cliente.Cpf = mskCPF.Text;
                    cliente.ExcluirPessoa(enviar);

                    MessageBox.Show("Cliente excluido com sucesso", "Concluido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    LimparCampos();
                    ListarContatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
