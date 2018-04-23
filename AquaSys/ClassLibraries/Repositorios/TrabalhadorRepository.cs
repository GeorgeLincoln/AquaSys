using ClassLibraries.Models;
using ClassLibraries.Repositories;
using ClassLibraries.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositories
{
    public class TrabalhadorRepository : RepositoryBase<Trabalhador>, ITrabalhadorRepository
    {
        public TrabalhadorRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}