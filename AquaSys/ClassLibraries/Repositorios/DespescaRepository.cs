using ClassLibraries.Models;
using ClassLibraries.Repositories;
using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositories
{
    public class DespescaRepository : RepositoryBase<Despesca>, IDespesca
    {
        public DespescaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}