
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Services.Impl
{
    public class TrabalhadorService : ServiceBase<Trabalhador>, ITrabalhadorService
    {
        public TrabalhadorService(ITrabalhadorRepository repository) : base(repository)
        {
        }
    }
}
            