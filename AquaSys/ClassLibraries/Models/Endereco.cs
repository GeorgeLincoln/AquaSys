using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClassLibraries.Models
{
    public class Endereco : IEntity
    {
        public Endereco()
        {
            Pessoas = new HashSet<Pessoa>();
        }
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public ICollection<Pessoa> Pessoas { get; set; }
    }
}
