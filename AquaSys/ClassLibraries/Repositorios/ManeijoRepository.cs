using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using ClassLibraries.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositorios
{
    public class ManeijoRepository : RepositoryBase<Maneijo>, IManeijoRepository
    {
        public ManeijoRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}