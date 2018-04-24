
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraries.Services;

namespace ClassLibraries.Services.Impl
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        public PessoaService(IPessoaRepository repository) : base(repository)
        {
        }
    }
}
            