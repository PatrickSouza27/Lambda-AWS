using Cadastro.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Controller
{
    public class TodosController
    {
        public readonly string Banco = @$"Server={Environment.GetEnvironmentVariable("BancoConnection")}, 1433;Database=lambda;User ID=admin;Password=teste123;TrustServerCertificate=True";
        public List<Usuario> Todos()
        {
            using var conn = new SqlConnection(Banco);
            return conn.Query<Usuario>("SELECT [Id], [Nome], [Login], [Email], [Acesso] FROM [Usuario]").ToList();
        }
    }
}
