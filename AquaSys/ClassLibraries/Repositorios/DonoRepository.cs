using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraries.Data.Context;

namespace ClassLibraries.Repositorios
{
    public class DonoRepository : RepositoryBase<Dono>, IDonoRepository
    {
        public DonoRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}