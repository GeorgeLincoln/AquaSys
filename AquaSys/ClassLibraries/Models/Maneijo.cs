using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraries.Models;


namespace ClassLibraries.Models
{
    public class Maneijo : IEntity
    {
        public int Id { get; set; }
        public string Estocagem { get; set; }
        public string Produção { get; set; }
        public int ViveiroId { get; set; }
        public virtual Viveiro Viveiro { get; set; }
    
    }
}
