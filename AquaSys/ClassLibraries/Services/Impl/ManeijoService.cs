
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraries.Services;

namespace ClassLibraries.Services.Impl
{
    public class ManeijoService : ServiceBase<Maneijo>, IManeijoService
    {
        public ManeijoService(IManeijoRepository repository) : base(repository)
        {
        }
    }
}
            