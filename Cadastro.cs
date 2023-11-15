using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Primeiro_Projeto
{
    public partial class Cadastro : Form
    {
        static string data_source = "datasource=localhost;username=root;password=H6t4pozb;database=test";
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection(data_source);
        private int ?id_contato_selecionado = null;
       
        
        public Cadastro()
        {
            InitializeComponent();

            list_view.View = View.Details;
            list_view.AllowColumnReorder = true;


            list_view.Columns.Add("ID", 50, HorizontalAlignment.Left);
            list_view.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            list_view.Columns.Add("Telefone", 100, HorizontalAlignment.Left);
            list_view.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            list_view.Columns.Add("Sexo", 60, HorizontalAlignment.Left);

            
            ListarContatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNome.Text) && 
                    !string.IsNullOrEmpty(txtCPF.Text) &&
                    !string.IsNullOrEmpty(txtSexo.Text) &&
                    id_contato_selecionado == null)
                {
                    conn.Open();
                    cmd.Connection = conn;

                    cmd.CommandText = "INSERT INTO cadastro (nome, telefone, cpf, sexo)" +
                                      "VALUES" +
                                      "(@nome, @telefone, @cpf, @sexo)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@sexo", txtSexo.Text);

                    cmd.ExecuteNonQuery();

                    

                }
                else if (!string.IsNullOrEmpty(txtNome.Text) &&
                    !string.IsNullOrEmpty(txtCPF.Text) &&
                    !string.IsNullOrEmpty(txtSexo.Text) &&
                    id_contato_selecionado != null)
                {
                    conn.Open();
                    cmd.Connection = conn;

                    cmd.CommandText = "UPDATE cadastro SET " +
                                      "nome=@nome, telefone=@telefone, cpf=@cpf, sexo=@sexo " +
                                      "WHERE id=@id ";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@sexo", txtSexo.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato atualizado com sucesso!", "Concluido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                else
                {
                    MessageBox.Show("Obrigatório NOME, CPF e Sexo", "Atenção!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                id_contato_selecionado = null;
                txtNome.Text = string.Empty;
                txtTelefone.Text = string.Empty;
                txtCPF.Text = string.Empty;
                txtSexo.Text = string.Empty;
                


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + "ocorreu" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message,
                            "Erro", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                ListarContatos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                conn.Open();
                cmd.Connection = conn;

                
                cmd.CommandText = "SELECT * FROM cadastro WHERE nome LIKE (@q) OR cpf LIKE (@q) ";
                
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");

                MySqlDataReader read = cmd.ExecuteReader();

                list_view.Items.Clear();

                while (read.Read())
                {
                    string[] row =
                    {
                        read.GetString(0),
                        read.GetString(1),
                        read.GetString(2),
                        read.GetString(3),
                        read.GetString(4),

                    };

                    list_view.Items.Add(new ListViewItem(row)); 
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + "ocorreu" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message,
                            "Erro", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void ListarContatos()
        {
            try
            {

                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM cadastro ORDER BY id DESC ";

                cmd.Prepare();


                MySqlDataReader read = cmd.ExecuteReader();

                list_view.Items.Clear();
                
                while (read.Read())
                {
                    string[] row =
                    {
                        read.GetString(0),
                        read.GetString(1),
                        read.GetString(2),
                        read.GetString(3),
                        read.GetString(4),

                    };
  
                    list_view.Items.Add(new ListViewItem(row));

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + "ocorreu" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message,
                            "Erro", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void list_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionada = list_view.SelectedItems;

            foreach(ListViewItem item in itens_selecionada) 
            {
                id_contato_selecionado = Convert.ToInt32( item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtTelefone.Text = item.SubItems[2].Text;
                txtCPF.Text = item.SubItems[3].Text;
                txtSexo.Text = item.SubItems[4].Text;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(id_contato_selecionado != null)
            {

            }
        }

        private void txtCPF_Click(object sender, EventArgs e)
        {
            //if (txtCPF.Text != txtCPF.Text)
            //{
            //    id_contato_selecionado = null;
            //}
            //else
            //{
            //    MessageBox.Show("CPF deve ser unico para cada pessoa!",
            //                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //};
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

            try
            {
               DialogResult conf = MessageBox.Show("Você tem certeza que deseja escliu este contato?" +
                           "\nNome: " + txtNome.Text + "\nCPF: " + txtCPF.Text,
                           "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (conf == DialogResult.Yes) 
                {
                    conn.Open();

                    cmd.CommandText = "DELETE FROM cadastro WHERE id=@id ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato escluido com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message,
                            "Erro", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message,
                "Erro", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                ListarContatos();

            }
        

           
        }
    }
}

