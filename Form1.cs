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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deu certo!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try 
            {
                if (txtUsuario.Text.Equals("fabiano") && txtSenha.Text.Equals("123"))
                {
                    // acessar area restrita.
                    var MenuRestrito = new MenuRestrito();
                    MenuRestrito.Show();
                    
                    this.Visible = false;

                }
                else 
                {
                    MessageBox.Show("Usario ou senha incorreto!",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                    txtUsuario.Focus();
                    txtSenha.Text = "";
                
                }
            }

            catch
            {

            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.LightBlue;
           
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.White;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.LightBlue;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla !=8 && tecla != 32) 
            {
                e.Handled = true;
                MessageBox.Show("Somente letras e numeros!", 
                                "Eita!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            

            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 8)
            {
                e.Handled = true;
                MessageBox.Show("Somente letras e numeros sem espaço!",
                                "Eita!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);


            }
        }
    }
}
