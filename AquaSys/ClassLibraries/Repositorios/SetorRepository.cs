using ClassLibraries.Models;
using ClassLibraries.Repositories;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositories
{
    public class ConvenioRepository : RepositoryBase<Convenio>, IConvenioRepository
    {
        public ConvenioRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}