
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraries.Services;

namespace ClassLibraries.Services.Impl
{
    public class DespescaService : ServiceBase<Despesca>, IDespescaService
    {
        public DespescaService(IDespescaRepository repository) : base(repository)
        {
        }
    }
}
            