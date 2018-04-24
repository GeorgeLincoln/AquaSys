using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using ClassLibraries.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositorios
{
    public class TrabalhadorSetorRepository : RepositoryBase<TrabalhadorSetor>, ITrabalhadorSetorRepository
    {
        public TrabalhadorSetorRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}