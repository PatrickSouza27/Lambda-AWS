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
    public class DeleteController
    {
        public readonly string Banco = @$"Server={Environment.GetEnvironmentVariable("BancoConnection")}, 1433;Database=lambda;User ID=admin;Password=teste123;TrustServerCertificate=True";
        public bool Remover(int Id)
        {
            using var conn = new SqlConnection(Banco);
            return conn.Execute("DELETE [Usuario] WHERE [Id] = @Id", new { Id }) == 1;
        }
    }
}
