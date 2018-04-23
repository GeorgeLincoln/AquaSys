using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraries.Models;


namespace ClassLibraries.Models
{
    public class Trabalhador
    {
         public Trabalhador()
         {
             TrabalhadorSetores = new List<TrabalhadorSetor>();

         }

        public int Id { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public virtual ICollection<TrabalhadorSetor> TrabalhadorSetores { get; set; }
             
    }
}
