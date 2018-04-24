using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraries.Models;

namespace ClassLibraries.Models
{
    public class Fazenda: IEntity
    {
         public int Id { get; set; }
         public float Tamanho { get; set; }
         public int QtdeViveiros { get; set; }

         public int EnderecoId { get; set; }
         public int DonoId { get; set; }
         public int TrabalhadorId { get; set; }
         public int ViveiroId { get; set; }

         public Endereco Endereco { get; set; }
         public Dono Dono { get; set; }         
         public Trabalhador Trabalhador { get; set; }
         public Viveiro Viveiro { get; set; }
    }
}