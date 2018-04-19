using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibraries.Models
{
    public class Fazenda
    {
         public int Id { get; set; }
         public float Tamanho { get; set; }
         public int QtdeViveiros { get; set; }

         public Endereço IdEndereco { get; set; }
         public Dono IdDono { get; set; }
         public Trabalhador IdTrabalhador { get; set; }
         public Viveiro IdViveiro { get; set; }

         public Endereco Endereco { get; set; }
         public Dono Dono { get; set; }         
         public Trabalhador Trabalhador { get; set; }
         public Viveiro Viveiro { get; set; }
    }
}