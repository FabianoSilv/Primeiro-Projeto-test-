using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Primeiro_Projeto.Model_s;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Primeiro_Projeto.Repository
{
    internal class testes
    {
        private static string conection = "server=localhost;user id=root;password=H6t4pozb;database=empresa";
        public Funcionario getFuncionario(string nome, string senha)
        {
            using (var db = new MySqlConnection(conection))
            {
                db.Open();
                var query = $"Select * From funcionario where nome = '{nome}' and senha ='{senha}'";
                var funcionario = db.Query<Funcionario>(query);

                return funcionario.FirstOrDefault();
            }
        }
    }
}
