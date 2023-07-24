using Cadastro.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Models
{
    public class DeleteIdModel
    {
        public int Id { get; set; }
        public DeleteIdModel() { }
        public DeleteIdModel(int id) => Id = id;
        public bool Remover() => new DeleteController().Remover(this.Id);

    }
}
