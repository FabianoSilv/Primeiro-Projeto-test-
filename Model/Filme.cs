using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Projeto.Model_s
{
    public class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Duração { get; set; }
        public string Classificação { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
       public string Capa { get; set; }
    }
}
