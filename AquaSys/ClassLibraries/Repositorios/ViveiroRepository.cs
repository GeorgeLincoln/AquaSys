using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using ClassLibraries.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositorios
{
    public class ViveiroRepository : RepositoryBase<Viveiro>, IViveiroRepository
    {
        public ViveiroRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}