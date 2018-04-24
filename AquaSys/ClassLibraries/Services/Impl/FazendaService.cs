
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraries.Services;

namespace ClassLibraries.Services.Impl
{
    public class FazendaService : ServiceBase<Fazenda>, IFazendaService
    {
        public FazendaService(IFazendaRepository repository) : base(repository)
        {
        }
    }
}
            