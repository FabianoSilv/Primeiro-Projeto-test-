using Google.Protobuf.WellKnownTypes;
using Primeiro_Projeto.Model_s;
using Primeiro_Projeto.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Primeiro_Projeto
{
    public partial class ListarFilmes : Form
    {
        Filme enviar = new Filme();
        DataBase filme = new DataBase();
        private int? id_filme = null;
        private string nomeFilme;
        private int AnoFilme;
        private string sinopse;
        private string capa;

        private static string caminho = System.Environment.CurrentDirectory;
        private string pastaDestino = caminho + @"\ImgCapa\";
        private string destinoImagem;
        private string origemNovaImagem;


        public ListarFilmes()
        {
            InitializeComponent();

            Lst_View.Columns.Add("Id", 30, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Ano", 40, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Duração", 80, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Classificação", 70, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Genero", 50, HorizontalAlignment.Left);
            Lst_View.Columns.Add("Sinopse", 300, HorizontalAlignment.Left);

            ListaFilmes();
        }
        private void LimparCampos()
        {
            id_filme = null;
            txtNomeFilme.Text = string.Empty;
            cbGenero.Text = null;
            txtRetornoCarac.Text = string.Empty;
            txtReturnName.Text = string.Empty;
            rtbRetornoSinopse.Text = string.Empty;
            picView.Image = null;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
            lbGenero.Visible = true;
            cbGenero.Visible = true;
            cbGenero.Enabled = true;

            lbNomeFilme.Visible = false;
            txtNomeFilme.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
            lbNomeFilme.Visible = true;
            txtNomeFilme.Visible = true;
            cbGenero.Enabled = false;

            lbGenero.Visible = false;
            cbGenero.Visible = false;

        }

        private void btnPesquisarNome_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNomeFilme.Text.Equals(""))
                {
                    enviar.Nome = txtNomeFilme.Text;

                    List<Filme> lista = new List<Filme>(filme.PesquisarFilme(enviar));
                    Lst_View.Items.Clear();
                    foreach (var item in lista)
                    {
                        AdicionarItemListView(item.Id, item.Nome, item.Ano.ToString(), item.Duração,
                            item.Classificação, item.Genero, item.Sinopse, item.Capa);
                    }
                    enviar.Nome = "";
                }
                else if (!cbGenero.Text.Equals(""))
                {

                    enviar.Genero = cbGenero.Text;
                    List<Filme> lista = new List<Filme>(filme.PesquisarFilme(enviar));
                    Lst_View.Items.Clear();
                    foreach (var item in lista)
                    {
                        AdicionarItemListView(item.Id, item.Nome, item.Ano.ToString(), item.Duração,
                            item.Classificação, item.Genero, item.Sinopse, item.Capa);
                    }

                }
                else
                {
                    MessageBox.Show("Insira todos os dados para pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    ListaFilmes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AdicionarItemListView(int coluna1, string coluna2, string coluna3, string coluna4,
                                            string coluna5, string coluna6, string coluna7, string coluna8)
        {
            ListViewItem item = new ListViewItem(coluna1.ToString());
            item.SubItems.Add(coluna2);
            item.SubItems.Add(coluna3);
            item.SubItems.Add(coluna4);
            item.SubItems.Add(coluna5);
            item.SubItems.Add(coluna6);
            item.SubItems.Add(coluna7);
            item.SubItems.Add(coluna8);
            Lst_View.Items.Add(item);
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedListViewItemCollection lista = Lst_View.SelectedItems;
                foreach (ListViewItem item in lista)
                {
                    enviar.Id = Convert.ToInt32(item.SubItems[0].Text);
                    enviar.Nome = Convert.ToString(item.SubItems[1].Text);
                    enviar.Ano = Convert.ToInt32(item.SubItems[2].Text);
                }

                if (id_filme != null)
                {
                    MessageBox.Show("Você selecionou o " +
                          "\n\nFilme: " + nomeFilme + "\nAno: " + AnoFilme + "\n\n para EXCLUIR e este processo é IRREVERSIVEL!",
                          "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult conf = MessageBox.Show("VOCÊ TEM CERTEZA QUE DESEJA EXCLUIR ESTE FILME?" +
                                "\n\nFilme: " + nomeFilme + "\nAno: " + AnoFilme,
                                "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (conf == DialogResult.Yes)
                    {
                        if (File.Exists(picView.ImageLocation))
                        {
                            File.Delete(picView.ImageLocation);
                        }

                        enviar.Id = Convert.ToInt32(id_filme);
                        filme.DeletarFilme(enviar);

                        MessageBox.Show("Filme excluido com sucesso!",
                              "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Para EXCLUIR é preciso escolher um filme", "Atenção!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                ListaFilmes();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListaFilmes()
        {
            try
            {
                Lst_View.Items.Clear();

                List<Filme> listarfilmes = new List<Filme>(filme.ListarFilme());

                foreach (var item in listarfilmes)
                {
                    AdicionarItemListView(item.Id, item.Nome, item.Ano.ToString(), item.Duração,
                        item.Classificação, item.Genero, item.Sinopse, item.Capa);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Lst_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection filmeSlecionado = Lst_View.SelectedItems;

            foreach (ListViewItem item in filmeSlecionado)
            {
                id_filme = Convert.ToInt32(item.SubItems[0].Text);
                txtReturnName.Text = item.SubItems[1].Text;
                txtRetornoCarac.Text = item.SubItems[2].Text + "  |  " + item.SubItems[4].Text + "  |  " +
                                       item.SubItems[3].Text + " Min " + "  |  " + item.SubItems[5].Text;
                rtbRetornoSinopse.Text = item.SubItems[6].Text;
                sinopse = item.SubItems[6].Text;
                picView.ImageLocation = Convert.ToString(item.SubItems[7].Text);
                capa = Convert.ToString(item.SubItems[7].Text);

            }
        }

        private void rtbRetornoSinopse_MouseClick(object sender, MouseEventArgs e)
        {
            if (id_filme != null)
            {
                rtbRetornoSinopse.ReadOnly = false;
                rtbRetornoSinopse.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Selecione um filme na lista para editar a sinopse", "Atenção",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rtbRetornoSinopse_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (sinopse != rtbRetornoSinopse.Text && id_filme != null)
                {
                    DialogResult alterada = MessageBox.Show($"Sinopse foi alterada de:" +
                                     $"\n\n {sinopse} \n\n para: \n\n {rtbRetornoSinopse.Text} " +
                                     $"\n\n Deseja salvar essa alteração?", "Atenção!",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (alterada == DialogResult.Yes)
                    {
                        enviar.Id = Convert.ToInt32(id_filme);
                        enviar.Sinopse = rtbRetornoSinopse.Text;
                        enviar.Capa = picView.ImageLocation;
                        sinopse = rtbRetornoSinopse.Text;
                        filme.AtualizarFilme(enviar);
                        ListaFilmes();

                        MessageBox.Show("Sinopse alterada com sucesso", "Alteração!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (alterada == DialogResult.No)
                    {
                        rtbRetornoSinopse.Text = sinopse;
                    }
                }
                rtbRetornoSinopse.ReadOnly = true;
                rtbRetornoSinopse.BackColor = Color.Empty;
                Lst_View.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void procurarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_filme != null)
                {
                    if (ofd_AlterarImagem.ShowDialog() == DialogResult.OK)
                    {
                        origemNovaImagem = ofd_AlterarImagem.FileName;
                        string imagem = ofd_AlterarImagem.SafeFileName;
                        picView.ImageLocation = origemNovaImagem;
                        destinoImagem = pastaDestino + imagem;
                    }
                    if (File.Exists(destinoImagem))
                    {
                        DialogResult conf = MessageBox.Show("Está imagem já existe em outro registro!! " +
                                                            "Deseja selecionar outra imagem?", "Atenção",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (conf == DialogResult.Yes)
                        {
                            picView.ImageLocation = capa;
                            return;
                        }
                        else
                        {
                            File.Delete(capa);
                            File.Copy(origemNovaImagem, destinoImagem, true);
                        }
                    }
                    else
                    {
                        File.Copy(origemNovaImagem, destinoImagem, true);
                    }
                    enviar.Id = Convert.ToInt32(id_filme);
                    enviar.Sinopse = sinopse;
                    enviar.Capa = destinoImagem;
                    filme.AtualizarFilme(enviar);

                    MessageBox.Show("Imagem Alterada com Sucesso", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListaFilmes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


