using ClassLibraries.Models;
using Domonio.Repositories;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>, ICidadeRepository
    {
        public CidadeRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}