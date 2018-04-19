using ClassLibraries.Models;
using ClassLibraries.Repositories;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}