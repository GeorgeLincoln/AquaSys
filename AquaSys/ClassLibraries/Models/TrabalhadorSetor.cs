using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClassLibraries.Models
{
    public class TrabalhadorSetor
    {
        public int Id { get; set; }
        public int TrabalhadorId { get; set; }
        public int SetorId { get; set; }

        public virtual Trabalhador Trabalhador { get; set; }
        public virtual Setor Setor { get; set; }

    }
}