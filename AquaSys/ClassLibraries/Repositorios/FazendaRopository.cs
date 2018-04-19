using ClassLibraries.Models;
using ClassLibraries.Repositories;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositories
{
    public class FazendaRopository: RepositoryBase<Fazenda>, IFazenda
    {
        public FazendaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
            
        }

    }
}