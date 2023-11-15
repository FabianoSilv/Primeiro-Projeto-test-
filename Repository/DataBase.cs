using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Primeiro_Projeto.Model_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Primeiro_Projeto.Repository
{
    internal class DataBase
    {
        public static string data_source = "datasource=localhost;username=root;password=123;database=empresa";
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection(data_source);

        private string nome;
        private string cpf;
        private string telefone;
        private string email;
        private string pesquisa;
        private int ?id_funcionario = null;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Pesquisa
        {
            get { return pesquisa; }
            set { pesquisa = value; }
        }
        public void CadastrarCliente()
        {
            try
            {

                if (!nome.Equals("") && !cpf.Equals("") && !telefone.Equals("") && !email.Equals(""))
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = "INSERT INTO cliente (nome, cpf, telefone, email)" +
                                          "VALUES" +
                                          "(@nome, @cpf, @telefone, @email)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Cliente {nome} cadastrado com sucesso", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Obrigatório NOME, CPF, Telefone e E-Mail", "Atenção!",
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
                MessageBox.Show("Ocorreu um erro " + ex.Message,
                            "Erro", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public List<Cliente> PesquisarCliente()
        {
            try
            {
                if (!pesquisa.Equals(""))
                {   
                 List<Cliente> lstCliente = new List<Cliente>();
                    conn.Open();
                    cmd.Connection = conn;


                    cmd.CommandText = "SELECT * FROM cliente WHERE nome LIKE (@q) OR cpf LIKE (@q) ";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@q", "%" + pesquisa + "%");

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                       Cliente row =new Cliente();


                        row.Id = reader.GetInt32(0);
                        row.Nome = reader.GetString(1);
                        row.CPF = reader.GetString(2);
                        row.Telefone = reader.GetString(3);
                        row.Email = reader.GetString(4);

                        lstCliente.Add(row);
                        
                       
                    }

                    return lstCliente;
                }
                else
                {
                    MessageBox.Show("Necessario preencher com Nome ou CPF", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + "ocorreu" + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message,
                            "Erro", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                return null;
            }
            finally
            {

                conn.Close();
                

            }
        }
        public void AtualizarCliente()
        {
            cmd.Connection= conn;
            conn.Open();

            cmd.CommandText = "UPDATE cliente SET " +
                              "nome=@nome, cpf=@cpf, telefone=@telefone, email=@email " +
                              "WHERE id=@id ";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@cpf", Cpf);
            cmd.Parameters.AddWithValue("@telefone", Telefone);
            cmd.Parameters.AddWithValue("@email", Email);
            //cmd.Parameters.AddWithValue("@id", //colocar variavel id);
        }
    }
}
