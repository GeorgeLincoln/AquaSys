
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Services.Impl
{
    public class SetorService : ServiceBase<Setor>, ISetorService
    {
        public SetorService(ISetorRepository repository) : base(repository)
        {
        }
    }
}
            