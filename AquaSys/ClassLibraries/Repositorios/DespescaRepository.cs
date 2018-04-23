using ClassLibraries.Models;
using ClassLibraries.Repositories;
using ClassLibraries.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositories
{
    public class DespescaRepository : RepositoryBase<Despesca>, IDespescaRepository
    {
        public DespescaRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}