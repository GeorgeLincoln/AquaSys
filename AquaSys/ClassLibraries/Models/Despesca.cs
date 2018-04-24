﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraries.Models;


namespace ClassLibraries.Models
{
    public class Despesca : IEntity
    {

        public int Id { get; set; }
        public int QtdePeixes { get; set; }
        public string TamPeixes { get; set; }
        public int ViveiroId { get; set; }
        public Viveiro Viveiro { get; set; }
    }
}
