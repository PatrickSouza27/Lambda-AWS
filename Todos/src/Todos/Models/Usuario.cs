using Cadastro.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Acesso { get; set; }
        public Usuario() { }
        public Usuario(string nome, string email, string login, string acesso)
        {
            Nome = nome;
            Email = email;
            Login = login;
            Acesso = acesso;
        }
    }
}
