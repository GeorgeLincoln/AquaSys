
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraries.Services;

namespace ClassLibraries.Services.Impl
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        public EnderecoService(IEnderecoRepository repository) : base(repository)
        {
        }
    }
}
            