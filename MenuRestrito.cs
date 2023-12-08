using Primeiro_Projeto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_Projeto
{
    public partial class MenuRestrito : Form
    {
        public bool logado = false;
        public int nivelAcesso = 0;

        public MenuRestrito()
        {
            InitializeComponent();
            var login = new TelaLogin(this);
            login.ShowDialog();
        }
        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void organizarEmCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void organizarNaHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void organizarNaVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void minimizarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form x in MdiChildren)
            {
                x.WindowState = FormWindowState.Minimized;
            }
        }
        private void fecharTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form x in MdiChildren)
            {
                x.Close();
            }
        }
        private void CadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (logado)
                {
                    if (nivelAcesso >= 2)
                    {
                        Form cadastrocliente = new CadastrarCliente();
                        cadastrocliente.MdiParent = this;
                        cadastrocliente.Show();
                    }
                    else
                    {
                        MessageBox.Show("É necessario um nivel maior de permissao!", "Atenção",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("É necessario estar logado para acessar!", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (logado)
                {
                    if (nivelAcesso == 2)
                    {
                        Form cadastroproduto = new CadastrarProduto();
                        cadastroproduto.MdiParent = this;
                        cadastroproduto.Show();
                    }
                    else
                    {
                        MessageBox.Show("É necessario um nivel maior de permissao!", "Atenção",
                                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("É necessario estar logado para acessar!", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listarFilmesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (logado)
            {
                if (nivelAcesso >= 1)
                {

                    Form lstfilmes = new ListarFilmes();
                    lstfilmes.MdiParent = this;
                    lstfilmes.Show();
                }
                else
                {
                    MessageBox.Show("É necessario um nivel maior de permissao!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("É necessario estar logado para acessar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin(this);
            login.Show();
        }
        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbNomeUsuario.Text = string.Empty;
            pbImagemLogin.Image = Properties.Resources.led_vermelho;
            lbNivelAcesso.Text = string.Empty;
            nivelAcesso = 0;
            logado = false;
            foreach (Form x in MdiChildren)
            {
                x.Close();
            }
        }
        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(cpf.Text, lbNivelAcesso.Text);
            perfil.MdiParent = this;

            perfil.Show();
        }
        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmeClientes filmesclietes = new FilmeClientes(cpf.Text);
            filmesclietes.MdiParent = this;
            filmesclietes.Show();
        }
    }
}
