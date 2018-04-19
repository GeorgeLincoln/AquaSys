using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClassLibraries.Models
{
    public class Viveiro : IEntity
    {
        public int Id { get; set; }
        public Endereco Endereco { get; set; }
        public string TipoDeProducao { get; set; }
        public string TipoDePeixe { get; set; }
        public Sensores Sensores { get; set; }

    }
}
