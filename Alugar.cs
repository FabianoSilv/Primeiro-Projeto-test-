using Primeiro_Projeto.Business;
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
using MySql.Data.MySqlClient;

namespace Primeiro_Projeto
{
    public partial class Alugar : Form
    {
        Pessoa enviarCliente = new Pessoa();
        Filme enviarFilme = new Filme();
        DataBase database = new DataBase();
        Negocio negocio = new Negocio();
        Fila fila = new Fila();
       
        private string nomefilme;
        private string cpf;
        public Alugar(string nomefilme, string cpf)
        {
            InitializeComponent();
            this.nomefilme = nomefilme;
            this.cpf = cpf;
        }
        private void Alugar_Load(object sender, EventArgs e)
        {
            try
            {
                enviarCliente.complemento = "Cliente";
                database.pesquisa = cpf;
                List<Pessoa> receber1 = database.PesquisarPessoa(enviarCliente);

                foreach (var item in receber1)
                {
                    lbl_NomeCliente.Text = item.nome;
                    lbl_IdCliente.Text = item.cpf;
                }

                enviarFilme.Nome = nomefilme;
                List<Filme> receber = database.PesquisarFilme(enviarFilme);

                foreach (var item in receber)
                {
                    lbl_IdFilme.Text = item.Id.ToString();
                    lbl_NomeFilme.Text = item.Nome;
                    lbl_Ano.Text = item.Ano.ToString();
                    lbl_Duracao.Text = item.Duração;
                    lbl_Classificacao.Text = item.Classificação;
                    lbl_Genero.Text = item.Genero;
                    rtb_sinopse.Text = item.Sinopse;
                    picView.ImageLocation = item.Capa;
                }
                FilaAtualizada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FilaAtualizada()
        {
            fila.nomefilme = nomefilme;
            List<Fila> receber = negocio.MostraFila(fila);

            if (receber.Count > 0)
            {
                lbl_Fila.Text = receber.Count.ToString();
                label4.Visible = true;
            }
            else
            {
                lbl_Fila.Text = "DISPONIVEL";
                label4.Visible = false;
            }
        }
        private void btn_Alugar_Click(object sender, EventArgs e)
        {
            try
            {
                fila.nomefilme = nomefilme;
                fila.pessoa = lbl_NomeCliente.Text;

                negocio.Enqueue(fila);

                FilaAtualizada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            // this.Close(); 
            DialogResult result = MessageBox.Show("desejar remover o primeiro da fila?", "teste",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                fila.nomefilme = nomefilme;
                negocio.Dequeue(fila);
                FilaAtualizada();
            }

            DialogResult result1 = MessageBox.Show("desejar zerar a fila?", "teste1",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                negocio.selec = 1;
                fila.nomefilme = nomefilme;
                fila.pessoa = lbl_NomeCliente.Text;
                negocio.Dequeue(fila);

            }
            DialogResult result2 = MessageBox.Show($"desejar tirar esse {lbl_NomeCliente.Text} da fila?", "teste1",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result2 == DialogResult.Yes)
            {
                negocio.selec = 2;
                fila.nomefilme = nomefilme;
                fila.pessoa = lbl_NomeCliente.Text;
                negocio.Dequeue(fila);
                FilaAtualizada();
            }

            // lbl_Fila.Text = fila.Count.ToString();
        }
    }
}
