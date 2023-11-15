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
        public MenuRestrito()
        {
            InitializeComponent();
            
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cadastro = new Cadastro();
            cadastro.MdiParent= this;
            cadastro.Show();
            this.toolStripSeparator2.Visible = true;

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
            foreach(Form x in MdiChildren) 
            {
                x.WindowState= FormWindowState.Minimized;
            
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
            Form cadastrocliente = new CadastrarCliente();
            cadastrocliente.MdiParent = this;
            cadastrocliente.Show();

        }
    }
}
