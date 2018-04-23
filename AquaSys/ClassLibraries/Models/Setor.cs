using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraries.Models;

namespace ClassLibraries.Models
{
    public class Setor: IEntity 
    {
        public Setor()
        {
             TrabalhadorSetores = new List<TrabalhadorSetor>();
        }
        public int Id { get; set; }

        public int IdDespesca { get; set; }
        public Despesca Despesca { get; set; }

        public int IdManeijo { get; set; }
        public Maneijo Maneijo { get; set; }
        public string Adm { get; set; }

        public virtual ICollection<TrabalhadorSetor> TrabalhadorSetores { get; set; }
    }
}