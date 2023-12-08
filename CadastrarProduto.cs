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



namespace Primeiro_Projeto
{
    public partial class CadastrarProduto : Form
    {
        Filme enviar = new Filme();
        DataBase filme = new DataBase();
        private string origenImagem = "C:\\Users\\fabia\\OneDrive\\Área de Trabalho\\Fabiano\\aa.jpg";
        private string imagem = "aa.jpg";
        private static string caminho = System.Environment.CurrentDirectory;
        private string pastaDestino = caminho + @"\ImgCapa\";
        private string destinoImagem = "";


        public CadastrarProduto()
        {
            InitializeComponent();
            picCapa.ImageLocation = "C:\\Users\\fabia\\OneDrive\\Área de Trabalho\\Fabiano\\aa.jpg";
            destinoImagem = pastaDestino + imagem;
        }

        private void LimparCampos()
        {
            txtFilme.Text = string.Empty;
            mskAno.Text = string.Empty;
            mskDuracao.Text = string.Empty;
            cbClassificao.Text = string.Empty;
            cbTipo.Text = string.Empty;
            rtxtSinopse.Text = string.Empty;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtFilme.Text.Equals("") && !mskAno.Text.Equals("") && !mskDuracao.Text.Equals("") &&
                     !cbClassificao.Text.Equals("") && !cbTipo.Text.Equals("") && !rtxtSinopse.Text.Equals(""))
                {
                    if (File.Exists(destinoImagem))
                    {
                        DialogResult conf = MessageBox.Show("Está imagem já existe em outro registro!!" +
                                                            " Deseja selecionar outra imagem?", "Atenção",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (conf == DialogResult.Yes)
                        {
                            //MessageBox.Show("Selecione outra imagem", "Escolher imagem", MessageBoxButtons.OK,
                            //MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            //ADIVIONAR A MESMA IMAGEM COM OUTRO NOME
                            File.Copy(origenImagem, destinoImagem, true);
                        }
                    }
                    else
                    {
                        File.Copy(origenImagem, destinoImagem, true);
                    }
                    enviar.Capa = destinoImagem;
                    enviar.Nome = txtFilme.Text;
                    enviar.Ano = Convert.ToInt32(mskAno.Text);
                    enviar.Duração = mskDuracao.Text;
                    enviar.Classificação = cbClassificao.Text;
                    enviar.Genero = cbTipo.Text;
                    enviar.Sinopse = rtxtSinopse.Text;

                    filme.CadastrarFilme(enviar);

                    MessageBox.Show($"Filme {enviar.Nome} cadastrado com sucesso", "Concluido",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Preencher todos os campos", "Atenção!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFilme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImagem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                origenImagem = openFileDialog1.FileName;
                imagem = openFileDialog1.SafeFileName;
                picCapa.ImageLocation = origenImagem;
                destinoImagem = pastaDestino + imagem;

            }
        }
    }
}
