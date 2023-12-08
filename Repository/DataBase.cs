using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Primeiro_Projeto.Model;
using Primeiro_Projeto.Model_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Primeiro_Projeto.Repository
{
    internal class DataBase
    {
        private static string data_source = "datasource=localhost;username=root;password=123;database=empresa";
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection(data_source);

        public int selectValidador { get; set; } //SELECIONAR IF UNIVERSAL
        public string pesquisa { get; set; } // PESQUISA UNIVERSAL

        public void CadastrarPessoa(Pessoa receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "insert into pessoa (nome, cpf, telefone, email, senha, acesso, complemento) " +
                                  "values" +
                                  "(@nome, @cpf, @telefone, @email, @senha, @acesso, @complemento) ";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nome", receber.nome);
                cmd.Parameters.AddWithValue("@cpf", receber.cpf);
                cmd.Parameters.AddWithValue("@telefone", receber.telefone);
                cmd.Parameters.AddWithValue("@email", receber.email);
                cmd.Parameters.AddWithValue("@senha", receber.senha);
                cmd.Parameters.AddWithValue("@acesso", receber.acesso);
                cmd.Parameters.AddWithValue("@complemento", receber.complemento);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro {ex.Number} ocorreu {ex.Message}", "ERRO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public List<Pessoa> ValidarLoginEmail(Pessoa receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                if (selectValidador == 1)
                {
                    cmd.CommandText = "select * from pessoa where nome=@nome and senha=@senha";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nome", receber.nome);
                    cmd.Parameters.AddWithValue("@senha", receber.senha);
                }
                else
                {
                    cmd.CommandText = "select * from pessoa where email=@email ";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@email", receber.email);
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (reader.Read())
                {
                    Pessoa row = new Pessoa();

                    row.id = reader.GetInt32(0);
                    row.nome = reader.GetString(1);
                    row.cpf = reader.GetString(2);
                    row.telefone = reader.GetString(3);
                    row.email = reader.GetString(4);
                    row.senha = reader.GetString(5);
                    row.acesso = reader.GetString(6);
                    row.complemento = reader.GetString(7);

                    lista.Add(row);
                }
                return lista;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro {ex.Number} ocorreu {ex.Message}", "ERRO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public void AtualizarPessoa(Pessoa receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                if (selectValidador == 1)
                {
                    cmd.CommandText = "update pessoa set " +
                                      "nome=@nome, telefone=@telefone, email=@email " +
                                      "where id=@id";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nome", receber.nome);
                    cmd.Parameters.AddWithValue("@telefone", receber.telefone);
                    cmd.Parameters.AddWithValue("email", receber.email);
                    cmd.Parameters.AddWithValue("@id", receber.id);
                }
                else
                {
                    cmd.CommandText = "update pessoa set nome=@nome, senha=@senha where id=@id";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nome", receber.nome);
                    cmd.Parameters.AddWithValue("@senha", receber.senha);
                    cmd.Parameters.AddWithValue("@id", receber.id);
                }

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro {ex.Number} ocorreu {ex.Message}", "ERRO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public List<Pessoa> ListarCliente(Pessoa receber)
        {
            try
            {
                List<Pessoa> listaCliente = new List<Pessoa>();

                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "SELECT * FROM pessoa where complemento=@complemento ORDER BY id DESC ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@complemento", receber.complemento);

                MySqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Pessoa row = new Pessoa();
                    {
                        row.id = read.GetInt32(0);
                        row.nome = read.GetString(1);
                        row.cpf = read.GetString(2);
                        row.telefone = read.GetString(3);
                        row.email = read.GetString(4);
                        row.senha = read.GetString(5);
                        row.acesso = read.GetString(6);
                        row.complemento = read.GetString(7);
                    };
                    listaCliente.Add(row);
                }
                return listaCliente;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + "ocorreu" + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally { conn.Close(); }
        }
        public List<Pessoa> PesquisarPessoa(Pessoa receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "select * from pessoa where complemento=@complemento " +
                                " and nome like (@q) or complemento=@complemento and cpf like (@q) ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@complemento", receber.complemento);
                cmd.Parameters.AddWithValue("@q", "%" + pesquisa + "%");

                List<Pessoa> pesquisarCliente = new List<Pessoa>();
                MySqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Pessoa row = new Pessoa();

                    row.id = read.GetInt32(0);
                    row.nome = read.GetString(1);
                    row.cpf = read.GetString(2);
                    row.telefone = read.GetString(3);
                    row.email = read.GetString(4);
                    row.senha = read.GetString(5);
                    row.acesso = read.GetString(6);
                    row.complemento = read.GetString(7);

                    pesquisarCliente.Add(row);
                }
                return pesquisarCliente;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro {ex.Number} ocorreu {ex.Message}", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public void ExcluirPessoa(Pessoa receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "delete from pessoa where id=@id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", receber.id);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro {ex.Number} ocorreu {ex.Message}", "ERRO",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public List<Filme> ListarFilme()
        {
            try
            {
                List<Filme> lstfilme = new List<Filme>();
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "SELECT * FROM filme ORDER BY id DESC ";

                MySqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Filme row = new Filme();
                    {
                        row.Id = read.GetInt32(0);
                        row.Nome = read.GetString(1);
                        row.Ano = read.GetInt32(2);
                        row.Duração = read.GetString(3);
                        row.Classificação = read.GetString(4);
                        row.Genero = read.GetString(5);
                        row.Sinopse = read.GetString(6);
                        row.Capa = read.GetString(7);
                    };
                    lstfilme.Add(row);
                }
                return lstfilme;
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
        public void CadastrarFilme(Filme receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "INSERT INTO filme (nome, ano, duração, classificação, genero, sinopse, capa)" +
                                      "VALUES" +
                                      "(@nome, @ano, @duração, @classificação, @genero, @sinopse, @capa)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nome", receber.Nome);
                cmd.Parameters.AddWithValue("@ano", receber.Ano);
                cmd.Parameters.AddWithValue("@duração", receber.Duração);
                cmd.Parameters.AddWithValue("@classificação", receber.Classificação);
                cmd.Parameters.AddWithValue("@genero", receber.Genero);
                cmd.Parameters.AddWithValue("@sinopse", receber.Sinopse);
                cmd.Parameters.AddWithValue("@capa", receber.Capa);

                cmd.ExecuteNonQuery();

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
        public List<Filme> PesquisarFilme(Filme receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                if (!receber.Nome.Equals(""))
                {
                    List<Filme> listFilmeNome = new List<Filme>();
                    cmd.CommandText = "SELECT * FROM filme WHERE nome LIKE (@q) ";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@q", "%" + receber.Nome + "%");

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Filme row = new Filme();

                        row.Id = reader.GetInt32(0);
                        row.Nome = reader.GetString(1);
                        row.Ano = reader.GetInt32(2);
                        row.Duração = reader.GetString(3);
                        row.Classificação = reader.GetString(4);
                        row.Genero = reader.GetString(5);
                        row.Sinopse = reader.GetString(6);
                        row.Capa = reader.GetString(7);

                        listFilmeNome.Add(row);
                    }
                    return listFilmeNome;
                }
                else
                {
                    List<Filme> listFilmeGenero = new List<Filme>();

                    cmd.CommandText = "SELECT * FROM filme WHERE genero LIKE (@q)";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@q", receber.Genero);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Filme row = new Filme();

                        row.Id = reader.GetInt32(0);
                        row.Nome = reader.GetString(1);
                        row.Ano = reader.GetInt32(2);
                        row.Duração = reader.GetString(3);
                        row.Classificação = reader.GetString(4);
                        row.Genero = reader.GetString(5);
                        row.Sinopse = reader.GetString(6);
                        row.Capa = reader.GetString(7);

                        listFilmeGenero.Add(row);
                    }
                    return listFilmeGenero;
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
        public void AtualizarFilme(Filme receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "UPDATE filme set " +
                                  "sinopse=@sinopse, capa=@capa " +
                                  "where id=@id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sinopse", receber.Sinopse);
                cmd.Parameters.AddWithValue("@capa", receber.Capa);
                cmd.Parameters.AddWithValue("@id", receber.Id);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro {ex.Number} ocorreu {ex.Message}", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void DeletarFilme(Filme receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "DELETE FROM filme WHERE id=@id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", receber.Id);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message,
                            "Erro", MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
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
        public void AdicionarFila(Fila receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "insert into fila (nomefilme, pessoa) value (@nomefilme, @pessoa)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomefilme", receber.nomefilme);
                cmd.Parameters.AddWithValue("@pessoa", receber.pessoa);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro {ex.Number} ocorreu {ex.Message}", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public List<Fila> ListarFila(Fila receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                // comando relacionado ao resumo no forms perfil

                //cmd.CommandText = "Select * from fila where pessoa=@pessoa order by id desc";

                //cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@pessoa", receber.pessoa);
                //MySqlDataReader reader = cmd.ExecuteReader();

                //List<Fila> resumo = new List<Fila>();

                //while (reader.Read())
                //{
                //    Fila row = new Fila();

                //    row.nomefilme = reader.GetString(1);
                //    row.pessoa = reader.GetString(2);
                //    row.datainicial = reader.GetString(3);
                //    row.datafinal = reader.GetString(4);

                //    resumo.Add(row);
                //}
                //return resumo;



                cmd.CommandText = " select * from fila where nomefilme=@nomefilme order by id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomefilme", receber.nomefilme);

                MySqlDataReader reader = cmd.ExecuteReader();
                List<Fila> ListaFilaFilme = new List<Fila>();
                while (reader.Read())
                {
                    Fila row = new Fila();

                    row.nomefilme = reader.GetString(1);
                    row.pessoa = reader.GetString(2);

                    ListaFilaFilme.Add(row);
                }
                return ListaFilaFilme;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro {ex.Number} ocorreu {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public void AlterarFila(Fila receber)
        {
            try
            {
                cmd.Connection = conn;
                conn.Open();

                if (selectValidador == 1) // zerar fila
                {
                    cmd.CommandText = "Delete from fila where nomefilme=@nomefilme";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nomefilme", receber.nomefilme);

                    cmd.ExecuteNonQuery();
                }
                else if (selectValidador == 2) // retirar pessoa da fila
                {
                    cmd.CommandText = "Delete from fila where nomefilme=@nomefilme and pessoa=@pessoa";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nomefilme", receber.nomefilme);
                    cmd.Parameters.AddWithValue("@pessoa", receber.pessoa);

                    cmd.ExecuteNonQuery();
                }
                else // retirar o primeiro nome da fila
                {
                    string pessoa;
                    cmd.CommandText = "Select pessoa from fila where nomefilme=@nomefilme order by id";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nomefilme", receber.nomefilme);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        pessoa = reader["pessoa"].ToString();

                        conn.Close();
                        conn.Open();
                        cmd.CommandText = "delete from fila where nomefilme=@nomefilme and pessoa=@pessoa";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@nomefilme", receber.nomefilme);
                        cmd.Parameters.AddWithValue("@pessoa", pessoa);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro {ex.Number} ocorreu {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}