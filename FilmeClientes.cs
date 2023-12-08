using MySqlX.XDevAPI.Relational;
using Primeiro_Projeto.Model_s;
using Primeiro_Projeto.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Primeiro_Projeto
{
    public partial class FilmeClientes : Form
    {

        static DataBase filme = new DataBase();

        string cpf;
        string nome;

        public FilmeClientes(string cpf)
        {
            InitializeComponent();
            this.cpf = cpf;

            // dgv_filme.DataSource = listarfilmes;

            ConfigurarGrades();
            //  CarregarImagem();


        }
        private static DataTable Pordutos()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(Int32));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Ano", typeof(string));
            dt.Columns.Add("Duração", typeof(string));
            dt.Columns.Add("Classificação", typeof(string));
            dt.Columns.Add("Genero", typeof(string));
            dt.Columns.Add("Sinopse", typeof(string));
            dt.Columns.Add("Capa", typeof(string));

            List<Filme> lstfilmes = new List<Filme>(filme.ListarFilme());

            foreach (var item in lstfilmes)
            {
                int id = item.Id;
                string nome = item.Nome;
                string ano = Convert.ToString(item.Ano);
                string duracao = item.Duração;
                string classificação = item.Classificação;
                string genero = item.Genero;
                string sinopse = item.Sinopse;
                string capa = item.Capa;

                dt.Rows.Add(id, nome, ano, duracao, classificação, genero, sinopse, capa);
            }
            return dt;
        }
        //private void CarregarImagem()
        //{
        //    foreach (DataGridViewRow row in dgv_filme.Rows)
        //    {
        //        row.Cells["Foto"].Value = Image.FromFile(row.Cells["Capa"].Value.ToString());

        //    }

        //}
        private void ConfigurarGrades()
        {
            dgv_filme.DataSource = Pordutos();

            dgv_filme.DefaultCellStyle.Font = new Font("arial", 10);

            DataGridViewColumn coluna0 = dgv_filme.Columns["iD"];
            // coluna0.Visible = false;

            DataGridViewColumn coluna1 = dgv_filme.Columns["Capa"];
            coluna1.DisplayIndex = 0;

            DataGridViewColumn coluna2 = dgv_filme.Columns["nome"];
            coluna2.Width = 200;

            DataGridViewColumn coluna3 = dgv_filme.Columns["ano"];
            coluna3.Width = 45;

            DataGridViewColumn coluna4 = dgv_filme.Columns["duração"];
            coluna4.Width = 70;
            DataGridViewColumn coluna5 = dgv_filme.Columns["classificação"];
            coluna5.Width = 43;
            DataGridViewColumn coluna6 = dgv_filme.Columns["genero"];
            coluna6.Width = 70;
            DataGridViewColumn coluna7 = dgv_filme.Columns["sinopse"];
            coluna7.Width = 800;

            //DataGridViewImageColumn coluna8 = new DataGridViewImageColumn();
            //coluna8.Name = "Foto";
            //coluna8.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //dgv_filme.Columns.Add(coluna8);
            //dgv_filme.Columns["Foto"].HeaderText = "blabla";
            //dgv_filme.Columns["Foto"].Width = 60;
            //coluna8.DisplayIndex = 0;

            //DataGridViewButtonColumn coluna9= new DataGridViewButtonColumn();
            //coluna9.Name = "btn";
            //dgv_filme.Columns.Add(coluna9);
            //coluna9.DisplayIndex = 8;
        }
        private void FilmeClientes_Load(object sender, EventArgs e)
        {

        }

        private void dgv_filme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nome = dgv_filme.Rows[dgv_filme.CurrentCell.RowIndex].Cells["nome"].Value.ToString();

                Form alugar = new Alugar(nome, cpf);
                alugar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



    }
}
