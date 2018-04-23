using ClassLibraries.Models;
using ClassLibraries.Repositories;
using ClassLibraries.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositories
{
    public class FazendaRopository: RepositoryBase<Fazenda>, IFazendaRepository
    {
        public FazendaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
            
        }

    }
}