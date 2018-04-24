﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraries.Models;


namespace ClassLibraries.Models
{
    public class Dono : IEntity
    {
    
        public int Id { get; set; }
        public int CNPJ { get; set; }
        public string NomeEmpresa { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

    }
}
