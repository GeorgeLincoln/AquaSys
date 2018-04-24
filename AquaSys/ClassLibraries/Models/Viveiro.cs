using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraries.Models;

namespace ClassLibraries.Models
{
    public class Viveiro : IEntity
    {
        public int Id { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public string TipoDeProducao { get; set; }
        public string TipoDePeixe { get; set; }
        public int SensorId { get; set; }
        public virtual Sensor Sensor { get; set; }

    }
}
