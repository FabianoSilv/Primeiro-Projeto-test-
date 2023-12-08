using Org.BouncyCastle.Bcpg;
using Primeiro_Projeto.Model;
using Primeiro_Projeto.Repository;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_Projeto.Business
{
    internal class Negocio
    {

        DataBase enviar = new DataBase();
        List<string> receb = new List<string>();
        public int? selec = null;
        public void Enqueue(Fila fila)
        {
            try
            {
                if (!receb.Contains(fila.pessoa))
                {
                    enviar.AdicionarFila(fila);

                    MessageBox.Show($"Cliente {fila.pessoa} adicionado a fila com sucesso!", "Concluido");
                }
                else
                {
                    MessageBox.Show($"Cliente {fila.pessoa} já está na fila do filme {fila.nomefilme}", "Atenção!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Fila> MostraFila(Fila fila)
        {

            List<Fila> receber = enviar.ListarFila(fila);

            receb.Clear();

            foreach (var item in receber)
            {
                receb.Add(item.pessoa);
            }

            return receber;
        }
        public void Dequeue(Fila fila)
        {
            try
            {
                if (selec == 1) // zerar fila
                {
                    enviar.selectValidador = 1;
                    enviar.AlterarFila(fila);
                }
                else if (selec == 2) // retirar pessoa da fila
                {
                    enviar.selectValidador = 2;
                    enviar.AlterarFila(fila);
                }
                else
                {
                    enviar.AlterarFila(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

