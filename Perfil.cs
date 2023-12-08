using Primeiro_Projeto.Business;
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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Primeiro_Projeto
{
    public partial class Perfil : Form
    {
        Pessoa enviar = new Pessoa();
        DataBase perfil = new DataBase();

        private int? id = null;
        private string Cpf = "";
        private string Comp = "";
        public Perfil(string cpf, string complemento)
        {
            InitializeComponent();

            lstview_Resumo.Columns.Add("Status", 50, HorizontalAlignment.Left);
            lstview_Resumo.Columns.Add("Nome", 70, HorizontalAlignment.Left);
            lstview_Resumo.Columns.Add("Valor", 70, HorizontalAlignment.Left);
            lstview_Resumo.Columns.Add("Inicio", 50, HorizontalAlignment.Left);

            Cpf = cpf;
            Comp = complemento;
            Perf();
            ResumoAtividade();

        }
        private void AdicionarListView(string coluna1, string coluna2, string coluna3, string coluna4)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(coluna1);
            item.SubItems.Add(coluna2);
            item.SubItems.Add(coluna3);
            item.SubItems.Add(coluna4);
            lstview_Resumo.Items.Add(item);
        }
        private void Perf()
        {
            perfil.pesquisa = Cpf;
            enviar.complemento = Comp;
            List<Pessoa> aprensentar = perfil.PesquisarPessoa(enviar);

            foreach (var item in aprensentar)
            {
                id = item.id;
                txt_Nome.Text = item.nome;
                txt_CPF.Text = item.cpf;
                txt_email.Text = item.email;
                txt_Telefone.Text = item.telefone;
            }
        }
        private void ResumoAtividade()
        {
            Negocio historico = new Negocio();
            Fila fila = new Fila();
            fila.pessoa = txt_Nome.Text;


            List<Fila> resumo = new List<Fila>(historico.MostraFila(fila));
            foreach (var item in resumo)
            {
                AdicionarListView(item.nomefilme, item.pessoa, item.datainicial, item.datainicial);
            }
        }
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            perfil.selectValidador = 1;
            enviar.id = Convert.ToInt32(id);
            enviar.nome = txt_Nome.Text;
            enviar.telefone = txt_CPF.Text;
            enviar.email = txt_CPF.Text;
            perfil.AtualizarPessoa(enviar);
            Perf();
        }
    }
}
