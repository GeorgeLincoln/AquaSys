using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraries.Models;

namespace ClassLibraries.Models
{
    public class Sensor : IEntity
    {
        public int Id { get; set; }
        public int Temperatura { get; set; }
        public int Oxigenio { get; set; }
        public int PH { get; set; }
        public int ViveiroId { get; set; }
        public virtual Viveiro Viveiro { get; set; }
    }
}
