using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClassLibraries.Models
{
    public class Sensor : IEntity
    {
        public int Id { get; set; }
        public int Temperatura { get; set; }
        public int Oxigenio { get; set; }
        public int PH { get; set; }
        public Viveiro Viveiro { get; set; }
    }
}
