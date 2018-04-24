using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraries.Data.Context;

namespace ClassLibraries.Repositorios
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}