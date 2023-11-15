using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Primeiro_Projeto
{
    public partial class CadastrarCliente : Form
    {
        DataBase cliente = new DataBase();

        public CadastrarCliente()
        {
            InitializeComponent();

            Lst_View.Columns.Add("Nome", 50, HorizontalAlignment.Left);
            Lst_View.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Email", 100, HorizontalAlignment.Left);
            

           

        }

        private void LimparCampos()
        {
            //id_contato_selecionado = null;
            txtNome.Text = string.Empty;
            mskCPF.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                    cliente.Nome = txtNome.Text;
                    cliente.Cpf = mskCPF.Text;
                    cliente.Telefone = mskTelefone.Text;
                    cliente.Email = txtEmail.Text;

                    cliente.CadastrarCliente();
                    LimparCampos();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro" + ex.Number + "ocorreu" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void AdicionarItemListView(string coluna1, string coluna2, string coluna3,string coluna4)
        {
            ListViewItem item = new ListViewItem(coluna1);
            item.SubItems.Add(coluna2);
            item.SubItems.Add(coluna3);
            item.SubItems.Add(coluna4);
            Lst_View.Items.Add(item);
        }


        private void btnPesquisar_Click(object sender, EventArgs e) // TA INCOMPLETO
        {
            try
            {
                
                
                    cliente.Pesquisa = txtPesquisar.Text;
                    cliente.PesquisarCliente();
                    Lst_View.Items.Clear();

                List<Cliente> list = cliente.PesquisarCliente();



                foreach (var item in list)
                {

                    AdicionarItemListView(item.Nome, item.CPF.ToString(), item.Telefone, item.Email);



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }
    }
}
