using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraries.Models;

namespace ClassLibraries.Models
{
    public class Pessoa : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
         public string Telefone { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
