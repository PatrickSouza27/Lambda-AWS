using Cadastro.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Models
{
    public class AtualizarView
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome Obrigario")]
        [MaxLength(40, ErrorMessage ="Maximo até 40 Caracteres")]
        [MinLength(1, ErrorMessage = "Minimo de 1 Caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Email Obrigario")]
        [EmailAddress(ErrorMessage = "Email Invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Acesso Obrigario")]
        [MaxLength(40, ErrorMessage = "Maximo até 40 Caracteres")]
        [MinLength(1, ErrorMessage = "Minimo de 1 Caracteres")]
        public string Acesso { get; set; }

        [Required(ErrorMessage = "Senha Obrigario")]
        [MaxLength(40, ErrorMessage = "Maximo até 40 Caracteres")]
        [MinLength(1, ErrorMessage = "Minimo de 1 Caracteres")]
        public string Senha { get; set; }
        public AtualizarView() { }
        public AtualizarView(string nome, string email, string login, string acesso, string senha)
        {
            Nome = nome;
            Email = email;
            Acesso = acesso;
            Senha = senha;
        }
        public bool Atualizar() => new AtualizarController().AtualizarUser(this);

    }
}
