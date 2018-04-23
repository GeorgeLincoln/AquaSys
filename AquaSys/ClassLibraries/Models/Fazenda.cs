using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraries.Models;


namespace ClassLibraries.Models
{
    public class Fazenda
    {
         public int Id { get; set; }
         public float Tamanho { get; set; }
         public int QtdeViveiros { get; set; }

         public Endereco EnderecoId { get; set; }
         public Dono DonoId { get; set; }
         public Trabalhador TrabalhadorId { get; set; }
         public Viveiro ViveiroId { get; set; }

         public Endereco Endereco { get; set; }
         public Dono Dono { get; set; }         
         public Trabalhador Trabalhador { get; set; }
         public Viveiro Viveiro { get; set; }
    }
}