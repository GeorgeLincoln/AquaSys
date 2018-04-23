using ClassLibraries.Models;
using ClassLibraries.Repositories;
using ClassLibraries.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositories
{
    public class DonoRepository : RepositoryBase<Dono>, IDonoRepository
    {
        public DonoRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}