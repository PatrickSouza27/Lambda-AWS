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
    public class CadastroController
    {
        public readonly string Banco = @$"Server={Environment.GetEnvironmentVariable("BancoConnection")}, 1433;Database=lambda;User ID=admin;Password=teste123;TrustServerCertificate=True";
        public bool CadastroUser(Usuario usuario)
        {
            using var conn = new SqlConnection(Banco);
            return conn.Execute("INSERT INTO[Usuario]([Nome], [Login], [Email], [Acesso], [Senha]) VALUES(@Nome, @Login, @Email, @Acesso, @Senha)", new { usuario.Nome, usuario.Login, usuario.Email, usuario.Acesso, usuario.Senha }) == 1;
        }
    }
}
